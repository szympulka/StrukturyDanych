using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;

namespace CSV
{
    public class CSV
    {
        public List<CsvObject> GetCsv(string path)
        {
            using (var streamReader = File.OpenText(path))
            {
                var reader = new CsvReader(streamReader);
                return reader.GetRecords<CsvObject>().ToList();
            }
        }

        public void SaveCsv(string path, List<CsvObject> csv)
        {
            using (var streamWriter = File.CreateText(path))
            {
                var writer = new CsvWriter(streamWriter);
                writer.WriteRecords(csv);
            }
        }

    }
}
