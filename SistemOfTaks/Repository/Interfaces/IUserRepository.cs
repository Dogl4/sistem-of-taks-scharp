using SistemOfTaks.Models;

namespace SistemOfTaks.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<List<UserModel>> FindAll();

        Task<UserModel> FindById(int id);

        Task<UserModel> Add(UserModel user);

        Task<UserModel> Update(UserModel user, int id);

        Task<bool> Delete(int id);
    }
}