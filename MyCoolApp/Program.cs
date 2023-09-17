
using MyCoolApp;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello! This is a program for creating your own unique character.");
        Console.WriteLine("Press any key to start...");
        Console.ReadKey(true);

        Console.WriteLine("Great! Firstly, enter age of your character:");
        var age = ValidateAge(Console.ReadLine());

        var user1 = new User(age);
        Console.WriteLine("Now, lets define gender of your character. Enter \"Male\" or \"Female\":");

        user1.Gender = Console.ReadLine() switch
        {
            "Male" => Gender.Male,
            "Female" => Gender.Female,
            _ => Gender.Email
        };

        Console.WriteLine("Please, enter user name:\t");
        user1.FirstName = ValidateName(Console.ReadLine() ?? "_", "first name");
        Console.WriteLine("Please, enter user surname:\t");
        user1.LastName = ValidateName(Console.ReadLine() ?? "_", "last name");

        Console.WriteLine(user1);
    }

    private static string ValidateName(string value, string fieldName)
    {
        if (!Regex.IsMatch(value, @"^[a-z _'-]+$", RegexOptions.IgnoreCase))
        {
            Console.WriteLine($"Invalid {fieldName}! Enter value again:");
            return ValidateName(Console.ReadLine() ?? "_", fieldName);
        }

        return value;
    }

    private static int ValidateAge(string value)
    {
        if (!int.TryParse(value, out int age) || age <= 0)
        {
            Console.WriteLine($"Invalid Age! Enter value again:");
            return ValidateAge(Console.ReadLine());
        }

        return age;
    }
}



/* Regex cheat sheet
 * ^ - Starts with
 * $ - Ends with
 * [] - Range
 * () - Group
 * . - Single character once
 * + - one or more characters in a row
 * ? - optional preceding character match
 * \ - escape character
 * \n - New line
 * \d - Digit
 * \D - Non-digit
 * \s - White space
 * \S - non-white space
 * \w - alphanumeric/underscore character (word chars)
 * \W - non-word characters
 * {x,y} - Repeat low (x) to high (y) (no "y" means at least x, no ",y" means that many)
 * (x|y) - Alternative - x or y
 * 
 * [^x] - Anything but x (where x is whatever character you want)
 */
