using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAlarmClock
{
    /// <summary>
    /// Applikationen simulerar en 24-timmars digital klockdisplay.
    /// Applicationen hanterar också allarmtid.
    /// </summary>
    class Program
    {
        private static string HorizontalLine = "\n════════════════════════════════════════════════════════════════════════════════\n";
        static void Main(string[] args)
        {
            Console.Title = "Digital Väckarklocka";
         
            //Test 1
/*------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            ViewTestHeader("Test 1.\nTest av standardkonstruktor.\n");           
            AlarmClock ac1 = new AlarmClock();
            Console.WriteLine(ac1);

            //Test 2
            //Test av konstruktorn med två parametrar.
/*------------------------------------------------------------------------------------------------------------------------------------------------------------*/;
            ViewTestHeader("Test 2.\nTest av konstruktorn med två parameter: (9, 42)\n");
            AlarmClock ac2 = new AlarmClock(9, 42);
            Console.WriteLine(ac2);

            //Test 3
            //Test av konstruktorn med fyra parametrar.
/*------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            ViewTestHeader("Test 3.\nTest av konstruktorn med två parameter: (13, 24, 7, 35)\n");
            AlarmClock ac3 = new AlarmClock(13, 24, 7, 35);
            Console.WriteLine(ac3);


            //Test 4
            //Test av metoden TickTock() som ska låta klockan gå en minut. Ställer befintligt AlarmClock-objekt till 23:58 och låter den gå 13 minuter.
/*------------------------------------------------------------------------------------------------------------------------------------------------------------*/         
            ViewTestHeader("Test 4.\nStäller befintligt AlarmClock-objekt till 23:58 och låter den gå 13 minuter.\n");
            AlarmClock ac4 = new AlarmClock(23, 58, 7, 35);          
            Run(ac4, 13);


            //Test 5
            //Ställer befintligt AlarmClock-objekt till tiden 6:12 och alarmtiden till 6:15 \noch låterden gå 6 minuter.
/*------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            ViewTestHeader("Test 5.\nStäller befintligt AlarmClock-objekt till tiden 6:12 och alarmtiden till 6:15 \noch låterden gå 6 minuter.\n");
            AlarmClock ac5 = new AlarmClock(6, 12, 6, 15);
            Run(ac5, 6);


            //Test 6
            //Test av egenskaperna så att undantag kastas då tid och alarmtid tilldelas felaktiga värden. 
/*------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            ViewTestHeader("Test 6.\nTestar egenskaperna så att undantag kastas då tid och alarmid tilldelas \nfelaktiga värden.\n");
            AlarmClock ac6 = new AlarmClock();
            

            try
            {
                ac6.Hour = 25;

            }
            catch (Exception ex)
            {               
                ViewErrorMessage(ex.Message);
            }
            try
            {    
                ac6.Minute = 78;

            }
            catch (Exception ex)
            {

                ViewErrorMessage(String.Format("Minuten är inte i intervallet 0-59. {0}\n", ex.Message));
            }
            try
            {
              ac6.AlarmHour = 64;

            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }
            try
            {
                ac6.AlarmMinute = 112;
               
            }
            catch (Exception ex)
            {
                
                ViewErrorMessage(ex.Message);
            }

            //Test 7
            //Test av konstruktorer så att undantag kastas då tid och alarmtid 
            //tilldelas felaktiga värden. 
/*------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            //AlarmClock ac7 = new AlarmClock(25, 78, 0,0);
            ViewTestHeader("Test 7.\nTestar konstruktoren så att undantag kastas då tid och alarmid tilldelas \nfelaktiga värden.\n");

            try
            {
                AlarmClock ac7 = new AlarmClock(55,77); //"78:89"
              
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }
            try
            {
                AlarmClock ac8 = new AlarmClock(0,0,56,35);               
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }
        }
            /// <summary>
            /// Privat statisk metod som har två parametrar. Den första parametern är en referens till AlarmClock- objekt.
            /// Den andra parametern är antalet minuter som AlarmClock-objektet ska gå (vilket lämpligen görs genom att låta
            /// ett AlarmClock-objekt göra upprepade anrop av metoden TickTock()). 
            /// </summary>
            /// <param name="ac"></param>
            /// <param name="minutes"></param>
            private static void Run(AlarmClock ac, int minutes)
            {             

                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ╔══════════════════════════════════════╗");
                Console.WriteLine(" ║       Väckarklockan URLED <TM>       ║");
                Console.Write(" ║      ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("  Modellnr.: 1DV402S2L2A");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("        ║");
                Console.WriteLine(" ╚══════════════════════════════════════╝\n");
                Console.ResetColor();

               
               
                
                //for (int i = 0; i < minutes; i++)
                //{
                //    ac.TickTock();
                //    //Console.ForegroundColor = ConsoleColor.White;
                //    Console.WriteLine(ac);
                //}

                for (int i = 0; i < minutes; i++)
                {
                    if (ac.TickTock())
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            Console.Beep();
                        }
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("{0, 8:0}  BEEP! BEEP! BEEP! BEEP!", ac);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine(ac);
                    }
                }
            }

            /// <summary>
            /// Privat statisk metoden som tar ett felmeddelande som argument och presenterar det. 
            /// </summary>
            /// <param name="message"></param>
            private static void ViewErrorMessage(string message)
            {

                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(message);
                Console.ResetColor();

            }

            /// <summary>
            /// Privat statisk metod som tar en sträng som argument och presenterar strängen.
            /// </summary>
            /// <param name="header"></param>
            public static void ViewTestHeader(string header)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(HorizontalLine);
                Console.WriteLine(header);
                Console.ResetColor();
            }

        }
    }