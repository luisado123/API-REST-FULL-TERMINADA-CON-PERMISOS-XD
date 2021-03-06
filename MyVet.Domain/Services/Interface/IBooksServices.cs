using MyVet.Domain.Dto;
using MyVet.Domain.Dto.Autores;
using MyVet.Domain.Dto.Books;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Domain.Services.Interface
{
    public interface IBooksServices
    {

        List<ConsultaAutoresLibrosDto> GetAllBooks();
        Task<ResponseDto> DeleteBooksAsync(int idBooks);
        Task<bool> InsertBooksAsync(InsertBooksDto data);
        Task<bool> UpdateBooksAsync(AlterBooksDto data);

    }
}
