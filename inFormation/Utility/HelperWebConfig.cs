using InFormation.DAL;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inFormation.Utility
{
    public class HelperWebConfig
    {
        public static IOptions<ReadConfig> config;

        public HelperWebConfig(IOptions<ReadConfig> _config)
        {
            config = _config;
        }

    }
}
