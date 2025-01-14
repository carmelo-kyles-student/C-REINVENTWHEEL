using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Authentication;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("dsa");
        string name = "cAt";
        char ch = 'z';
        char[] chars = toCharArray(name);
        // Console.WriteLine(charToString(chars));
        // printArray(toAsciiArray(chars));
        // Console.WriteLine(toUpper(toAsciiArray(chars)));
        // Console.WriteLine(toLower(toAsciiArray(chars)));
        Console.WriteLine(CountVowels(chars));
        Console.WriteLine(CountConsonants(chars));
        Console.WriteLine(HasLetter(ch, name));

    }
    public static void printArray(int[] array)
    {
        for (int i = 0; i < size(array); i++)
        {
            Console.Write(array[i]);
        }
    }
    public static int[] toAsciiArray(char[] chars)
    {
        int[] ints = new int[size(chars)];
        for (int i = 0; i < ints.Length; i++)
        {
            ints[i] = chars[i];
        }
        return ints;
    }

    public static string charToString(char[] chars)
    {
        string str = "";
        for (int i = 0; i < chars.Length; i++)
        {
            str += chars[i];
        }
        return str;
    }
    public static char[] toCharArray(string str)
    {
        char[] arr = new char[size(str)];
        for (int i = 0; i < str.Length; i++)
        {
            arr[i] = str[i];
        }
        return arr;

    }
    public static char[] toCharArray(int[] array)
    {
        char[] chars = new char[size(array)];
        for (int i = 0; i < size(chars); i++)
        {
            chars[i] = (char)array[i];
        }
        return chars;
    }
    public static int size(string str)
    {
        int count = 0;
        foreach (char c in str)
        {
            count++;
        }
        return count;
    }
    public static int size(char[] c)
    {

        int count = 0;
        foreach (char rc in c)
        {
            count++;
        }
        return count;

    }
    public static int size(int[] c)
    {

        int count = 0;
        foreach (int rc in c)
        {
            count++;
        }
        return count;

    }

    public static string toUpper(int[] asciiArray)
    {
        string str = "";
        for (int i = 0; i < size(asciiArray); i++)
        {
            if (asciiArray[i] >= 97 && asciiArray[i] <= 122)
            {
                // Console.WriteLine("before change" + asciiArray[i]);
                asciiArray[i] = asciiArray[i] - 32;
                // Console.WriteLine("after change" + asciiArray[i]);

                str += asciiArray[i];
            }
            else
            {
                str += asciiArray[i];
            }
        }
        return charToString(toCharArray(asciiArray));
    }
    public static string toLower(int[] asciiArray)
    {
        string str = "";
        for (int i = 0; i < size(asciiArray); i++)
        {
            if (asciiArray[i] >= 65 && asciiArray[i] <= 90)
            {
                // Console.WriteLine("before change" + asciiArray[i]);
                asciiArray[i] = asciiArray[i] + 32;
                // Console.WriteLine("after change" + asciiArray[i]);

                str += asciiArray[i];
            }
            else
            {
                str += asciiArray[i];
            }
        }
        return charToString(toCharArray(asciiArray));
    }
    public static string reverse(char[] chars)
    {
        string str = "";
        for (int i = size(chars); i > 0; i--)
        {
            str += chars[i - 1];
        }
        return str;
    }
    public static int CountVowels(char[] chars)
    {
        int count = 0;
        for (int i = 0; i < size(chars); i++)
        {
            char ch = chars[i];
            switch (ch)
            {
                case 'a':
                    count++;
                    break;
                case 'e':
                    count++;
                    break;
                case 'i':
                    count++;
                    break;
                case 'o':
                    count++;
                    break;
                case 'u':
                    count++;
                    break;
                case 'A':
                    count++;
                    break;
                case 'E':
                    count++;
                    break;
                case 'I':
                    count++;
                    break;
                case 'O':
                    count++;
                    break;
                case 'U':
                    count++;
                    break;
                default:
                    break;



            }
        }
        return count;
    }
    public static int CountConsonants(char[] chars)
    {
        int count = 0;
        for (int i = 0; i < size(chars); i++)
        {
            char ch = chars[i];
            switch (ch)
            {
                case 'a':
                    break;
                case 'e':
                    break;
                case 'i':
                    break;
                case 'o':
                    break;
                case 'u':
                    break;
                case 'A':
                    break;
                case 'E':
                    break;
                case 'I':
                    break;
                case 'O':
                    break;
                case 'U':
                    break;
                default:
                    count++;
                    break;



            }
        }
        return count;
    }
    public static bool HasLetter(char ch, string key)
    {
        bool isFound = false;
        char[] charry = toCharArray(key);
        for (int i = 0; i<size(charry); i++){
            if (charry[i]== ch){
                isFound = true;
                break;
            }
        }
        return isFound;
    }
}

 