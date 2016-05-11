﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain
{
    public abstract class Entity<T>
    {
        [Key]
        public T Id { get; set; }
    }
}
