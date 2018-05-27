﻿using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppContext.Context
{
    public class ApplicationContext : DbContext
    {

        public ApplicationContext():base("DefaultConnection")
        {

        }

        public DbSet<User> Users { get; set; }
        
    }
}
