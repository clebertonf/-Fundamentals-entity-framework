using Fundamentals_entity_framework.Data;
using Fundamentals_entity_framework.Models;
using System;
using System.Linq;

namespace Fundamentals_entity_framework
{
    internal class Program
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


            }
        }
    }
}
