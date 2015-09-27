﻿using Gallery.Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery.Models
{
    public class GalleryContext : DbContext
    {
        public GalleryContext(string connectionString) : base(connectionString) { }

        public DbSet<User> Users;
    }
}
