using Interfaces;
using System;

namespace SQLDataProvider

{

    public class DataProvider : IDataProvider

    {

        public string Response { get; set; }

        public void ShowHello(string say)
        {
            Console.WriteLine("this has to be implemented in database:");
        }


    }

}