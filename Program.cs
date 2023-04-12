using EFBlog.Data;
using EFBlog.Models;
using Microsoft.EntityFrameworkCore;

namespace EFBlog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BlogDataContext())
            {
                var tag = new Tag { Name = "Asp.NET2", Slug = "aspnet2" };
                context.Tags.Add(tag);
                context.SaveChanges();

                //    var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
                //    tag.Name = "DotNet";
                //    tag.Slug = "dotnet";
                //    context.Update(tag);
                //    context.SaveChanges();

                //    var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
                //    context.Remove(tag);
                //    context.SaveChanges();

                //    ToList() trás todos os registros(deve-se sempre executá-lo por último)
                //    var tags = context.Tags.Where(x => x.Name.Contains(".NET")).ToList();

                //    foreach (var tag in tags)
                //    {
                //        Console.WriteLine(tag.Name);
                //    }

                //    ToList() trás todos os registros(deve-se sempre executá-lo por último)
                //     AsNoTracking() não trás Métadados(usar somente em leituras, ou seja, SELECT)
                //    var tags = context.Tags.AsNoTracking().ToList();

                //    foreach (var tag in tags)
                //    {
                //        Console.WriteLine(tag.Name);
                //    }

                //    O '?' permitirá que o objeto seja nulo sem quebrar a aplicação
                //    var tag = context.Tags.AsNoTracking().FirstOrDefault(x => x.Id == 3);
                //    Console.WriteLine(tag?.Name);

                //    var tags = context.Tags.AsNoTracking();

                //    foreach (var tag in tags)
                //    {
                //        Console.WriteLine(tag.Name);
                //    }

                //    Console.ReadKey();
                //}

                //using var context = new BlogDataContext();

                //var user = new User() 
                //{
                //    Name = "Rafa Malta",
                //    Slug = "rafamalta",
                //    Email = "rafamalta@teste.io",
                //    Bio = "aprendendo EF Core",
                //    Image = "https://balta.io",
                //    PasswordHash = "123098457"
                //};

                //var category = new Category()
                //{
                //    Name = "Backend",
                //    Slug = "backend"                
                //};

                //var post = new Post()
                //{
                //    Author = user,
                //    Category = category,
                //    Body = "<p>Hello World</p>",
                //    Slug = "comecando-com-ef-core",
                //    Summary = "Neste artigo vamos aprender EF Core",
                //    Title = "Começando com EF Core",
                //    CreateDate = DateTime.Now,
                //    LastUpdateDate = DateTime.Now
                //};

                //context.Posts.Add(post);
                //context.SaveChanges();

                //using var context = new BlogDataContext();
                //var posts = context.Posts.AsNoTracking()
                //    .Include(x => x.Author)
                //    .Include(x => x.Category)
                //    .Where(x => x.AuthorId == 1)
                //    .OrderByDescending(x => x.LastUpdateDate)
                //    .ToList();

                //foreach (var post in posts)
                //{
                //    Console.WriteLine($"{post.Title} escrito por {post.Author?.Name} em {post.Category?.Name}");
                //}
                //Console.ReadKey();

                //using var context = new BlogDataContext();
                //var post = context.Posts
                //    .Include(x => x.Author)
                //    .Include(x => x.Category)
                //    .OrderByDescending(x => x.LastUpdateDate)
                //    .FirstOrDefault(); // Pegando o primeiro item

                //post.Author.Name = "Teste";
                //context.Posts.Update(post);
                //context.SaveChanges();
            }
        }
    }
}
