using System;


namespace Repository.Repositories
{
    public class NotFoundException : Exception 
    {
        public NotFoundException(string message) : base(message) { }
    }
}
