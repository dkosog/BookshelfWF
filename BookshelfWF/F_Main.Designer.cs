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
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV1
            // 
            this.DGV1.AllowUserToAddRows = false;
            this.DGV1.AllowUserToDeleteRows = false;
            this.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
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
            this.DGV1.Location = new System.Drawing.Point(12, 12);
            this.DGV1.MultiSelect = false;
            this.DGV1.Name = "DGV1";
            this.DGV1.ReadOnly = true;
            this.DGV1.RowHeadersVisible = false;
            this.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV1.ShowEditingIcon = false;
            this.DGV1.Size = new System.Drawing.Size(669, 426);
            this.DGV1.TabIndex = 0;
            this.DGV1.Click += new System.EventHandler(this.DGV1_Click);
            // 
            // BT_Add
            // 
            this.BT_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_Add.Location = new System.Drawing.Point(687, 250);
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.Size = new System.Drawing.Size(194, 35);
            this.BT_Add.TabIndex = 1;
            this.BT_Add.Text = "Добавить книгу";
            this.BT_Add.UseVisualStyleBackColor = true;
            this.BT_Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // TB_Author
            // 
            this.TB_Author.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Author.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Author.Location = new System.Drawing.Point(687, 36);
            this.TB_Author.Name = "TB_Author";
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
            this.TB_Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Title.Location = new System.Drawing.Point(687, 100);
            this.TB_Title.Name = "TB_Title";
            this.TB_Title.Size = new System.Drawing.Size(194, 29);
            this.TB_Title.TabIndex = 2;
            // 
            // L_Title
            // 
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
            this.TB_Filename.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Filename.Location = new System.Drawing.Point(687, 164);
            this.TB_Filename.Multiline = true;
            this.TB_Filename.Name = "TB_Filename";
            this.TB_Filename.Size = new System.Drawing.Size(194, 29);
            this.TB_Filename.TabIndex = 2;
            // 
            // L_Filename
            // 
            this.L_Filename.AutoSize = true;
            this.L_Filename.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_Filename.Location = new System.Drawing.Point(683, 140);
            this.L_Filename.Name = "L_Filename";
            this.L_Filename.Size = new System.Drawing.Size(89, 21);
            this.L_Filename.TabIndex = 3;
            this.L_Filename.Text = "Имя файла";
            // 
            // BT_Edit
            // 
            this.BT_Edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_Edit.Location = new System.Drawing.Point(687, 291);
            this.BT_Edit.Name = "BT_Edit";
            this.BT_Edit.Size = new System.Drawing.Size(194, 35);
            this.BT_Edit.TabIndex = 1;
            this.BT_Edit.Text = "Изменить книгу";
            this.BT_Edit.UseVisualStyleBackColor = true;
            this.BT_Edit.Click += new System.EventHandler(this.BT_Edit_Click);
            // 
            // BT_Del
            // 
            this.BT_Del.Cursor = System.Windows.Forms.Cursors.Default;
            this.BT_Del.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_Del.Location = new System.Drawing.Point(687, 332);
            this.BT_Del.Name = "BT_Del";
            this.BT_Del.Size = new System.Drawing.Size(194, 35);
            this.BT_Del.TabIndex = 1;
            this.BT_Del.Text = "Удалить книгу";
            this.BT_Del.UseVisualStyleBackColor = true;
            this.BT_Del.Click += new System.EventHandler(this.BT_Del_Click);
            // 
            // BT_Open
            // 
            this.BT_Open.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_Open.Location = new System.Drawing.Point(687, 209);
            this.BT_Open.Name = "BT_Open";
            this.BT_Open.Size = new System.Drawing.Size(194, 35);
            this.BT_Open.TabIndex = 1;
            this.BT_Open.Text = "Открыть файл книги";
            this.BT_Open.UseVisualStyleBackColor = true;
            this.BT_Open.Click += new System.EventHandler(this.BT_Open_Click);
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(BookshelfWF.Book);
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.L_Filename);
            this.Controls.Add(this.L_Title);
            this.Controls.Add(this.TB_Filename);
            this.Controls.Add(this.L_Author);
            this.Controls.Add(this.TB_Title);
            this.Controls.Add(this.TB_Author);
            this.Controls.Add(this.BT_Del);
            this.Controls.Add(this.BT_Edit);
            this.Controls.Add(this.BT_Open);
            this.Controls.Add(this.BT_Add);
            this.Controls.Add(this.DGV1);
            this.Name = "F_Main";
            this.Text = "Библиотека";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
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
    }
}

