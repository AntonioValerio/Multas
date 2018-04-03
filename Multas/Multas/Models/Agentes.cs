using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Multas.Models
{
    public class Agentes
    {

        public Agentes()
        {
            ListaDeMultas = new HashSet<Multas>();
        }
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage =" O {0} é de preenchimento obrigatório")]
        [RegularExpression("[A-ZÀÈÌÒÙÁÉÍÓÚÂÊÎÔÛ][a-záéíóúÀàèìòùâêîôûäëïöüãõç]+ ((|'|-| dos | da | de | e | d'| Mc|)[A-ZÀÈÌÒÙÁÉÍÓÚÂÊÎÔÛ][a-záéíóúÀàèìòùâêîôûäëïöüãõç]+){1,4)", ErrorMessage = "o {0} apenas pode conter letras e espaços em branco.Cada palara começa em Maiúscula ,seguida de minúscula...")]
        public string Nome { get; set; }

        [Required(ErrorMessage = " A {0} é de preenchimento obrigatório")]
        public string Esquadra { get; set; }
        public string Fotografia { get; set; }
        //lista de multas de 'emite'
        public virtual ICollection<Multas> ListaDeMultas { get; set; }
    }
}