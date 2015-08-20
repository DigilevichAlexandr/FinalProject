using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ASP.NET.DIGILEVICH.FileStorage.Models
{
    public class FileContext:DbContext
    {
        public DbSet<StoredFile> StoredFiles { get; set; }
    }
}