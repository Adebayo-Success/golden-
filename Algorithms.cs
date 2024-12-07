//  namespace Algorithms;
 public class Algorithms
 {
    public static List<int>  GetVowelPosition(string s)
    {
        char[] vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];
        List<int> positionOfVowels = new List<int>();

        for(int i = 0; i < s.Length; i++)
        {
            for(int j = 0; j < vowels.Length; j++ )
            {
                if (s[i]== vowels[j])
                {
                    positionOfVowels.Add(i);
                }
            }
        }

        return positionOfVowels;
    }

    //Question 2
    public static string ShiftLetters(string inputString)
    {
        char[] lettersChars = new char[inputString.Length];
        for (int b = 0; b < inputString.Length; b++)
        {
            char myCharacters = inputString[b];
            if (myCharacters >= 'a' && myCharacters <= 'z')
            {
                lettersChars[b] = myCharacters == 'z' ? 'a' : (char)(myCharacters + 1);
            }
            else if (myCharacters >= 'A' && myCharacters <= 'Z')
            {
                lettersChars[b] = myCharacters == 'Z' ? 'A' : (char)(myCharacters + 1);
            }
            else
            {
                lettersChars[b] = myCharacters;
            }
        }
        return new string(lettersChars);
    }

    //Question 3
    public static string TransformCase(string inputString)
    {

        char[] lettersChars = new char[inputString.Length];
        for (int b = 0; b < inputString.Length; b++)
        {
            char myCharacters = inputString[b];
            if (myCharacters >= 'a' && myCharacters <= 'z')
            {
                lettersChars[b] = (myCharacters == 'z') ? 'a' : (char)(myCharacters - 32);
            }
            else if (myCharacters >= 'A' && myCharacters <= 'Z')
            {
                lettersChars[b] = (myCharacters == 'Z') ? 'A' : (char)(myCharacters + 32);
            }
            else
            {
                lettersChars[b] = myCharacters;
            }
        }
        return new string(lettersChars);
    }

    //Question 5
    public static string SwapPairs(string s)
    {
        char[] Chars = new char[s.Length];
        for (int b = 0; b < s.Length; b++)
        {
           if (b % 2 == 0)
           {
                if(b + 1 >= s.Length)
                {
                    Chars[b] = s[b];
                }
                else
                {
                    Chars[b] = s[b + 1];
                }
           }
           else
           {
                Chars[b] = s[b - 1];
           }
        }

        return new string (Chars);
    }


    //Question 4
    public static string ReplaceCharacters(string inputString, char c1, char c2)
    {
        List<char> result = new List<char>() ;
        foreach(char load in inputString)
        {
           if(load == c1)
           {
                result.Add(c2);
           }
           else 
           {
                result.Add(load);
           }
        }
         return new string (result.ToArray());
    }

}



