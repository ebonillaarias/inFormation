using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inFormation.Utility
{
    public class HelperWebConfig
    {
        private static IConfiguration configuration;

        public HelperWebConfig(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        public static string SERV_GET_EMPLOYEE = configuration.GetSection("").GetSection("").Value;
    }
}
