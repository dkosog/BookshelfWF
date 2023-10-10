namespace BookshelfWF
{
    partial class F_Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.BT_Add = new System.Windows.Forms.Button();
            this.TB_Author = new System.Windows.Forms.TextBox();
            this.L_Author = new System.Windows.Forms.Label();
            this.TB_Title = new System.Windows.Forms.TextBox();
            this.L_Title = new System.Windows.Forms.Label();
            this.TB_Filename = new System.Windows.Forms.TextBox();
            this.L_Filename = new System.Windows.Forms.Label();
            this.BT_Edit = new System.Windows.Forms.Button();
            this.BT_Del = new System.Windows.Forms.Button();
            this.BT_Open = new System.Windows.Forms.Button();
            this.TB_Filter_Author = new System.Windows.Forms.TextBox();
            this.TB_Filter_Title = new System.Windows.Forms.TextBox();
            this.BT_Filter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CB_WFile = new System.Windows.Forms.CheckBox();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV1
            // 
            this.DGV1.AllowUserToAddRows = false;
            this.DGV1.AllowUserToDeleteRows = false;
            this.DGV1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV1.ColumnHeadersHeight = 25;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV1.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DGV1.Location = new System.Drawing.Point(2, 2);
            this.DGV1.MultiSelect = false;
            this.DGV1.Name = "DGV1";
            this.DGV1.ReadOnly = true;
            this.DGV1.RowHeadersVisible = false;
            this.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV1.ShowEditingIcon = false;
            this.DGV1.Size = new System.Drawing.Size(672, 451);
            this.DGV1.TabIndex = 0;
            this.DGV1.Click += new System.EventHandler(this.DGV1_Click);
            // 
            // BT_Add
            // 
            this.BT_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_Add.Location = new System.Drawing.Point(687, 412);
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.Size = new System.Drawing.Size(194, 35);
            this.BT_Add.TabIndex = 1;
            this.BT_Add.Text = "Добавить книгу";
            this.BT_Add.UseVisualStyleBackColor = true;
            this.BT_Add.Click += new System.EventHandler(this.BT_Add_Click);
            // 
            // TB_Author
            // 
            this.TB_Author.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Author.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Author.Location = new System.Drawing.Point(687, 36);
            this.TB_Author.Name = "TB_Author";
            this.TB_Author.ReadOnly = true;
            this.TB_Author.Size = new System.Drawing.Size(194, 29);
            this.TB_Author.TabIndex = 2;
            // 
            // L_Author
            // 
            this.L_Author.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Author.AutoSize = true;
            this.L_Author.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_Author.Location = new System.Drawing.Point(687, 12);
            this.L_Author.Name = "L_Author";
            this.L_Author.Size = new System.Drawing.Size(53, 21);
            this.L_Author.TabIndex = 3;
            this.L_Author.Text = "Автор";
            // 
            // TB_Title
            // 
            this.TB_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Title.Location = new System.Drawing.Point(687, 100);
            this.TB_Title.Multiline = true;
            this.TB_Title.Name = "TB_Title";
            this.TB_Title.ReadOnly = true;
            this.TB_Title.Size = new System.Drawing.Size(194, 58);
            this.TB_Title.TabIndex = 2;
            // 
            // L_Title
            // 
            this.L_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Title.AutoSize = true;
            this.L_Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_Title.Location = new System.Drawing.Point(687, 76);
            this.L_Title.Name = "L_Title";
            this.L_Title.Size = new System.Drawing.Size(78, 21);
            this.L_Title.TabIndex = 3;
            this.L_Title.Text = "Название";
            // 
            // TB_Filename
            // 
            this.TB_Filename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Filename.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Filename.Location = new System.Drawing.Point(687, 322);
            this.TB_Filename.Multiline = true;
            this.TB_Filename.Name = "TB_Filename";
            this.TB_Filename.ReadOnly = true;
            this.TB_Filename.Size = new System.Drawing.Size(194, 29);
            this.TB_Filename.TabIndex = 2;
            // 
            // L_Filename
            // 
            this.L_Filename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Filename.AutoSize = true;
            this.L_Filename.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_Filename.Location = new System.Drawing.Point(683, 298);
            this.L_Filename.Name = "L_Filename";
            this.L_Filename.Size = new System.Drawing.Size(89, 21);
            this.L_Filename.TabIndex = 3;
            this.L_Filename.Text = "Имя файла";
            // 
            // BT_Edit
            // 
            this.BT_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_Edit.Location = new System.Drawing.Point(687, 453);
            this.BT_Edit.Name = "BT_Edit";
            this.BT_Edit.Size = new System.Drawing.Size(194, 35);
            this.BT_Edit.TabIndex = 1;
            this.BT_Edit.Text = "Изменить книгу";
            this.BT_Edit.UseVisualStyleBackColor = true;
            this.BT_Edit.Click += new System.EventHandler(this.BT_Edit_Click);
            // 
            // BT_Del
            // 
            this.BT_Del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Del.Cursor = System.Windows.Forms.Cursors.Default;
            this.BT_Del.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_Del.Location = new System.Drawing.Point(687, 494);
            this.BT_Del.Name = "BT_Del";
            this.BT_Del.Size = new System.Drawing.Size(194, 35);
            this.BT_Del.TabIndex = 1;
            this.BT_Del.Text = "Удалить книгу";
            this.BT_Del.UseVisualStyleBackColor = true;
            this.BT_Del.Click += new System.EventHandler(this.BT_Del_Click);
            // 
            // BT_Open
            // 
            this.BT_Open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Open.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_Open.Location = new System.Drawing.Point(687, 371);
            this.BT_Open.Name = "BT_Open";
            this.BT_Open.Size = new System.Drawing.Size(194, 35);
            this.BT_Open.TabIndex = 1;
            this.BT_Open.Text = "Открыть файл книги";
            this.BT_Open.UseVisualStyleBackColor = true;
            this.BT_Open.Click += new System.EventHandler(this.BT_Open_Click);
            // 
            // TB_Filter_Author
            // 
            this.TB_Filter_Author.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Filter_Author.Location = new System.Drawing.Point(12, 501);
            this.TB_Filter_Author.Name = "TB_Filter_Author";
            this.TB_Filter_Author.Size = new System.Drawing.Size(100, 29);
            this.TB_Filter_Author.TabIndex = 4;
            // 
            // TB_Filter_Title
            // 
            this.TB_Filter_Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Filter_Title.Location = new System.Drawing.Point(128, 42);
            this.TB_Filter_Title.Name = "TB_Filter_Title";
            this.TB_Filter_Title.Size = new System.Drawing.Size(100, 29);
            this.TB_Filter_Title.TabIndex = 4;
            // 
            // BT_Filter
            // 
            this.BT_Filter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_Filter.Location = new System.Drawing.Point(580, 36);
            this.BT_Filter.Name = "BT_Filter";
            this.BT_Filter.Size = new System.Drawing.Size(82, 35);
            this.BT_Filter.TabIndex = 5;
            this.BT_Filter.Text = "Поиск";
            this.BT_Filter.UseVisualStyleBackColor = true;
            this.BT_Filter.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Автор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(124, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_WFile);
            this.groupBox1.Controls.Add(this.BT_Filter);
            this.groupBox1.Controls.Add(this.TB_Filter_Title);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 459);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 81);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск записей";
            // 
            // CB_WFile
            // 
            this.CB_WFile.AutoSize = true;
            this.CB_WFile.Location = new System.Drawing.Point(248, 53);
            this.CB_WFile.Name = "CB_WFile";
            this.CB_WFile.Size = new System.Drawing.Size(121, 17);
            this.CB_WFile.TabIndex = 6;
            this.CB_WFile.Text = "Только с файлами";
            this.CB_WFile.UseVisualStyleBackColor = true;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(BookshelfWF.Book);
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 542);
            this.Controls.Add(this.TB_Filter_Author);
            this.Controls.Add(this.L_Filename);
            this.Controls.Add(this.L_Title);
            this.Controls.Add(this.TB_Filename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L_Author);
            this.Controls.Add(this.TB_Title);
            this.Controls.Add(this.TB_Author);
            this.Controls.Add(this.BT_Del);
            this.Controls.Add(this.BT_Edit);
            this.Controls.Add(this.BT_Open);
            this.Controls.Add(this.BT_Add);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.groupBox1);
            this.Name = "F_Main";
            this.Text = "Библиотека";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.Button BT_Add;
        private System.Windows.Forms.TextBox TB_Author;
        private System.Windows.Forms.Label L_Author;
        private System.Windows.Forms.TextBox TB_Title;
        private System.Windows.Forms.Label L_Title;
        private System.Windows.Forms.TextBox TB_Filename;
        private System.Windows.Forms.Label L_Filename;
        private System.Windows.Forms.Button BT_Edit;
        private System.Windows.Forms.Button BT_Del;
        private System.Windows.Forms.Button BT_Open;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.TextBox TB_Filter_Author;
        private System.Windows.Forms.TextBox TB_Filter_Title;
        private System.Windows.Forms.Button BT_Filter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CB_WFile;
    }
}

