using System;
namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon gun = new Weapon(10, 0, 4, true);
            int choise = -1;
            while (choise!=-1)
            {
                Console.WriteLine("Choise:");
                choise = Convert.ToInt32(Console.ReadLine());

                switch (choise)
                {
                    case 0: {
                            
                        
                        }break;
                    case 1:
                        {

                        }break;
                    case 2:
                        {

                        }break;
                    case 3:
                        {

                        }
                        break;
                    case 4:
                        {

                        }
                        break;
                    case 5:
                        {

                        }
                        break;
                    case 6:
                        {

                        }
                        break;
                    default:
                        {
                            
                        }break;
                }
            }
        }
    }
}
