using System;
namespace example  
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.GetEncoding("UTF-16");
            Console.Write("bulletcap:");
            int bulletcap = Convert.ToInt16(Console.ReadLine());
            Console.Write("bulletcount:");
            int bulletcount = Convert.ToInt16(Console.ReadLine());
            Console.Write("time:");
            double time = Convert.ToDouble(Console.ReadLine());
            bool auto = true;
            

            Weapon gun = new Weapon(bulletcap, bulletcount, time, auto);
            int choise = 0;
            while (choise != 6)
            {
                Console.Write(@"
0 - İnformasiya almaq üçün
1 - Shoot metodu üçün
2 - Fire metodu üçün
3 - GetRemainBulletCount metodu üçün
4 - Reload metodu üçün
5 - ChangeFireMode metodu üçün
6 - Proqramdan dayandirmaq üçün
7 - Clear console
Choise:");
                choise = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("---------------------------");
                switch (choise)
                {
                    case 0:
                        gun.Info();
                        break;
                    case 1:
                        gun.Shoot();
                        break;
                    case 2:
                        gun.Fire();
                        break;
                    case 3:
                        gun.GetRemainBulletCount();
                        break;
                    case 4:
                        gun.Reload();
                        break;
                    case 5:
                        gun.ChangeFireMode();
                        break;
                    case 6: break;
                    case 7:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Wrong input");

                        break;
                }
            }
        }
    }
}
