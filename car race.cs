using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Car
    {
        private int maxspeed;
        private int speed = 0;
        private bool life = true;
        private double distance = 0;
        public Car(int maxspeed)
        {
            this.maxspeed = maxspeed;
        }
        public void setspeed(int num)
        {
            this.speed = num;
        }
        public int getspeed()
        {
            return this.speed;
        }
        public int getmaxspeed()
        {
            return this.maxspeed;
        }
        public bool getlife()
        {
            return this.life;
        }
        public void murder()
        {
            this.life = false;
        }
        public double getdistance()
        {
            return this.distance;
        }
        public void setdistance(double num)
        {
            this.distance = num;
        }
    }
            

    
    class CarRace
    {
            private Car[] carrace;
            public CarRace(int n)
            {
                this.carrace = new Car[n];
            }
            public void race()
            {
                for (int i = 0; i < carrace.Length; i++)
                {
                    carrace[i] = new Car(int.Parse(Console.ReadLine()));

                }
                Random rnd = new Random();
                bool check = false;
                while (!check)
                {
                    for (int i = 0; i < carrace.Length; i++)
                    {

                    if (carrace[i].getlife())
                    {


                        int hagrala = rnd.Next(1, 5);
                        WheelOfFortune(hagrala, i);

                        carrace[i].setdistance(carrace[i].getdistance() + (carrace[i].getspeed() * 0.033));
                        if(carrace[i].getdistance()>10)
                        {
                            Console.WriteLine("the winning car is car number " + i);
                            check = false;
                            break;
                        }
                            


                        }
                    }
                    
                    }


                }
        public void WheelOfFortune(int hagrala, int i)
        {
            switch (hagrala)
            {
                case 1:
                    if (carrace[i].getspeed() + 10 <= carrace[i].getmaxspeed())
                    {
                        carrace[i].setspeed(carrace[i].getspeed() + 10);

                    }
                    else
                    {
                        carrace[i].setspeed(carrace[i].getmaxspeed());
                    }
                    break;
                case 2:
                    if (carrace[i].getspeed() >= 10)
                    {
                        carrace[i].setspeed(carrace[i].getspeed() - 10);
                    }
                    else
                    {
                        carrace[i].setspeed(0);
                    }
                    break;
                case 3:
                    if (carrace[i].getspeed() >= 20)
                    {
                        carrace[i].setspeed(carrace[i].getspeed() - 20);
                    }
                    else
                    {
                        carrace[i].setspeed(0);
                    }
                    break;
                case 4:
                    carrace[i].murder();
                    break;
            }
        }
            }
    class Program
    {
        static void Main(string[] args)
        {
            CarRace cars = new CarRace(int.Parse(Console.ReadLine()));
            cars.race();
        }
    }
}
