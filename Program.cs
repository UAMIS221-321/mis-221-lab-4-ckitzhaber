internal class Program{

    static void mainMenu(){
        Console.Clear();
        Console.WriteLine("\nWelcome!");
        Console.WriteLine("Enter 1 to display full triangle");
        Console.WriteLine("Enter 2 to display partial triangle");
        Console.WriteLine("Enter 3 to exit\n");
    }

    static void displayTriangle(bool isComplete){
        if(isComplete){fullTriangle();}
        else{partialTriangle();}
    }


    static void fullTriangle(){
        int rand = randomInt(3, 10);
        for(int i = 1; i <= rand; i++){
            for(int j = 1; j <= i; j++){
                Console.Write("O ");
            }
            Console.Write("\n");
        }
    }

    static void partialTriangle(){
        int randSize = randomInt(3,10);
        for(int i = 1; i <= randSize; i++){
            int randHole = randomInt(0,10);
            for(int j = 1; j <= i; j++){
                if(j != randHole){Console.Write("O ");}
                else{Console.Write("  ");} //this line contains a en quad space, matches O width
            }
            Console.Write("\n");
        }
    }

    static int randomInt(int min, int max){
        Random rnd = new Random();
        return rnd.Next(min, max);
    }

    static void Main(string[] args){
        while(true){
            mainMenu();
            string userInput = Console.ReadLine();
            Console.WriteLine("\n");
            if(userInput == "1"){displayTriangle(true);}
            else if(userInput == "2"){displayTriangle(false);}
            else if(userInput == "3"){
                Console.WriteLine("Have a Nice Day!");
                break;
            }
            else{
                Console.WriteLine("Invalid Input");
            }
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
    }
}