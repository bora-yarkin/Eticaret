using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Core.Models
{
    public class Order : BaseEntity
    {
        public Order()
        {
            this.OrderItems = new List<OrderItem>();
        }
        [DisplayName("Ad")]
        public string FirstName { get; set; }
        [DisplayName("Soyad")]
        public string Surname { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("Sokak")]
        public string Street { get; set; }
        [DisplayName("Şehir")]
        public string City { get; set; }
        [DisplayName("Mahalle")]
        public string State { get; set; }
        [DisplayName("Zip Kodu")]
        public string ZipCode { get; set; }
        [DisplayName("Sipariş Durumu")]
        public string OrderStatus { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
