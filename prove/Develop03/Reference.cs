public class ScripReference{
    public string _book;   
    public int _verse;
    public int _chapter;

    public void DisplayVerse(string book, int verse, int chapter){
        _book = book;
        _verse = verse;
        _chapter = chapter;
        Console.WriteLine($"{book} {chapter}:{verse}");
    }
}