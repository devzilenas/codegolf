using System;
using System.Collections.Generic;

class M 
{
    double d(double[]a) {
        Array.Reverse(a);
        var s = new Stack<double>(a);
        int i=0,j;
        while (s.Count>1)
        {
            double l=s.Pop(),r=s.Pop();
            j=i++%5;
            s.Push(j==0?l+r:j==1?l-r:j==2?l*r:j==3?l/r:Math.Pow(l, r));
        }
        return s.Peek();
    }

    public static void Main()
    {
        int[][] a = new int[][]{
            new int[]{1,2,3,4,5},
            new int[]{5,12,23,2,4,4,2,6,7},
            new int[]{-8,50,3,3,-123,4,17,99,13},
            new int[]{2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2},
            new int[]{1,0,1,0,1,0},
            new int[]{-9,-8,-1},
            new int[]{0,-3},
            new int[]{-99}
        };
        var r = new double[] { 0, 539, -1055.356, 256, 1, -16, -3, -99 };

        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(new M().d(Array.ConvertAll(a[i], e => Convert.ToDouble(e))));
        }
        Console.ReadKey();
    }
}
