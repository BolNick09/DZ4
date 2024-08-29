using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class GeometryShapes
    {
        private char symb;
        public GeometryShapes(char symb)
        {
            this.symb = symb;
        }
        public char Symb
        {
            get { return this.symb; }
        }
    }

    public class Rectangle : GeometryShapes
    {
        private int width;
        private int height;
        public Rectangle(char symb, int width, int height) : base (symb)
        {
            this.width = width;
            this.height = height;
        }

        public void draw()
        {
            
            for (int i = 0; i < width; i++)
            {
                Console.Write(this.Symb);
            }
            Console.WriteLine();

            // Боковые границы и внутреннее заполнение
            for (int i = 0; i < height - 2; i++)
            {
                Console.Write(this.Symb);
                for (int j = 0; j < width - 2; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(this.Symb);
            }

            // Верхняя и нижняя границы
            for (int i = 0; i < width; i++)
            {
                Console.Write(this.Symb);
            }
            Console.WriteLine();
        }
    }
    public class Square : Rectangle
    {
        public Square(char symb, int side) : base(symb, side, side) { }        
    }
    public class Triangle : GeometryShapes
    {
        private int height;
        public Triangle(char symb, int height) : base(symb)
        {
            this.height = height;
        }
        public void draw()
        {
            int spaces = height - 1;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < spaces; j++)                
                    Console.Write(" ");
                

                for (int j = 0; j < 2 * i + 1; j++)                
                    Console.Write(this.Symb);
                
                Console.WriteLine();
                spaces--;
            }
        }
    }

}
