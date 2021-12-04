using System;
//Порушений принцип підстановки Лісков.
//Треба створити інтерфейс для обрахунку площі і створити класи фігур,
//які успадкують метод рахування площі і перевизначать його,
//щоб рахувало для його фігури.
//Таким чином я можу створити не тільки квадрат і прямокутник, але і круг, і навіть трьохвимірні фігури,
//де я зможу обраховувати площі
interface IFigure
{
    int GetArea();
}

class Rectangle : IFigure
{
    public int Width { get; set; }
    public int Height { get; set; }

    public int GetArea()
    {
        return Width * Height;
    }
}

//квадрат наслідується від прямокутника!!!
class Square : IFigure
{
    public int Side { get; set; }

    public int GetArea()
    {
        return Side * Side;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle();
        rectangle.Width = 10;
        rectangle.Height = 5;
        Console.WriteLine("Rectangle area: {0}", rectangle.GetArea());

        Square square = new Square();
        square.Side = 10;
        Console.WriteLine("Square area: {0}", square.GetArea());

        Console.ReadKey();
    }
}