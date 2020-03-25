using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;

namespace TA_VS12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SerialPort S = new SerialPort("COM3", 9600);
                S.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }
    }
}
