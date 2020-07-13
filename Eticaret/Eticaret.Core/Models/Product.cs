using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Core.Models
{
    public class Product : BaseEntity
    {

        [DisplayName("Ürün Adı")]
        public string Name { get; set; }
        [DisplayName("Açıklama")]
        public string Description { get; set; }
        [DisplayName("Fiyat")]
        public decimal Price { get; set; }
        [DisplayName("Kategori")]
        public string Category { get; set; }
        [DisplayName("Resim")]
        public string Image { get; set; }

    }
}
