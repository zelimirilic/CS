using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaineClasse;
using System.Configuration;
using System.IO;



namespace MaineClasseTest
{
    [TestClass]
    public class FileProccesTest
    {
        private const string _BAD_FILE_NAME = @"c:\someFileDoesNotExist.bad";
        private string _GoodFileName;

        public TestContext TestContext { get; set; }
        [TestMethod]
        public void FileNameDoesExist()
        {
            FileProcess fp = new FileProcess();
            bool fromCall;

            
            SetGoodFileName();

            TestContext.WriteLine("Creating the file: " + _GoodFileName);
            File.AppendAllText(_GoodFileName, "Some Text");

            TestContext.WriteLine("Testing the file: " + _GoodFileName);
            fromCall = fp.FileExists(_GoodFileName);

            TestContext.WriteLine("Deleting the file: " + _GoodFileName);
            File.Delete(_GoodFileName);

            Assert.IsTrue(fromCall);
        }

        [TestMethod]
        public void FileNameDoesNotExist()
        {
            FileProcess fp = new FileProcess();
            bool fromCall = fp.FileExists(_BAD_FILE_NAME);
            Assert.IsFalse(fromCall);
        }

        public void SetGoodFileName() {
            _GoodFileName = ConfigurationManager.AppSettings["GoodFileName"];
            if (_GoodFileName.Contains("[AppPath]")) {
                _GoodFileName = _GoodFileName.Replace("[AppPath]", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameNullOrEmpty_ThrowArgNullEx()
        {
            FileProcess fp = new FileProcess();
            fp.FileExists("");
        }
        [TestMethod]
        
        public void FileNameNullOrEmpty_ThrowArgNullEx2()
        {
            FileProcess fp = new FileProcess();
            try
            {
            fp.FileExists("");
            }
            catch(Exception)
            {
                return;
            }
            Assert.Fail("Call to FileExist did not throw an ArCallEx !");

        }
    }
}
