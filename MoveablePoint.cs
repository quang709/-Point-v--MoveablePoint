using System;
using System.Collections.Generic;
using System.Text;

namespace Point_và_MoveablePoint
{
    class MovablePoint : Point
    {
        public float xSpeed = 0.0f;
        public float ySpeed = 0.0f;
        public float z = 0.0f;
        public MovablePoint()
        {

        }

        public MovablePoint(float x, float y, float xSpeed, float ySpeed) : base(x, y)
        {
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
        }

        public float GetXSpeed()
        {
            return xSpeed;
        }

        public void SetXSpeed(float xSpeed)
        {
            this.xSpeed = xSpeed;
        }
        public float GetYSpeed()
        {
            return ySpeed;
        }

        public void SetYSpeed(float ySpeed)
        {
            this.ySpeed = ySpeed;
        }

        public float[] GetSpeed()
        {
            return new float[3] { base.GetX(), base.GetY(), z };
        }
        public MovablePoint Move()
        {
            x += xSpeed;
            y += ySpeed;
            return this;
        }
        public override string ToString()
        {
            return "xSpeed = " + GetXSpeed() + "\nySpeed = " + GetYSpeed() + "\nx, y, z = " + string.Join(", ", GetSpeed());
        }
    }
}
