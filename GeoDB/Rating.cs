using System;
using System.Collections.Generic;
using System.Text;

namespace GeoDB
{
    class Rating
    {
        public UInt16 Stars { get; set; }

        public Rating(UInt16 rating_stars)
        {
            this.Stars = rating_stars;
        }
    }
}
