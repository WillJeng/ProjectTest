
//int x = 30;
//int y = 20;
//Console.WriteLine(x > y);

//string result = (x > y) ? "x大" : "y大";
//Console.WriteLine(result);

//int day = 1;
//switch (day)
//{
//    case 1:
//        Console.WriteLine("Monday");
//        break;
//    case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    case 3:
//        Console.WriteLine("Wednesday");
//        break;
//    case 4:
//        Console.WriteLine("Thursdfay");
//        break;
//    case 5:
//        Console.WriteLine("Friday");
//        break;
//}

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


