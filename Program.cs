using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDay3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Data Types

            //byte myByte = 12;
            //sbyte mySbyte = 1;
            //short myShort = 12;
            //int myInt = 12;
            //long myLong = 12;
            //double myDouble = 12.5;
            //float myFloat = 12.5F;
            //decimal myDecimal = 12;
            //char myChar = 'A';
            //string myString = "Our String";
            //DateTime myDateTime = new DateTime(day:12, month:12, year: 2022);
            //bool myBool = false;
            try 
            
            {
                byte ourByte;
            Console.WriteLine("Enter a number");
            
            ourByte = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Number is " + ourByte);
            Console.ReadKey(); 
            }

            //order is important for the catch
            catch(FormatException fe) 
            { 
                Console.WriteLine("Format Exception " +fe.Message);
            }
            catch (OverflowException of)
            {
                Console.WriteLine("Overflow Exception " + of.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error!!! " + ex.Message);
            }
            finally 
            {

                Console.WriteLine("End of the Program!!!");
                Console.ReadKey();
                    
            }



        }
    }
}
