using Fundamentals_entity_framework.Data;
using Fundamentals_entity_framework.Models;
using System;

namespace Fundamentals_entity_framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BlogDataContext())
            {
                var tag = new Tag() { Name = "AspNet", Slug = "aspnet-core" };
                context.Tags.Add(tag);
                context.SaveChanges();
            }
        }
    }
}
