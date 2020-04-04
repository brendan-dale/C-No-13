using System;

namespace fizzbuzz
{

class Math {

    public static int x
    { get; set; }
    public static int y
    { get; set; } 
    public static int z
    { get; set; }
    public static int a
    { get; set; }
    public static int m
    { get; set; } 
    public static int s
    { get; set; }

    public static int addMethod(int a)
    {
      x = a + 2;
      return x;
    }
    
    public static int multiplyMethod(int m)
    {
      y = m * 2;
      return y;
    }

    public static int subtractMethod(int s)
    {
      z = s - 2;
      return z;
    }

}

}