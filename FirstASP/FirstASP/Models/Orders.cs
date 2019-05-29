using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstASP.Models
{
    public class Orders
    {
        public int id { get; set; }
        public int good_id { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "Длина строки должна быть от 10 до 50 символов")]
        public string FIO { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "Длина строки должна быть от 10 до 50 символов")]
        public string number { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "Длина строки должна быть от 10 до 50 символов")]
        public string adress { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "Длина строки должна быть от 10 до 50 символов")]
        public string email { get; set; }
        public DateTime date { get; set; }

    }
}