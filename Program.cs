using System;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;

class Program {
    static private int difficultNumber;
    static private char letter;
    static private string tracejado = "";
    static private string[] easyWords = ["MACACO", "CELULAR", "BRASILEIRO", "CADEIRA"];
    static private string[] mediumWords = ["CABECEIO", "CAPIVARA", "CHINES", "ZEBRA"];
    static private string[] hardWords = ["HULK", "TCHAU", "MONOTEISMO", "HEDIONDO", "HELIPONTO"];

    static void Main() {        

        Console.WriteLine("Choose the difficult level:");
        Console.WriteLine("1 - Easy");
        Console.WriteLine("2 - Medium");
        Console.WriteLine("3 - Hard");

        if (Console.ReadLine != null)
            difficultNumber = int.Parse(Console.ReadLine());

        Console.WriteLine(DrawLayout(GetWord(difficultNumber))+"\n\n");

        if(IsNullOrWhiteSpace(Console.ReadLine())) {
            Console.WriteLine("Please, write some character!");    
        }

        while (Console.ReadLine().Length != 1) {
            Console.WriteLine("Please, one letter by time!");
        }

        letter = char.Parse(Console.ReadLine());

        //Todo: Implementar verificação se a letra está contida na string

        //Todo: (Caso esteja contida) Implementar verificação do local da letra na string

        //Todo: (Caso não esteja contida) Implementar "perca de vida" e inserir loop para número "x" de tentativas

    }

    static string DrawLayout(string pWord) {
        for (int i=0; i != pWord.Length; i++) {
            tracejado += "_ ";
        }

        return tracejado;
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

    static Boolean IsNullOrWhiteSpace(string pInput) {
        if(pInput == null || pInput == "") {
            return true;
        } else {
            return false;
        }
    }

}