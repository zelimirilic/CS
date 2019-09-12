using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
namespace Loans.Tests
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false)]
    class ProductComparisonAttribute : CategoryAttribute 
    {

    }
}
