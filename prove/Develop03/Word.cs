using System.IO;
public class Word{
    string _word="";
    string randNumber = "";
    Random rnd = new Random();
    Boolean shown = true;
    List<string> inwords = new List<string>();
    List<char> letters = new List<char>();
    public void Display(){
        string fileName = "scripture.txt";
        string [] lines = System.IO.File.ReadAllLines(fileName);

        foreach(string line in lines){
            Console.WriteLine(line);
            string[] wordParts = line.Split(" ");
            foreach(string part in wordParts)
            {
                inwords.Add(part);
            }
        }

        Console.Write("Press Enter to Clear the words");
        string respo = Console.ReadLine() ?? String.Empty;
    }

    public string HideWord(){
        
        int plusNum = 0;
        int randomNumber = rnd.Next(0,inwords.Count);
        string randNumber = inwords[randomNumber];
        int numberOfletters = randNumber.Count();
        string letter = randNumber;
        letters.AddRange(letter);
        int totalNum = letter.Count();
        while (plusNum != totalNum){
            letters[plusNum] = '_';
            plusNum = plusNum+1;
        }
        foreach (char letRep in letters){
            Console.WriteLine(letRep);
        }
        return randNumber;

    }

    public void ShowWord(){

    }
}