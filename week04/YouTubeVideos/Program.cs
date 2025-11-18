using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine();

        // Create Comments
        Comment comment1 = new Comment("Juan Perez", "Vel illum qui consequatur, vel illum qui dolorem eum fugiat.");
        Comment comment2 = new Comment("Lucía Gómez", "Consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");
        Comment comment3 = new Comment("Carlos Méndez", "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.");
        Comment comment4 = new Comment("Ana Torres", "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.");
        Comment comment5 = new Comment("Valentina Ruiz", "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");
        Comment comment6 = new Comment("Martín López", "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium.");
        Comment comment7 = new Comment("Sofía Herrera", "Totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.");
        Comment comment8 = new Comment("Diego Fernández", "Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit.");
        Comment comment9 = new Comment("Camila Díaz", "Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit.");
        Comment comment10 = new Comment("Tomás Castro", "Sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem.");
        Comment comment11 = new Comment("Julieta Ríos", "Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam.");
        Comment comment12 = new Comment("Nicolás Vega", "Nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit.");
        Comment comment13 = new Comment("Agustina Molina", "Qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat.");
        Comment comment14 = new Comment("Mateo Navarro", "Quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur?");
        Comment comment15 = new Comment("Isabella Romero", "Vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?");
        Comment comment16 = new Comment("Facundo Herrera", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore.");

        // Create Videos
        Video video1 = new Video("The Art of Focus", "Laura Méndez", 320);
        Video video2 = new Video("C# Fundamentals: Classes and Objects", "CodeAcademy", 540);
        Video video3 = new Video("Exploring Patagonia in 4K", "TravelWithLeo", 275);
        Video video4 = new Video("How to Make Empanadas", "Cocina Criolla", 180);

        // Populate the videos with comments
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video2.AddComment(comment7);
        video2.AddComment(comment8);


        video3.AddComment(comment9);
        video3.AddComment(comment10);
        video3.AddComment(comment11);
        video3.AddComment(comment12);

        video4.AddComment(comment13);
        video4.AddComment(comment14);
        video4.AddComment(comment15);
        video4.AddComment(comment16);

        // add videos to a list
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // loop through each video in the list and display results
        foreach (var v in videos)
        {
            Console.WriteLine(v.GetDisplayText());
            Console.WriteLine(v.GetComments());
        }

    }
}