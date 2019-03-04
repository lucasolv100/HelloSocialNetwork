﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HelloSocialNetwork.Domain.Entities
{
    public class Postagem
    {
        public int Id { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Texto { get; set; }
    }
}
