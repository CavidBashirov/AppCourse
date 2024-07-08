using AutoMapper;
using Domain.Entities;
using Repository.Repositories.Interfaces;
using Service.DTOs.Admin.Authors;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepo;
        private readonly IMapper _mapper;

        public AuthorService(IAuthorRepository authorRepo,
                             IMapper mapper)
        {
            _authorRepo = authorRepo;
            _mapper = mapper;
            
        }
        public async Task CreateAsync(AuthorCreateDto model)
        {
           var data =_mapper.Map<Author>(model);
           await _authorRepo.CreateAsync(data);
        }

        public async  Task DeleteAsync(int id)
        {
            var existAuthor=  await _authorRepo.GetById(id);
            await _authorRepo.DeleteAsync(existAuthor);
        }

        public async Task EditAsync(AuthorEditDto model,int id)
        {
           var existAuthor = await _authorRepo.GetById(id);
            _mapper.Map(model, existAuthor);
           await _authorRepo.EditAsync(existAuthor);
        }

        public async Task<IEnumerable<AuthorDto>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<AuthorDto>>(await _authorRepo.GetAllAsync());
        }

        public async Task<AuthorDto> GetByIdAsync(int id)
        {
            return _mapper.Map<AuthorDto>(await _authorRepo.GetById(id));
        }
    }
}
