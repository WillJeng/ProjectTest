

class Car
{
    public string model;
    
    public Car()
    { 
        model = "will";    
    }

    public static void Main(string[] args)
    { 
        Car Ford = new Car();
        Console.WriteLine(Ford.model);
        
        Dog dog = new Dog();
        dog.Car();
    }
}


class Dog
{ 
    public string voide;
    public Dog() 
    {
        voide = "汪汪汪";
    }

    public void Car()
    {
        Dog dog = new Dog();
        Console.WriteLine(dog.voide);
    }
}


