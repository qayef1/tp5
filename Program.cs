using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MODUL5_103022400070
{
    class DataGeneric<T>
    {
        private T data;

        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + data);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DataGeneric<string> data = new DataGeneric<string>("103022400070");
            data.PrintData();

            Console.ReadLine();
        }
    }
}