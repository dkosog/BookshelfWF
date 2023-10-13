using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.IO;

namespace BookshelfWF
{
    /// <summary>
    /// Работа с базой данных
    /// </summary>
    internal class DbWork
    {
        //internal static string pathDB = Path.Combine(Application.StartupPath, "dbase.db");
        private static string pathDB = "Data Source=dbase.db";

        /// <summary>
        /// Создание новой пустой БД.
        /// </summary>
        internal static void CreateDB()
        {
                 using (var con = new SQLiteConnection("Data Source=dbase.db"))

                 {
                        con.Open();
                        SQLiteCommand cmd = new SQLiteCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "CREATE TABLE TB_BOOKS (Id INTEGER NOT NULL UNIQUE, Author TEXT, Title TEXT, Genre TEXT, Year TEXT, " +
                                           "Raiting TEXT, Description TEXT, FileName	TEXT, FileData	BLOB, PRIMARY KEY(Id AUTOINCREMENT));";
                        {
                            try
                            {
                                cmd.ExecuteNonQuery();
                                 MessageBox.Show(pathDB);
                            }
                           catch (Exception ex)
                            {
                            MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                            con.Close();
                            }

                        }
                 }
        }

        /// <summary>
        /// Загрузка всех книг из БД.
        /// </summary>
        /// <returns>Все книги без содержимого файлов книг.</returns>
        internal static DataTable GetBooks()
        {
            if (!File.Exists(pathDB)) 
            {
            CreateDB();
            }
            DataTable books = new DataTable();
            try
            {
                
                using (SQLiteConnection con = new SQLiteConnection(string.Format(pathDB)))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand(@"SELECT Id, Author, Title, Genre, Year, Raiting, Description, FileName FROM TB_BOOKS order by Author;", con);
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                    da.Fill(books);
                    return books;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return books;
                    }
                }

        /// <summary>
        /// Загрузка из БД одной записи.
        /// </summary>
        /// <param name="SelectedId">Id записи для выгрузки.</param>
        /// <returns>Одна запись, включая содержимое файла книги.</returns>
        internal static List<Book> GetBook(int SelectedId)
        {
            
            List<Book> books = new List<Book>();
            try
            {

                using (SQLiteConnection con = new SQLiteConnection(string.Format(pathDB)))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Connection = con;
                    cmd.CommandText = @"SELECT * FROM TB_BOOKS WHERE ID=@SelectedId";
                    cmd.Parameters.Add(new SQLiteParameter("@SelectedId", SelectedId));
                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            var id = rdr.GetInt32(0);
                            var author = rdr.GetString(1);
                            var title = rdr.GetString(2);
                            var genre = rdr.GetString(3);
                            var year = rdr.GetString(4);
                            var raiting = rdr.GetString(5);
                            var description = rdr.GetString(6);
                            var filename = rdr.GetString(7);
                            var filedata = (byte[])rdr.GetValue(8);

                            Book bk = new Book 
                            { Id = id, Author = author, Title = title, Genre = genre, Year = year, Raiting = raiting,
                               Description=description,  FileName = filename, FileData=filedata };
                            books.Add(bk);

                        }
                        return books;
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return books;
            }
        }

        /// <summary>
        /// Добавление запись в БД.
        /// </summary>
        /// <param name="book">Коллекция полей класса Book.</param>
        internal static void AddBook(Book book)
        {
            List<Book> books = new List<Book>();
            if (book.FileName == null || book.FileName=="") 
            { 
                book.FileName = "none"; 
            }
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(string.Format(pathDB)))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Connection = con;
                    cmd.CommandText = @"INSERT INTO TB_BOOKS (Author, Title, Genre, Year, Raiting, Description, FileName, FileData)
                                                            VALUES (@Author, @Title, @Genre, @Year, @Raiting, @Description, @FileName, @FileData)";
                    cmd.Parameters.Add(new SQLiteParameter("@Author", book.Author));
                    cmd.Parameters.Add(new SQLiteParameter("@Title", book.Title));
                    cmd.Parameters.Add(new SQLiteParameter("@Genre", book.Genre));
                    cmd.Parameters.Add(new SQLiteParameter("@Year", book.Year));
                    cmd.Parameters.Add(new SQLiteParameter("@Raiting", book.Raiting));
                    cmd.Parameters.Add(new SQLiteParameter("@Description", book.Description));
                    cmd.Parameters.Add(new SQLiteParameter("@FileName", book.FileName));
                    cmd.Parameters.Add(new SQLiteParameter("@FileData", book.FileData));
                    int number = cmd.ExecuteNonQuery();
                    MessageBox.Show("Добавлено записей: " + number.ToString());
                }
            }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
        }

        /// <summary>
        /// Удаление записи из БД.
        /// </summary>
        /// <param name="id">Идентификатор записи которая должна бытьудалена</param>
        internal static void DelBook(int id)
        {
            
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(string.Format(pathDB)))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Connection = con;
                    cmd.CommandText = @"DELETE FROM TB_BOOKS WHERE ID=@Id";
                    cmd.Parameters.Add(new SQLiteParameter("@Id", id));
                    int number = cmd.ExecuteNonQuery();
                    MessageBox.Show("Удалено записей: " + number.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
    }
