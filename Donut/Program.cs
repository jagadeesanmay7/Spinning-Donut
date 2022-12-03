float A = 0, B = 0, i, j;
int k;
float[]? z = new float[1760];
char[] b = new char[1760];

//To clear the screen \x1b[2J is used
Console.Write("\x1b[2J");

/*
 * can use "for loop" or "while loop" both will work
 * for(; ; )
 * while (!(Console.KeyAvailable && Console.ReadKey(false).Key == ConsoleKey.Escape))
*/
for (; ; )
{
    Console.CursorVisible = false;
    Array.Clear(z);
    Array.Fill(b, ' ');

    for (j = 0; j < 6.28; j += (float)0.07)
    {
        for (i = 0; i < 6.28; i += (float)0.02)
        {
            float c = (float)Math.Sin(i);
            float d = (float)Math.Cos(j);
            float e = (float)Math.Sin(A);
            float f = (float)Math.Sin(j);
            float g = (float)Math.Cos(A);
            float h = d + 2;
            float D = 1 / (c * h * e + f * g + 5);
            float l = (float)Math.Cos(i);
            float m = (float)Math.Cos(B);
            float n = (float)Math.Sin(B);
            float t = c * h * g - f * e;
            int x = (int)(40 + 30 * D * (l * h * m - t * n));
            int y = (int)(12 + 15 * D * (l * h * n + t * m));
            int o = x + 80 * y;
            int N = (int)(8 * ((f * e - c * d * g) * m - c * d * e - f * g - l * d * n));
            if (22 > y && y > 0 && x > 0 && 80 > x && D > z[o])
            {
                z[o] = D;
                b[o] = "m.jagadeesan"[N > 0 ? N : 0];
            }
        }
    }

    //This x1b[H will return to home cursor
    Console.Write("\x1b[H");
    for (k = 0; k < 1761; k++)
    {
        Console.Write(k % 80 != 0 ? b[k] : (char)10);
        A += (float)0.00004;
        B += (float)0.00002;
    }
}