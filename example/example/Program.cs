using System;
namespace example
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.GetEncoding("UTF-16");
            int bulletcap = -1;
            int bulletcount = -1;
            double time = -1;
            bool auto = true;
            int choise = -1;



            Weapon gun = new Weapon(bulletcap, bulletcount, time, auto);


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
7 - Redaktə et
----
FOR DEBUG
8 - Clear Console
9 - ShowInfo
Choise:");
                choise = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("---------------------------");
                switch (choise)
                {
                    case 0:
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
                        gun.Settings();
                        break;

                    case 8:
                        Console.Clear();
                        break;
                    case 9:
                        gun.ShowInfo();
                        break;
                    default:
                        Console.WriteLine("Wrong input");

                        break;
                }
            }
        }
    }
}
