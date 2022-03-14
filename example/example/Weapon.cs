using System;
using System.Collections.Generic;
using System.Text;

namespace example
{
    class Weapon
    {
        public int bulletCap;
        public int bulletCount;
        public double time;
        public bool auto = true;

        public Weapon(int bulletCap,int bulletCount,double time,bool auto)
        {
            this.bulletCap = bulletCap;
            this.bulletCount = bulletCount;
            this.time = time;
            this.auto = auto;
            if (bulletCount > bulletCap) Console.WriteLine("WARNING:WRONG DATA:bulletcount cant be greater than bulletcap");
        }



        public  void Shot()
        {
            if (bulletCount <= 0)
            {
                Console.WriteLine("no bullet left");
            }
            else if (auto==true)
            {
                Console.WriteLine("pew");
                bulletCount--;
                if (bulletCount > 0)
                {
                    bulletCount--;
                    Console.WriteLine("pew");
                }
                else
                {
                    Console.WriteLine("no bullet left");
                }
            }
           else
            {
                bulletCount--;
                Console.WriteLine("pew");
            }
            
            

        }
        public  void Fire()
        {
            double shotedbullets=0;
            if(bulletCount==0)
            {
                Console.WriteLine("no bullet left");
                return;
            }
            while(bulletCount>0)
            {
                Console.WriteLine("Shot");
                shotedbullets++;
            }
            shotedbullets *= (bulletCap / time);
            Console.WriteLine($"no bullet left.time:{shotedbullets}");
        }

        public  void GetRemainBulletCount()
        {
            Console.WriteLine("Bullets left:"+bulletCount);
        }

        public  void Reload()
        {
            if (bulletCap - bulletCount == 0) Console.WriteLine("ammo is full");
            else
            {
                Console.WriteLine($"{bulletCap - bulletCount}:bullet added");
                bulletCount = bulletCap;
            }
        }
        public void Info()
        {

        }

    }
}
