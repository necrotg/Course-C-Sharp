using System;
using System.Threading;

namespace Challenge_Post
{
    class VideoPost:Post
    {
        protected String videoURL;
        protected Double length;
        protected int currentDuration;
        protected Timer timer1;

        public String GetVideoURL()
        {
            return videoURL;
        }
        public Double GetLength()
        {
            return length;
        }
        public VideoPost()
        {

        }

        public VideoPost(string user, string title, bool isPublic, String videoURL, Double length) : base(user, title, isPublic)
        {
            this.videoURL = videoURL;
            this.length = length;
        }

        public override void Print()
        {
            Console.WriteLine($"{postID} - {user} - {title} - {isPublic} - {videoURL} - {length} ");   
        }

        public void Play()
        {
            timer1 = new Timer(TimerCallback,null,0,1000);

            Console.WriteLine(timer1);
        }
        private void TimerCallback(Object o)
        {
            if(currentDuration < length)
            {
                currentDuration++;
                Console.WriteLine("Video at {0}", currentDuration);
                GC.Collect();
            }
            else { Stop(); }
        }
        public void Stop()
        {
            Console.WriteLine("Stopped at {0}", currentDuration);
            currentDuration = 0;
            timer1.Dispose();
        }

    }
}
