using AutoMapper;
using BookWebApi.AppCores.Interfaces;
using BookWebApi.AppDataAccess.Repositories.Interfaces;
using BookWebApi.AppModels.DTOs;
using BookWebApi.AppModels.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookWebApi.AppCores.Implementations
{
    public class AuthorServices : IAuthorServices
    {
        private readonly IAuthor _authorRepo;
        private readonly IMapper _mapper;

        public AuthorServices(IAuthor authorRepo, IMapper mapper)
        {
            _authorRepo = authorRepo;
            _mapper = mapper;
        }
        public async Task<AuthorDetailDto> AddAuthor(AuthorDto author)
        {
            try
            {
                var res = _mapper.Map<Author>(author);
                var response = await _authorRepo.Add(res);
                if (response)
                {
                    var responseAuthor = _mapper.Map<AuthorDetailDto>(author);
                    responseAuthor.Id = res.Id;
                    return responseAuthor;
                }

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }

        public async Task<bool> DeleteAuthor(string id)
        {
            var author = _authorRepo.GetAuthorById(id);
            if(author != null)
            {
                try
                {
                    var res = await _authorRepo.Delete(author);
                    if (res)
                    {
                        return res;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return false;
        }

        public async Task<List<AuthorListDto>> GetAllAuthorList()
        {
            var listOfAuthor = new List<AuthorListDto>();
            try
            {
                var res = await _authorRepo.GetAuthors();
                if(res != null)
                {
                    foreach (var author in res)
                    {
                        listOfAuthor.Add(_mapper.Map<AuthorListDto>(author));
                    }
                    return listOfAuthor;
                }

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }

        public async Task<AuthorDetailDto> GetAuthorById(string id)
        {
            try
            {
                var author = await _authorRepo.GetAuthorById(id);
                if(author != null)
                {
                    var res = _mapper.Map<AuthorDetailDto>(author);
                    return res;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }

        public async Task<bool> UpdateAuthor(string authorid, AuthorDto author)
        {
            var check = await _authorRepo.GetAuthorById(authorid);
            if(check != null)
            {
                try
                {
                    var updatedAuthor = _mapper.Map<Author>(author);
                    updatedAuthor.Id = authorid;
                    var res = await _authorRepo.Update(updatedAuthor);
                    if (res)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

            }
            return false;
        }
    }
}
