namespace BookshelfWF
{
    partial class F_Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.L_Author = new System.Windows.Forms.Label();
            this.TB_Author = new System.Windows.Forms.TextBox();
            this.L_Title = new System.Windows.Forms.Label();
            this.TB_Title = new System.Windows.Forms.TextBox();
            this.L_Filename = new System.Windows.Forms.Label();
            this.TB_Filename = new System.Windows.Forms.TextBox();
            this.BT_Save = new System.Windows.Forms.Button();
            this.BT_Cancel = new System.Windows.Forms.Button();
            this.BT_File_Load = new System.Windows.Forms.Button();
            this.BT_File_Delete = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CB_Genre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Year = new System.Windows.Forms.MaskedTextBox();
            this.TB_Description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_Raiting = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // L_Author
            // 
            this.L_Author.AutoSize = true;
            this.L_Author.Location = new System.Drawing.Point(18, 20);
            this.L_Author.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_Author.Name = "L_Author";
            this.L_Author.Size = new System.Drawing.Size(95, 20);
            this.L_Author.TabIndex = 0;
            this.L_Author.Text = "Автор книги";
            // 
            // TB_Author
            // 
            this.TB_Author.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Author.Location = new System.Drawing.Point(18, 46);
            this.TB_Author.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Author.Name = "TB_Author";
            this.TB_Author.Size = new System.Drawing.Size(330, 29);
            this.TB_Author.TabIndex = 1;
            // 
            // L_Title
            // 
            this.L_Title.AutoSize = true;
            this.L_Title.Location = new System.Drawing.Point(18, 78);
            this.L_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_Title.Name = "L_Title";
            this.L_Title.Size = new System.Drawing.Size(121, 20);
            this.L_Title.TabIndex = 0;
            this.L_Title.Text = "Название книги";
            // 
            // TB_Title
            // 
            this.TB_Title.Location = new System.Drawing.Point(18, 103);
            this.TB_Title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Title.Name = "TB_Title";
            this.TB_Title.Size = new System.Drawing.Size(330, 27);
            this.TB_Title.TabIndex = 1;
            // 
            // L_Filename
            // 
            this.L_Filename.AutoSize = true;
            this.L_Filename.Location = new System.Drawing.Point(14, 433);
            this.L_Filename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_Filename.Name = "L_Filename";
            this.L_Filename.Size = new System.Drawing.Size(89, 20);
            this.L_Filename.TabIndex = 0;
            this.L_Filename.Text = "Файл книги";
            // 
            // TB_Filename
            // 
            this.TB_Filename.Location = new System.Drawing.Point(16, 458);
            this.TB_Filename.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Filename.Name = "TB_Filename";
            this.TB_Filename.ReadOnly = true;
            this.TB_Filename.Size = new System.Drawing.Size(153, 27);
            this.TB_Filename.TabIndex = 1;
            // 
            // BT_Save
            // 
            this.BT_Save.Location = new System.Drawing.Point(16, 503);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(330, 28);
            this.BT_Save.TabIndex = 2;
            this.BT_Save.Text = "Сохранить";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.Location = new System.Drawing.Point(16, 546);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(330, 28);
            this.BT_Cancel.TabIndex = 2;
            this.BT_Cancel.Text = "Отмена";
            this.BT_Cancel.UseVisualStyleBackColor = true;
            this.BT_Cancel.Click += new System.EventHandler(this.BT_Cancel_Click);
            // 
            // BT_File_Load
            // 
            this.BT_File_Load.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_File_Load.Location = new System.Drawing.Point(176, 458);
            this.BT_File_Load.Name = "BT_File_Load";
            this.BT_File_Load.Size = new System.Drawing.Size(81, 28);
            this.BT_File_Load.TabIndex = 3;
            this.BT_File_Load.Text = "Загрузить";
            this.BT_File_Load.UseVisualStyleBackColor = true;
            this.BT_File_Load.Click += new System.EventHandler(this.BT_File_Load_Click);
            // 
            // BT_File_Delete
            // 
            this.BT_File_Delete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_File_Delete.Location = new System.Drawing.Point(267, 458);
            this.BT_File_Delete.Name = "BT_File_Delete";
            this.BT_File_Delete.Size = new System.Drawing.Size(81, 28);
            this.BT_File_Delete.TabIndex = 3;
            this.BT_File_Delete.Text = "Удалить";
            this.BT_File_Delete.UseVisualStyleBackColor = true;
            this.BT_File_Delete.Click += new System.EventHandler(this.BT_File_Delete_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CB_Genre
            // 
            this.CB_Genre.AutoCompleteCustomSource.AddRange(new string[] {
            "Фэнтези",
            "Фантастика",
            "Детективы",
            "Любовные романы",
            "Ужасы",
            "Приключения",
            "Комиксы и манга",
            "Бизнес-литература",
            "Компьютерная литература",
            "Искусство и культура",
            "Научная литература",
            "Хобби и досуг",
            "Общество",
            "Мемуары",
            "Красота и здоровье",
            "Детская литература",
            "Учебная литература"});
            this.CB_Genre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CB_Genre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Genre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CB_Genre.FormattingEnabled = true;
            this.CB_Genre.Items.AddRange(new object[] {
            "Бизнес-литература",
            "Детективы",
            "Детская литература",
            "Искусство и культура",
            "Комиксы и манга",
            "Компьютерная литература",
            "Красота и здоровье",
            "Любовные романы",
            "Мемуары",
            "Научная литература",
            "Общество",
            "Приключения",
            "Ужасы",
            "Учебная литература",
            "Фантастика",
            "Фэнтези",
            "Хобби и досуг"});
            this.CB_Genre.Location = new System.Drawing.Point(18, 158);
            this.CB_Genre.Name = "CB_Genre";
            this.CB_Genre.Size = new System.Drawing.Size(233, 28);
            this.CB_Genre.Sorted = true;
            this.CB_Genre.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Жанр книги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Издана(год)";
            // 
            // TB_Year
            // 
            this.TB_Year.Location = new System.Drawing.Point(257, 158);
            this.TB_Year.Mask = "0000";
            this.TB_Year.Name = "TB_Year";
            this.TB_Year.Size = new System.Drawing.Size(76, 27);
            this.TB_Year.TabIndex = 9;
            this.TB_Year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_Description
            // 
            this.TB_Description.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Description.Location = new System.Drawing.Point(16, 267);
            this.TB_Description.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Description.Multiline = true;
            this.TB_Description.Name = "TB_Description";
            this.TB_Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_Description.Size = new System.Drawing.Size(330, 161);
            this.TB_Description.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Краткая аннотация";
            // 
            // CB_Raiting
            // 
            this.CB_Raiting.AutoCompleteCustomSource.AddRange(new string[] {
            "Фэнтези",
            "Фантастика",
            "Детективы",
            "Любовные романы",
            "Ужасы",
            "Приключения",
            "Комиксы и манга",
            "Бизнес-литература",
            "Компьютерная литература",
            "Искусство и культура",
            "Научная литература",
            "Хобби и досуг",
            "Общество",
            "Мемуары",
            "Красота и здоровье",
            "Детская литература",
            "Учебная литература"});
            this.CB_Raiting.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CB_Raiting.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CB_Raiting.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Raiting.FormattingEnabled = true;
            this.CB_Raiting.Items.AddRange(new object[] {
            "⭐",
            "⭐⭐",
            "⭐⭐⭐",
            "⭐⭐⭐⭐",
            "⭐⭐⭐⭐⭐"});
            this.CB_Raiting.Location = new System.Drawing.Point(153, 202);
            this.CB_Raiting.Name = "CB_Raiting";
            this.CB_Raiting.Size = new System.Drawing.Size(180, 28);
            this.CB_Raiting.Sorted = true;
            this.CB_Raiting.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Рейтинг книги";
            // 
            // F_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 590);
            this.Controls.Add(this.CB_Raiting);
            this.Controls.Add(this.TB_Year);
            this.Controls.Add(this.CB_Genre);
            this.Controls.Add(this.BT_File_Delete);
            this.Controls.Add(this.BT_File_Load);
            this.Controls.Add(this.BT_Cancel);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.TB_Filename);
            this.Controls.Add(this.L_Filename);
            this.Controls.Add(this.TB_Description);
            this.Controls.Add(this.TB_Title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.L_Title);
            this.Controls.Add(this.TB_Author);
            this.Controls.Add(this.L_Author);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "F_Add";
            this.Text = "F_Add";
            this.Load += new System.EventHandler(this.F_Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Author;
        private System.Windows.Forms.TextBox TB_Author;
        private System.Windows.Forms.Label L_Title;
        private System.Windows.Forms.TextBox TB_Title;
        private System.Windows.Forms.Label L_Filename;
        private System.Windows.Forms.TextBox TB_Filename;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.Button BT_Cancel;
        private System.Windows.Forms.Button BT_File_Load;
        private System.Windows.Forms.Button BT_File_Delete;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox CB_Genre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TB_Year;
        private System.Windows.Forms.TextBox TB_Description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_Raiting;
        private System.Windows.Forms.Label label4;
    }
}