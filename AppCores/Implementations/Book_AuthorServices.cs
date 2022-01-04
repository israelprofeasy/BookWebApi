using AutoMapper;
using BookWebApi.AppCores.Interfaces;
using BookWebApi.AppDataAccess.Repositories.Interfaces;
using BookWebApi.AppModels.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookWebApi.AppCores.Implementations
{
    public class Book_AuthorServices : IBook_AuthorServices
    {
        private readonly IBook_AuthorRepository _book_AuthorRepo;
        private readonly IMapper _mapper;

        public Book_AuthorServices(IBook_AuthorRepository book_AuthorRepository, IMapper mapper )
        {
            _book_AuthorRepo = book_AuthorRepository;
            _mapper = mapper;
        }
        public async Task<bool> AddBookAuthor(string authorId, string bookId)
        {
            var author = _book_AuthorRepo.;
        }

        public async Task<List<BookFavoriteDto>> GetAuthorBooks(string authorId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<AuthorListDto>> GetBookAuthors(string bookId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> RemoveBookAuthor(string authorId, string bookId)
        {
            throw new System.NotImplementedException();
        }
    }
}
