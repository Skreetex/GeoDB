using System;
using System.Collections.Generic;
using System.Text;

namespace GeoDB
{
    class Place
    {
        public string Name { get; set; }
        GeoCoordinate Coordinate;
        List<Comment> Comments;
        List<Rating> Ratings;

        public Place(float place_x, float place_y, string place_name)
        {
            Coordinate = new GeoCoordinate(place_x, place_y);
            Comments = new List<Comment>();
            Ratings = new List<Rating>();
            this.Name = place_name;
        }

        public void PrintPlace()
        {
            Console.WriteLine(this.Name);
            Coordinate.PrintCoordinates();
        }

        public void AddComment(string comment_name, string comment_text)
        {
            Comments.Add(new Comment(comment_name, comment_text));
        }

        public void AddRating(UInt16 rating_stars)
        {
            Ratings.Add(new Rating(rating_stars));
        }
    }
}
