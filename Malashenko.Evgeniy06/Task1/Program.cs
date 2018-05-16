using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryPaint;
using ClassLibrary;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomSize = new Random();
            Random randomGenerator = new Random();
            Figure[] fig = new Figure[10];
            for(int i=0; i < fig.Length; i++)
            {
                switch (randomGenerator.Next(4))
                {
                    case 0:
                        fig[i] = new Rectangle(randomSize.Next(10,50), randomSize.Next(10,50));break;
                    case 1:
                        fig[i] = new Line(randomSize.Next(10,20), randomSize.Next(10,20));break;
                    case 2:
                        fig[i] = new Round(randomSize.Next(30), randomSize.Next(10,30),
                            randomSize.Next(20));break;
                    case 3:
                        fig[i] = new Ring(randomSize.Next(10, 30), randomSize.Next(10, 30), randomSize.Next(1, 50), randomSize.Next(1, 30));break;
                }
                
            }
            Canvas consoleCanvas = new Canvas();
            for (int i = 0; i < fig.Length; i++)
            {
                Console.WriteLine( fig[i].Name);
                fig[i].Draw(consoleCanvas);
            }
            Console.ReadKey();

        }
    }
}
