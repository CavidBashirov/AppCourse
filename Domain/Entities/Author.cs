﻿using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Author : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
