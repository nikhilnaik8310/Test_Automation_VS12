using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;
using System.Threading;

namespace TA_VS12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SerialPort S = new SerialPort("COM4", 9600);
                S.Open();
                Thread.Sleep(2000);
                string s = S.ReadExisting();
                if (s.Contains("Nikhil Naik"))
                {
                    Console.WriteLine("Pass");
                }
                else
                {
                    Console.WriteLine("Fail");
                }
                Thread.Sleep(10000);
                S.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Thread.Sleep(10000);
            }
            
        }
    }
}
