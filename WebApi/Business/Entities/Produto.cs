using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Business.Entities
{
    public class Produto
    {
        [Key]
        public long ID { get; set; }
        public String Descricao { get; set; }
        public long Preco { get; set; }
    }
}