using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistanceApp.Data
{
    public class Database: IGettingData
    {
        protected string _queryResult;
        public Database()
        {
            _queryResult = "";
        }
        public void Connect()
        {

        }
        public async Task MakeQuery(string query)
        {

        }
        public string QueryResult()
        {
            return _queryResult; 
        }
    }
}
