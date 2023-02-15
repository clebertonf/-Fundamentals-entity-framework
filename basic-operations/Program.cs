using basic_operations.Data;
using basic_operations.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace basic_operations
{
    public class Program
    {
        static void Main(string[] args)
        {
            // using (var context = new BlogDataContext()) { };

            // insert com sub conjuntos
           using var context = new BlogDataContext();

            //var user = new User()
            //{
            //    Name = "Cleberton",
            //    Slug = "clebertoFrancisco",
            //    Email = "cleberton@gmail.com",
            //    Bio = "programador back-end",
            //    Image = "https://www.instagram.com/cleberton_dev/",
            //    PasswordHash = "123321558899"
            //};

            //var category = new Category 
            //{ 
            //    Name = "Backend", 
            //    Slug = "backend" 
            //};

            //var post = new Post
            //{
            //    Author = user,
            //    Category = category,
            //    Body = "<p>Hello world</p>",
            //    Slug = "comecando-com-ef-core",
            //    Summary = "Neste artigo vamos aprender EF core",
            //    Title = "Começando com EF Core",
            //    CreateDate = DateTime.Now,
            //    LastUpdateDate = DateTime.Now,
            //};

            //context.Posts.Add(post);
            //context.SaveChanges();

            // List

            var posts = context.Posts
                .AsNoTracking()
                .Include(x => x.Author) // executa um join
                .Include(x => x.Category)
                .OrderByDescending(x => x.LastUpdateDate)
                .ToList();

            foreach(var post in posts)
                Console.WriteLine($"{post.Title} escrito por {post.Author?.Name} seu id: {post.Author.Id} escrito na categororia {post.Category?.Name}"); // caso não exista autor retorna vazio
        }
    }
}