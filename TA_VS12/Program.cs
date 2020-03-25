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
                //SerialPort S = new SerialPort("COM4", 9600); //@ Step 1: //@@ Set Communication Port
                S.Open(); //@Step2: //@@ Open Serial port 
                Thread.Sleep(2000);
                string s = S.ReadExisting(); //@Step 3: //@@ Read Serial port 
                if (s.Contains("Nikhil Naik")) //@ Step 4: //@@ Verify Data
                {
                    Console.WriteLine("PASS"); //@@ If Equel Pass.
                }
                else
                {
                    Console.WriteLine("FAIL"); //@@ If Not Equel Fail.
                }
                Thread.Sleep(10000);
                S.Close(); //@ Step 5: //@@ Close Serial Port.
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Thread.Sleep(10000);
            }
            
        }
    }
}
