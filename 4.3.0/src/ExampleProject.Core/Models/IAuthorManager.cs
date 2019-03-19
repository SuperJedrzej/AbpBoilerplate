using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Services;

namespace ExampleProject.Models
{
    public interface IAuthorManager : IDomainService
    {
        IEnumerable<Author> GetAllList();
        Author GetAuthorbyID(int id);
        Task<Author> Create(Author entity);
        void Update(Author entity);
        void Delete(int id);
    }
}
