using Bulkimport.Bussiness;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bulkimport.Data
{
    public class ImportDbcontext : DbContext
    {
        public DbSet<ImportData> imports { get; set; }
        public ImportDbcontext(DbContextOptions options) : base(options)
        {

        }
    }
}
