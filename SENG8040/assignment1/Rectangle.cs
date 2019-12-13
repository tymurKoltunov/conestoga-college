using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1_part1
{
    public class Rectangle
    {
        private int length;
        private int width;

        public Rectangle()
        {
            length = 1;
            width = 1;
        }
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public int GetLength()
        {
            return length;
        }
        public int GetWidth()
        {
            return width;
        }
        public void SetLength(int length)
        {
            this.length = length;
        }
        public void SetWidth(int width)
        {
            this.width = width;
        }
        public int GetPerimiter()
        {
            return length * 2 + width * 2;
        }
        public int GetArea()
        {
            return length * width;
        }
    }
}
