﻿namespace Assigment_1_OOP
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

        }
    }
}
