using System;

class VowelsConsonants
{
    public static void Main()
    {
        string str = Console.ReadLine().ToLower();
        int vow = 0, cons = 0;
        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];
            if (ch >= 'a' && ch <= 'z')
            {
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    vow++;// count of vowel
                else
                    cons++; //consonants count
            }
        }

        Console.WriteLine("Vowels are " + vow);
        Console.WriteLine("Consonants are " + cons);
    }
}
