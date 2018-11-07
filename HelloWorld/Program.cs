
using Entities;

using Interfaces;

using System;

namespace HelloWorldDemo

{
    public class Program

    {

        public static void Main(string[] args)

        {

            DataProviderFactory dataProviderFactory = new DataProviderFactory();

            IDataProvider consoleProvider = dataProviderFactory.CreateDataProvider("ConsoleDataAccess");

            consoleProvider.ShowHello("hello World - console");
     
        }

    }

}