using Microsoft.Data.SqlClient;
using DogGo2.Models;
namespace DogGo2.Repositories
{
    public interface IOwnerRepository
    {
        SqlConnection Connection { get; }

        void AddOwner(Owner owner);
        void DeleteOwner(int ownerId);
        Owner GetOwnerByEmail(string email);
        Owner GetOwnerById(int id);
        void UpdateOwner(Owner owner);
    }
}