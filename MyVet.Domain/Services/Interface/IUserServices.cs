using Infraestructure.Entity.Model;
using MyVet.Domain.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyVet.Domain.Services.Interface
{
    public interface IUserServices
    {
        #region Auth
        TokenDto Login(LoginDto user);
       
        #endregion

        #region Methods Crud
        public List<UserDto> GetAllUsers();

        UserEntity GetUser(int idUser);

        Task<bool> UpdateUser(UserEntity user);


        Task<bool> DeleteUser(int idUser);
        Task<ResponseDto> CreateUser(UserEntity user);


        #endregion
    }
}