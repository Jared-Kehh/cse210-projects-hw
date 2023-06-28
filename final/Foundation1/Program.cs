using System;

class Program
{
    static void Main(string[] args)
    {
        Video youtube = new Video("MrBeast died","MrBeast",120);
        Video youtube1 = new Video("One penny to ??", "Ryan Trahan",200);
        Video youtube2 = new Video("BRUHHH","Jeremiah Franco",500);
        Comments ytcomments = new Comments("Jeremiah","sorry bro, RIP");
        Comments ytcomments1 = new Comments("LoserFace33","YOOO!");
        Comments ytcomments2 = new Comments("iphoneBros","WHYY BROOO");
        Comments ytcomments3 = new Comments("Promabler", "I like how everyone is like it's cool to see Matt eating normally when he ate 11 fried chicken sandwiches in one sitting, lmao");
        Comments ytcomments4 = new Comments("BloxyLmao","Only Matt can do a chicken sandwich tier list and finish all the food by himself");
        Comments ytcomments5 = new Comments("JJ_samurai","This was an nice video to watch today and this man is such an legend :]");
        Comments ytcomments6 = new Comments("Aceaidthe1st","Always makes me hungry. Keep up the good work!!!");

        youtube.AddingComments(ytcomments);
        youtube.AddingComments(ytcomments1);
        youtube.AddingComments(ytcomments2);
        youtube.DisplayVideo();
        youtube.NumberComments();
        youtube.DisplayComments();
        Console.WriteLine("===============================================");
        youtube1.AddingComments(ytcomments4);
        youtube1.AddingComments(ytcomments5);
        youtube1.AddingComments(ytcomments6);
        youtube1.DisplayVideo();
        youtube1.NumberComments();
        youtube1.DisplayComments();
        Console.WriteLine("===============================================");
        youtube2.DisplayVideo();

    }
}