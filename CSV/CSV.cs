using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;

namespace CSV
{
    public class CSV<T> where T:class
    {
        public List<T> GetCsv(string path)
        {
            using (var streamReader = File.OpenText(path))
            {
                var reader = new CsvReader(streamReader);
                return reader.GetRecords<T>().ToList();
            }
        }

        public void SaveCsv(string path, List<T> csv)
        {
            using (var streamWriter = File.CreateText(path))
            {
                var writer = new CsvWriter(streamWriter);
                writer.WriteRecords(csv);
            }
        }

        public void SaveCsv(string path, List<CsvHelper> csv)
        {
            using (var streamWriter = File.CreateText(path))
            {
                var writer = new CsvWriter(streamWriter);
                writer.WriteRecords(csv);
            }
        }
    }
}
