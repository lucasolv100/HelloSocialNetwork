using System;

namespace HelloSocialNetwork.Domain.Entities
{
    public class Comentario
    {
        public int Id { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Texto { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; private set; }
        public int PostagemId { get; set; }
        public virtual Postagem Postagem { get; set; }

        public Comentario()
        {
            DataPublicacao = DateTime.Now;
        }

        public void SetUsuario(Usuario usuario)
        {
            if(usuario != null)
            {
                Usuario = usuario;
            }
        }
    }
}