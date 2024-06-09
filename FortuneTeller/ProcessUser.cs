using FortuneTeller.Exceptions;
using FortuneTeller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    public class ProcessUser
    {
        private const int fieldCount = 2;
        public ProcessUser() { }


        public void StartProcess()
        {
            // loop forever
            while (true)
            {
                User user = new User();
                Console.Clear();
                Console.WriteLine("Welcome to the fortune Teller, my good fortune shine on you");
                Console.WriteLine();
                int counter = 0;

                while (counter < fieldCount)
                {
                    try
                    {
                        switch (counter)
                        {
                            case 0:
                                Console.Write("What is your first Name: ");
                                user.FirstName = KeyBoardInput();
                                Console.WriteLine();
                                break;
                            case 1:
                                Console.Write("What is your Last Name: ");
                                user.LastName = KeyBoardInput();
                                Console.WriteLine();
                                break;
                        }
                        counter++;

                    }
                    catch (ValidateException ve)
                    {
                        Console.WriteLine();
                        Console.WriteLine(ve.Message);
                        Console.WriteLine();
                        continue;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine();
                        Console.WriteLine(ex.Message);
                        Console.WriteLine();
                        continue;
                    }
                }


            }
        }

        private string KeyBoardInput()
        {
            string result = Console.ReadLine();
            return result;
        }
    }
}

