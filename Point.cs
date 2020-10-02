using System;
using System.Collections.Generic;
using System.Text;

namespace Point_và_MoveablePoint
{
    class Point
    {
        public float x = 0.0f;
        public float y = 0.0f;
        public Point()
        {

        }
        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float GetX()
        {
            return x;
        }
        public void SetX(float x)
        {
            this.x = x;
        }
        public float GetY()
        {
            return y;
        }
        public void SetY(float y)
        {
            this.y = y;
        }
        public float[] GetXY()
        {
            return new float[2] { x, y };
        }
        public void SetXY(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return "x = " + GetX() + "\ny = " + GetY() + "\nx,y = " + string.Join(", ", GetXY());
        }
    }
}
