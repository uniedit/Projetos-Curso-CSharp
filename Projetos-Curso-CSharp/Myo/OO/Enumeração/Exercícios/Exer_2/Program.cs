using System;
using Projetos_Curso_CSharp.Myo.Enumeração.Entities;

internal class ProgramExer_2 {
    public void Method() {

        DateTime moment;
        string title, content;
        int likes;
        Comment comment = new Comment();

        moment = DateTime.Parse("21/06/2018 13:05:44");
        title = "Traveling to New Zealand";
        content = "I'm going to visit this wonderful country!";
        likes = 12;

        Post p1 = new Post(moment, title, content, likes);

        comment = new Comment("Have a nice trip");
        p1.AddComments(comment);
        comment = new Comment("Wow that's awesome!");
        p1.AddComments(comment);

        ///

        moment = DateTime.Parse("28/07/2018 23:14:19");
        title = "Good night guys";
        content = "See you tomorrow";
        likes = 5;

        Post p2 = new Post(moment, title, content, likes);

        comment = new Comment("Good night");
        p2.AddComments(comment);
        comment = new Comment("May the Force be with you");
        p2.AddComments(comment);

        Console.WriteLine(p1);
        Console.WriteLine(p2);

        /* Solução Professor
        Comment c1 = new Comment("Have a nice trip!");
        Comment c2 = new Comment("Wow that's awesome!");
        Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12);
        p1.AddComment(c1);
        p1.AddComment(c2);

        Comment c3 = new Comment("Good night");
        Comment c4 = new Comment("May the Force be with you");
        Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5);
        p2.AddComment(c3);
        p2.AddComment(c4);

        Console.WriteLine(p1);
        Console.WriteLine(p2);
        */

    }
}
