using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaineClasseTest
{
    /// <summary>
    /// Summary description for MaineClasseInitialization
    /// </summary>
    [TestClass]
    public class MaineClasseInitialization
    {
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext tc)
        {
            tc.WriteLine("In the Assembly Initialize Method");
        }
        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {

        }
        

    }



    
}
