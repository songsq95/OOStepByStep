﻿namespace OOStepByStep
{
    public class Person
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual string IntroduceMyself()
        {
            return $"My name is {name}. I am {age} years old.";
        }

        public string Name { get => name; }

        //public int Age { get { return age; } }
    }
}