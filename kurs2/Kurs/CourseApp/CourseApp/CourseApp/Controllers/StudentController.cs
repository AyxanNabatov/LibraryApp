using Service.Helpers;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp.Controllers
{
    public class StudentController
    {
        StudentService studenstservice = new StudentService();
        public void Create()
        {
            Helper.WriteConsole(ConsoleColor.Blue, "Add student name : ");
            string studentName = Console.ReadLine();
            Helper.WriteConsole(ConsoleColor.Blue, "Add student");
        }

        internal void GetById()
        {
            throw new NotImplementedException();
        }

        internal void Update()
        {
            throw new NotImplementedException();
        }

        internal void Delete()
        {
            throw new NotImplementedException();
        }

        internal void GetAll()
        {
            throw new NotImplementedException();
        }

        internal void Search()
        {
            throw new NotImplementedException();
        }

        internal void Age()
        {
            throw new NotImplementedException();
        }
    }
}
