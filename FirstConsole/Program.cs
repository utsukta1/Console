
using FirstConsole.Abstractss;
using FirstConsole.Constructor;
using FirstConsole.Encapulatess;
using FirstConsole.Loop;
using FirstConsole.Math;
using FirstConsole.oop;
using FirstConsole.Overridess;

//Add abc = new Add();
//abc.Addition();
//abc.Subtraction();

//Construct construct = new Construct();
//construct.Defcons();

//Console.WriteLine("Enter a number: ");
//int f= Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter another number :");
//int g= Convert.ToInt32(Console.ReadLine());
//Construct construct1 = new Construct(f,g);
//construct1.Parcons();

//Console.WriteLine("xyz");

//Console.WriteLine("Enter three numbers : ");
//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//int c = Convert.ToInt32(Console.ReadLine());

//if (c > b)
//{
//    if (c > a)
//    {
//        Console.WriteLine("The greatest number is: " + c);
//    }

//}
//else
//{
//    if(b> a)
//    {
//        Console.WriteLine("The greatest number is :" + b);
//    }
//    else
//    {
//        Console.WriteLine("The greatest number is :" + a);
//    }
//}


//if (a>b & a > c)
//{
//    Console.WriteLine("The greatest number is: " + a);
//}
//else if (b>a & b>c)
//{
//    Console.WriteLine("The greatest number is: " + b);
//}

//else
//{
//    Console.WriteLine("The greatest number is: "+ c);
//}

Loop loop = new Loop();
//loop.Floop();
//loop.Wloop();
//loop.Dwloop();

Area area = new Area();
//Console.WriteLine("Enter CIRCLE if you want the area of circle and RECT if you want the area of a rectangle.");
//string name = Console.ReadLine();
//if (name == "CIRCLE")
//{
//    area.Aofcircle();
//}
//else if(name == "RECT")
//{
//    area.Aofrect();
//}
//else
//{
//    Console.WriteLine("Please type CIRCLE or RECT ONLY !");
//}

//loop.feloop();

//Car car = new Car();
//car.BootCpacity();
//Scooter scooter = new Scooter();
//scooter.BootCpacity();
//scooter.model();
//Animals animals = new Animals();
//Console.WriteLine(animals.Utsukta("Cow"));
//Console.WriteLine(animals.Snake("Python"));

//Overloadss overloadss = new Overloadss();
//overloadss.Areas(4,5);
//Bike bike = new Bike();
//bike.Wheels();
//Monkey monkey = new Monkey();
//monkey.animalSound();
//abc.Sum(6, 5);

Bank bank = new Bank();
bank.setpin(613);
Console.WriteLine(bank.getpin());


Console.ReadLine();
