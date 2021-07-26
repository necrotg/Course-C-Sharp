using System;

namespace Challenge_Post
{
    class Program
    {
        static void Main(string[] args)
        {
            ImagePost img = new ImagePost("Felipeee", "foto do meu pe", false, "https://pack.com");
            img.Print();
            VideoPost vid = new VideoPost("Fefe", "video rebolando", false, "https://rebola.com", 2000000);
            vid.Print();
            ImagePost img2 = new ImagePost("Felipeee", "foto do meu pe", false, "https://pack.com");
            img2.Print();
            Console.WriteLine("Press 1 to start the video");
            String video = Console.ReadLine();

            if (video.Equals("1")){
                vid.Play();
                Console.WriteLine("Press 2 to start the video");
                if (Console.ReadLine().Equals("2")){
                    vid.Stop();
                }
                
            }

        }
    }
}
