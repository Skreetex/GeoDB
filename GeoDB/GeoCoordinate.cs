using System;
using System.Collections.Generic;
using System.Text;

namespace GeoDB
{
    class GeoCoordinate : Vector2D
    {
        public GeoCoordinate(float geo_x, float geo_y) : base(geo_x, geo_y)
        {

        }

        public bool Equals(GeoCoordinate coordinate)
        {
            if (coordinate.x == this.x && coordinate.y == this.y)
                return true;
            else
                return false;
        }

        public bool IsNear(GeoCoordinate coordinate, double distance)
        {
            if (Math.Abs(coordinate.x - this.x) < distance && Math.Abs(coordinate.y - this.y) < distance)
                return true;
            else
                return false;
        }

        public override void PrintCoordinates()
        {
            Console.WriteLine("Ion: " + x.ToString() + " lat: " + y.ToString());
        }
    }
}
