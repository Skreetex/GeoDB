using System;
using System.Collections.Generic;
using System.Text;

namespace GeoDB
{
    class Comment
    {
        public string Name { get; set; }
        public string Text { get; set; }

        public Comment(string comment_name, string comment_text)
        {
            this.Name = comment_name;
            this.Text = comment_text;
        }
    }
}
