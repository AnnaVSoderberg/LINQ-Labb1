using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Menu
    {
        public static void StartMenu()
        {
            bool meny = true;

            while (meny)
            {
                Console.WriteLine("Mata in en siffra och tryck på Enter:   ");
                Console.WriteLine();
                Console.WriteLine("  - - - - MENY - - - - ");
                Console.WriteLine("[1] Visa alla lärare som undervisar matte");
                Console.WriteLine("[2] Visa alla elever och deras lärare");
                Console.WriteLine("[3] Visa om en tabellen innehåller programmering1 eller inte");
                Console.WriteLine("[4] Editera Programmering2 till OOP i kolumn Ämne/Subject");
                Console.WriteLine("[5] Editera OOP till Programmering 2 i kolumn Ämne/Subject");
                Console.WriteLine("[6] Uppdatera ett record med Läraren Anas till Reidar");
                Console.WriteLine("[7] Avsluta");

                Int32.TryParse(Console.ReadLine(), out int input);

                switch (input)
                {
                    case 1:
                        Console.Clear();
                        LINQs.AllTeachersInMath();
                        break;
                    case 2:
                        Console.Clear();
                        LINQs.StudentsAndTeachers();
                        break;
                    case 3:
                        Console.Clear();
                        LINQs.SubjectContainProgrammering1();
                        break;
                    case 4:
                        Console.Clear();
                        LINQs.EditProgramming2ToOOP();
                        break;

                    case 5:
                        Console.Clear();
                        LINQs.EditOOPTOProgramming2();
                        break;
                    case 6:
                        Console.Clear();
                        LINQs.UpdateStudentRecordFromAnasToReidar();
                        break;
                    case 7:
                        meny = false;
                        break;
                    default:
                        Console.WriteLine("Mata in siffra mellan 1 och 6");
                        break;
                }
            }
        }
    }
}
