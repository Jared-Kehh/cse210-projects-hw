using System.IO;
using System.Text.RegularExpressions;
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
        var keepGoing = true;
        while(keepGoing){
            Console.Write("\nPress Enter to take the words out and type stop to end: ");
            string respo = Console.ReadLine() ?? String.Empty;
            if(respo == "stop"){
                keepGoing = false;
            }
            else{
                HideWord();
                ShowWord();
            }
                
        }
    }

    public void HideWord(){
    
        int plusNum = 0;
        int randomNumber = rnd.Next(0,inwords.Count);
        string randWord = inwords[randomNumber];
        letters.AddRange(randWord);
        int totalNum = randWord.Count();
        while (plusNum != totalNum){
            letters[plusNum] = '_';
            plusNum = plusNum+1;
        }

        string showWord = "";
        foreach (char letRep in letters){
            showWord = showWord + letRep;
        }

        inwords.Remove(randWord);
        inwords.Insert(randomNumber, showWord);
    }

    public void ShowWord(){
        foreach (string words in inwords){
            Console.Write($"{words} ");
        }
        letters.Clear();


    }
}