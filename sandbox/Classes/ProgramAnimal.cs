using System;

class Program
{
    static void Main(string[] args)
    {
        BaldEagle joey = new BaldEagle("Joey", "'Merica! **Background Explosion**");
        BaldEagle dragon = new BaldEagle("Dragon", "I am death!!");

        joey.MakeSound();
        dragon.MakeSound();
    }
}