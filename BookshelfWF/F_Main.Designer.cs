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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.CB_Raiting_Filter = new System.Windows.Forms.ComboBox();
            this.CB_Genre_Filter = new System.Windows.Forms.ComboBox();
            this.CB_WFile = new System.Windows.Forms.CheckBox();
            this.BT_Clear = new System.Windows.Forms.Button();
            this.TB_Year_Filter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Genre = new System.Windows.Forms.TextBox();
            this.L_Genre = new System.Windows.Forms.Label();
            this.TB_Year = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_Raiting = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_Description = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV1
            // 
            this.DGV1.AllowUserToAddRows = false;
            this.DGV1.AllowUserToDeleteRows = false;
            this.DGV1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV1.ColumnHeadersHeight = 29;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV1.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGV1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DGV1.Location = new System.Drawing.Point(2, 2);
            this.DGV1.MultiSelect = false;
            this.DGV1.Name = "DGV1";
            this.DGV1.ReadOnly = true;
            this.DGV1.RowHeadersVisible = false;
            this.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV1.ShowEditingIcon = false;
            this.DGV1.Size = new System.Drawing.Size(1132, 445);
            this.DGV1.TabIndex = 0;
            this.DGV1.Click += new System.EventHandler(this.DGV1_Click);
            // 
            // BT_Add
            // 
            this.BT_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Add.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_Add.Location = new System.Drawing.Point(1144, 483);
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.Size = new System.Drawing.Size(164, 35);
            this.BT_Add.TabIndex = 1;
            this.BT_Add.Text = "Добавить книгу";
            this.BT_Add.UseVisualStyleBackColor = true;
            this.BT_Add.Click += new System.EventHandler(this.BT_Add_Click);
            // 
            // TB_Author
            // 
            this.TB_Author.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Author.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Author.Location = new System.Drawing.Point(1140, 25);
            this.TB_Author.Name = "TB_Author";
            this.TB_Author.ReadOnly = true;
            this.TB_Author.Size = new System.Drawing.Size(332, 27);
            this.TB_Author.TabIndex = 2;
            // 
            // L_Author
            // 
            this.L_Author.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Author.AutoSize = true;
            this.L_Author.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_Author.Location = new System.Drawing.Point(1136, 2);
            this.L_Author.Name = "L_Author";
            this.L_Author.Size = new System.Drawing.Size(51, 20);
            this.L_Author.TabIndex = 3;
            this.L_Author.Text = "Автор";
            // 
            // TB_Title
            // 
            this.TB_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Title.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Title.Location = new System.Drawing.Point(1140, 87);
            this.TB_Title.Multiline = true;
            this.TB_Title.Name = "TB_Title";
            this.TB_Title.ReadOnly = true;
            this.TB_Title.Size = new System.Drawing.Size(332, 31);
            this.TB_Title.TabIndex = 2;
            // 
            // L_Title
            // 
            this.L_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Title.AutoSize = true;
            this.L_Title.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_Title.Location = new System.Drawing.Point(1140, 64);
            this.L_Title.Name = "L_Title";
            this.L_Title.Size = new System.Drawing.Size(77, 20);
            this.L_Title.TabIndex = 3;
            this.L_Title.Text = "Название";
            // 
            // TB_Filename
            // 
            this.TB_Filename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Filename.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Filename.Location = new System.Drawing.Point(1144, 448);
            this.TB_Filename.Multiline = true;
            this.TB_Filename.Name = "TB_Filename";
            this.TB_Filename.ReadOnly = true;
            this.TB_Filename.Size = new System.Drawing.Size(202, 29);
            this.TB_Filename.TabIndex = 2;
            // 
            // L_Filename
            // 
            this.L_Filename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Filename.AutoSize = true;
            this.L_Filename.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_Filename.Location = new System.Drawing.Point(1143, 424);
            this.L_Filename.Name = "L_Filename";
            this.L_Filename.Size = new System.Drawing.Size(89, 21);
            this.L_Filename.TabIndex = 3;
            this.L_Filename.Text = "Имя файла";
            // 
            // BT_Edit
            // 
            this.BT_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Edit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_Edit.Location = new System.Drawing.Point(1314, 483);
            this.BT_Edit.Name = "BT_Edit";
            this.BT_Edit.Size = new System.Drawing.Size(162, 35);
            this.BT_Edit.TabIndex = 1;
            this.BT_Edit.Text = "Изменить книгу";
            this.BT_Edit.UseVisualStyleBackColor = true;
            this.BT_Edit.Click += new System.EventHandler(this.BT_Edit_Click);
            // 
            // BT_Del
            // 
            this.BT_Del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Del.Cursor = System.Windows.Forms.Cursors.Default;
            this.BT_Del.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_Del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Del.Location = new System.Drawing.Point(1222, 524);
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
            this.BT_Open.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_Open.Location = new System.Drawing.Point(1352, 448);
            this.BT_Open.Name = "BT_Open";
            this.BT_Open.Size = new System.Drawing.Size(120, 29);
            this.BT_Open.TabIndex = 1;
            this.BT_Open.Text = "Открыть файл";
            this.BT_Open.UseVisualStyleBackColor = true;
            this.BT_Open.Click += new System.EventHandler(this.BT_Open_Click);
            // 
            // TB_Filter_Author
            // 
            this.TB_Filter_Author.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Filter_Author.Location = new System.Drawing.Point(12, 501);
            this.TB_Filter_Author.Name = "TB_Filter_Author";
            this.TB_Filter_Author.Size = new System.Drawing.Size(120, 27);
            this.TB_Filter_Author.TabIndex = 4;
            // 
            // TB_Filter_Title
            // 
            this.TB_Filter_Title.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Filter_Title.Location = new System.Drawing.Point(126, 42);
            this.TB_Filter_Title.Name = "TB_Filter_Title";
            this.TB_Filter_Title.Size = new System.Drawing.Size(157, 27);
            this.TB_Filter_Title.TabIndex = 4;
            // 
            // BT_Filter
            // 
            this.BT_Filter.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_Filter.Location = new System.Drawing.Point(905, 39);
            this.BT_Filter.Name = "BT_Filter";
            this.BT_Filter.Size = new System.Drawing.Size(82, 28);
            this.BT_Filter.TabIndex = 5;
            this.BT_Filter.Text = "Поиск";
            this.BT_Filter.UseVisualStyleBackColor = true;
            this.BT_Filter.Click += new System.EventHandler(this.BT_Filter_Click);
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
            this.label2.Location = new System.Drawing.Point(122, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_Raiting_Filter);
            this.groupBox1.Controls.Add(this.CB_Genre_Filter);
            this.groupBox1.Controls.Add(this.CB_WFile);
            this.groupBox1.Controls.Add(this.BT_Clear);
            this.groupBox1.Controls.Add(this.BT_Filter);
            this.groupBox1.Controls.Add(this.TB_Year_Filter);
            this.groupBox1.Controls.Add(this.TB_Filter_Title);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 459);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1122, 81);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск записей";
            // 
            // CB_Raiting_Filter
            // 
            this.CB_Raiting_Filter.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.CB_Raiting_Filter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CB_Raiting_Filter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CB_Raiting_Filter.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Raiting_Filter.FormattingEnabled = true;
            this.CB_Raiting_Filter.Items.AddRange(new object[] {
            "⭐",
            "⭐⭐",
            "⭐⭐⭐",
            "⭐⭐⭐⭐",
            "⭐⭐⭐⭐⭐"});
            this.CB_Raiting_Filter.Location = new System.Drawing.Point(554, 41);
            this.CB_Raiting_Filter.Name = "CB_Raiting_Filter";
            this.CB_Raiting_Filter.Size = new System.Drawing.Size(121, 28);
            this.CB_Raiting_Filter.Sorted = true;
            this.CB_Raiting_Filter.TabIndex = 7;
            // 
            // CB_Genre_Filter
            // 
            this.CB_Genre_Filter.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.CB_Genre_Filter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CB_Genre_Filter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CB_Genre_Filter.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CB_Genre_Filter.FormattingEnabled = true;
            this.CB_Genre_Filter.Items.AddRange(new object[] {
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
            this.CB_Genre_Filter.Location = new System.Drawing.Point(289, 42);
            this.CB_Genre_Filter.Name = "CB_Genre_Filter";
            this.CB_Genre_Filter.Size = new System.Drawing.Size(153, 28);
            this.CB_Genre_Filter.Sorted = true;
            this.CB_Genre_Filter.TabIndex = 7;
            // 
            // CB_WFile
            // 
            this.CB_WFile.AutoSize = true;
            this.CB_WFile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CB_WFile.Location = new System.Drawing.Point(708, 42);
            this.CB_WFile.Name = "CB_WFile";
            this.CB_WFile.Size = new System.Drawing.Size(155, 24);
            this.CB_WFile.TabIndex = 6;
            this.CB_WFile.Text = "Только с файлами";
            this.CB_WFile.UseVisualStyleBackColor = true;
            // 
            // BT_Clear
            // 
            this.BT_Clear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_Clear.Location = new System.Drawing.Point(1014, 38);
            this.BT_Clear.Name = "BT_Clear";
            this.BT_Clear.Size = new System.Drawing.Size(82, 28);
            this.BT_Clear.TabIndex = 5;
            this.BT_Clear.Text = "Очистить";
            this.BT_Clear.UseVisualStyleBackColor = true;
            this.BT_Clear.Click += new System.EventHandler(this.BT_Clear_Click);
            // 
            // TB_Year_Filter
            // 
            this.TB_Year_Filter.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Year_Filter.Location = new System.Drawing.Point(448, 42);
            this.TB_Year_Filter.Name = "TB_Year_Filter";
            this.TB_Year_Filter.Size = new System.Drawing.Size(100, 27);
            this.TB_Year_Filter.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(550, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Рейтинг";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(444, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Год";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(285, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Жанр";
            // 
            // TB_Genre
            // 
            this.TB_Genre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Genre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Genre.Location = new System.Drawing.Point(1140, 144);
            this.TB_Genre.Name = "TB_Genre";
            this.TB_Genre.ReadOnly = true;
            this.TB_Genre.Size = new System.Drawing.Size(332, 27);
            this.TB_Genre.TabIndex = 2;
            // 
            // L_Genre
            // 
            this.L_Genre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Genre.AutoSize = true;
            this.L_Genre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_Genre.Location = new System.Drawing.Point(1140, 121);
            this.L_Genre.Name = "L_Genre";
            this.L_Genre.Size = new System.Drawing.Size(92, 20);
            this.L_Genre.TabIndex = 3;
            this.L_Genre.Text = "Жанр книги";
            // 
            // TB_Year
            // 
            this.TB_Year.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Year.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Year.Location = new System.Drawing.Point(1140, 197);
            this.TB_Year.Name = "TB_Year";
            this.TB_Year.ReadOnly = true;
            this.TB_Year.Size = new System.Drawing.Size(164, 27);
            this.TB_Year.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1140, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Год выпуска";
            // 
            // TB_Raiting
            // 
            this.TB_Raiting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Raiting.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Raiting.Location = new System.Drawing.Point(1310, 197);
            this.TB_Raiting.Name = "TB_Raiting";
            this.TB_Raiting.ReadOnly = true;
            this.TB_Raiting.Size = new System.Drawing.Size(162, 27);
            this.TB_Raiting.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(1306, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Рейтинг";
            // 
            // TB_Description
            // 
            this.TB_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Description.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Description.Location = new System.Drawing.Point(1140, 250);
            this.TB_Description.Multiline = true;
            this.TB_Description.Name = "TB_Description";
            this.TB_Description.ReadOnly = true;
            this.TB_Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_Description.Size = new System.Drawing.Size(332, 171);
            this.TB_Description.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(1140, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Аннотация";
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 561);
            this.Controls.Add(this.TB_Filter_Author);
            this.Controls.Add(this.L_Filename);
            this.Controls.Add(this.L_Title);
            this.Controls.Add(this.TB_Filename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.L_Genre);
            this.Controls.Add(this.L_Author);
            this.Controls.Add(this.TB_Title);
            this.Controls.Add(this.TB_Description);
            this.Controls.Add(this.TB_Raiting);
            this.Controls.Add(this.TB_Year);
            this.Controls.Add(this.TB_Genre);
            this.Controls.Add(this.TB_Author);
            this.Controls.Add(this.BT_Del);
            this.Controls.Add(this.BT_Edit);
            this.Controls.Add(this.BT_Open);
            this.Controls.Add(this.BT_Add);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.groupBox1);
            this.Name = "F_Main";
            this.Text = "Книжная полка";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox TB_Filter_Author;
        private System.Windows.Forms.TextBox TB_Filter_Title;
        private System.Windows.Forms.Button BT_Filter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CB_WFile;
        private System.Windows.Forms.TextBox TB_Genre;
        private System.Windows.Forms.Label L_Genre;
        private System.Windows.Forms.ComboBox CB_Genre_Filter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Year_Filter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_Raiting_Filter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Year;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_Raiting;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_Description;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BT_Clear;
    }
}

