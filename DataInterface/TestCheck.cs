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

//Skapa en klass f�r att r�tta prov. Klassen ska ha en metod som tar t.ex. ett elevid och ett provid.
//Metoden ska anv�nda interface f�r att l�sa upp den elevens svar p� det angivna provet,
//och ett annat interface f�r att l�sa upp r�tt svar p� det provet.

//Metoden ska sen loopa igenom elevens svar och j�mf�ra med r�tt svar.
//Till sist ska en instans av provresultat skapas med elevens po�ng (andel r�tt svar i %) skapas,
//och skickas till DataAccess-lagret f�r att sparas.