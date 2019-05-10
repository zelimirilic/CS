using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;

namespace MyClassesTest
{
    [TestClass]
    public class FileProcessTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void FileNameDoesExist()
        {
            FileProcess fp = new FileProcess();
            bool fromCall;
            fromCall = fp.FileExists(@"C:\Windows\Regedit.exe");

            Assert.IsTrue(fromCall);

        }
        [TestMethod]
        public void FileNameDoesNotExist()
        {
            FileProcess fp = new FileProcess();
            bool fromCall;
            fromCall = fp.FileExists(@"C:\Windows\badFile.bad");

            Assert.IsFalse(fromCall);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameNullOrEmpty_ThrowsArgNullException()
        {
            FileProcess fp = new FileProcess();

            fp.FileExists("");
        }
        [TestMethod]
        public void FileNameNullOrEmpty_ThrowsArgNullException_UsingTryCatch()
        {
            FileProcess fp = new FileProcess();

            try
            {
                fp.FileExists("");
            }
            catch (ArgumentNullException)
            {
                //The test was a succes

                return;
            }
            Assert.Fail("Call to FileExixst did NOT throw  a mistakes.....");

        }
    }
}
