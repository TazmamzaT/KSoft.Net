using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KSoftNet;
using KSoftNet.IntegrationTests.Options;

namespace KSoftNet.IntegrationTests.Fixtures
{
    public class KSoftApiFixture : IDisposable
    {
        public IConfiguration Configuration { get; }

        public KSoftAPI KSoftAPI { get; }

        public KSoftApiFixture()
        {
            Configuration = new ConfigurationBuilder().AddJsonFile("secrets.json").Build();

            KSoftApiOptions ksoftoptions = new KSoftApiOptions();
            Configuration.GetSection(KSoftApiOptions.KSoftApi).Bind(ksoftoptions);

            KSoftAPI = new KSoftAPI(ksoftoptions.ApiToken);
        }

        public void Dispose()
        {
            
        }
    }
}
