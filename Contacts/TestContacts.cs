using System;

//Creating contact application

public class TestContacts
{
    public static void Main(String[] args)
    {
        string[] names = new string[10];
        int index;
        int count = 0;
        names[count++] = "John";
        names[count++] = "Jane";
        names[count++] = "Todd";

        string cmd = " ";
        while (cmd != "quit")
        {
            InputWrapper iw = new InputWrapper();
            Console.WriteLine("Enter command, quit to exit.");
            cmd = iw.getString("> ");
            Console.WriteLine("the command {0} was entered", cmd);

            switch (cmd)
            {
                case "add":
                    //use getString method of the InputWrapper class to set user input to the name variable.
                    string name = iw.getString("names: ");
                    //place the value stored in the name variable in the names array
                    names[count++] = name;
                    Console.WriteLine(name);
                    break;
                case "forward":
                    //loop through the names array and print out it's values.
                    for (int i = 0; i < names.Length; i++)
                        Console.WriteLine(names[i]);
                    break;
                case "backward":
                    //loop through the array in reverse
                    for (int i = 9; i >= 0; i--)
                        Console.WriteLine(names[i]);
                    // <---------------- Array method works also----------------->
                    //Array.Reverse(names);
                    //Console.WriteLine("Backward");
                    //PrintIndexAndValues(names);
                    break;
                case "find":
                    //string target = iw.getString("Enter name:  ");
                    //bool found = false;
                    //int j = 0;
                    //while (!found && j < names.Length)
                    //{
                    //    if (target == names[j])
                    //    {
                    //        found = true;
                    //        Console.WriteLine("{0} located at index {1}.", target, j);
                    //        break;
                    //    }
                    //    else
                    //    {
                    //        j++;
                    //       continue;
                    //    }
                    //    Console.WriteLine("{0} not in array.", target);
                    //}
                    string target = iw.getString("Enter search name:  "); 
                    index = Search(names, count, target);
                    if (index != -1)
                    {
                        Console.WriteLine("{0} was located at index {1}.", target, index);
                    }
                    else
                    {
                        Console.WriteLine("{0} was not located in the array.", target);
                    }
                    break;
                case "remove":
                    target = iw.getString("Enter name:  ");
                    index = Search(names, count, target);
                    if (index != -1)
                    {
                        Console.WriteLine("{0} was removed the array.", target);
                        names[index] = " ";
                    }
                    else
                    {
                        Console.WriteLine("{0} was not located in the array.", target);
                    }
                    break;
                default:
                    Console.WriteLine("Available commands include: forward, backward, add, find, remove");
                    break;
            }
        }
    }

    public static int Search (string[] names, int count, string target)
    {
        int j = 0;
        bool found = false;
        while (!found && j < names.Length)
        {
            if (target == names[j])
            {
                found = true;
            }
            else
            {
                j++;
            }
        }
        if (found)
        {
            return j;
        }
        else
        {
            return -1;
        }
    }

    public static void PrintIndexAndValues(Array names)
    {
        for (int i = names.GetLowerBound(0); i <= names.GetUpperBound(0); i++)
            Console.WriteLine("{1}", i, names.GetValue(i));
    }

}