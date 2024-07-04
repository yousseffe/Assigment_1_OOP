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
    enum Colors
    {
        Red,
        Green,
        Blue,
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
            /*Person1[] persons = new Person1[3];
            persons[0] = new Person1("Alice", 25);
            persons[1] = new Person1("Bob", 30);
            persons[2] = new Person1("Charlie", 28);

            foreach (Person1 person in persons)
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

            #region 6-Struct for Point and Calculating Distance
            /*Console.Write("Enter x and y for point 1: ");
            string[] point1Input = Console.ReadLine().Split();
            Point point1 = new Point(double.Parse(point1Input[0]), double.Parse(point1Input[1]));

            Console.Write("Enter x and y for point 2: ");
            string[] point2Input = Console.ReadLine().Split();
            Point point2 = new Point(double.Parse(point2Input[0]), double.Parse(point2Input[1]));

            double distance = point1.DistaceBetween(point2);
            Console.WriteLine($"Distance between points: {distance}");*/
            #endregion

            #region 7-Struct for Person and Finding the Oldest Person
            /*Person[] persons = new Person[3];

            for (int i = 0; i < persons.Length; i++)
            {
                Console.Write($"Enter name for person {i + 1}: ");
                string name = Console.ReadLine();
                Console.Write($"Enter age for person {i + 1}: ");
                int age = int.Parse(Console.ReadLine());

                persons[i] = new Person(name, age);
            }

            Person oldest = persons[0];
            foreach (Person person in persons)
            {
                if (person.age > oldest.age)
                {
                    oldest = person;
                }
            }

            Console.WriteLine($"The oldest person is {oldest.name} with {oldest.age} years.");*/
            #endregion
        }
    }
}
