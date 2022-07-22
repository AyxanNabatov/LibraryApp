using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Helpers
{
    public class Helper
    {
        public static void WriteConsole(ConsoleColor color, string text)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }

    public enum Menues
    {
        CreateStudent = 1,
        GetStudentById = 2,
        UpdateStudent = 3,
        DeleteStudent = 4,
        GetAllStudent = 5,
        SearchStudent = 6,
        CreateGroup = 7,
        UpdateGroup = 8,
        DeleteGroup = 9,
        GetGroupById = 10,
        GetStudentsByAge = 11,
        GetAllGroup = 12,
    }
}
