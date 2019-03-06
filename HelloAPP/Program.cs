using HelloSocialNetwork.Domain.Entities;
using HelloSocialNetwork.Infra.CrossCutting.Loggin;
using HelloSocialNetwork.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using System;

namespace HelloAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            var usuario = new Usuario {
                Nome = "Lucas",
                SobreNome = "Souza",
                Email = "teste@teste.com",
                Senha = "tetse@teste123",
                UrlFoto = "tesakdjajsk",
                Sexo = HelloSocialNetwork.Domain.Enums.SexoEnum.Maculino,
                DataNascimento = Convert.ToDateTime("26/11/1992")
            };


            var optionsBuilder = new DbContextOptionsBuilder<HelloSocialNetworkContext>();
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseMySql("Server=localhost;userid=root;password=;database=HelloDB", m => m.MigrationsAssembly("HelloSocialNetwork.Infra.Data"));

            try
            {
                using (var dbcontext = new HelloSocialNetworkContext(optionsBuilder.Options))
                {
                    dbcontext.GetService<ILoggerFactory>().AddProvider(new Logger());
                    dbcontext.Usuarios.Add(usuario);
                    dbcontext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
                Console.ReadKey();
            }
            
        }
    }
}
