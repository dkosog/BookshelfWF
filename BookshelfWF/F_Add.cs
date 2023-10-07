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
            Book book = new Book { Author = TB_Author.Text, Title = TB_Title.Text, FileName = TB_Filename.Text, FileData=filedata };
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
            BT_File_Delete.Enabled = false;
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
            // читаем файл в строку
           
        }
    }
}
