using DogGo.Models;

namespace DogGo.Repositories
{
    public interface IDogRepository
    {
        List<Dog> GetAllDogs();
        Dog GetDogById(int id);
        

        void DeleteDog(int dog);
        void AddDog(Dog dog);

        void UpdateDog(Dog dog);


    }
}
