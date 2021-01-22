using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;

namespace KTableau.DAL.Test
{
    [TestClass]
    public class KTableauDALTest
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        [TestMethod]
        public void TestMethod1()
        {
            logger.Info("Init test");

        }
    }
}
