using System.Xml.XPath;

namespace c_sharp_extra;

class Program
{
    static void Main(string[] args)
    {
        //Oppgave 1
        int a = 20;
        int b = 12;

        Console.WriteLine(MyIntMethod(a, b));

        Console.WriteLine("\n");

        //Oppgave 2
        int[] myNumberArray = {1, 3, 8, 2};

        static int SumArray(int[] myNumberArray)
        {
            int n = 0; 
            for(int i = 0; i < myNumberArray.Count(); i++){
                n += myNumberArray[i];
            }
            return n;
        }

        var sum = SumArray(myNumberArray);
        Console.Write(sum);

        Console.WriteLine("\n");

        //Oppgave 2 med en annen metode jeg fant
        int[] myNumberArray2 = {3,6,7,8};

        static int SumArray1(int[] myNumberArray2)
        {
            int result = myNumberArray2.Sum();
            return result;
        }

        Console.WriteLine(SumArray1(myNumberArray2));

        Console.WriteLine("\n");

        //Oppgave 3
        Dictionary<string, int> myDictionary = new Dictionary<string, int>()
        {
            {"Jan", 30},
            {"Grete", 52},
            {"Geir", 63}
        };
        myDictionary.Add("Anna", 75);
        myDictionary.Add("Gustav", 81);
        foreach (var KeyValuePair in myDictionary)
        {
            Console.WriteLine($"Name: {KeyValuePair.Key}, Age: {KeyValuePair.Value}");
        }
    }

//Hører til oppgave 1
    static public int MyIntMethod (int a, int b)
    {
        int total;
        total = a + b;
        return total;
    }
}