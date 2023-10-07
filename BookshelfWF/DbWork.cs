using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace BookshelfWF
{
    internal class DbWork
    {
        //internal static string pathDB = Path.Combine(Application.StartupPath, "dbase.db");
        private static string pathDB = "Data Source=dbase.db";

        internal static void CreateDB()
        {
                 using (var con = new SQLiteConnection("Data Source=dbase.db"))

                 {
                        con.Open();
                        SQLiteCommand cmd = new SQLiteCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "CREATE TABLE TB_BOOKS (Id INTEGER NOT NULL UNIQUE, Author TEXT, Title TEXT, " +
                                           "FileName	TEXT, FileData	BLOB, PRIMARY KEY(Id AUTOINCREMENT));";
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

        internal static BindingList<Book> GetBooks()
        {
            //if (!File.Exists(pathDB)) 
            //{
            //CreateDB();
            //}
            BindingList<Book> books = new BindingList<Book>();
            try
            {
                
                using (SQLiteConnection con = new SQLiteConnection(string.Format(pathDB)))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand(@"SELECT Id, Author, Title, FileName FROM TB_BOOKS;", con);
                    
                        using (var rdr = cmd.ExecuteReader())
                        {

                            while (rdr.Read())
                            {
                                var id = rdr.GetInt32(0);
                                var author = rdr.GetString(1);
                                var title = rdr.GetString(2);
                                var filename = rdr.GetString(3);
                                //var filedata = (byte[])rdr.GetValue(4);

                                Book bk = new Book { Id = id, Author = author, Title = title, FileName = filename};
                                books.Add(bk);

                            }
                            return books;
                        }
                    

                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return books;
                    }
                }

        internal static BindingList<Book> GetBook(int SelectedId)
        {
            //if (!File.Exists(pathDB)) 
            //{
            //CreateDB();
            //}
            BindingList<Book> books = new BindingList<Book>();
            try
            {

                using (SQLiteConnection con = new SQLiteConnection(string.Format(pathDB)))
                {
                    con.Open();
                    //string query = "SELECT * FROM TB_BOOKS WHERE ID=7"; //WHERE Id = " + SelectedId;
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Connection = con;
                    cmd.CommandText = @"SELECT * FROM TB_BOOKS WHERE ID=@SelectedId";
                    cmd.Parameters.Add(new SQLiteParameter("@SelectedId", SelectedId));
                    //cmd.ExecuteNonQuery();
                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            var id = rdr.GetInt32(0);
                            var author = rdr.GetString(1);
                            var title = rdr.GetString(2);
                            var filename = rdr.GetString(3);
                            var filedata = (byte[])rdr.GetValue(4);

                            Book bk = new Book { Id = id, Author = author, Title = title, FileName = filename, FileData=filedata };
                            books.Add(bk);

                        }
                        return books;
                    }


                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return books;
            }
        }

        internal static void AddBook(Book book)
        {
            BindingList<Book> books = new BindingList<Book>();
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
                    cmd.CommandText = @"INSERT INTO TB_BOOKS (Author, Title, FileName, FileData)
                                                            VALUES (@Author, @Title, @FileName, @FileData)";
                                cmd.Parameters.Add(new SQLiteParameter("@Author", book.Author));
                                cmd.Parameters.Add(new SQLiteParameter("@Title", book.Title));
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

        ////internal static void AddBooks(string author, string title, string filename, byte[] filedata)
        //internal static void AddBooks(Book book)
        //{
        //    //if (!File.Exists(pathDB)) 
        //    //{
        //    //CreateDB();
        //    //}
        //    try
        //    {
        //        List<Book> books = new List<Book>();
        //        using (SQLiteConnection con = new SQLiteConnection(string.Format($"Data source={pathDB};")))
        //        {
        //            con.Open();
        //            SQLiteCommand cmd = new SQLiteCommand();
        //            cmd.Connection = con;
        //            cmd.CommandText = @"INSERT INTO TB_BOOKS (Author, Title, FileName)
        //                                            VALUES (@Author, @Title, @FileName)";
        //            cmd.Parameters.Add(new SQLiteParameter("@Author", book.Author));
        //            cmd.Parameters.Add(new SQLiteParameter("@Title", book.Title));
        //            cmd.Parameters.Add(new SQLiteParameter("@FileName", book.FileName));
        //            //cmd.Parameters.Add(new SQLiteParameter("@FileData", book.FileData));
        //            int number = cmd.ExecuteNonQuery();
        //            MessageBox.Show("Добавлено записей: " + number.ToString());
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return;
        //    }
        //}

        internal static void DelBook(int id)
        {
            //if (!File.Exists(pathDB)) 
            //{
            //CreateDB();
            //}
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
