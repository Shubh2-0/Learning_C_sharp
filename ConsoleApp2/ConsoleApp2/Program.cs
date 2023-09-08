// HERE WE HAVE SYSTEM NAME SPACE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 WHAT IS NAMESPACE ?
 
NAMESPACE IS TYPICAL A BLOCK OF CODE OR A 
CONTAINER WHERE WE DEFINE
OUR MULTIPLE CLASSES FOR SAME LOGIC 
 
 
 */

namespace ConsoleApp2
{
     class Program
    {
/*
 *      DATA TYPES IN C#
 * 
 */
        
        static int rollNumber; // Integer 4 bytes
        static long adharNumber; // Long 8 bytes

        static float hieght; // Float 4 bytes 
        static double wieght; // Double 8 bytes

        static Boolean isPresent; // Boolean 1 bit

        static char firstNameCharcter; // Character 2 bytes
        static string name; // String 2 bytes per character


        static void Main(string[] args)
        {
            rollNumber = 34;
            name = "Shubham Bhati";
            isPresent = true;
            adharNumber = 27436278237832; 
            hieght = 5.6f;
            wieght = 68;
            firstNameCharcter = 'S';
            

            Console.WriteLine("Hello World\n\n");

            Console.Write("\n\n" +
                "NAME : " +name+
                "\nATTENDANCE : \t" +isPresent+
                "\nHIEGHT : \t"+hieght+
                "\nWIEGHT : \t"+wieght+
                "\n ADHAR NUMBER : \t"+ adharNumber+
                "\nFIRST NAME CHARCTER : \t" +firstNameCharcter+
                "\nROLLNUMBER : \t"+rollNumber+"\n\n");


            Console.WriteLine("I love C# 💓\n\n\n");


            /*
                        TAKE INPUT IN C# USING READLINE

             */

            Console.WriteLine("Write your Institude name");

            string schoolName = Console.ReadLine();

            Console.WriteLine("\n\n"+schoolName);




            // TYPE CASTING 

            // 1. EPLICIT CASTING 
            //char to int to long to float to double

            int g = 90;
            double k = g;

            char n = 'h';
            long m = n;


            // 2. EXPLICIT CASTING 


            float b = 56.7f;
            int v = (int) b;



            Console.Write("Enter How Many Pens do you want : ");
            string pens = Console.ReadLine();

            Console.WriteLine("You want "+pens+" pens but i give you 2 extra pens So total pens is :  "+ (Convert.ToInt32(pens) + 2) );


            int maxNum = Math.Max(34, 56);
            Console.WriteLine(maxNum);

            int minNum = Math.Min(48, 19);
            Console.WriteLine(minNum);

            double sqr = Math.Sqrt(81);

            Console.WriteLine(sqr);



            // STRING FUNCTIONS

            string str = "HELLO MY NAME IS Shubham Bhati";
            Console.WriteLine("length of the string : "+str.Length);

            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());

            Console.WriteLine(String.Concat("hello", "world"));



            // STRING INTERPOLATION 

            string name1 = "Shubham Bhati";
            String school = "Masai School";

            Console.WriteLine($"My name is {name1} and i am a student of {school}");




            Console.WriteLine("\n\n\n ENTER YOUR AGE\n\n");
    
            string age1 =  Console.ReadLine();

            int age = Convert.ToInt32(age1);

            if (age < 18 && age > 0)
                Console.WriteLine("not eligible for driving");

            else if (age <= 0)
                Console.WriteLine("Invalid age");

            else
                Console.WriteLine("eligible for driving");





            // LOOPS

            Console.WriteLine("\n\nFOR LOOP");

            for (int i=0;i<10;i++)
                Console.WriteLine(i);


            Console.WriteLine("\n\nWHILE LOOP");      

            int j = 0;

            while(j  < 10)
            {
                Console.WriteLine(j++);
            }




            // BREAK 

            for (int i = 10; i > 0; i--)
            {
                if (i == 7)
                {
                    Console.WriteLine("Break");
                    break;
                }
                 
                else
                    Console.WriteLine("Running");

            }




            // METHODS (FUNCTIONS)


            Great();


            Console.WriteLine("\n\n\nSum of 2,3 and 4 is : "+ Sum(2,3,4) );


            // OPPS CONCEPTS

            Student st1 = new Student();

            st1.name = "Shubham";
            st1.age = 23;
            st1.city = "Ujjain";


            Console.WriteLine(st1);


            Student st2 = new Student("Aman", 34, "ujjain");

            Console.WriteLine(st2);






            Console.ReadLine();

            
        }

        static int Sum(int a,int b,int c)
        {
            return a + b + c;

        }

        static void Great()
        {
            Console.WriteLine("Hello , How are you ?");
        }

    }
}
