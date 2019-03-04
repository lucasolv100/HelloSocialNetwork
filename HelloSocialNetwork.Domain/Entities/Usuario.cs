﻿using System;
using HelloSocialNetwork.Domain.Enums;

namespace HelloSocialNetwork.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }
        public string UrlFoto { get; set; }
        public SexoEnum Sexo { get; set; }
    }
}
