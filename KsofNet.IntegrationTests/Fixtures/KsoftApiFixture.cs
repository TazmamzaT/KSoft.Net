using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSoftNet.IntegrationTests.Fixtures
{
    public class KSoftApiFixture : IDisposable
    {
        public IConfiguration Configuration { get; }

        public KSoftApiFixture()
        {
            Configuration = new ConfigurationBuilder().AddJsonFile("secrets.json").Build();
        }

        public void Dispose()
        {
            
        }
    }
}
