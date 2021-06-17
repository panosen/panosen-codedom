using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Panosen.CodeDom.MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataObject dataObject = new DataObject();

            dataObject.AddDataValue("1", "11");
            dataObject.AddDataValue("2", "22");

            Assert.AreEqual(2, dataObject.DataItemMap.Count);
        }
    }
}
