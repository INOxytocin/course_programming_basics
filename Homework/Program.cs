﻿using System.Runtime.Intrinsics.X86;

namespace Homework
{
    internal class Program
    {
        //Globalni promenne. Upravuji se na pocatku kazdeho cyklu.
        public static string global_name = "";
        public static string global_surname = "";
        public static int global_age = 0;
        public static int global_weight = 0;
        public static float global_height = 0.0f;
        public static float global_BMI = 0.0f;

        static void Main(string[] args)
        {
            

            int people = UserInputWMessage_ToInt("Uvedte pocet uzivatelu");
            MainCycle(people);


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
        //Kalkulace BMI
        public static float CalculateBMI(float heightCM, int weight)
        {
            float height_meters = heightCM / 100;
            float BMI = (float)weight / (float)Math.Pow(height_meters, 2);
            return BMI;
        }
        //Precte userinput z konzole a ulozi jako String
        public static string UserInputWMessage_ToString(string message)
        {
            Console.WriteLine(message);
            string user_input = Console.ReadLine();
            return user_input;
        }
        //Precte userinput z konzole a ulozi jako Int
        public static int UserInputWMessage_ToInt (string message)
        {
            Int32.TryParse(UserInputWMessage_ToString(message), out int converted_int);
            return converted_int;
        }
        //Precte userinput z konzole a ulozi jako Float
        public static float UserInputWMessage_ToFloat(string message)
        {
            float converted_float = (float)UserInputWMessage_ToInt(message);
            return converted_float;
        }
        //Hlavni cyklus, ktery si pocita pocet osob, kterym pocitame BMI, obsahuje ostatni funkce v poradi, jak davaji smysl.
        public static void MainCycle(int number_of_cycles)
        {
            for (int i = 0; i < number_of_cycles; i++)
            {
                Console.WriteLine((i + 1) + ". osoba");

                DataCollector();
                DataExtractor();

                
                

            }

            
        }
        //Ziska data o uzivateli z userinputu, dopocita a vlozi je do globalnich promennych
        public static void DataCollector ()
        {
            string name = UserInputWMessage_ToString("\nJmeno:");

            string surname = UserInputWMessage_ToString("\nPrijmeni:");

            int age = UserInputWMessage_ToInt("\nVek:");

            int weight = UserInputWMessage_ToInt("\nVaha (kg):");

            float height = UserInputWMessage_ToFloat("\nVyska (cm):");

            global_name = name;

            global_surname = surname;

            global_age = age;

            global_weight = weight;

            global_height = height;

            global_BMI = CalculateBMI(global_height, global_weight);

        }
        public static void DataExtractor()
        {
            Console.WriteLine("\n" + global_name + " " + global_surname + " je starý(á) " + global_age + " let. Váží " + global_weight + " kilogramů a je " + global_height + " centimetrů vysoký/á.\n");


            Console.WriteLine("BMI = " + global_BMI + "\n");
        }
        //public static int BMICategory()
        //{
        //    if (true)
        //    {
        //
        //    }
        //    else if (true)
        //    {
        //
        //    }
        //
        //}
    }

}
