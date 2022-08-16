using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedExample
{
    internal class Encapsulation_Database
    {
        private string _databaseConnection;
        public string OracleDatabaseConnection()
        {
            _databaseConnection = "Oracle Database";
            return _databaseConnection;
        }
    }
}
