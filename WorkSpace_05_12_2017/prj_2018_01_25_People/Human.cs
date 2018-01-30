﻿using System;

namespace People
{
    abstract class Human
    {
        public string Name { get; set; }
        public Human(string name): base()
        {
            Name = name;
        }
        public virtual void Eat()
        {
            Console.WriteLine("Eating food...");
        }
        public Human()
        {
            Console.WriteLine("Enter name");
            Name = Console.ReadLine();
        }
        public override string ToString()
        {
            return $"Human {Name}";
        }
        public abstract void print();
    }
}
