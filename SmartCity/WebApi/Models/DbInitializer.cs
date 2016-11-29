using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class DbInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            CategoryInfrastructure Loisir = new CategoryInfrastructure()
            {
                IdCategoryInfrastructure = 1,
                Label = "Loisirs"
            };
            CategoryInfrastructure Restauration = new CategoryInfrastructure()
            {
                IdCategoryInfrastructure = 2,
                Label = "Restaurations"
            };
            CategoryInfrastructure Monument = new CategoryInfrastructure()
            {
                IdCategoryInfrastructure = 3,
                Label = "Monuments"
            };
            CategoryInfrastructure Commerce = new CategoryInfrastructure()
            {
                IdCategoryInfrastructure = 4,
                Label = "Commerces"
            };
            TypeInfrastructure Chinois = new TypeInfrastructure()
            {
                IdTypeInfrastructure = 1,
                Label = "Chinois",
                CategoryInfrastructure = Restauration
            };
            TypeInfrastructure Japonais = new TypeInfrastructure()
            {
                IdTypeInfrastructure = 1,
                Label = "Japonais",
                CategoryInfrastructure = Restauration
            };
            TypeInfrastructure Grec = new TypeInfrastructure()
            {
                IdTypeInfrastructure = 2,
                Label = "Grec",
                CategoryInfrastructure = Restauration
            };
            TypeInfrastructure Mexicain = new TypeInfrastructure()
            {
                IdTypeInfrastructure = 3,
                Label = "Mexicain",
                CategoryInfrastructure = Restauration
            };
            TypeInfrastructure Thai = new TypeInfrastructure()
            {
                IdTypeInfrastructure = 4,
                Label = "Thailendais",
                CategoryInfrastructure = Restauration
            };
            TypeInfrastructure Snack = new TypeInfrastructure()
            {
                IdTypeInfrastructure = 5,
                Label = "Snack",
                CategoryInfrastructure = Restauration
            };

            TypeInfrastructure Alimentation = new TypeInfrastructure()
            {
                IdTypeInfrastructure = 6,
                Label = "Alimentation",
                CategoryInfrastructure = Commerce
            };
            TypeInfrastructure Textile = new TypeInfrastructure()
            {
                IdTypeInfrastructure = 7,
                Label = "Textile",
                CategoryInfrastructure = Commerce
            };
            TypeInfrastructure Bricolage = new TypeInfrastructure()
            {
                IdTypeInfrastructure = 8,
                Label = "Bricolage",
                CategoryInfrastructure = Commerce
            };
            TypeInfrastructure JeuxVideo = new TypeInfrastructure()
            {
                IdTypeInfrastructure = 9,
                Label = "Jeux Video",
                CategoryInfrastructure = Commerce
            };
            TypeInfrastructure Bijoux = new TypeInfrastructure()
            {
                IdTypeInfrastructure = 10,
                Label = "Bijoux",
                CategoryInfrastructure = Commerce
            };
            TypeInfrastructure Boulangerie = new TypeInfrastructure()
            {
                IdTypeInfrastructure = 11,
                Label = "Boulangerie",
                CategoryInfrastructure = Commerce
            };
            TypeInfrastructure Historique = new TypeInfrastructure()
            {
                IdTypeInfrastructure = 12,
                Label = "Historique",
                CategoryInfrastructure = Monument
            };
            TypeInfrastructure Culturel = new TypeInfrastructure()
            {
                IdTypeInfrastructure = 13,
                Label = "Culturel",
                CategoryInfrastructure = Monument
            };
            TypeInfrastructure Bibliotheque = new TypeInfrastructure()
            {
                IdTypeInfrastructure = 14,
                Label = "Bibliotheque",
                CategoryInfrastructure = Monument
            };
            TypeInfrastructure Agora = new TypeInfrastructure()
            {
                IdTypeInfrastructure = 15,
                Label = "Agora",
                CategoryInfrastructure = Monument
            };
            TypeInfrastructure SalleSport = new TypeInfrastructure()
            {
                IdTypeInfrastructure = 16,
                Label = "Salle de Sport",
                CategoryInfrastructure = Loisir
            };
            TypeInfrastructure Italien = new TypeInfrastructure()
            {
                IdTypeInfrastructure = 17,
                Label = "Italien",
                CategoryInfrastructure = Restauration
            };
            User user1 = new User()
            {
                IdUser = 1,
                FirstName = "julien",
                LastName = "heylen",
                Birthday = new DateTime(1995, 11, 15),
                Email = "julien.heylen@hotmail.be",
                isMale = true,
                UserAdress = "chemin des dix bonniers,4",
                UserLocality = "Perwez",
                UserPostalCode = "1360",
                Phone = "0498516704",
                Password = "123"

            };

            context.Users.Add(user1);

            context.CategoryInfrastructures.Add(Loisir);
            context.CategoryInfrastructures.Add(Monument);
            context.CategoryInfrastructures.Add(Commerce);
            context.CategoryInfrastructures.Add(Restauration);
            context.TypeInfrastructures.Add(Chinois);
            context.TypeInfrastructures.Add(Japonais);
            context.TypeInfrastructures.Add(Thai);
            context.TypeInfrastructures.Add(Mexicain);
            context.TypeInfrastructures.Add(Italien);
            context.TypeInfrastructures.Add(Grec);
            context.TypeInfrastructures.Add(Historique);
            context.TypeInfrastructures.Add(Culturel);
            context.TypeInfrastructures.Add(Bricolage);
            context.TypeInfrastructures.Add(Boulangerie);
            context.TypeInfrastructures.Add(Bijoux);
            context.TypeInfrastructures.Add(JeuxVideo);
            context.TypeInfrastructures.Add(Textile);
            context.TypeInfrastructures.Add(Bibliotheque);
            context.TypeInfrastructures.Add(Agora);
            context.TypeInfrastructures.Add(SalleSport);
            context.SaveChanges();
        }

    }
}