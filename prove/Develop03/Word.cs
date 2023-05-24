using System.IO;
public class Word{
    string _word="";
    Boolean shown = true;
    List<string> inwords = new List<string>();
    public Word(string words){
        _word = words;
    }
    public void Display(){
        string fileName = "scripture.txt";
        string [] lines = System.IO.File.ReadAllLines(fileName);

        foreach(string line in lines){
            Console.WriteLine(line);
            string[] wordParts = line.Split("");
            foreach(string part in wordParts)
            {
                inwords.Add(part);
            }
        }

        // Console.WriteLine(_word);
        // Console.Write("Press Enter to Clear the words");
        // string respo = Console.ReadLine() ?? String.Empty;
        // while (shown != false){
        //     HideWord();
        //     break;
        // }

    }

    public void HideWord(){
        Console.Clear();
        Console.WriteLine("");

    }

    public void ShowWord(){

    }
}