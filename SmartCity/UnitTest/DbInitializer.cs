using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class DbInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            User user = new User()
            {
                IdUser = 1,
                FirstName = "julien",
                LastName = "heylen",
                Birthday = new DateTime(1995,11,15),
                Email="julien.heylen@hotmail.be",
                isMale=true,
                UserAdress="chemin des dix bonniers,4",
                UserLocality="Perwez",
                UserPostalCode= "1360",
                Phone="0498516704",
                Password="123"

            };
            CategoryInfrastructure categoryInfrastructure1 = new CategoryInfrastructure()
            {
                IdCategoryInfrastructure=1,
                Label="Magasin"
            };
            CategoryInfrastructure categoryInfrastructure2 = new CategoryInfrastructure()
            {
                IdCategoryInfrastructure = 2,
                Label = "Restaurant"
            };
            TypeInfrastructure typeInfrastructure = new TypeInfrastructure()
            {
                IdTypeInfrastructure=1,
                Label="Chinois",
                CategoryInfrastructure = categoryInfrastructure2
            };
            Infrastructure Infrastructure1 = new Infrastructure()
            {
                IdInfrastructure = 1,
                Name = "hong",
                InfraAddress = "rue",
                InfraLocality = "namur",
                InfraPostalCode = "5023",
                GeolactionX=50.55555,
                GeolactionY=4.00000,
                TypeInfrastructure = typeInfrastructure

            };

            context.Users.Add(user);
            context.CategoryInfrastructures.Add(categoryInfrastructure1);
            context.CategoryInfrastructures.Add(categoryInfrastructure2);
            context.TypeInfrastructures.Add(typeInfrastructure);
            context.Infrastructures.Add(Infrastructure1);
            context.SaveChanges();
        }

    }
}
