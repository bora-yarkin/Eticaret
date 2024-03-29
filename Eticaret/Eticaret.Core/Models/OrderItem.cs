﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Core.Models
{
    public class OrderItem : BaseEntity
    {
        [DisplayName("Sipariş Numarası")]
        public string OrderId { get; set; }
        public string ProductId { get; set; }
        [DisplayName("Ürün Adı")]
        public string ProductName { get; set; }
        [DisplayName("Fiyat")]
        public decimal Price { get; set; }
        [DisplayName("Resim")]
        public string Image { get; set; }
        [DisplayName("Sayı")]
        public int Quanity { get; set; }
    }
}
