System;
namespace ConsoleApplication7
{
abstract class shape
{
public int H; public int W;
public shape(int h, int w)
{ H = h;
W = w; } public virtual double area()
{ return 0; }
}
class rectangle :shape
{ public rectangle(int p, int q) : base(p, q) { } public double area()
{ return H * W; }
}
class triangle:shape
{
public triangle(int p, int q) : base(p, q) { } public double area() { return (H * W)/2.0; }
}
class Program
{
static void Main(string[] args) { shape s1 = new rectangle(5, 5); Console.WriteLine
(s1.area()); shape s2 = new triangle (6, 6);
Console.WriteLine(s2.area());
Console.ReadLine ();
} }
}