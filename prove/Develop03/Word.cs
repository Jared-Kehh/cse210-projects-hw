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
        letters.AddRange(randNumber);
        int totalNum = randNumber.Count();
        while (plusNum != totalNum){
            letters[plusNum] = '_';
            plusNum = plusNum+1;
        }
        return randNumber;
    }

    public void ShowWord(){
        string showWord = "";
        foreach (char letRep in letters){
            showWord = showWord + letRep;
        }
        Console.WriteLine(showWord);
        inwords.Remove(randNumber);
        inwords.Add(showWord);

        foreach (string words in inwords){
            Console.WriteLine(words);
        }



    }
}