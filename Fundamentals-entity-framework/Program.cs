using Fundamentals_entity_framework.Data;
using Fundamentals_entity_framework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Fundamentals_entity_framework
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BlogDataContext())
            {
                // Add
                //var tag = new Tag() { Name = "AspNet", Slug = "aspnet-core" };
                //context.Tags.Add(tag);
                //context.SaveChanges();

                // Update
                //var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
                //tag.Slug = "aspnetcore";

                //context.Update(tag);
                //context.SaveChanges();

                // Delete
                //var tag = context.Tags.FirstOrDefault(x => x.Id == 2);

                //context.Tags.Remove(tag);
                //context.SaveChanges();

                // List

                // var tags = context.Tags.AsNoTracking().ToList(); // To list sempre no final das tags, pois é onde a query de fato é executada
                // AsNoTracking() não trackeia os dados, não traz metadados, dando performace.
                //  AsNoTracking() usado somente em select
                // Se for fazer um update ou delete não use AsNoTracking() no select antes

                //foreach (var tag in tags)
                //{
                //    Console.WriteLine(tag.Name);
                //}

                // Todos métodos de lista executam de fato a query no banco, então sempre devem ser po ultimo
                // .ToList(), .FirstOrDefault() etc ...
                var tag = context.Tags.AsNoTracking().FirstOrDefault(x => x.Id == 3);

                Console.WriteLine(tag?.Name);
            }
        }
    }
}
