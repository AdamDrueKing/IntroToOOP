﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Cat
    {
        //Inside of our class, we create the blueprint for our object.
        //Classes are templates in OOP that we use to create objects.
        //The should always be named in Pascal case.

        //In OOP, there are two types of States:
        //Fields - variables that belong to a class
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;

        //Properties - a sort of mix between a field and a method that allow controlled access
        public string Name
            {
            get {return this.name; }
            set { this.name = value; }
            }

        public int Age
        {
            get { return this.age; }
        }


        //We also have Behaviors.
        //Methods - repeatable/reusable sections of code - Actions
        //Constructors - specialized methods that are used when instantiating an object
        //  -allow us to control the state of an object upon creation
        //  /allow us to perform any actions of the object might need
        //  -always share the name of the class
        public Cat()
        {
            //This is an example of a default constructor. A default constructor takes no arguments/parameters
        }

        //Can have as many constructors as you need as long as they each have a unique signature.
        //By "signature," we mean parameters in the parentheses after the constructor name.
        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age; 
            this.furColor = furColor;
        }


        public void Eat()
        {
            if(isHungry)
            {
                isHungry = false;
            }
            Console.WriteLine("Is the cat Hungry? " + isHungry);
        }
    }
}
