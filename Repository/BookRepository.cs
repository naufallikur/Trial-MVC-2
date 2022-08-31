﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingMVC.Models;

namespace TestingMVC.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) && x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id = 1, Title = "MVC", Author = "Naufal"},
                new BookModel(){Id = 2, Title = "MVC", Author = "Naufal"},
                new BookModel(){Id = 3, Title = "C#", Author = "Intan"},
                new BookModel(){Id = 4, Title = "Java", Author = "Ninis"},
                new BookModel(){Id = 5, Title = "PHP", Author = "Fattah"},
            };
        }
    }
}
