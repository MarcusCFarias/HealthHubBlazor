using HealthHubBlazor.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HealthHubBlazor.Data.Configurations
{
    public class DbInitializer
    {
        private readonly ModelBuilder _modelBuilder;
        public DbInitializer(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }
        internal void seed()
        {
            string idRoleReceptionist = Guid.NewGuid().ToString();
            string idRoleDoctor = Guid.NewGuid().ToString();
            string idReceptionist = Guid.NewGuid().ToString();

            _modelBuilder.Entity<IdentityRole>().HasData
            (
                new IdentityRole
                {
                    Id = idRoleReceptionist,
                    Name = "Atendente",
                    NormalizedName = "ATENDENTE"
                },
                new IdentityRole
                {
                    Id = idRoleDoctor,
                    Name = "Médico",
                    NormalizedName = "MÉDICO"
                }
            );

            var hasher = new PasswordHasher<IdentityUser>();

            _modelBuilder.Entity<Receptionist>().HasData
                (
                    new Receptionist
                    {
                        Id = idReceptionist,
                        Name = "Pro Consulta",
                        Email = "proconsulta@hotmail.com",
                        EmailConfirmed = true,
                        UserName = "proconsulta@hotmail.com",
                        NormalizedEmail = "PROCONSULTA@HOTMAIL.COM",
                        NormalizedUserName = "PROCONSULTA@HOTMAIL.COM",
                        PasswordHash = hasher.HashPassword(null, "ProConsulta123"),
                    }
                );

            _modelBuilder.Entity<IdentityUserRole<string>>().HasData
                (
                    new IdentityUserRole<string>
                    {
                        RoleId = idRoleReceptionist,
                        UserId = idReceptionist
                    }
                );

            _modelBuilder.Entity<Specialty>().HasData
                (
                    new Specialty
                    {
                        Id = 1,
                        Name = "Cardiologia",
                        Description = "Especialidade médica que se ocupa do diagnóstico e tratamento das doenças que acometem o coração bem como os outros componentes do sistema circulatório."
                    },
                    new Specialty
                    {
                        Id = 2,
                        Name = "Dermatologia",
                        Description = "Especialidade médica que se ocupa do diagnóstico e tratamento clínico-cirúrgico das doenças de pele, mucosas, cabelo e unhas."
                    },
                    new Specialty
                    {
                        Id = 3,
                        Name = "Endocrinologia",
                        Description = "Especialidade médica que estuda as ordens do sistema endócrino e suas secreções específicas chamadas de secreções fisiológicas."
                    },
                    new Specialty
                    {
                        Id = 4,
                        Name = "Gastroenterologia",
                        Description = "Especialidade médica que se ocupa do estudo, diagnóstico e tratamento clínico das doenças do aparelho digestivo."
                    }


                );
        }
    }
}
