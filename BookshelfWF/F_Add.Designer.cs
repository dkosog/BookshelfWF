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
            this.SuspendLayout();
            // 
            // L_Author
            // 
            this.L_Author.AutoSize = true;
            this.L_Author.Location = new System.Drawing.Point(20, 21);
            this.L_Author.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_Author.Name = "L_Author";
            this.L_Author.Size = new System.Drawing.Size(98, 21);
            this.L_Author.TabIndex = 0;
            this.L_Author.Text = "Автор книги";
            // 
            // TB_Author
            // 
            this.TB_Author.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Author.Location = new System.Drawing.Point(20, 48);
            this.TB_Author.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Author.Name = "TB_Author";
            this.TB_Author.Size = new System.Drawing.Size(371, 29);
            this.TB_Author.TabIndex = 1;
            // 
            // L_Title
            // 
            this.L_Title.AutoSize = true;
            this.L_Title.Location = new System.Drawing.Point(20, 98);
            this.L_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_Title.Name = "L_Title";
            this.L_Title.Size = new System.Drawing.Size(123, 21);
            this.L_Title.TabIndex = 0;
            this.L_Title.Text = "Название книги";
            // 
            // TB_Title
            // 
            this.TB_Title.Location = new System.Drawing.Point(20, 125);
            this.TB_Title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Title.Name = "TB_Title";
            this.TB_Title.Size = new System.Drawing.Size(371, 29);
            this.TB_Title.TabIndex = 1;
            // 
            // L_Filename
            // 
            this.L_Filename.AutoSize = true;
            this.L_Filename.Location = new System.Drawing.Point(20, 172);
            this.L_Filename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_Filename.Name = "L_Filename";
            this.L_Filename.Size = new System.Drawing.Size(89, 21);
            this.L_Filename.TabIndex = 0;
            this.L_Filename.Text = "Имя файла";
            // 
            // TB_Filename
            // 
            this.TB_Filename.Location = new System.Drawing.Point(20, 199);
            this.TB_Filename.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Filename.Name = "TB_Filename";
            this.TB_Filename.ReadOnly = true;
            this.TB_Filename.Size = new System.Drawing.Size(172, 29);
            this.TB_Filename.TabIndex = 1;
            // 
            // BT_Save
            // 
            this.BT_Save.Location = new System.Drawing.Point(20, 262);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(371, 29);
            this.BT_Save.TabIndex = 2;
            this.BT_Save.Text = "Сохранить";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.Location = new System.Drawing.Point(20, 316);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(371, 29);
            this.BT_Cancel.TabIndex = 2;
            this.BT_Cancel.Text = "Отмена";
            this.BT_Cancel.UseVisualStyleBackColor = true;
            this.BT_Cancel.Click += new System.EventHandler(this.BT_Cancel_Click);
            // 
            // BT_File_Load
            // 
            this.BT_File_Load.Location = new System.Drawing.Point(199, 199);
            this.BT_File_Load.Name = "BT_File_Load";
            this.BT_File_Load.Size = new System.Drawing.Size(91, 29);
            this.BT_File_Load.TabIndex = 3;
            this.BT_File_Load.Text = "Загрузить";
            this.BT_File_Load.UseVisualStyleBackColor = true;
            this.BT_File_Load.Click += new System.EventHandler(this.BT_File_Load_Click);
            // 
            // BT_File_Delete
            // 
            this.BT_File_Delete.Location = new System.Drawing.Point(300, 198);
            this.BT_File_Delete.Name = "BT_File_Delete";
            this.BT_File_Delete.Size = new System.Drawing.Size(91, 29);
            this.BT_File_Delete.TabIndex = 3;
            this.BT_File_Delete.Text = "Удалить";
            this.BT_File_Delete.UseVisualStyleBackColor = true;
            this.BT_File_Delete.Click += new System.EventHandler(this.BT_File_Delete_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // F_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 375);
            this.Controls.Add(this.BT_File_Delete);
            this.Controls.Add(this.BT_File_Load);
            this.Controls.Add(this.BT_Cancel);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.TB_Filename);
            this.Controls.Add(this.L_Filename);
            this.Controls.Add(this.TB_Title);
            this.Controls.Add(this.L_Title);
            this.Controls.Add(this.TB_Author);
            this.Controls.Add(this.L_Author);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
    }
}