using System;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;

class Program {
    static private string tracejado = "";
    static private string[] easyWords = ["MACACO", "CELULAR", "BRASILEIRO", "CADEIRA"];
    static private string[] mediumWords = ["CABECEIO", "CAPIVARA", "CHINES", "ZEBRA"];
    static private string[] hardWords = ["HULK", "TCHAU", "MONOTEISMO", "HEDIONDO", "HELIPONTO"];

    static void Main() {        

        Console.WriteLine("Choose the difficult level:");
        Console.WriteLine("1 - Easy");
        Console.WriteLine("2 - Medium");
        Console.WriteLine("3 - Hard");

        if (Console.ReadLine)
        int difficultNumber = int.Parse(Console.ReadLine());

        DrawLayout(GetWord(difficultNumber));      

    }

    static void DrawLayout(string pWord) {
        for (int i=0; i != pWord.Length; i++) {
            tracejado += "_";
        }
    }

    static string GetWord(int pIndex) {
        Random random = new Random();
        string ChoosedWord = "";

        switch (pIndex) {
            case 1: 
                ChoosedWord = easyWords[random.Next(0, easyWords.Length)];
                break;
            case 2: 
                ChoosedWord = mediumWords[random.Next(0, mediumWords.Length)];
                break;
            case 3:
                ChoosedWord = hardWords[random.Next(0, hardWords.Length)];
                break;
            default:
                Console.WriteLine("Nível inválido!");
                break;
        }       

        return ChoosedWord;
    }

}