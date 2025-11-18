using System;

class Program
{
    static int Add(int x, int y)          => x + y;
    static int Subtract(int x, int y)     => x - y;
    static int Multiply(int x, int y)     => x * y;
    static int Divide(int x, int y)       => x / y;
    static int Mod(int x, int y)          => x % y;

    static bool AndFunc(bool x, bool y)   => x && y;
    static bool OrFunc(bool x, bool y)    => x || y;
    static bool NotFunc(bool x)           => !x;

    static bool GreaterThan(int x, int y) => x > y;
    static bool LessEqual(int x, int y)   => x <= y;
    static bool Equal(int x, int y)       => x == y;

    static void Main()
    {
        int a = 5, b = 3, c = 7, d = 4, e = 2, f = 10;
        bool x = true, y = false, z = true, isAdmin = false;

        // 1) Worked Example
        bool expected1 = (a + b * c) > (d - e) && x || y;
        bool actual1 =
            OrFunc(
                AndFunc(
                    GreaterThan(
                        Add(a, Multiply(b, c)),
                        Subtract(d, e)
                    ),
                    x
                ),
                y
            );
        Console.WriteLine($"{expected1} {actual1}");


        // 2)
        bool expected2 = (a - b) * (c + d) <= e && z && !x;
        // actual2 = ...

        // 3)
        bool expected3 = (a + b + c) % d == 0 || (f > e && isAdmin);
        // actual3 = ...

        // 4)
        bool expected4 = !(x || y) && (a * a > b * c);
        // actual4 = ...
    }
}