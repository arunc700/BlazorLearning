using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppDemo.Data
{

    public class Author
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Please enter valid email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Salary is required")]
        [Range(1, 1000, ErrorMessage = "Salary should be in between 0 to 1000")]
        public int Salary { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        public DateTime DateOfBirth { get; set; }

        public string City { get; set; }
    }

    public interface IAuthor
    {
        public List<Author> GetAuthorAsync();
        public Author GetAuthorByIdAsync(int id);
        void SaveAuthor(Author author);

    }

    public class AuthorData : IAuthor
    {
        public int CreatedDate { get; set; }
        public List<Author> AuthorList = new List<Author>();


        public AuthorData()
        {
            AuthorList.Add(new Author() { ID = 1, Name = "Arun", Email = "arun@gmail.com", City = "Delhi", Salary = 300, DateOfBirth = DateTime.Now.Date });
            AuthorList.Add(new Author() { ID = 2, Name = "Ram", Email = "arun@gmail.com", City = "Delhi", Salary = 400, DateOfBirth = DateTime.Now.Date });
            AuthorList.Add(new Author() { ID = 3, Name = "Pankaj", Email = "arun@gmail.com", City = "Delhi", Salary = 450, DateOfBirth = DateTime.Now.Date });
            AuthorList.Add(new Author() { ID = 4, Name = "Kevin", Email = "arun@gmail.com", City = "Delhi", Salary = 500, DateOfBirth = DateTime.Now.Date });
        }

        public List<Author> GetAuthorAsync()
        {
            return AuthorList;
        }

        public Author GetAuthorByIdAsync(int id)
        {
            return AuthorList.Where(x => x.ID == id).FirstOrDefault();
        }
        public void SaveAuthor(Author author)
        {
            AuthorList.Add(author);
        }

    }
}
