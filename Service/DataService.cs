using Library.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    public class DataService
    {
        private readonly DbRepository db;

        public DataService()
        {
            db = new DbRepository();
        }

        // Genre methods

        public List<Genre> GetAllGenres()
        {
            return db.Genres.ToList();
        }

        // Book methods

        public List<Book> GetAllBooks()
        {
            return db.Books.ToList();
        }

        // Reader methods

        public List<Reader> GetAllReaders()
        {
            return db.Readers.ToList();
        }

        // Rent methods

        public List<Rent> GetAllRents()
        {
            return db.Rents.ToList();
        }

        // Genre methods

        public Genre FindGenreById(int id)
        {
            return db.Genres.Find(id);
        }

        public Genre FindGenreByName(string name)
        {
            return db.Genres.FirstOrDefault(g => g.Name == name);
        }

        public void AddGenre(Genre genre)
        {
            db.Genres.Add(genre);
            db.SaveChanges();
        }

        public void UpdateGenre(Genre genre)
        {
            var existingGenre = db.Genres.Find(genre.Id);
            if (existingGenre != null)
            {
                existingGenre.Name = genre.Name;
                db.SaveChanges();
            }
        }

        public void DeleteGenre(int genreId)
        {
            var genre = db.Genres.Find(genreId);
            if (genre != null)
            {
                db.Genres.Remove(genre);
                db.SaveChanges();
            }
        }

        // Book methods

        public Book FindBookById(int id)
        {
            return db.Books.Find(id);
        }

        public void AddBook(Book book)
        {
            if (string.IsNullOrWhiteSpace(book.Title))
                throw new Exception("Title cannot be null or empty.");

            if (string.IsNullOrWhiteSpace(book.Author))
                throw new Exception("Author cannot be null or empty.");

            if (string.IsNullOrWhiteSpace(book.PublishingHouse))
                throw new Exception("PublishingHouse cannot be null or empty.");

            if (book.ReleaseYear == 0)
                throw new Exception("ReleaseYear cannot be null.");

            if (book.Price == 0)
                throw new Exception("Price cannot be null.");

            if (book.Genre == 0)
                throw new Exception("Genre cannot be null.");

            db.Books.Add(book);
            db.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            var existingBook = db.Books.Find(book.Id);
            if (existingBook != null)
            {
                existingBook.Title = book.Title;
                existingBook.Author = book.Author;
                existingBook.PublishingHouse = book.PublishingHouse;
                existingBook.ReleaseYear = book.ReleaseYear;
                existingBook.Price = book.Price;
                existingBook.Genre = book.Genre;
                db.SaveChanges();
            }
        }

        public void DeleteBook(int bookId)
        {
            var book = db.Books.Find(bookId);
            if (book != null)
            {
                db.Books.Remove(book);
                db.SaveChanges();
            }
        }

        // Reader methods

        public Reader FindReaderById(int id)
        {
            return db.Readers.Find(id);
        }

        public void AddReader(Reader reader)
        {
            db.Readers.Add(reader);
            db.SaveChanges();
        }

        public void UpdateReader(Reader reader)
        {
            var existingReader = db.Readers.Find(reader.Id);
            if (existingReader != null)
            {
                existingReader.Name = reader.Name;
                existingReader.Address = reader.Address;
                existingReader.PhoneNumber = reader.PhoneNumber;
                db.SaveChanges();
            }
        }

        public void DeleteReader(int readerId)
        {
            var reader = db.Readers.Find(readerId);
            if (reader != null)
            {
                db.Readers.Remove(reader);
                db.SaveChanges();
            }
        }

        // Rent methods

        public Rent FindRentById(int id)
        {
            return db.Rents.Find(id);
        }

        public void AddRent(Rent rent)
        {
            db.Rents.Add(rent);
            db.SaveChanges();
        }

        public void UpdateRent(Rent rent)
        {
            var existingRent = db.Rents.Find(rent.Id);
            if (existingRent != null)
            {
                existingRent.Book = rent.Book;
                existingRent.Reader = rent.Reader;
                existingRent.RentDate = rent.RentDate;
                existingRent.ExpectedReturnDate = rent.ExpectedReturnDate;
                existingRent.ReturnDate = rent.ReturnDate;
                db.SaveChanges();
            }
        }

        public void DeleteRent(int rentId)
        {
            var rent = db.Rents.Find(rentId);
            if (rent != null)
            {
                db.Rents.Remove(rent);
                db.SaveChanges();
            }
        }
    }

}
