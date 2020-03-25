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
                SerialPort S = new SerialPort("COM3", 9600);
                Thread.Sleep(2000);
                Thread.Sleep(15000);
                S.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }
    }
}
