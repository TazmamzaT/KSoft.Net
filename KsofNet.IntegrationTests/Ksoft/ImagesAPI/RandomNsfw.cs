using KSoftNet.IntegrationTests.Fixtures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace KSoftNet.IntegrationTests.KSoft.ImagesAPI
{
    public class RandomNsfw : IClassFixture<KSoftApiFixture>
    {
        KSoftApiFixture fixture;

        public RandomNsfw(KSoftApiFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public async Task PostEndsWithGif()
        {
            var post = await fixture.KSoftAPI.imagesAPI.RandomNsfw(true);
            Assert.EndsWith(".gif", post.ImageUrl);
        }

        [Fact]
        public async Task PostEndsWithNotGif()
        {
            var post = await fixture.KSoftAPI.imagesAPI.RandomNsfw(true);
            Assert.DoesNotContain(".gif", post.ImageUrl);
        }
    }
}
