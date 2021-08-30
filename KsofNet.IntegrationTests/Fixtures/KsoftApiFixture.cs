using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsofNet.IntegrationTests.Fixtures
{
    public class KsoftApiFixture : IDisposable
    {
        public IConfiguration Configuration { get; }

        public KsoftApiFixture()
        {
            Configuration = new ConfigurationBuilder().AddJsonFile("secrets.json").Build();
        }

        public void Dispose()
        {
            
        }
    }
}
