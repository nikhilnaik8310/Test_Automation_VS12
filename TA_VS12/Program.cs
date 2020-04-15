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
                S.Open(); //@@ ECU is connected.
                //@@ Unable to observe Red “LED” power up
                Thread.Sleep(5000);//@ Step 2: //@@ Wait till appliance state. 
                string s = S.ReadExisting();  
                if (s.Contains("10101")|| s.Contains("01010"))//@ Step 3: //@@ Observe LED behavior
                {
                    Console.WriteLine("PASS"); //@@ LED ON for 1S and OFF for 1S.
                }
                else
                {
                    Console.WriteLine("FAIL"); //@@ Does not observe LED ON for 1S and OFF for 1S.
                }
                S.Close(); //@ Step 5: //@@ Close Serial Port.
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());//@@ ECU is not Connected to com port.
               
            }
        }
    }
}
