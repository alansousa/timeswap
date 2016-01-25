//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TimeSwap.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class RECURSO
    {
        public RECURSO()
        {
            this.PROJETO = new HashSet<PROJETO>();
            this.RECURSOHABILIDADE = new HashSet<RECURSOHABILIDADE>();
            this.RECURSOTAREFA = new HashSet<RECURSOTAREFA>();
        }


        [Key]
        public string MATRICULA { get; set; }
        public string NOME { get; set; }
        public int CARGOID { get; set; }
        public string TELEFONE { get; set; }
        public string CPF { get; set; }
        public string LOGIN { get; set; }
        public string SENHA { get; set; }
        public double? HOMEMHORA { get; set; }
        public string EMAIL { get; set; }
    
        public virtual CARGO CARGO { get; set; }
        public virtual ICollection<PROJETO> PROJETO { get; set; }
        public virtual ICollection<RECURSOHABILIDADE> RECURSOHABILIDADE { get; set; }
        public virtual ICollection<RECURSOTAREFA> RECURSOTAREFA { get; set; }
    }
}