using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgOppgaverBasicLab
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    ////Oppgave 1
        //    //int num = 0;

            //for (int i = 1; i < 11; i++)
            //{
            //    num = num + i;
            //}
            //Console.WriteLine(num);
            //Console.ReadLine();

            //Oppgave 2
            //int num = 0;
            //int num2 = 0;

            //Console.WriteLine("Write 10 numbers");
            //for (int i = 0; i < 10; i++)
            //{

            //        num = Int32.Parse(Console.ReadLine());
            //        num2 = num2 + num;
            //}
            //Console.WriteLine("Sum " + num2);
            //Console.WriteLine("Avg " + num2 / 10);
            //Console.ReadLine();

            //Oppgave 3
            //int[] num = new int[11];
            //Random ran = new Random();

            //for (int i = 1; i < 11; i++)
            //{
            //    num[i] = ran.Next(1, 20);
            //}
            //for (int i = 1; i < 11; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}
            //Console.ReadLine();

            //Oppgave 4
            //int[] num = new int[10];

            //for (int i = 0; i < 10; i++)
            //{

            //    num[i] = i + 1;

            //}
            //Array.Reverse(num);
            //for (int i = 0; i < 10; i++)
            //{

            //    Console.WriteLine(num[i]);
            //}
            //Console.ReadLine();

            //Oppgave 5
            //int[] highnum = new int[50];
            //Random ran = new Random();


            //for (int i = 0; i < highnum.Length; i++)
            //{
            //    highnum[i] = ran.Next(1, 1000);
            //}
            //Console.WriteLine(highnum.Max()); 
            //Console.ReadLine();

            //Oppgave 6
            //int[] incNum = new int[10];
            //Random ran = new Random();

            //for (int i = 0; i < incNum.Length; i++)
            //{
            //    incNum[i] = ran.Next(1, 100);
            //}
            //Array.Sort(incNum);
            //for (int i = 0; i < incNum.Length; i++)
            //{
            //    Console.WriteLine(incNum[i]);
            //}
            //Console.ReadLine();

            //Oppgave 7
            //Console.Write("Skriv inn hvor mange plasser tabellen skal inneholde: ");
            //int s = Int32.Parse(Console.ReadLine());
            //int[] num = new int[s];
            //Random ran = new Random();

            //for (int i = 0; i < num.Length; i++)
            //{
            //    num[i] = ran.Next(1, 100);
            //}
            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}
            //Console.ReadLine();

            //Oppgave 8
            //int[] arr = new int[20];
            //Random ran = new Random();

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = ran.Next(1, 100);
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 != 0)
            //        Console.Write(arr[i] + " ");
            //}
            //Console.ReadLine();

            //Oppgave 9
            //for (int i = 6; i > 0; i--)
            //{
            //    for (int j = i; j > 0; j--)
            //    {
            //        Console.Write("#");
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}
            
            //Console.ReadLine();
        }
    }

//Oppgave 10
//internal class Hotell
//{
//    int antallRom;
//    int antallLedig;
//    int antallOpptatt;
//    int antallGjester;
//    static void Main(string[] args)
//    {
//        Hotell Fredrikstad = new Hotell();
//        Fredrikstad.antallRom = 100;
//        Fredrikstad.antallLedig = 100;
//        Fredrikstad.antallOpptatt = 0;
//        Fredrikstad.antallGjester = 0;
//        Console.WriteLine("Antall rom på hotellet: " + Fredrikstad.antallRom);
//        Console.WriteLine("Antall Gjester på hotellet: " + Fredrikstad.antallGjester);
//        Console.WriteLine("Antall ledige rom på hotellet: " + Fredrikstad.antallLedig);
//        Console.WriteLine("Antall opptatte rom på hotellet: " + Fredrikstad.antallOpptatt);
//        Console.Write("Skriv hvor mange gjester som skal sjekke inn på hotellet: ");
//        int innsjekk = Int32.Parse(Console.ReadLine());
//        for (int i = 0; i < innsjekk; i++)
//        {
//            Fredrikstad.innsjekk();
//        }
//        Console.WriteLine();
//        Console.WriteLine("Antall Gjester på hotellet: " + Fredrikstad.antallGjester);
//        Console.WriteLine("Antall ledige rom på hotellet: " + Fredrikstad.antallLedig);
//        Console.WriteLine("Antall opptatte rom på hotellet: " + Fredrikstad.antallOpptatt);
//        Console.Write("Skriv hvor mange gjester som skal sjekke ut av hotellet: ");
//        int utsjekk = Int32.Parse(Console.ReadLine());
//        for (int i = 0; i < utsjekk; i++)
//        {
//            Fredrikstad.utsjekk();
//        }
//        Console.WriteLine();
//        Console.WriteLine("Antall Gjester på hotellet: " + Fredrikstad.antallGjester);
//        Console.WriteLine("Antall ledige rom på hotellet: " + Fredrikstad.antallLedig);
//        Console.Write("Antall opptatte rom på hotellet: " + Fredrikstad.antallOpptatt);
//        Console.ReadLine();
//    }
//    public void utsjekk()
//    {
//        Boolean utsjekk = true;
//        if (utsjekk)
//        {
//            antallGjester--;
//            antallLedig++;
//            antallOpptatt--;
//        }

//    }
//    public void innsjekk()
//    {
//        Boolean innsjekk = true;
//        if (innsjekk)
//        {
//            antallGjester++;
//            antallLedig--;
//            antallOpptatt++;
//        }

//    }
//}

