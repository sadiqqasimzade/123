using System;

namespace example
{
    class Weapon
    {

        private int _bulletCap;
        private int _bulletCount;
        private double _time;
        private bool _auto;
        public int BulletCap
        {
            get
            {
                return _bulletCap;
            }
            set
            {
                while (value <= 0||value<BulletCount)
                {
                    Console.Write("bulletcap:");
                    value = Convert.ToInt16(Console.ReadLine());
                    if (value <= 0||value<BulletCount) Console.WriteLine("WRONG INPUT BULLETCAP CANT BE <=0 OR <BULLETCOUNT");
                }
                _bulletCap = value;
            }
        }
        public int BulletCount
        {
            get
            {
                return _bulletCount;
            }
            set
            {
                while (value < 0 || value > _bulletCap)
                {
                    Console.Write("bulletcount:");
                    value = Convert.ToInt16(Console.ReadLine());
                    if (value < 0 || value > _bulletCap ) Console.WriteLine("WRONG INPUT BULLETCOUNT CANT BE <0  OR  >BULLETCAP ");
                }
                _bulletCount = value;
            }
        }
        public double Time
        {
            get
            {
                return _time;
            }
            set
            {
                while (value <= 0)
                {
                    Console.Write("time:");
                    value = Convert.ToDouble(Console.ReadLine());
                    if (value <= 0) Console.WriteLine("WRONG INPUT TIME CANT BE <=0");
                }
                _time = value;
            }
        }
        public bool Auto
        {
            get
            {
                return _auto;
            }
            set
            {
                while (true)
                {
                    Console.WriteLine("auto mode 1) TRUE 2)FALSE");
                    int choise = Convert.ToInt32(Console.ReadLine());
                    if (choise == 1)
                    {
                        value = true;
                        break;
                    }
                    else if (choise == 2)
                    {
                        value = false;
                        break;
                    }
                    Console.WriteLine("WRONG INPUT");
                }
                _auto = value;
            }
        }

        public Weapon(int bulletCap, int bulletCount, double time, bool auto)
        {
            BulletCap = bulletCap;
            BulletCount = bulletCount;
            Time = time;
            Auto = auto;
        }



        public void Shoot()
        {
            if (_bulletCount == 0)
                Console.WriteLine("no bullet left");
            else
            {
                _bulletCount--;
                Console.WriteLine("pew");
            }
        }
        public void Fire()
        {
            //double cooldown = 1;//atislar arasinda fasile
            double shotedbullets = 0;
            if (_bulletCount == 0)
            {
                Console.WriteLine("no bullet left");
                return;
            }
            if (_auto)
            {
                while (_bulletCount > 0)
                {
                    _bulletCount--;
                    shotedbullets++;
                    Console.Write(shotedbullets + ")pew");
                }
            }
            else
            {
                while (_bulletCount > 0)
                {
                    _bulletCount--;
                    shotedbullets++;
                    Console.WriteLine(shotedbullets + ")pew");
                }
            }
            //if (auto == true)
            //    shotedbullets *= (time / bulletCap);
            //else shotedbullets *= ((time / bulletCap) + cooldown);
            Console.WriteLine($"\nno bullet left.\ntime:{Math.Round(shotedbullets * (_time / _bulletCap), 2)}sec");
        }

        public void GetRemainBulletCount()
        {
            Console.WriteLine("Bullets need:" + (_bulletCap - _bulletCount));

        }

        public void Reload()
        {
            if (_bulletCap - _bulletCount == 0)
                Console.WriteLine("ammo is full");

            else
            {
                Console.WriteLine($"{_bulletCap - _bulletCount}:bullet added");
                _bulletCount = _bulletCap;
            }
        }


        public void ChangeFireMode()
        {
            _auto = !_auto;
            Console.WriteLine("Auto Mode changed to:" + _auto);
        }

        public void Settings()
        {
            string stringchoise = "0";
            while (stringchoise != "C")
            {
                switch (stringchoise)
                {
                    case "T":
                        BulletCap = 0;
                        stringchoise = "C";
                        break;
                    case "S":
                        BulletCount = -1;
                        stringchoise = "C";
                        break;
                    case "D":
                        Time = 0;
                        stringchoise = "C";
                        break;
                    default:
                        Console.Write(@"7 - Redaktə et :
T - Tutumu dəyişsin
S - Güllə sayı
D - Sıfırlama saniyəsi
C - Cancel
Choise:");
                        stringchoise = Console.ReadLine();
                        break;
                }
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"BulletCap:{BulletCap}\nBulletCount:{BulletCount}\nTime:{Time}\nAutoMode:{Auto}");
        }
    }
}
