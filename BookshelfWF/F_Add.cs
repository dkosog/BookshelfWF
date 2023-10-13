using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookshelfWF
{
    public partial class F_Add : Form
    {
        private byte[] filedata;
        private string filepath;
        public F_Add()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Book files(*.txt;*.pdf;*.doc;*.docx;*.fb2.zip;*.fb2)|*.txt;*.pdf;*.doc;*.docx;*.fb2.zip;*.fb2|All files(*.*)|*.*";

        }

        private void BT_Save_Click(object sender, EventArgs e)
        {
            Book book = new Book 
            { Author = TB_Author.Text, Title = TB_Title.Text, Genre=CB_Genre.Text, Year=TB_Year.Text,
                Raiting=CB_Raiting.Text, Description=TB_Description.Text, FileName = TB_Filename.Text, FileData=filedata };
            if (SharedId.Id != -1)
            { DbWork.DelBook(SharedId.Id); }
            DbWork.AddBook(book);
            this.Close();
        }

        private void BT_File_Delete_Click(object sender, EventArgs e)
        {
            filedata = null;
            TB_Filename.Text = null;
            BT_File_Delete.Enabled = false;
        }

        private void F_Add_Load(object sender, EventArgs e)
        {
            if (SharedId.Id !=-1)
            {
                List<Book> loadedbook = new List<Book>(DbWork.GetBook(SharedId.Id));
                TB_Author.Text = loadedbook[0].Author;
                TB_Title.Text = loadedbook[0].Title;
                CB_Genre.Text = loadedbook[0].Genre;
                TB_Year.Text = loadedbook[0].Year;
                CB_Raiting.Text = loadedbook[0].Raiting;
                TB_Description.Text = loadedbook[0].Description;
                TB_Filename.Text = loadedbook[0].FileName;
                filedata = loadedbook[0].FileData;
                BT_File_Delete.Enabled = false;
                BT_Save.Text = "Сохранить изменения";
                this.Text = "Редактирование книги";
            }
            else
            {
                BT_File_Delete.Enabled = false;
                BT_Save.Text = "Добавить книгу";
                this.Text = "Добавление книги";
            }
            
        }

        private void BT_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_File_Load_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            TB_Filename.Text = openFileDialog1.SafeFileName;
            filepath = openFileDialog1.FileName;
            using (FileStream fs = new FileStream(filepath, FileMode.Open))
            {
                filedata = new byte[fs.Length];
                fs.Read(filedata, 0, filedata.Length);
            }

            if (filepath != null)
            {
                BT_File_Delete.Enabled = true;
            }
            
           
        }
    }
}
