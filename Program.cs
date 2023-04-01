using System;

public class Program
{
    public static void Main(string[] args)
    {
        // object of derived class

        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.FirstName = "Roger";
        FTE.LastName = "Fed";
        FTE.YearlySalary = 500000;
        FTE.PrintFullName();

        // object of derived class

        PartTimeEmployee PTE = new PartTimeEmployee();
        PTE.FirstName = "Part";
        PTE.LastName = "Time";
        PTE.PrintFullName();

        // object of derived class
        Dog labrador = new Dog();

        // accesses overridden method
        labrador.eat();

        // object of derived class

        Square s1 = new Square();
        s1.calculateArea();
        s1.calculatePerimeter(s1.length, s1.sides);

        // object of derived class

        Rectangle t1 = new Rectangle();
        t1.calculateArea();
        t1.calculatePerimeter(t1.length, t1.sides);

    }
}
public class Employee //Base Class
{
    public string FirstName;
    public string LastName;
    public string Email;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class FullTimeEmployee : Employee //Inheritance- Derived class
{
    public float YearlySalary;
}

public class PartTimeEmployee : Employee //Inheritance- Derived class
{
    public float HourlyRate;
}

public class TemporaryEmployee : Employee //Inheritance- Derived class
{
    
}

//Method Overriding in Inheritance
// base class
class Animal 
{
    public virtual void eat()
    {

        Console.WriteLine("I eat food");
    }
}

// derived class of Animal 
class Dog : Animal
{

    // overriding method from Animal
    public override void eat()
    {
        //base.eat(); Call method from animal class

        Console.WriteLine("I eat Dog food");
    }
}

//Example of inheritance
class RegularPolygon
{

    public void calculatePerimeter(int length, int sides)
    {

        int result = length * sides;
        Console.WriteLine("Perimeter: " + result);
    }
}

class Square : RegularPolygon
{

    public int length = 200;
    public int sides = 4;
    public void calculateArea()
    {

        int area = length * length;
        Console.WriteLine("Area of Square: " + area);
    }
}

class Rectangle : RegularPolygon
{

    public int length = 100;
    public int breadth = 200;
    public int sides = 4;

    public void calculateArea()
    {

        int area = length * breadth;
        Console.WriteLine("Area of Rectangle: " + area);
    }
}




