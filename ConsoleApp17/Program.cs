using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp17
{   class Shop
    {
        static int cashRegister = 0;
        static int Count = 0;
        abstract class Computer
        {
            abstract public int Price();
        }
        class Dell : Computer
        {
            public int C;
            public Dell(int price)
            {
                C = price;
            }
            public override int Price()
            {
                return C;
            }

        }
        class Asus : Computer
        {
            public int C;
            public Asus(int price)
            {
                C = price;
            }
            public override int Price()
            {
                return C;
            }
        }
        abstract class Mouse
        {
            abstract public int Price();
        }
        class M3 : Mouse
        {
            public int C;
            public M3(int price)
            {
                C = price;
            }
            public override int Price()
            {
                return C;
            }            
        }
        class M5 : Mouse
        {
            public int C;
            public M5(int price)
            {
                C = price;
            }
            public override int Price()
            {
                return C;
            }
        }
        class M7 : Mouse
        {
            public int C;
            public M7(int price)
            {
                C = price;
            }
            public override int Price()
            {
                return C;
            }            
        }
        public static void Menu1()
        {
            Dell dell = new Dell(500);
            Asus asus = new Asus(700);
            char done = 'n';
            Console.WriteLine("Please choose a single or multple item");
            do
            {
                Console.WriteLine("a. Dell: 500$ ");
                Console.WriteLine("b. Asus: 700$");
                char order = char.Parse(Console.ReadLine());
                switch (order)
                {
                    case 'a':
                        Count += dell.Price();
                        using (StreamWriter w = File.AppendText("bill.txt"))
                        {
                            w.WriteLine("Dell: 500$");
                        }
                        break;
                    case 'b':
                        Count += asus.Price();
                        using (StreamWriter w = File.AppendText("bill.txt"))
                        {
                            w.WriteLine("Asus: 700$");
                        }
                        break;
                    
                    default:
                        Console.WriteLine("Not on the menu!");
                        break;
                }

                Console.Write("Order Complete?(y/n)");
                done = Char.Parse(Console.ReadLine());
                Console.Clear();
                cashRegister += Count;
            }
            while (done == 'n' || done == 'N');
            Console.WriteLine("Please take your bill");

            using (StreamWriter w = File.AppendText("bill.txt"))
            {
                w.WriteLine("Total Bill: {0}", Count);
            }
        }
        public static void Menu2()
        {
            M3 m3 = new M3(5);
            M5 m5 = new M5(7);
            M7 m7 = new M7(9);
            char done = 'n';
            Console.WriteLine("Please choose a single or multple item");
            do
            {
                Console.WriteLine("a. M3: 5$");
                Console.WriteLine("b. M5: 7$");
                Console.WriteLine("c. M7: 9$");

                char order = char.Parse(Console.ReadLine());
                switch (order)
                {
                    case 'a':
                        Count += m3.Price();
                        using (StreamWriter w = File.AppendText("bill.txt"))
                        {
                            w.WriteLine("M3: 5$");
                        }
                        break;
                    case 'b':
                        Count += m5.Price();
                        using (StreamWriter w = File.AppendText("bill.txt"))
                        {
                            w.WriteLine("M5: 7$");
                        }
                        break;
                    case 'c':
                        Count += m7.Price();
                        using (StreamWriter w = File.AppendText("bill.txt"))
                        {
                            w.WriteLine("M7: 9$");
                        }
                        break;
                    default:
                        Console.WriteLine("Not on the menu!");
                        break;
                }

                Console.Write("Order Complete?(y/n)");
                done = Char.Parse(Console.ReadLine());
                Console.Clear();
                cashRegister += Count;
            }
            while (done == 'n' || done == 'N');
            Console.WriteLine("Please take your bill");

            using (StreamWriter w = File.AppendText("bill.txt"))
            {
                w.WriteLine("Total Bill: {0}", Count);
            }
        }
        public static void RandomWait()
        {
            System.Threading.Thread.Sleep(1000);
        }
        class Program
        {
            static void Main(string[] args)
            {
                char run = 'n';
                do
                {
                    Console.Clear();
                    Console.WriteLine("Welcome!");
                    RandomWait();
                    Console.Clear();
                    Console.WriteLine("What action would you like to perform?");
                    Console.WriteLine("a. Check current balance in register");
                    Console.WriteLine("b. Place an laptop");
                    Console.WriteLine("c. Place an Mouse");
                    Console.WriteLine("d. Close register");
                    char choice = Char.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (choice)
                    {
                        case 'a':
                            Console.WriteLine("The cash register currently has {0} rupees", cashRegister);
                            break;

                        case 'b':
                            Count = 0;
                            Menu1();
                            break;
                        case 'c':
                            Count = 0;
                            Menu2();
                            break;
                        case 'd':
                            run = 'y';
                            break;

                        default:
                            Console.WriteLine("Invalid option!");
                            break;
                    }
                    Console.Write("Close register? (y/n)");
                    run = Convert.ToChar(Console.ReadLine());
                    Console.Clear();
                }
                while (run == 'n' || run == 'N');
               
            }
        }
    }
}
