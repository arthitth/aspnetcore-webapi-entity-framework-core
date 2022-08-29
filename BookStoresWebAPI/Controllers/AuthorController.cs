using BookStoresWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoresWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Author> Get()
        {
            using (var context = new BookStoreDBContext())
            {
                //get all author
                return context.Authors.ToList();

                //get author by id
                //return context.Author.Where(auth => auth.AuthorId == 1).ToList();

                //add a author
                //Author author = new Author();
                //author.FirstName = "Arthit";
                //author.LastName = "Th";
                //context.Author.Add(author);
                //context.SaveChanges();
                //return context.Author.Where(auth => auth.FirstName == "Arthit").ToList();

                //update
                //Author author = context.Author.Where(auth => auth.FirstName == "Arthit").FirstOrDefault();
                //author.Phone = "084-118-3938";
                //context.SaveChanges();
                //return context.Author.Where(auth => auth.FirstName == "arthit").ToList();

                //delete
                //Author author = context.Authors.Where(auth => auth.FirstName == "Arthit").FirstOrDefault();
                //context.Remove(author);
                //context.SaveChanges();
                //return context.Authors.Where(auth => auth.FirstName == "arthit").ToList();

                //Scaffold-DbContext "Server=.\SQLExpress;Database=BookStoresDB;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer - OutputDir Models

                //Scaffold-DbContext "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookStoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -force

                //Scaffold-DbContext - Connection Name = BookStoresDB Microsoft.EntityFrameworkCore.SqlServer - OutputDir Models - force
            }
        }
    }
}
