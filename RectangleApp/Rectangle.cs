using System;

namespace RectangleApp
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

        public int GetLength(int length)
        {
            this.length = length;
            return length;
        }


        public int SetLength(int length)
        {
            this.length = length;
            return this.length;
        }


        public int GetWidth(int width)
        {
            this.width = width;
            return width;
        }


        public int SetWidth(int width)
        {
            this.width = width;
            return this.width;
        }

        public int GetPerimeter()
        {
            int perimeter = 2 * (length + width);
            return perimeter;
        }

        public int GetArea()
        {
            int area = length * width;
            return area;
        }

    }
}
