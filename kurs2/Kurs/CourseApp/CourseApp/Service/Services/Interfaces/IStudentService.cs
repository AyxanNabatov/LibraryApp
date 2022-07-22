using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services.Interfaces
{
    public interface IStudentService
    {
        Student Create(int groupId, Student Student);
        Student GetById(int id);
        Student Update(int id, Student student);
        void Delete(int id);
        Student GetAllByAge(int id);
        List<Student> GetAll();
        List<Student> Search(string search);


    }
}
