﻿using System;
using KTableau.DAL.models;
using Microsoft.EntityFrameworkCore;
using NLog;


namespace KTableau.DAL
{
    public class KTableauDBContext : DbContext
    {   

        // All tables DBContext has to control under
        public DbSet<User> Users { get; set; }
        public DbSet<Transition> Transitions { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TaskProject> Tasks { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Note> Notes { get; set; }


        // :base is the Java's 'super'
        public KTableauDBContext(DbContextOptions<KTableauDBContext> options) : base(options)
        {  
            
        }

        public KTableauDBContext(KTableauDBContext dbContext)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Connection string
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=KTableau");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Fluent API (PK, indexes, relations and rowverion)

            // Entity User (autogenerated)
            modelBuilder.Entity<User>().HasKey(p => p.UserId);
            modelBuilder.Entity<User>().HasIndex(p => p.UserName).IsUnique();
            modelBuilder.Entity<User>().Property(p => p.UserId).ValueGeneratedOnAdd();            
            modelBuilder.Entity<User>().Property(p => p.RowVersion).IsRowVersion().ValueGeneratedOnAddOrUpdate();
            
            // Note: There is no need to set double side relations.
            
                       
            // Entity Transition
            modelBuilder.Entity<Transition>().HasKey(p => p.TransitionId);
            modelBuilder.Entity<Transition>().HasIndex(p => p.State);
            modelBuilder.Entity<Transition>().Property(p => p.TransitionId).ValueGeneratedOnAdd();
            modelBuilder.Entity<Transition>().Property(p => p.RowVersion).IsRowVersion().ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<Transition>().HasOne(p => p.Task).WithMany(p => p.Transitions).HasForeignKey("TaskId");

            // Entity Team
            modelBuilder.Entity<Team>().HasKey(p => new { p.UserId, p.ProjectId });
            modelBuilder.Entity<Team>().Property(p => p.RowVersion).IsRowVersion().ValueGeneratedOnAddOrUpdate();

            modelBuilder.Entity<Team>().HasOne(p => p.Project).WithOne(p => p.Team).HasForeignKey("ProjectId");
            modelBuilder.Entity<Team>().HasOne(p => p.User).WithMany(p => p.Team).HasForeignKey("UserId");

            // Entity Task
            modelBuilder.Entity<TaskProject>().HasKey(p => p.TaskId);
            modelBuilder.Entity<TaskProject>().HasIndex(p => p.ProjectId);
            modelBuilder.Entity<TaskProject>().HasIndex(p => p.State);
            modelBuilder.Entity<TaskProject>().Property(p => p.TaskId).ValueGeneratedOnAdd();
            modelBuilder.Entity<TaskProject>().Property(p => p.RowVersion).IsRowVersion().ValueGeneratedOnAddOrUpdate();

            // This is the same to say that Task class has a property named Project that is related to a
            // list of Task in Project class. This sets the entire relationship between Project and Task 
            // so there is no need to set anything at the Project class side.
            modelBuilder.Entity<TaskProject>().HasOne(p => p.Project).WithMany(p => p.Tasks).HasForeignKey("ProjectId");

            // Entity Project
            modelBuilder.Entity<Project>().HasKey(p => p.ProjectId);
            modelBuilder.Entity<Project>().Property(p => p.ProjectId).ValueGeneratedOnAdd();
            modelBuilder.Entity<Project>().Property(p => p.RowVersion).IsRowVersion().ValueGeneratedOnAddOrUpdate();

            // Project.TeamId is a FK to Team. Fot this reason, we have to create a new property
            // as follows: Project.Team 
            // Note: the same happens at the table Team, which has a property named Team.ProjectId and its
            // own Navigation Property Team.Project
            modelBuilder.Entity<Project>().HasOne(p => p.Team).WithOne(p => p.Project).HasForeignKey("TeamId");
            

            // Entity Note
            modelBuilder.Entity<Note>().HasKey(p => p.NoteId);
            modelBuilder.Entity<Note>().HasIndex(p => p.TaskId);
            modelBuilder.Entity<Note>().Property(p => p.NoteId).ValueGeneratedOnAdd();
            modelBuilder.Entity<Note>().Property(p => p.RowVersion).IsRowVersion().ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<Note>().HasOne(p => p.Task).WithMany(p => p.Notes).HasForeignKey("TaskId");












        }
    }
}
