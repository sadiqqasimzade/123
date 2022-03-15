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
            InputChecker();
        }



        public void Shoot()
        {
            if (bulletCount == 0)
                Console.WriteLine("no bullet left");
            
            else if (auto == true)
            {
                Console.WriteLine("pew");
                bulletCount--;
                if (bulletCount > 0)
                {
                    bulletCount--;
                    Console.WriteLine("pew");
                }
                else
                    Console.WriteLine("no bullet left");
                
            }
            else
            {
                bulletCount--;
                Console.WriteLine("pew");
            }

        }
        public void Fire()
        {
            double cooldown = 1;//atislar arasinda fasile
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
                    Console.Write("pew");
                    bulletCount--;
                    shotedbullets++;
                }
            }
            else
            {
                while (bulletCount > 0)
                {
                    Console.WriteLine("pew");
                    bulletCount--;
                    shotedbullets++;
                }
            }
            if (auto == true) shotedbullets = ((time / bulletCap) * shotedbullets) + shotedbullets * cooldown;
            else shotedbullets *= (time / bulletCap);
            Console.WriteLine($"no bullet left.\ntime:{shotedbullets}sec");
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
        public void Info()
        {
            Console.WriteLine(@$"       Info
BulletCap:{bulletCap}
BulletCount:{bulletCount}
FireTime:{time}
Auto fire mode:{auto}");
        }

        public void ChangeFireMode()
        {
            auto = !auto;
            Console.WriteLine("Mode changed");
        }
        public void InputChecker()
        {
            if(bulletCap<=0)
            {
                bulletCap = 10;
                Console.WriteLine("WARNING:BULLET CAPACITY CANT BE 0 OR NEGATIVE.USING DEFAULT PARAMS:bullet capacity=10");
            }
            if(bulletCount>bulletCap)
            {
                bulletCount = 0;
                Console.WriteLine("WARNING:BULLET AMOUT CANT BE GREATER THAN CAPACITY.USING DEFAULT PARAMS:bullet amout=0");
            }
            if(time<=0)
            {
                time = 10;
                Console.WriteLine("WARNING:TIME CANT BE 0 OR NEGATIVE.USING DEFAULT PARAMS:time=10sec");
            }

        }

    }
}
