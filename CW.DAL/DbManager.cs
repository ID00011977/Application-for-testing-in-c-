using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.DAL
{
   //DbManager works for connection with other two managers(Test and Applicant)
        public class DbManager
        {
            protected SqlCeConnection Connection
            {
                get
                {
                    return new SqlCeConnection(Properties.Settings.Default.ConnectionString);
                }
            }

        }
    
}
