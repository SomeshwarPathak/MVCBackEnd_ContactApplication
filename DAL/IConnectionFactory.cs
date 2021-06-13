using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IConnectionFactory
    {
        IDbConnection dbConnection(string connectionPath);
    }

    public class ConnectionFactory : IConnectionFactory
    {
        public IDbConnection dbConnection(string connectionPath)
        {
            throw new NotImplementedException();
        }
    }
}
