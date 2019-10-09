using DataInterface;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    public class TestCheck
    {
        public TestScore TestChecker(int StudentID, int TestID)
        {

        }
    }
}

//Skapa en klass för att rätta prov. Klassen ska ha en metod som tar t.ex. ett elevid och ett provid.
//Metoden ska använda interface för att läsa upp den elevens svar på det angivna provet,
//och ett annat interface för att läsa upp rätt svar på det provet.

//Metoden ska sen loopa igenom elevens svar och jämföra med rätt svar.
//Till sist ska en instans av provresultat skapas med elevens poäng (andel rätt svar i %) skapas,
//och skickas till DataAccess-lagret för att sparas.