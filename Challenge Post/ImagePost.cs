using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Post
{
    class ImagePost : Post
    {
        protected String imageURL;

        public String GetImageURL()
        {
            return imageURL;
        }
        public ImagePost()
        {

        }
        public ImagePost(string user, string title, bool isPublic, String imageURL) : base(user, title, isPublic)
        {
            this.isPublic = isPublic;
            this.imageURL = imageURL;
        }
        public override void Print()
        {
            Console.WriteLine($"{postID} - {user} - {title} - {isPublic} - {imageURL}");
        }

    }
}
