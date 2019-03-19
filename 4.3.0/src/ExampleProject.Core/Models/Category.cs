using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.Models
{
    public class Category : FullAuditedEntity
    {
        public Category()
        {
            Books = new HashSet<Book>();
        }
        [Required]
        public string DisplayName { get; set; }
        public virtual ICollection<Book> Books { get; set; }

    }
}
