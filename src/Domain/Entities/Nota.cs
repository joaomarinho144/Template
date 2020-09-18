using Domain.Common;
using System;

namespace Domain.Entities
{
    public class Nota : AuditableEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
