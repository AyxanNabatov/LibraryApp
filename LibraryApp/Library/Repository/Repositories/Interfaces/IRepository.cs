﻿using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.Interfaces
{
    public interface IRepository<T> where T:BaseEntity
    {
        void Create(T data);
        void UpDate(T data);
        void Delete(T data);
        T Get(Predicate<T> predicate);
        List<T> GetAll(Predicate<T> predicate);
    }
}
