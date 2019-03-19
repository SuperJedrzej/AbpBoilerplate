using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.Models
{
    public class Book : FullAuditedEntity
    {
        [Required]
        public string DisplayName { get; set; }
        public int? TotalPagenumber { get; set; }

        [ForeignKey("Author")]
        public int AuthorId{ get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
    }
}
