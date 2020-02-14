using System;

namespace Dog_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
        namespace Dog_Challenge
        {
            enum Gender { Male, Female};

            class Dog{
                public Dog(String name1, String owner1, int age1, Gender gender1){

                    name = name1;
                    owner = owner1;
                    age = age1;
                    gender = gender1;
                }
                public String name; 
                public String owner;
                public int age;
                public Gender gender; 

                public void bark(int barks)
                {
                    for (int i = 0; i < barks; i++)
                    {
                        Console.WriteLine("Woof!");
                    }
                }
                
                public String getTag()
                {
                    String tag = "";
                    if (gender == Gender.Male && age <= 1)
                    {
                        tag = "If lost, call " + owner + ". His name is " + name + " and he is " + age + "years old.";

                    }
                    else if (gender == Gender.Male && age > 1){
                        
                        tag = "If lost, call " + owner + ". His name is " + name + " and she is " + age + " years old.";
                }
                    else if (gender == Gender.Female && age > 1){

                        tag = "If lost, call " + owner + ". Her name is " + name + "and she is " + age + " years old.";

                    else if (gender == Gender.Female && age <= 1){

                        tag = "If lost, call " + owner + ". Her name is " + name + " and she is" + age + " years old.";
                    }

                    return tag;

                }
            }
        }
        }
    }
}

class Program
{ 
    static void Main(string[] args)
    {
        Dog_Challenge puppy = new Dog_Challenge("Lucy", "Kyle", 4, Gender.Female);
        puppy.bark(2);
        Console.WriteLine(puppy.getTag());

        Dog_Challenge myDog = new Dog_Challenge("Striker", "Will", 1, Gender.Male);
        myDog.bark(4);
        Console.WriteLine(myDog.getTag());
        
        Dog_Challenge myDog = new Dog_Challenge("Dehlila", "Will", 2, Gender.Female);
        myDog.bark(1);
        Console.WriteLine(myDog.getTag());

        Console.ReadLine();
    }
}