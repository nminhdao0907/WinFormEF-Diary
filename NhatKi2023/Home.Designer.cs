namespace NhatKi2023
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            dtDate = new DateTimePicker();
            txtTitle = new TextBox();
            rtContent = new RichTextBox();
            txtHashtag = new TextBox();
            btnUpdate = new Button();
            dgDiary = new DataGridView();
            btnAdd = new Button();
            label7 = new Label();
            btnDelete = new Button();
            groupBox1 = new GroupBox();
            cbFavourite = new CheckBox();
            btnViewFavour = new Button();
            btnSearch = new Button();
            btnReset = new Button();
            label8 = new Label();
            txtId = new TextBox();
            label5 = new Label();
            cbStatus = new ComboBox();
            txtSearch = new TextBox();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgDiary).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Britannic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(13, 30);
            label2.Name = "label2";
            label2.Size = new Size(350, 52);
            label2.TabIndex = 2;
            label2.Text = "New Diary Entry";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(13, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 1);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(9, 89);
            label1.Name = "label1";
            label1.Size = new Size(354, 31);
            label1.TabIndex = 4;
            label1.Text = "Add new entry in your diary";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(24, 320);
            label3.Name = "label3";
            label3.Size = new Size(146, 26);
            label3.TabIndex = 5;
            label3.Text = "Select Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Lucida Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(24, 422);
            label4.Name = "label4";
            label4.Size = new Size(138, 26);
            label4.TabIndex = 5;
            label4.Text = "Enter Title:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Lucida Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(42, 743);
            label6.Name = "label6";
            label6.Size = new Size(70, 26);
            label6.TabIndex = 5;
            label6.Text = "Tags";
            // 
            // dtDate
            // 
            dtDate.CalendarMonthBackground = Color.Black;
            dtDate.Location = new Point(27, 349);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(300, 27);
            dtDate.TabIndex = 6;
            dtDate.ValueChanged += dtDate_ValueChanged;
            dtDate.Enter += dtDate_Enter;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = SystemColors.Menu;
            txtTitle.Location = new Point(28, 451);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = " Enter your title";
            txtTitle.Size = new Size(300, 27);
            txtTitle.TabIndex = 7;
            txtTitle.Enter += txtTitle_Enter;
            txtTitle.Leave += txtTitle_Leave;
            // 
            // rtContent
            // 
            rtContent.BackColor = Color.WhiteSmoke;
            rtContent.BorderStyle = BorderStyle.None;
            rtContent.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rtContent.Location = new Point(28, 539);
            rtContent.Name = "rtContent";
            rtContent.Size = new Size(1213, 184);
            rtContent.TabIndex = 8;
            rtContent.Text = "";
            // 
            // txtHashtag
            // 
            txtHashtag.Location = new Point(113, 745);
            txtHashtag.Name = "txtHashtag";
            txtHashtag.PlaceholderText = " #hashtag, #different_hashtag";
            txtHashtag.Size = new Size(250, 27);
            txtHashtag.TabIndex = 7;
            txtHashtag.Enter += txtHashtag_Enter;
            txtHashtag.Leave += txtHashtag_Leave;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.ActiveCaptionText;
            btnUpdate.Location = new Point(13, 45);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(131, 44);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "MODIFY";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dgDiary
            // 
            dgDiary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDiary.Location = new Point(384, 130);
            dgDiary.Name = "dgDiary";
            dgDiary.RowHeadersWidth = 51;
            dgDiary.RowTemplate.Height = 29;
            dgDiary.Size = new Size(857, 403);
            dgDiary.TabIndex = 10;
            dgDiary.CellClick += dgDiary_CellClick;
            dgDiary.CellContentClick += dgDiary_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(1107, 736);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(134, 43);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "SAVE CHANGES";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Lucida Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(28, 498);
            label7.Name = "label7";
            label7.Size = new Size(272, 26);
            label7.TabIndex = 5;
            label7.Text = "Write your story here: ";
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.Location = new Point(173, 45);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 44);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(cbFavourite);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnViewFavour);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(24, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 187);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose your option";
            // 
            // cbFavourite
            // 
            cbFavourite.AutoSize = true;
            cbFavourite.ForeColor = Color.Black;
            cbFavourite.Location = new Point(13, 95);
            cbFavourite.Name = "cbFavourite";
            cbFavourite.Size = new Size(198, 32);
            cbFavourite.TabIndex = 14;
            cbFavourite.Text = "Add to favourites";
            cbFavourite.UseVisualStyleBackColor = true;
            cbFavourite.CheckedChanged += cbFavourite_CheckedChanged;
            // 
            // btnViewFavour
            // 
            btnViewFavour.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnViewFavour.ForeColor = SystemColors.ActiveCaptionText;
            btnViewFavour.Location = new Point(18, 133);
            btnViewFavour.Name = "btnViewFavour";
            btnViewFavour.Size = new Size(285, 44);
            btnViewFavour.TabIndex = 9;
            btnViewFavour.Text = "VIEW MY FAVOURITE";
            btnViewFavour.UseVisualStyleBackColor = true;
            btnViewFavour.Click += btnViewFavour_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.ActiveCaptionText;
            btnSearch.Location = new Point(615, 80);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(131, 44);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Location = new Point(967, 736);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(134, 43);
            btnReset.TabIndex = 9;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Lucida Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(421, 745);
            label8.Name = "label8";
            label8.Size = new Size(43, 26);
            label8.TabIndex = 5;
            label8.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(459, 745);
            txtId.Name = "txtId";
            txtId.PlaceholderText = " Your Entry's ID";
            txtId.ReadOnly = true;
            txtId.Size = new Size(115, 27);
            txtId.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(946, 97);
            label5.Name = "label5";
            label5.Size = new Size(77, 23);
            label5.TabIndex = 5;
            label5.Text = "Status";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(1029, 94);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(198, 28);
            cbStatus.TabIndex = 12;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(384, 88);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Type here to search...";
            txtSearch.Size = new Size(225, 34);
            txtSearch.TabIndex = 13;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(824, 738);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(134, 43);
            btnExit.TabIndex = 9;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1282, 802);
            Controls.Add(txtSearch);
            Controls.Add(cbStatus);
            Controls.Add(btnSearch);
            Controls.Add(groupBox1);
            Controls.Add(dgDiary);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnAdd);
            Controls.Add(rtContent);
            Controls.Add(txtHashtag);
            Controls.Add(txtId);
            Controls.Add(txtTitle);
            Controls.Add(dtDate);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            MouseLeave += Home_MouseLeave;
            ((System.ComponentModel.ISupportInitialize)dgDiary).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dtDate;
        private TextBox txtTitle;
        private RichTextBox rtContent;
        private TextBox txtHashtag;
        private Button btnUpdate;
        private DataGridView dgDiary;
        private Button btnAdd;
        private Label label7;
        private Button btnDelete;
        private GroupBox groupBox1;
        private Button btnReset;
        private Label label8;
        private TextBox txtId;
        private ComboBox cbStatus;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnExit;
        private CheckBox cbFavourite;
        private Button btnViewFavour;
    }
}