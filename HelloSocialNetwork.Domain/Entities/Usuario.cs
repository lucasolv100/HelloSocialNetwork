﻿using System;
using System.Collections.Generic;
using HelloSocialNetwork.Domain.Enums;

namespace HelloSocialNetwork.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }
        public string UrlFoto { get; set; }
        public SexoEnum Sexo { get; set; }
        
        public virtual Identificacao Identificacao { get; set; }
        public virtual StatusRelacionamento StatusRelacionamento { get; set; }
        public virtual ProcurandoPor ProcurandoPor { get; set; }
        public virtual ICollection<Postagem> Postagens { get; set; }
        public virtual ICollection<Comentario> Comentarios { get; set; }
        public virtual ICollection<LocalTrabalho> LocalTrabalho { get; set; }
        public virtual ICollection<InstituicaoEnsino> InstituicaoDeEnsino { get; set; }
        public virtual ICollection<Amigo> Amigos { get; set; }
        public virtual ICollection<UsuarioGrupo> UsuarioGrupos { get; set; }

        public Usuario()
        {
            Postagens = new List<Postagem>();
            UsuarioGrupos = new List<UsuarioGrupo>();
            LocalTrabalho = new List<LocalTrabalho>();
            InstituicaoDeEnsino = new List<InstituicaoEnsino>();
            Amigos = new List<Amigo>();
            Comentarios = new List<Comentario>();
        }

    }
}
