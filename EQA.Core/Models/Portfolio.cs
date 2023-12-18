using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQA.Core.Models
{
    public class Portfolio : BaseEntity
    {
        [Required]
        [StringLength(maximumLength:21)]
        public string Name { get; set; }
        [StringLength(maximumLength:50)]
        public string Title { get; set; }
        [StringLength(maximumLength: 250)]
        public string Description { get; set; }
        [StringLength(maximumLength: 500)]
        public string ImageUrl { get; set; }        
        [NotMapped]
        public IFormFile? ImageFile { get; set; }
        public object PortfolioIds { get; set; }
    }
}
