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

        #region Class Initialize and Cleanup
        [ClassInitialize]
        public static void ClassInitialize(TestContext tc)
        {
            tc.WriteLine("In the class Initialize");
        }
        [ClassCleanup]
        public static void ClassCleanup()
        {

        }
        #endregion

        #region Test Initialize and cleanup
    
        [TestInitialize]
        public void TestInitialize()
        {
            if(TestContext.TestName.StartsWith("FileNameDoesExist"))
            {
                SetGoodFileName();
                if (string.IsNullOrEmpty(_GoodFileName))
                {
                    TestContext.WriteLine("Creating the file: " + _GoodFileName);
                    File.AppendAllText(_GoodFileName, "Some text");
                }
            }
        }
        [TestCleanup]
        public void TestCleanup()
        {
            if (TestContext.TestName.StartsWith("FileNameDoesExist"))
            {
                if (string.IsNullOrEmpty(_GoodFileName))
                {
                    TestContext.WriteLine("Deleting the file: " + _GoodFileName);
                    File.Delete(_GoodFileName);
                }
            }
        }
        #endregion
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("MultiDB_Zeljko")]
        public void FileExistsTestFromDB()
        {
            FileProcess fp = new FileProcess();
            string fileName;
            bool expectedValue;
            bool causesException;
            bool fromCall;
            //Get value from data row
            fileName = TestContext.DataRow["FileName"].ToString();
            expectedValue = Convert.ToBoolean(TestContext.DataRow["ExpectedValue"]);
            causesException = Convert.ToBoolean(TestContext.DataRow["CausesException"]);
            //Check assertion
            try
            {
                fromCall = fp.FileExists(fileName);
                Assert.AreEqual(expectedValue, fromCall,
                                "File Name: " + fileName + " has failed it's existence test in test: FileExistsTestFromDB()");
            }
            catch(AssertFailedException ex)
            {
                //Rethrow assertion
                throw ex;
            }
            catch(ArgumentNullException)
            {
                //See if method wae expected to throw an exception
                Assert.IsTrue(causesException);
            }
        }

        [TestMethod]
        [Description("Check to see if file does exist")]
        [Owner("Zeljko")]
        public void FileNameDoesExist()
        {
            FileProcess fp = new FileProcess();
            bool fromCall;


            //TestContext.WriteLine("Creating the file: " + _GoodFileName);
            //File.AppendAllText(_GoodFileName, "Some Text");

            TestContext.WriteLine("Testing the file: " + _GoodFileName);
            File.AppendAllText(_GoodFileName, "Some Text");
            fromCall = fp.FileExists(_GoodFileName);

            //TestContext.WriteLine("Deleting the file: " + _GoodFileName);
            //File.Delete(_GoodFileName);

            Assert.IsTrue(fromCall);
        }

        private const string FILE_NAME = @"FileforDeploy.txt";

        [TestMethod]
        [Owner("Zeks")]
        [DeploymentItem(FILE_NAME)]
        public void FileNameDoesExistUsingDeploymentItem()
        {
            FileProcess fp = new FileProcess();
            string fileName;
            bool fromCall;
            fileName = TestContext.DeploymentDirectory + @"\" + FILE_NAME;
            TestContext.WriteLine("Checking file: " + fileName);
            fromCall = fp.FileExists(fileName);
            Assert.IsTrue(fromCall);
        }
        [TestMethod]
        [Timeout(5000)]
        public void SimulateTimeout()
        {
            System.Threading.Thread.Sleep(4000);
        }

        [TestMethod]
        public void FileNameDoesNotExistSimpleMessage()
        {
            //Arrange
            FileProcess fp = new FileProcess();
            //Act
            bool fromCall = fp.FileExists(_GoodFileName);
            //Assert
            Assert.IsFalse(fromCall, "File does NOT exist.");
        }
        [TestMethod]
        public void FileNameDoesNotExistMessageWithFormating()
        {
            //Arrange
            FileProcess fp = new FileProcess();
            //Act
            bool fromCall = fp.FileExists(_GoodFileName);
            //Assert
            Assert.IsFalse(fromCall, "File '{0}' Does NOT exist.", _GoodFileName);
        }

        [TestMethod]
        [Description("Check to see if file NOT does exist")]
        [Owner("Zdravko")]
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
        [Owner("Pera")]
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
