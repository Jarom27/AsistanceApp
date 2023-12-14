using Microsoft.Maui.Storage;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistanceApp.Data
{
    public class FileDatabase : Database
    {
        
        public FileDatabase()
        {
            _queryResult = "";
        }
        public void Connect()
        {
            
        }
        public async void MakeQuery(string query)
        {
           
        }
        public async Task<string> GetQuery(string query)
        {
            try
            {
                using var stream = await FileSystem.OpenAppPackageFileAsync(query);
                using var reader = new StreamReader(stream);
                _queryResult = await reader.ReadToEndAsync();
                
            }
            catch (FileNotFoundException fx)
            {

            }
            return _queryResult;
        }
        public async Task RegisterData(string query, string data)
        {
            try
            {
                using var stream = await FileSystem.OpenAppPackageFileAsync(query);
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    await writer.WriteLineAsync(data);
                }
            }
            catch (FileNotFoundException fx)
            {

            }
        }
    }
}
