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
    /// <summary>
    /// Основная форма работы с книгами.
    /// </summary>
    public partial class F_Main : Form
    {
        public DataTable books = new DataTable();
        
        public F_Main()
        {
            InitializeComponent();

        }
        
        /// <summary>
        /// Настройка источника данных и внешнего вида DataGridView.
        /// </summary>
        private void SetupDataGridView()
        {
            //DataTable books = new DataTable();
            books = DbWork.GetBooks();
            DGV1.DataSource = books;
            DGV1.AutoGenerateColumns = false;
            DGV1.Columns[0].Visible = false;
            DGV1.Columns[1].HeaderText = "Автор";
            DGV1.Columns[1].Width = 150;
            DGV1.Columns[2].HeaderText = "Название книги";
            DGV1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV1.Columns[3].HeaderText = "Жанр";
            DGV1.Columns[3].Width = 100;
            DGV1.Columns[4].HeaderText = "Год";
            DGV1.Columns[4].Width = 40;
            DGV1.Columns[5].HeaderText = "Оценка";
            DGV1.Columns[5].Width = 50;
            DGV1.Columns[6].Visible = false;
            DGV1.Columns[7].HeaderText = "Файл книги";
            DGV1.Columns[7].Width = 200;
            DGV1.Columns[1].SortMode = DataGridViewColumnSortMode.Automatic;
            
            if (DGV1.Rows.Count > 0)
            { DGV1.CurrentCell = DGV1[1, 0]; }
        }

        /// <summary>
        /// Настройка элементов отображающих значение ячеек выделенной строки DataGridView.
        /// </summary>
        private void SetupTextBoxes()
        {            
            BT_Open.Enabled = false;
            if (DGV1.Rows.Count > 0)
            {
                TB_Author.Text = (DGV1[1, DGV1.CurrentRow.Index].Value).ToString();
                TB_Title.Text = (DGV1[2, DGV1.CurrentRow.Index].Value).ToString();
                TB_Genre.Text = (DGV1[3, DGV1.CurrentRow.Index].Value).ToString();
                TB_Year.Text = (DGV1[4, DGV1.CurrentRow.Index].Value).ToString();
                TB_Raiting.Text = (DGV1[5, DGV1.CurrentRow.Index].Value).ToString();
                TB_Description.Text = (DGV1[6, DGV1.CurrentRow.Index].Value).ToString();
                TB_Filename.Text = (DGV1[7, DGV1.CurrentRow.Index].Value).ToString();
            
            if ((DGV1[7, DGV1.CurrentRow.Index].Value).ToString() != "none")
            { BT_Open.Enabled = true; }
            else { BT_Open.Enabled = false; }
            }
        }

        /// <summary>
        /// Действие по кнопке Добавить книгу.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_Add_Click(object sender, EventArgs e)
        {
            //DbWork.CreateDB();
            SharedId.Id = -1;
            F_Add newForm = new F_Add();
            newForm.ShowDialog();
            SetupDataGridView();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            SetupDataGridView();
            SetupTextBoxes();
        }

        /// <summary>
        /// Действие по клику на DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGV1_Click(object sender, EventArgs e)
        {
            SetupTextBoxes();
        }

        /// <summary>
        /// Действие по кнопке Удалить книгу.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_Del_Click(object sender, EventArgs e)
        {
            int DelId = Convert.ToInt32(DGV1[0, DGV1.CurrentRow.Index].Value);
            //MessageBox.Show(DelId.ToString());
            DbWork.DelBook(DelId);
            SetupDataGridView();
        }

        /// <summary>
        /// Действие по кнопке Открыть файл книги.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_Open_Click(object sender, EventArgs e)
        {
            int SelectedId = Convert.ToInt32(DGV1[0, DGV1.CurrentRow.Index].Value); //Загрузка выделенной записи.
            MessageBox.Show(SelectedId.ToString());
            List<Book> loadedbook = new List<Book>(DbWork.GetBook(SelectedId));
            MessageBox.Show(loadedbook[0].FileName);
            
            using (FileStream fs = new FileStream(loadedbook[0].FileName, FileMode.OpenOrCreate)) //Сохранение файла в каталог с программой.
            {
                fs.Write(loadedbook[0].FileData, 0, loadedbook[0].FileData.Length);
            }
            
            var proc = new System.Diagnostics.Process(); //Открытие сохраненного файла в асоциированной программе.
            proc.StartInfo.FileName = loadedbook[0].FileName;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }

        /// <summary>
        /// Действие по кнопке Изменить книгу.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_Edit_Click(object sender, EventArgs e)
        {
            SharedId.Id = Convert.ToInt32(DGV1[0, DGV1.CurrentRow.Index].Value); //Передача Id выделеной записи в форму F_Add.
            F_Add newForm = new F_Add();
            newForm.ShowDialog();
            SetupDataGridView();
            SharedId.Id = -1;
        }
              
        /// <summary>
        /// Действие по кнопке Поиск.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_Filter_Click(object sender, EventArgs e)
        {
            if(CB_WFile.Checked) //Фильтрация DGV1. 
            {
                (DGV1.DataSource as DataTable).DefaultView.RowFilter = $"Author like '{TB_Filter_Author.Text}%'" +
                    $" and Title like '{TB_Filter_Title.Text}%' and Genre like '{CB_Genre_Filter.Text}%'" +
                    $"and Year like '{TB_Year_Filter.Text}%' and Raiting = '{CB_Raiting_Filter.Text}' and FileName <>'none'"; 
            }
            else
            {
                (DGV1.DataSource as DataTable).DefaultView.RowFilter = $"Author like '{TB_Filter_Author.Text}%'" +
                    $" and Title like '{TB_Filter_Title.Text}%' and Genre like '{CB_Genre_Filter.Text}%'" +
                    $"and Year like '{TB_Year_Filter.Text}%' and Raiting = '{CB_Raiting_Filter.Text}'";
            }
            
        }

        /// <summary>
        /// Действие по кнопке Очистить.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_Clear_Click(object sender, EventArgs e)
        {
            TB_Filter_Author.Text = null; //Очистка полей ввода параметров поиска.
            TB_Filter_Title.Text = null;
            TB_Year_Filter.Text = null;
            CB_Genre_Filter.Text = null;
            CB_Raiting_Filter.Text = null;
            CB_WFile.Checked = false;
            (DGV1.DataSource as DataTable).DefaultView.RowFilter = null;
        }
    }
}
