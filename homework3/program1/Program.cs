using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



interface Shape
{
    void display();
}

//三角形
class Triangle:Shape
{
    private double bottom;     //底边
    private double height;      //高

    public Triangle(double bottom, double height)
    {
        this.bottom = bottom;
        this.height = height;
        Console.WriteLine("已创建一个三角形，其底和高分别为：" + bottom + "和" + height);
    }

    private double Area
    {
        get
        {
            return bottom * height / 2;
        }
    }

    public void display()
    {
        Console.WriteLine("三角形的面积：" + Area);
    }
}

//圆
class Circle:Shape
{
    private double radius;   //半径

    public Circle(double radius)
    {
        this.radius = radius;
        Console.WriteLine("已创建一个圆，其半径为：" + radius);
    }

    private double Area
    {
        get
        {
            return radius * radius * Math.PI;
        }
    }

    public void display()
    {
        Console.WriteLine("圆的面积：" + Area);
    }
}

//正方形
class Sqare : Shape
{
    private double side;   //边长

    public Sqare(double side)
    {
        this.side = side;
        Console.WriteLine("已创建一个正方形，其边长为：" + side) ;
    }

    private double Area
    {
        get
        {
            return side * side;
        }
    }

    public void display()
    {
        Console.WriteLine("正方形的面积：" + Area);
    }

}

//长方形
class Rectangle : Shape
{
    private double width;       //宽
    private double height;       //长

    public Rectangle(double width,double height)
    {
        this.width = width;
        this.height = height;
        Console.WriteLine("已创建一个长方形，其长和宽分别为" + height + "和" + width);
    }

    private double Area
    {
        get
        {
            return width * height;
        }
    }

    public void display()
    {
        Console.WriteLine("长方形的面积：" + Area);
    }
}

class ShapeFactory
{
    public static Shape getShape(string type)
    {
        Shape shape = null;
        if (type == "triangle")
        {
            Console.WriteLine("请输入三角形的底边长度：");
            int bottom = Int32.Parse(Console.ReadLine());
            Console.WriteLine("请输入三角形的高：");
            int height = Int32.Parse(Console.ReadLine());
            shape = new Triangle(bottom, height);
        }
        else if (type == "circle")
        {
            Console.WriteLine("请输入圆的半径：");
            int radius = Int32.Parse(Console.ReadLine());
            shape = new Circle(radius);
        }
        else if (type == "sqare")
        {
            Console.WriteLine("请输入正方形的边长：");
            int side = Int32.Parse(Console.ReadLine());
            shape = new Sqare(side);
        }
        else if (type == "rectangle")
        {
            Console.WriteLine("请输入长方形的长：");
            int height = Int32.Parse(Console.ReadLine());
            Console.WriteLine("请输入长方形的宽：");
            int width = Int32.Parse(Console.ReadLine());
            shape = new Rectangle(width, height);
        }
        else
        {
            Console.WriteLine("对不起，没有找到这种图形或暂时无法创建这种图形。");
        }
        return shape;
    }
}

namespace program1
{
    class Client
    {
        static void Main(string[] args)
        {
            Shape shape1;
            shape1 = ShapeFactory.getShape("triangle");
            shape1.display();
            Shape shape2;
            shape2 = ShapeFactory.getShape("circle");
            shape2.display();
            Shape shape3;
            shape3 = ShapeFactory.getShape("sqare");
            shape3.display();
            Shape shape4;
            shape4 = ShapeFactory.getShape("rectangle");
            shape4.display();
            Console.WriteLine("按任意键以结束");
            Console.ReadKey();
        }
    }
}
