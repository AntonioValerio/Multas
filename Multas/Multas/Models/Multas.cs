﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Multas.Models
{
    public class Multas
    {
        [Key]
        public int ID { get; set; }//PK
        public string Infracao { get; set; }
        public decimal ValorMulta { get; set; }
        public DateTime DataMulta { get; set; }
        public string LocalMulta { get; set; }

        //**********************************************
        //representar as chaves forasteira
        //**********************
        //FK para a tabela dos condutores 
        [ForeignKey("Condutor")]
        public int CondutorFK { get; set; }
        public virtual Condutores Condutor { get; set; }
        
        //FK para a tabela agents
        [ForeignKey("Agente")]
        public int AgenteFK { get; set; }
        public virtual Agentes Agente { get; set; }

        //FK para a tabela viatura
        [ForeignKey("Viatura")]
        public int ViaturaFK { get; set; }
        public virtual Viaturas Viatura { get; set; }
    }
}