﻿using CsvHelper;
using CsvHelper.Configuration;
using FinancialHelper.Shared.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialHelper.Shared.Services
{
    public class CSVService : ICSVService
    {
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposing)
        {
            if (disposing) { }
        }

        public List<BankData> GetDataFromFile(string path)
        {
            List<BankData> bankData = new(); 

            CsvConfiguration csvConfig = new(CultureInfo.InvariantCulture)
            {
                Encoding = Encoding.Default,
                HasHeaderRecord = true,
                Delimiter = ",",
                MemberTypes = MemberTypes.Properties,
                HeaderValidated = null,
                MissingFieldFound = null,
            };

            using (StreamReader streamReader = new(path, Encoding.Default))
                using(CsvReader csvReader = new(streamReader, csvConfig))
            {
                bankData = csvReader.GetRecords<BankData>().ToList();
                Debug.WriteLine($"Rows imported: {bankData.Count}");
            }

            return bankData;
        }
    }
}