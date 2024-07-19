using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandas
{
    public class Usuario
    {
        //propriedades  da classe
        //colunas da tabala Usuarios

        [Key]//chave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//Incrementa Automaticamente
        public int id { get; set; }
        public string Nome { get; set; } = string.Empty;  
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
    }

}
