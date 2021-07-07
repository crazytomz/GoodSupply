using GoodSupply.DataTransferObject.DTO;
using GoodSupply.PGRepository.Contracts;
using Microsoft.Extensions.Options;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodSupply.PGRepository.Services
{
    public class DataFactory : IDataFactory
    {
        private readonly PGConnectionProperty _pGConnectionProperty;
        public DataFactory(IOptionsSnapshot<PGConnectionProperty> optionsSnapshot)
        {
            _pGConnectionProperty = optionsSnapshot.Value;
        }
        private NpgsqlConnection pgSQLCon = null;
        public NpgsqlConnection GetDBConnection()
        {
            try
            {
                pgSQLCon = new NpgsqlConnection(_pGConnectionProperty.PGConnectionString);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return pgSQLCon;
        }

    }
}
