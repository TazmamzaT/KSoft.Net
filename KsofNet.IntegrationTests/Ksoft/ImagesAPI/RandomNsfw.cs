using KsofNet.IntegrationTests.Fixtures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace KsofNet.IntegrationTests.Ksoft.ImagesAPI
{
    public class RandomNsfw : IClassFixture<KsoftApiFixture>
    {
        KsoftApiFixture fixture;

        public RandomNsfw(KsoftApiFixture fixture)
        {
            this.fixture = fixture;
        }
    }
}
