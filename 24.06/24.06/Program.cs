using System;

namespace _24._06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Services.JSONReader reader = new Services.JSONReader();
            //reader.Reader();

            Services.Starter starter = new Services.Starter();

            starter.FillEvent += starter.handler;
            starter.FillEvent2 += starter.handler;

            starter.Open();
        }
    }
}
