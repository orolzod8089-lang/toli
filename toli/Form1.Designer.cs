namespace toli
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSearch = new TextBox();
            lblSearch = new Label();
            lblLanguage = new Label();
            cmbLanguage = new ComboBox();
            lblWords = new Label();
            dgvWords = new DataGridView();
            colld = new DataGridViewTextBoxColumn();
            colEng = new DataGridViewTextBoxColumn();
            colMon = new DataGridViewTextBoxColumn();
            colRus = new DataGridViewTextBoxColumn();
            lblSaved = new Label();
            lblEng = new Label();
            lblMon = new Label();
            label4 = new Label();
            textEng = new TextBox();
            textMon = new TextBox();
            textBox3 = new TextBox();
            btnAdd = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            lblCount = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvWords).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(75, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(430, 27);
            txtSearch.TabIndex = 0;
            txtSearch.Text = "Хайх үг ...";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(20, 25);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(45, 20);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Хайх:";
            lblSearch.Click += label1_Click;
            // 
            // lblLanguage
            // 
            lblLanguage.AutoSize = true;
            lblLanguage.Location = new Point(620, 25);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(36, 20);
            lblLanguage.TabIndex = 3;
            lblLanguage.Text = "Хэл:";
            // 
            // cmbLanguage
            // 
            cmbLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLanguage.FormattingEnabled = true;
            cmbLanguage.Location = new Point(665, 15);
            cmbLanguage.Name = "cmbLanguage";
            cmbLanguage.Size = new Size(135, 28);
            cmbLanguage.TabIndex = 4;
            // 
            // lblWords
            // 
            lblWords.AutoSize = true;
            lblWords.Location = new Point(20, 85);
            lblWords.Name = "lblWords";
            lblWords.Size = new Size(106, 20);
            lblWords.TabIndex = 5;
            lblWords.Tag = "";
            lblWords.Text = "toli.db • words";
            // 
            // dgvWords
            // 
            dgvWords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvWords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWords.Columns.AddRange(new DataGridViewColumn[] { colld, colEng, colMon, colRus });
            dgvWords.Location = new Point(20, 120);
            dgvWords.Name = "dgvWords";
            dgvWords.ReadOnly = true;
            dgvWords.RowHeadersVisible = false;
            dgvWords.RowHeadersWidth = 51;
            dgvWords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvWords.Size = new Size(500, 335);
            dgvWords.TabIndex = 6;
            dgvWords.CellContentClick += dgvWords_CellContentClick;
            // 
            // colld
            // 
            colld.HeaderText = "№";
            colld.MinimumWidth = 6;
            colld.Name = "colld";
            colld.ReadOnly = true;
            // 
            // colEng
            // 
            colEng.HeaderText = "Англи";
            colEng.MinimumWidth = 6;
            colEng.Name = "colEng";
            colEng.ReadOnly = true;
            // 
            // colMon
            // 
            colMon.HeaderText = "Монгол";
            colMon.MinimumWidth = 6;
            colMon.Name = "colMon";
            colMon.ReadOnly = true;
            // 
            // colRus
            // 
            colRus.HeaderText = "Орос";
            colRus.MinimumWidth = 6;
            colRus.Name = "colRus";
            colRus.ReadOnly = true;
            // 
            // lblSaved
            // 
            lblSaved.AutoSize = true;
            lblSaved.Location = new Point(530, 85);
            lblSaved.Name = "lblSaved";
            lblSaved.Size = new Size(166, 20);
            lblSaved.TabIndex = 7;
            lblSaved.Text = "saved.db • saved_words";
            // 
            // lblEng
            // 
            lblEng.AutoSize = true;
            lblEng.Location = new Point(20, 475);
            lblEng.Name = "lblEng";
            lblEng.Size = new Size(51, 20);
            lblEng.TabIndex = 11;
            lblEng.Text = "Англи";
            lblEng.Click += lblEng_Click;
            // 
            // lblMon
            // 
            lblMon.AutoSize = true;
            lblMon.Location = new Point(278, 475);
            lblMon.Name = "lblMon";
            lblMon.Size = new Size(63, 20);
            lblMon.TabIndex = 12;
            lblMon.Text = "Монгол";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(551, 475);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 13;
            label4.Text = "Орос";
            // 
            // textEng
            // 
            textEng.Location = new Point(77, 472);
            textEng.Name = "textEng";
            textEng.Size = new Size(198, 27);
            textEng.TabIndex = 14;
            // 
            // textMon
            // 
            textMon.Location = new Point(602, 472);
            textMon.Name = "textMon";
            textMon.Size = new Size(198, 27);
            textMon.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(347, 472);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(198, 27);
            textBox3.TabIndex = 16;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(55, 527);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "+ Нэмэх";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(171, 527);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 18;
            button2.Text = "Засах";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(289, 527);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 19;
            button3.Text = "Устгах";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(411, 527);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 20;
            button4.Text = "Цэвэрлэх";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(530, 527);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 21;
            button5.Text = "Санах";
            button5.UseVisualStyleBackColor = true;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(20, 580);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(163, 20);
            lblCount.TabIndex = 22;
            lblCount.Tag = "";
            lblCount.Text = "Нийт: 0 үг • Санасан: 0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 255, 192);
            label2.Location = new Point(598, 128);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 24;
            label2.Text = "Санасан үгс";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(598, 151);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(91, 27);
            textBox1.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(832, 653);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(lblCount);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnAdd);
            Controls.Add(textBox3);
            Controls.Add(textMon);
            Controls.Add(textEng);
            Controls.Add(label4);
            Controls.Add(lblMon);
            Controls.Add(lblEng);
            Controls.Add(lblSaved);
            Controls.Add(dgvWords);
            Controls.Add(lblWords);
            Controls.Add(cmbLanguage);
            Controls.Add(lblLanguage);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            MaximumSize = new Size(850, 700);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гурван хэлний толь бичиг";
            ((System.ComponentModel.ISupportInitialize)dgvWords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Label lblSearch;
        private Label lblLanguage;
        private ComboBox cmbLanguage;
        private Label lblWords;
        private DataGridView dgvWords;
        private DataGridViewTextBoxColumn colld;
        private DataGridViewTextBoxColumn colEng;
        private DataGridViewTextBoxColumn colMon;
        private DataGridViewTextBoxColumn colRus;
        private Label lblSaved;
        private Label lblEng;
        private Label lblMon;
        private Label label4;
        private TextBox textEng;
        private TextBox textMon;
        private TextBox textBox3;
        private Button btnAdd;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label lblCount;
        private Label label2;
        private TextBox textBox1;
    }
}
