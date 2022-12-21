/*Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями:
y = k1 * x + b1, y = k2 * x +b2.
Значения k1, b1, k2, b2 задаются пользователем*/

Console.WriteLine("Enter k1: ");
float k1 = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Enter b1: ");
float b1 = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Enter k2: ");
float k2 = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Enter b2: ");
float b2 = Convert.ToSingle(Console.ReadLine());
intersectionPoint(k1, b1, k2, b2);

void intersectionPoint(float k1, float b1, float k2, float b2)
{
    float x = (b2 - b1) / (k1 - k2);
    float y = k1 * x + b1;
    
    if (k1 == k2)
    {
        Console.WriteLine("Straight lines don't intersect");
    }
    else
    {
        Console.WriteLine($"Intersection at a point X:{x}, Y:{y}");
    }
}
