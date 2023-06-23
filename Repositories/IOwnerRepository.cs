using DogGo.Models;

namespace DogGo.Repositories
{
    public interface IOwnerRepository
    {
        List<Owner> GetAllOwners();
        Owner GetOwnerById(int id);
        Owner GetOwnerByEmail(string email);

       void DeleteOwner(int owner);
        void AddOwner(Owner owner);

        void UpdateOwner(Owner owner);

       

    }
}
