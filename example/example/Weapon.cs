using System;

namespace example
{
    class Weapon
    {
        public int bulletCap;
        public int bulletCount;
        public double time;
        public bool auto;

        public Weapon(int bulletCap, int bulletCount, double time, bool auto)
        {
            this.bulletCap = bulletCap;
            this.bulletCount = bulletCount;
            this.time = time;
            this.auto = auto;
        }



        public void Shoot()
        {
            if (bulletCount == 0)
                Console.WriteLine("no bullet left");
            else
            {
                bulletCount--;
                Console.WriteLine("pew");
            }
        }
        public void Fire()
        {
            //double cooldown = 1;//atislar arasinda fasile
            double shotedbullets = 0;
            if (bulletCount == 0)
            {
                Console.WriteLine("no bullet left");
                return;
            }
            if (auto)
            {
                while (bulletCount > 0)
                {
                    bulletCount--;
                    shotedbullets++;
                    Console.Write(shotedbullets+")pew");
                }
            }
            else
            {
                while (bulletCount > 0)
                {
                    bulletCount--;
                    shotedbullets++;
                    Console.WriteLine(shotedbullets+")pew");
                }
            }
            //if (auto == true)
            //    shotedbullets *= (time / bulletCap);
            //else shotedbullets *= ((time / bulletCap) + cooldown);
            Console.WriteLine($"\nno bullet left.\ntime:{Math.Round(shotedbullets * (time / bulletCap), 2)}sec");
        }

        public void GetRemainBulletCount()
        {
            Console.WriteLine("Bullets need:" + (bulletCap-bulletCount));
        }

        public void Reload()
        {
            if (bulletCap - bulletCount == 0)
                Console.WriteLine("ammo is full");
            
            else
            {
                Console.WriteLine($"{bulletCap - bulletCount}:bullet added");
                bulletCount = bulletCap;
            }
        }
       

        public void ChangeFireMode()
        {
            auto = !auto;
            Console.WriteLine("Auto Mode changed to:"+auto);
        }
        

    }
}
