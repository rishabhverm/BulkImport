using Bulkimport.Bussiness.Interface;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Text;

namespace Bulkimport.Data.Repsoritory
{
    public class ImportBulkRepository : IBulkImport
    {
        public DataColumn GetImportColumn(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetImportData(string query)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> ReadCSV<T>(Stream file)
        {
            var reader = new StreamReader(file);
            var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            var records = csv.GetRecords<T>();
            return records;
        }
    }
}
