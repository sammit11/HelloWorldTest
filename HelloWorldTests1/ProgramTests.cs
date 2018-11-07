using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

using Interfaces;

using System;

namespace HelloWorldDemo.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MainTest()
        {
            DataProviderFactory dataProviderFactory = new DataProviderFactory();

            IDataProvider consoleProvider = dataProviderFactory.CreateDataProvider("ConsoleDataAccess");

            consoleProvider.ShowHello("hello world console");

            Assert.IsTrue(consoleProvider.Response == "hello world console" );
        }
    }
}