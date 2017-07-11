using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Dog
    {
        //Create a Dog class
        //Your dog class should have fields for hair length, height, running speed and weight
        //Your class should have the following behaviors: run, bark, potty, cuddle

        //Fields:
        private string hairLength;
        private int height;
        private int runningSpeed;
        private double weight;

        //Properties
        public string HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }
        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
        public int RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.RunningSpeed = value; }
        }
        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        //****public int RunningSpeed {get; set;} does the same thing as above

        //Constructor:
        public Dog()
        {
            //this is my default constructor
        }

        public Dog(string hairLength, int height, int runningSpeed, double weight)
        {
            this.hairLength = hairLength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
        }


        //Behaviors:
        public int Run()
        {
        Console.WriteLine("Go doggy go!");
            RunningSpeed -= 1;
            return RunningSpeed;
            }

        public void Bark()
        {
        Console.WriteLine("Bork bork bork!!!");
        }

        public void Potty()
        {
            Console.WriteLine("Fart noises!!!");
        }

        public void Cuddle()
        {
            Console.WriteLine("Awww, doggo is so sweet.");
        }

        


    }
}
