using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
  abstract  class Vehicle//sealed is the keyword used to stop class from inherit
    {
        protected string color;
        public Vehicle()//invoked automatically by child class
        {
            this.color = "WHITE";
            Console.WriteLine("CONSTRUCTOR FROM VEHICLE");
        }
        public Vehicle(string clr)//not invoked automatically by child class
        {

            this.color = clr;
            Console.WriteLine("parametrised");

        }
      public   abstract void Fuel();//abstract method;

            public virtual void Start()//to override the method in base class
        {
            Console.WriteLine("started");

        }
        public void Stop()
        {
            Console.WriteLine("stopped");
        }
    }

    class Bus:Vehicle
    {
        int seating;
        int speed;
        public override void Fuel()
        {
            Console.WriteLine("FILL DIESEL BUS");
        }

       
        public Bus() : base("red")//calling parent class parameter constructor
        {
            this.seating = 10;
            this.speed = 20;
            Console.WriteLine("bus constructor");
        }
        
        public void Run()
        {
            Console.WriteLine("bus color is"+this.color+"have seating for"+this.seating+"going with speed of"+this.speed);

        }
       
    }
    class Car:Vehicle
    {
        int speed;
        string type;
        public override void Fuel()
        {
            Console.WriteLine("FILL DIESEL CAR");
        }
        public Car()
        {
            this.speed = 110;
            this.type = "kk";
          
            Console.WriteLine("car constructor");
        }
        public Car(string clr,int spd,string type):base(clr)//passing self class parameter constructor
        {
            this.speed = spd;
            this.type = type;
        }
        public void Drive()
        {
            Console.WriteLine("bus color is" + this.color+ "going with speed of" + this.speed+"of type"+this.type);
        }
        public override void Start()//overriding parent class method
        {
            Console.WriteLine(" car started");

        }

    }

}
