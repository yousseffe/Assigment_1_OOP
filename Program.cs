namespace Assigment_1_OOP
{
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    [Flags]
    enum Permissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-Enum for WeekDays and Printing Days of the Week
            /*foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }*/
            #endregion

            #region 2-Struct for Person and Displaying Details
            /*Person[] persons = new Person[3];
            persons[0] = new Person("Alice", 25);
            persons[1] = new Person("Bob", 30);
            persons[2] = new Person("Charlie", 28);

            foreach (Person person in persons)
            {
                Console.WriteLine(person);
            }*/
            #endregion

            #region 3-Enum for Season and Displaying Month Range
            /*Console.Write("Enter season name: ");
            string input = Console.ReadLine();
            Season season;

            if (Enum.TryParse(input, true, out season))
            {
                switch (season)
                {
                    case Season.Spring:
                        Console.WriteLine("March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("December to February");
                        break;
                    default:
                        Console.WriteLine("Invalid season");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid season");
            }*/
            #endregion

            #region 4-Enum for Permissions and Managing Permissions
            /*Permissions userPermissions = Permissions.Read | Permissions.Write;

            Console.WriteLine($"Current permissions: {userPermissions}");

            userPermissions |= Permissions.Execute;
            Console.WriteLine($"Permissions after adding Execute: {userPermissions}");

            userPermissions &= ~Permissions.Write;
            Console.WriteLine($"Permissions after removing Write: {userPermissions}");

            bool hasDelete = (userPermissions & Permissions.Delete) == Permissions.Delete;
            Console.WriteLine($"Has Delete permission: {hasDelete}");*/
            #endregion

            #region 5-Enum for Colors and Checking Primary Colors
            /*Console.Write("Enter color name: ");
                string input = Console.ReadLine();
                Colors color;

                if (Enum.TryParse(input, true, out color))
                {
                    Console.WriteLine($"{color} is a primary color.");
                }
                else
                {
                    Console.WriteLine($"{input} is not a primary color.");
                }*/
            #endregion

        }
    }
}
