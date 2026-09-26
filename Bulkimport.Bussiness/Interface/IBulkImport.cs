using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Bulkimport.Bussiness.Interface
{
    public interface IBulkImport
    {

        public IEnumerable<T> ReadCSV<T>(Stream file);
        public DataTable GetImportData(string query);

        public DataColumn GetImportColumn(int id );

    }
}
