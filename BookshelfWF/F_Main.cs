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
    public partial class F_Main : Form
    {
        private BindingList<Book> books;
        public F_Main()
        {
            InitializeComponent();

        }
        private void SetupDataGridView()
        {
            books = new BindingList<Book>(DbWork.GetBooks());
            DGV1.DataSource = books;
            DGV1.AutoGenerateColumns = false;
            DGV1.Columns[0].Visible = false;
            DGV1.Columns[1].HeaderText = "Автор";
            DGV1.Columns[1].Width = 100;
            DGV1.Columns[2].HeaderText = "Название книги";
            DGV1.Columns[3].HeaderText = "Файл книги";
            DGV1.Columns[3].Width = 100;
            DGV1.Columns[4].Visible = false;
            DGV1.Columns[1].SortMode = DataGridViewColumnSortMode.Automatic;
            DGV1.CurrentCell = DGV1[1, 0];
        }

        private void SetupTextBoxes()
        {
            //TB_Author.Text = DGV1[1, Convert.ToInt32(DGV1.CurrentCell.RowIndex.ToString())].Value.ToString();
            TB_Author.Text = (DGV1[1, DGV1.CurrentRow.Index].Value).ToString();
            TB_Title.Text = (DGV1[2, DGV1.CurrentRow.Index].Value).ToString();
            TB_Filename.Text = (DGV1[3, DGV1.CurrentRow.Index].Value).ToString();
            if ((DGV1[3, DGV1.CurrentRow.Index].Value).ToString() != "none")
            { BT_Open.Enabled = true; }
            else { BT_Open.Enabled = false; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DbWork.CreateDB();
            F_Add newForm = new F_Add();
            newForm.ShowDialog();
            SetupDataGridView();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            SetupDataGridView();
            SetupTextBoxes();


        }

        private void DGV1_Click(object sender, EventArgs e)
        {
            SetupTextBoxes();
        }

        private void BT_Del_Click(object sender, EventArgs e)
        {
            int DelId = Convert.ToInt32(DGV1[0, DGV1.CurrentRow.Index].Value);
            MessageBox.Show(DelId.ToString());
            DbWork.DelBook(DelId);
            SetupDataGridView();
        }

        private void BT_Open_Click(object sender, EventArgs e)
        {

            int SelectedId = Convert.ToInt32(DGV1[0, DGV1.CurrentRow.Index].Value);
            MessageBox.Show(SelectedId.ToString());
            BindingList<Book> loadedbook = new BindingList<Book>(DbWork.GetBook(SelectedId));
            MessageBox.Show(loadedbook[0].FileName);
            using (FileStream fs = new FileStream(loadedbook[0].FileName, FileMode.OpenOrCreate))
            {
                fs.Write(loadedbook[0].FileData, 0, loadedbook[0].FileData.Length);
            }
            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = loadedbook[0].FileName;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }
    }
}
