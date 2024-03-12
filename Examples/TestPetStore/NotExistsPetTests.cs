using Microsoft.Extensions.DependencyInjection;
using PetStore;

namespace TestPetStore
{
    [TestFixture]
    public class NotExistsPetTests : BaseTest
    {

        [Test]
        public async Task Test()
        {
            var petStoreClient = BaseTest.ServiceProvider.GetRequiredService<IPetStoreClient>();


            Assert.ThrowsAsync<ApiException>(async () => await petStoreClient.GetPetByIdAsync(1).ConfigureAwait(false));
        }
    }
}