
using System;

namespace GeoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Place Weiz = new Place(100, 200, "Weiz");

            Weiz.AddComment("user1", "Weiz ist eine kleine Stadt!");
            Weiz.AddRating(1);

        }
    }
}
