using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookshelfWF
{
    /// <summary>
    /// Описание объектов каталога.
    /// </summary>
    internal class Book
    {
        /// <summary>
        /// Идентификатор для работы с БД.
        /// </summary>
        private int id;
        
        /// <summary>
        /// Автор книги.
        /// </summary>
        private string author;
        
        /// <summary>
        /// Название книги.
        /// </summary>
        private string title;
        
        /// <summary>
        /// Жанр книги.
        /// </summary>
        private string genre;
        
        /// <summary>
        /// Год издательства книги.
        /// </summary>
        private string year;
        
        /// <summary>
        /// Рейтинг (оценка) книги. 
        /// </summary>
        private string raiting;
        
        /// <summary>
        /// Краткая аннотация книги.
        /// </summary>
        private string description;
        
        /// <summary>
        /// Имя файла книги (при наличии).
        /// </summary>
        private string filename;
        
        /// <summary>
        /// Содержимое файла книги.
        /// </summary>
        private byte[] filedata;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public string Year
        {
            get { return year; }
            set { year = value; }
        }

        public string Raiting
        {
            get { return raiting; }
            set { raiting = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string FileName
        {
            get { return filename; }
            set { filename = value; }
        }

        public byte[] FileData
        {
            get { return filedata; }
            set { filedata = value; }
        }
    }
}
