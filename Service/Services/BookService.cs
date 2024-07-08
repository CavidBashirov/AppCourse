using AutoMapper;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Repository.Repositories.Interfaces;
using Service.DTOs.Admin.Books;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepo;
        private readonly IMapper _mapper;

        public BookService(IBookRepository bookRepo,
                           IMapper mapper)
        {
            _bookRepo = bookRepo;
            _mapper = mapper;            
        }


        public async Task<IEnumerable<BookDto>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<BookDto>>(await _bookRepo.GetAllAsync());
        }
    }
}
