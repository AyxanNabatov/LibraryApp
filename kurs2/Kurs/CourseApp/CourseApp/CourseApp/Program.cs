using Service.Helpers;
using System;
using Service.Services;
using Domain.Models;
using CourseApp.Controllers;

namespace CourseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentController studentController = new StudentController();
            GroupController groupController = new GroupController();
            Helper.WriteConsole(ConsoleColor.Blue, "Select one option : ");

            GetMenues();

            while (true)
            {
                SelectOption:  string selectOption = Console.ReadLine();

                int selectTrueOption;

                bool isSelectOption = int.TryParse(selectOption, out selectTrueOption);

                if (isSelectOption)
                {
                    switch(selectTrueOption)
                    {
                        case (int)Menues.CreateStudent:

                            studentController.Create();

                            break;
                        case (int)Menues.GetStudentById:

                            studentController.GetById();
                            break;
                        case (int)Menues.UpdateStudent:

                            studentController.Update();
                            break;
                        case (int)Menues.DeleteStudent:

                            studentController.Delete();
                            break;

                        case (int)Menues.GetStudentsByAge:
                            studentController.Age();

                            break;

                        case (int)Menues.GetAllStudent:

                            studentController.GetAll();

                            break;

                        case (int)Menues.SearchStudent:

                            studentController.Search();

                            break;

                        case (int)Menues.CreateGroup:

                            groupController.Create();

                            break;

                        case (int)Menues.UpdateGroup:
                            groupController.Update();

                            break;

                        case (int)Menues.DeleteGroup:
                             groupController.Delete();

                            break;

                        case (int)Menues.GetGroupById:
                            groupController.GetById();

                            break;

                        case (int)Menues.GetAllGroup:
                            groupController.GetAll();

                            break;

                     


                        default:
                            Helper.WriteConsole(ConsoleColor.Red, "Select Correct option number");
                            break;
                    }
                    
                }
                else
                {
                    Helper.WriteConsole(ConsoleColor.Red, "Select correct option:");
                    goto SelectOption;
                }
            }

        }

        private static void GetMenues()
        {
            Helper.WriteConsole(ConsoleColor.Yellow, "1 - Create student, 2 - GetStudent by id, 3 - Update student, 4 - Delete student, 5 - Get all stundet, 6 - Search student, Create group");
        }
    }
}
