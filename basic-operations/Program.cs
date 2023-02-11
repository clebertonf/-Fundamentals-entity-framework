using basic_operations.Data;
using basic_operations.Models;
using System;

namespace basic_operations
{
    public class Program
    {
        static void Main(string[] args)
        {
            // using (var context = new BlogDataContext()) { };

           using var context = new BlogDataContext();

            var user = new User()
            {
                Name = "Cleberton",
                Slug = "clebertoFrancisco",
                Email = "cleberton@gmail.com",
                Bio = "programador back-end",
                Image = "https://www.instagram.com/cleberton_dev/",
                PasswordHash = "123321558899"
            };

            var category = new Category 
            { 
                Name = "Backend", 
                Slug = "backend" 
            };

            var post = new Post
            {
                Author = user,
                Category = category,
                Body = "<p>Hello world</p>",
                Slug = "comecando-com-ef-core",
                Summary = "Neste artigo vamos aprender EF core",
                Title = "Começando com EF Core",
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
            };

            context.Posts.Add(post);
            context.SaveChanges();
        }
    }
}
