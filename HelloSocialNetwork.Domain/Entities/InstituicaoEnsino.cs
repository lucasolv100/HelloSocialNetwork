using System;

namespace HelloSocialNetwork.Domain.Entities
{
    public class InstituicaoEnsino
    {
        public int Id { get; set; }
        public virtual int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public string NomeInstituicao { get; set; }
        public DateTime? DataFormacao { get; set; }
    }
}