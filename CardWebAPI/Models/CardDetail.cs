using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CardWebAPI.Models
{
    public class CardDetail
    {
        [Key]
        public int CataoDetalheId { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório !")]
        [Column(TypeName = "nvarchar(100)")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório !")]
        [Column(TypeName = "nvarchar(16)")]
        public String NumeroCartao { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório !")]
        [Column(TypeName = "nvarchar(5)")]
        public String DataExpiracao { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório !")]
        [Column(TypeName = "nvarchar(3)")]
        public String CodigoSeguranca { get; set; }
    }

}

