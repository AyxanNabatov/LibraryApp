using Domain.Models;
using Repository.Repositories;
using Servive.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servive.Services
{
    public class LibraryService : ILibraryServices
    {
        private LibraryRepository _libraryRepository;
        private int _count;
        public LibraryService()
        {
            _libraryRepository = new LibraryRepository();
        }
        public Library Create(Library library)
        {
            library.Id = _count;

            _libraryRepository.Create(library);
            _count++;
            return library;


        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Library> GetAll()
        {
            throw new NotImplementedException();
        }

        public Library GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Library UpDate(int id, Library library)
        {
            throw new NotImplementedException();
        }
    }
}
