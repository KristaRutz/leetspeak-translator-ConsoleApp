using System;

namespace Leetspeak
{

  public class Program
  {
    public static void Main()
    {
      string input = Console.ReadLine();
      LeetspeakTranslator myTranslate = new LeetspeakTranslator();
      Console.WriteLine(myTranslate.Translate(input));
      Main();
    }
  }
  public class LeetspeakTranslator
  {
    public string Translate(string input)
    {
      char[] array = input.ToCharArray();
      for (int i = 0; i < array.Length; i++)
      {

        //variable naming
        // char current = array[i];
        // if (i != 0)
        // {
        //   char previous = array[i-1];
        // }
        // if(i < array.Length-1)
        // {
        //   char next = array[i+1];
        // }
 
        // character replacement
        if (array[i] == 'e' || array[i] == 'E')
        {
          array[i] = '3';
        }
        else if (array[i] == 'o' || array[i] == 'O')
        {
          array[i] = '0';
        }
        else if (array[i] == 'I')
        {
          array[i] = '1';
        }
        else if (array[i] == 't' || array[i] == 'T')
        {
          array[i] = '7';
        }
        else if (array[i] == 's' && ((i != 0 && array[i-1] != ' ') && (i < array.Length-1 && array[i+1] != 's' && array[i-1] != 's') || (i == array.Length - 1 && array[i-1] != 's')))
        {
          array[i] = 'z';
        }
        else if (i != 0 && array[i] == 'S' && array[i-1] != ' ')
        {
          array[i] = 'Z';
        }
      }
      string output = string.Join("", array);
      return output;
    }
  }
}