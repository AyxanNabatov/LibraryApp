using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Library : BaseEntity
    {
        public string Name { get; set; }
        public int SeatCount { get; set; }

        public static implicit operator Library(int v)
        {
            throw new NotImplementedException();
        }
    }
}
