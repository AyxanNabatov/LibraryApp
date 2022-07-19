using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servive.Services.Interfaces
{
    public interface ILibraryServices
    {
        Library Create(Library library);
        Library UpDate(int id, Library library);
        void Delete(int id);
        Library GetById(int Id);
        List<Library> GetAll();
    }
}
