
public class program
{
    public static void Main()

    {
        //calcuate the vowels from the string

        Console.WriteLine("please enter any string");
        var str = Console.ReadLine(); //welcome

        int vowelscounter = 0;
        foreach (var item in str) 
        {
           if (item == 'a'|| item == 'e'|| item == 'i'|| item == 'o'|| item == 'u'||
               item == 'a'||  item == 'e' || item == 'i' || item == 'o'|| item == 'u')  
                
           {
               vowelscounter++;
           }
        }
        Console.WriteLine("number of vowels in the string=" + vowelscounter);



    }
}

    