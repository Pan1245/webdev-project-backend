using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace houseofgriffin_api.Models
{
    public class WorkTime
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string day { get; set; } = string.Empty;
        private TimeOnly _fromTime;
        [Required]
        public string fromTime { get { return _fromTime.ToString("HH:mm"); } set { _fromTime = TimeOnly.Parse(value); } }
        private TimeOnly _toTime;
        [Required]
        public string toTime { get { return _toTime.ToString("HH:mm"); } set { _toTime = TimeOnly.Parse(value); } }
        public int teacherId { get; set; }
        public Teacher? teacher { get; set; }
    }
}