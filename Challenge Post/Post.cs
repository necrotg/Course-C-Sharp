using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Post
{
    class Post
    {
        private static int CurrentPostID;
        protected int postID;
        protected String user;
        protected String title;
        protected bool isPublic;

        public int GetPostID()
        {
            return this.postID;
        }
        public String GetUser()
        {
            return user;
        }
        public String GetTitle()
        {
            return title;
        }
        public bool GetIsPublic()
        {
            return isPublic;
        }


        public Post()
        {
            this.postID = 0;
            this.user = "Felipe Milani";
            this.title = "Arigathank you";
            this.isPublic = true;

        }

        public Post(string user, string title, bool isPublic)
        {
            this.postID = GetNextID();
            this.user = user;
            this.title = title;
            this.isPublic = isPublic;
        }

        public virtual void Print()
        {
            Console.WriteLine($"{postID} - {user} - {title} - {isPublic}");
        }
        public int GetNextID()
        {
           return CurrentPostID++;
        } 

    }
}
