using Microsoft.Extensions.DependencyInjection;
using PetStore;

namespace TestPetStore
{
    [TestFixture]
    public class PetTests : BaseTest
    {
        IPetStoreClient? _petStoreClient;
        Pet _newPet;

        [OneTimeSetUp]
        public void Setup()
        {
            _petStoreClient = BaseTest.ServiceProvider.GetRequiredService<IPetStoreClient>();

            _newPet = new Pet
            {
                Category = new Category
                {
                    Name = "BigDog",
                    Id = 1,
                },
                Id = 4,
                Name = "Bernie",
                PhotoUrls = { "URL1", " URL2" },
                Status = PetStatus.Available,
                Tags = new[] { new Tag { Id = 1, Name = "GermanSheperd" }, new Tag { Id = 2, Name = "Dog" } }
            };
        }

        [Order(1)]
        [Test]
        public async Task CreatePetTest()
        {
            await _petStoreClient.AddPetAsync(_newPet).ConfigureAwait(false);
        }

        [Order(2)]
        [Test]
        public async Task GetPetTest()
        {
            var foundPet = await _petStoreClient.GetPetByIdAsync(_newPet.Id.Value).ConfigureAwait(false);

            Assert.Multiple(() =>
            {
                Assert.That(foundPet.Name, Is.EqualTo(_newPet.Name));
                Assert.That(foundPet.Category.Name, Is.EqualTo(_newPet.Category.Name));
                Assert.That(foundPet.Category.Id, Is.EqualTo(_newPet.Category.Id));
            });
        }

        [Order(3)]
        [Test]
        public async Task UpdatePetTest()
        {
            _newPet.Name = "Nero";
            await _petStoreClient.UpdatePetAsync(_newPet).ConfigureAwait(false);

            var foundPet = await _petStoreClient.GetPetByIdAsync(_newPet.Id.Value).ConfigureAwait(false);

            Assert.That(foundPet.Name, Is.EqualTo(_newPet.Name));
        }

        [Order(9)]
        [Test]
        public async Task DeletePetTest()
        {
            await _petStoreClient.DeletePetAsync("YOUR_API_KEY", _newPet.Id.Value).ConfigureAwait(false);
        }

        [Order(10)]
        [Test]
        public async Task AlreadyDeletedTest()
        {
            Assert.ThrowsAsync<ApiException>(async () => await _petStoreClient.GetPetByIdAsync(1555).ConfigureAwait(false));
        }
    }
}