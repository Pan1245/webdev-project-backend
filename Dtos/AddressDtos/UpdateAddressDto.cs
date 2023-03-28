using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace houseofgriffin_api.Dtos.AddressDtos
{
    public class UpdateAddressDto
    {
        [Required]
        public string address { get; set; } = string.Empty;
        [Required]
        public string subdistrict { get; set; } = string.Empty;
        [Required]
        public string district { get; set; } = string.Empty;
        [Required]
        public string province { get; set; } = string.Empty;
        [Required]
        public string zipcode { get; set; } = string.Empty;
    }
}