using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Core.Models
{
    public class Customer : BaseEntity
    {
        public string UserId { get; set; }
        [DisplayName("Ad")]
        public string FirstName { get; set; }
        [DisplayName("Soyad")]
        public string LastName { get; set; }
        public string Email { get; set; }
        [DisplayName("Sokak")]
        public string Street { get; set; }
        [DisplayName("Şehir")]
        public string City { get; set; }
        [DisplayName("Mahalle")]
        public string State { get; set; }
        [DisplayName("Zip Kodu")]
        public string ZipCode { get; set; }
    }
}
