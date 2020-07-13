using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Core.Models
{
    public class ProductCategory : BaseEntity
    {
        [DisplayName("Kategori")]
        public string Category { get; set; }

    }
}
