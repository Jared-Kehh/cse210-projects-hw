public class Video{
    string _title;
    string _author;
    int _length;
    List<Comments> comments = new List<Comments>();
    public Video(string title, string author, int length){
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddingComments(Comments comment){
        comments.Add(comment);
    }

    public void NumberComments(){
        Console.WriteLine($"Amount of Comments:{comments.Count}");
    }

    public void DisplayVideo(){
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nSeconds: {_length}");
    }
    public void DisplayComments(){
        Console.WriteLine("Comments:");
        foreach (Comments commentss in comments){
            Console.WriteLine($"{commentss._name}: {commentss._comment}");
        }
    }


}