using System;

namespace MiniProject
{
    class UserLogin
    {
        static string username;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Username");
            username = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Choose Technology \n\n1.C# Technology\n2.Java Technology\n3.Python Technology  ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine ("CSharp.Questions()");
                    break;
                case 2:
                    Console.WriteLine("Java.Questions()");
                  break;
                case 3:
                    Console.WriteLine("Python.Questions()"); 
                    break;
            }
        }
    }
    public class Csharp
    {
        public static void Questions()
        {
            string[] CSArr = new string[10];
            CSArr[0] = "Q.1) C# is ________ language \n1.platform dependent \n2. platform independent\n3.Programming Language \n4. Language ";
            CSArr[1] = "Q.2)String is_______\n1.mutable \n2. immutable \n3. changable \n4.none of the Above  ";
            CSArr[2] = "Q.3)_______is exit Controlled loop\n1.while loop \n2.for loop\n3.do while loop \n4.all of the above";
            CSArr[3] = "Q.4) For Loop is  ______ loop \n1.exit control \n2.entry control\n3.both \n4.none of the above ";
            CSArr[4] = "Q.5) Abstraction achieve by ______\n1.Abtstaction \n2.Interface\n3.All of the Above\n4. None of the Above";
            CSArr[5] = "Q.6)String Builder  is_______\n1.mutable \n2. immutable \n3. constant \n4.none of the Above  ";
            CSArr[6] = "Q.7)Inheritance is used to hide internal implementation.\n1.True \n2. False \n4. ";
            CSArr[7] = "Q.8)C# is_______  Language\n1.mutable \n2. immutable \n3. changable \n4.none of the Above  ";
            CSArr[8] = "Q.9)CLR stands for_______\n1.Control Language Runtime  \n2.Common Language Runtime\n3.Central Language Runtime\n4.None of Above ";
            CSArr[9] = "Q.10)Use of Trim Function  is_______\n1.Remove Symbol \n2.Remove Staring spaces \n3.Remove start and end spaces\n4.remove all spaces  ";

            int[] csans = new int[10];
            csans[0] = 2;
            csans[1] = 2;
            csans[2] = 3;
            csans[3] = 2;
            csans[4] = 3;
            csans[5] = 2;
            csans[6] = 1;
            csans[7] = 2;
            csans[8] = 2;
            csans[9] = 3;
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(CSArr[i]);
                Console.WriteLine("Choose Option");
                int ans = int.Parse(Console.ReadLine());
                if (ans == csans[i])
                {
                    Console.WriteLine("Correct Answer");
                    count++;
                }
                else
                {
                    Console.WriteLine("Wrong Answer");
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"Your Score is {count}/10");
            if (count >= 6)
                Console.WriteLine("Congrats ......You Cleared This Test");
            else
                Console.WriteLine("Unfortunately......You were not cleared The Test");
        }
    }       
    class Java
    {
        public static void Questions()
        {
            string[] JArr = new string[10];
            JArr[0] = "Q.1) Which of the following is true about anonymous inner class? \n1.It has only Methods \n2. Object can't be created\n3.It has a fixed class name \n4. It has no class name ";
            JArr[1] = "Q.2)In which process a local variable has the same name as one of the instance variables?\n1.Serilization \n2. Variable Shadowing \n3. Abstaction\n4.Multi-Threading  ";
            JArr[2] = "Q.3)if x=3,y=5,and z=10 ++z+y-y+z+x++\n1.24 \n2.23\n3.20 \n4.25";
            JArr[3] = "Q.4) What does expression float a= 35/0 return? \n1.0 \n2.Not a Number\n3.Infinity \n4.Runtime Exception";
            JArr[5] = "Q.5)Which of the following is a valid long literal?\n1.ABH8097 \n2. L990023 \n3. 904423 \n4.0xnf029L ";
            JArr[6] = "Q.6)What is return Type of HashCode()method in the Object Class?.\n1.Object \n2. int \n3.long \n4.void ";
            JArr[7] = "Q.7)Which of the following is not a Java features ? \n1.Dynamic \n2. Architecture Neutral \n3. Use of Pointers \n4.none of the Above  ";
            JArr[8] = "Q.8)Which of the following option leads to the portability and security of Java ?\n1.ByteCode is executed by JVM  \n2.The applet makes the java code secure and portable \n3.Use of Exception Hanndling\n4.Dynamic binding between Objects";
            JArr[9] = "Q.9)Number of primitive data types in Java are ?\n1.6 \n2.7 \n3.8\n4.9 ";

            int[] csans = new int[10];
            csans[0] = 4;
            csans[1] = 2;
            csans[2] = 4;
            csans[3] = 3;
            csans[4] = 3;
            csans[5] = 2;
            csans[6] = 1;
            csans[7] = 2;
            csans[8] = 1;
            csans[9] = 3;
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(JArr[i]);
                Console.WriteLine("Choose Option");
                int ans = int.Parse(Console.ReadLine());
                if (ans == csans[i])
                {
                    Console.WriteLine("Correct Answer");
                    count++;
                }
                else
                {
                    Console.WriteLine("Wrong Answer");
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"Your Score is {count}/10");
            if (count >= 6)
                Console.WriteLine("Congrats ......You Cleared This Test");
            else
                Console.WriteLine("Unfortunately......You were not cleared The Test");
        }
    }
    class Python
    {
        public static void Questions()
        {
            string[] PArr = new string[10];
            PArr[0] = "Q.1) Who developed Python Programming Language? \n1.Wick van Rossum\n2. Rasmus Lerdorf\n3.Guido van Rossum \n4. Niene Stom ";
            PArr[1] = "Q.2 which type of Programming does Python support?\n1.object oriented programming\n2.structured programming \n3.Functional Programmig\n4.all of the mentioned ";
            PArr[2] = "Q.3)is python case sensitive when dealing with identifiers?\n1.no \n2.yes \n3.machine dependent\n4.none of the mentioned";
            PArr[3] = "Q.4) Is Python code compiled or interpreted? \n1.Python code is both compiled and interpreted \n2.Python code is neither compiled nor interpreted\n3.Python code is only Compiled\n4.Python code is only interpreted";
            PArr[5] = "Q.5)Which of the following is correct extension of the Python File?\n1..python \n2. .pl \n3. .py \n4. .p ";
            PArr[6] = "Q.6)All keywords in Python are in ________\n1.Capitalized \n2.Lower case \n3.UPPER CASE \n4.none of mentioned ";
            PArr[7] = "Q.7)What will be the value of following Python expression?  4+3%5 \n1.7\n2. 2 \n3. 4 \n4.1  ";
            PArr[8] = "Q.8)Which of the following is used to define a block of code in Python language ?\n1.Indentation \n2.Key \n3.Brackets\n4.All of the Ab";
            PArr[9] = "Q.9)Which keyword is used for function in Python Language ?\n1.Function\n2 .Def \n3.Fun\n4.Define ";

            int[] csans = new int[10];
            csans[0] = 3;
            csans[1] = 4;
            csans[2] = 4;
            csans[3] = 1;
            csans[4] = 2;
            csans[5] = 3;
            csans[6] = 4;
            csans[7] = 1;
            csans[8] = 1;
            csans[9] = 2;
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(PArr[i]);
                Console.WriteLine("Choose Option");
                int ans = int.Parse(Console.ReadLine());
                if (ans == csans[i])
                {
                    Console.WriteLine("Correct Answer");
                    count++;
                }
                else
                {
                    Console.WriteLine("Wrong Answer");
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"Your Score is {count}/10");
            if (count >= 6)
                Console.WriteLine("Congrats ......You Cleared This Test");
            else
                Console.WriteLine("Unfortunately......You were not cleared The Test");
        }
    }

}
    

    


        
    

            
        
    

