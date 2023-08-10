// 1. Принцип инкапсуляции:

public class Car
{
    private string? brand;
    private int year;

    public string GetBrand()
    {
        return brand;
    }

    public void SetBrand(string brand)
    {
        this.brand = brand;
    }

    public int GetYear()
    {
        return year;
    }

    public void SetYear(int year)
    {
        this.year = year;
    }
}

// Принцип инкапсуляции позволяет скрыть внутреннюю реализацию класса 
// и предоставлять доступ только через определенные методы (геттеры и сеттеры). 
// В данном примере приватные поля brand и year скрыты от прямого доступа 
// и доступны только через публичные методы.




// 2. Принцип наследования:

public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

// Принцип наследования позволяет создавать новые классы на основе 
// уже существующих классов, наследуя их свойства и методы. 
// В данном примере класс Dog наследует метод Eat от класса Animal и добавляет новый метод Bark.




// 3. Принцип полиморфизма:

public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

// Принцип полиморфизма позволяет использовать объекты различных классов 
// с общим интерфейсом одинаковым образом. В данном примере классы Rectangle 
// и Circle наследуют абстрактный класс Shape и реализуют единственный метод 
// CalculateArea для расчета площади фигуры. 




// 4. Принцип абстракции:

public abstract class Human
{
    public abstract void Laugh();

    public void Eat()
    {
        Console.WriteLine("Human wants to eat.");
    }
}

public class Baby : Human
{
    public override void Laugh()
    {
        Console.WriteLine("Baby is laughing.");
    }
}

// Принцип абстракции позволяет определить общий интерфейс для классов, 
// оставляя реализацию методов на уровне наследников. В данном примере 
// абстрактный класс Human определяет абстрактный метод Laughing, 
// который должен быть реализован в наследниках. Класс Baby наследует Human 
// и реализует свой звук через метод Laughing.