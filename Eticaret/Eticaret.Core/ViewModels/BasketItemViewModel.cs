using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Core.ViewModels
{
    public class BasketItemViewModel
    {
        public string Id { get; set; }
        [DisplayName("Ürün Sayısı")]
        public int Quanity { get; set; }
        [DisplayName("Ürün Adı")]
        public string ProductName { get; set; }
        [DisplayName("Fiyat")]
        public decimal Price { get; set; }
        [DisplayName("Ürün Resmi")]
        public string Image { get; set; }
    }
}
