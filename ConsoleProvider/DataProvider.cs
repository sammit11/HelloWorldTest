using Interfaces;
using System;

namespace ConsoleDataProvider

{

    public class DataProvider : IDataProvider

    {

        public string Response { get; set; }

        public void ShowHello(string say)
        {
            Console.WriteLine(say);

            //for test purpose set the say to Response
            this.Response = say;
        }

    }

}