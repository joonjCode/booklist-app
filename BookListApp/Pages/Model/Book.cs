using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListApp.Pages.Model
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name{ get; set; }

        public string Author { get; set; }

         // 테이블 추가 및 수정해야할 경우 
         public string ISBN { get; set; }
    }
}
