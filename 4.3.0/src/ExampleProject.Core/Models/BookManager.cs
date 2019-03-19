using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.Models
{
    public class BookManager : DomainService, IBookManager
    {
        private readonly IRepository<Book> _repositoryBook;
        public BookManager(IRepository<Book> repositoryBook)
        {
            _repositoryBook = repositoryBook;
        }

        public async Task<Book> Create(Book entity)
        {
            var book = _repositoryBook.FirstOrDefault(x => x.Id == entity.Id);
            if (book != null)
            {
                throw new UserFriendlyException("Already exists");
            }
            else
            {
                return await _repositoryBook.InsertAsync(entity);
            }
        }

        public void Delete(int id)
        {
            var book = _repositoryBook.FirstOrDefault(x => x.Id == id);
            if (book == null)
            {
                throw new UserFriendlyException("No data found");
            }
            else
            {
                _repositoryBook.Delete(book.Id);
            }
        }

        public IEnumerable<Book> GetAllList()
        {
            return _repositoryBook.GetAll();
        }

        public Book GetBookByID(int id)
        {
            return _repositoryBook.Get(id);
        }

        public void Update(Book entity)
        {
            _repositoryBook.Update(entity);
        }
    }
}
