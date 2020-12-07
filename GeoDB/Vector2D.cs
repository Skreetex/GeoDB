using System;
using System.Collections.Generic;
using System.Text;

namespace GeoDB
{
    class Vector2D
    {
        public float x { get; set; }
        public float y { get; set; }

        public Vector2D(float vector_x, float vector_y)
        {
            this.x = vector_x;
            this.y = vector_y;
        }

        public virtual void PrintCoordinates()
        {
            Console.WriteLine("(" + x.ToString() + ", " + y.ToString() + ")");
        }
    }
}
