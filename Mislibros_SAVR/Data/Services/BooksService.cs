﻿using Mislibros_SAVR.Data.viewModels;
using Mislibros_SAVR.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Mislibros_SAVR.Data.Services
{
    public class BooksService
    {
        private AppDbContext _context;
        public BooksService(AppDbContext context)
        {
            _context = context;
        }

        //Metodo que permite agregar un nuevo libro en la BD
        /*public void AddBook(BookVM book)
        {
            var _book = new Books()
            {
                Titulo = book.Titulo,
                Descripcion = book.Descripcion,
                IsRead = book.IsRead,
                DateRead = book.DateRead,
                Rate = book.Rate,
                Genero = book.Autor,
                CoverUrl = book.CoverUrl,
                DateAdded = DateTime.Now,

            };
            _context.Books.Add(_book);
            _context.SaveChanges();
        }*/
        public void AddBookWhitAuthors(BookVM book)
        {
            var _book = new Books()
            {
                Titulo = book.Titulo,
                Descripcion = book.Descripcion,
                IsRead = book.IsRead,
                DateRead = book.DateRead,
                Rate = book.Rate,
                Genero = book.Genero,
                CoverUrl = book.CoverUrl,
                DateAdded = DateTime.Now,
                PublisherId = book.PublisherId

            };
            _context.Books.Add(_book);
            _context.SaveChanges();

            foreach(var id in book.AutorIDs)
            {
                var _book_author = new Book_Author()
                {
                    BookId = _book.id,
                    AuthorId  = id 
                };
                _context.Book_Authors.Add(_book_author);
                _context.SaveChanges(); 
            }
        }
        //Metodo que permite obtener una lista de todos los libro en la BD
        public List<Books> GetAllBks() => _context.Books.ToList();
        //Metodo para devolver un libro de la BD que fue solicitado
        public Books GetBookById(int bookid) => _context.Books.FirstOrDefault(n => n.id == bookid);
        //Metodo para modificar todos los libros de la BD
        public Books UpdateBookByID(int bookid, BookVM book)
        {
            var _book = _context.Books.FirstOrDefault(n => n.id == bookid);
            if(_book != null)
            {
                _book.Titulo = book.Titulo;
                _book.Descripcion = book.Descripcion;
                _book.IsRead = book.IsRead;
                _book.DateRead = book.DateRead;
                _book.Rate = book.Rate;
                _book.Genero = book.Genero;
                _book.CoverUrl = book.CoverUrl;
                _context.SaveChanges();
            }
            return _book;
        }

        public void DeleteBookById(int bookid)
        {
            var _book = _context.Books.FirstOrDefault(n => n.id == bookid);
            if(_book != null)
            {
                _context.Books.Remove(_book);
                _context.SaveChanges();
            }
        }

    }
}
