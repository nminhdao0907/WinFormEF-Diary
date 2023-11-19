namespace NhatKi2023
{
    partial class MyFavourite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyFavourite));
            cbStatus = new ComboBox();
            btnSearch = new Button();
            btnReset = new Button();
            groupBox1 = new GroupBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtSearch = new TextBox();
            dgFavourite = new DataGridView();
            btnAdd = new Button();
            txtId = new TextBox();
            label5 = new Label();
            label8 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgFavourite).BeginInit();
            SuspendLayout();
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(1052, 89);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(198, 28);
            cbStatus.TabIndex = 34;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.ActiveCaptionText;
            btnSearch.Location = new Point(639, 78);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(131, 44);
            btnSearch.TabIndex = 31;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Location = new Point(985, 614);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(134, 43);
            btnReset.TabIndex = 29;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(48, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 159);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose your option";
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
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(408, 88);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Type here to search...";
            txtSearch.Size = new Size(225, 34);
            txtSearch.TabIndex = 35;
            // 
            // dgFavourite
            // 
            dgFavourite.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgFavourite.Location = new Point(408, 187);
            dgFavourite.Name = "dgFavourite";
            dgFavourite.RowHeadersWidth = 51;
            dgFavourite.RowTemplate.Height = 29;
            dgFavourite.Size = new Size(857, 403);
            dgFavourite.TabIndex = 32;
            dgFavourite.CellContentClick += dgFavourite_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(1125, 614);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(134, 43);
            btnAdd.TabIndex = 28;
            btnAdd.Text = "SAVE CHANGES";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Location = new Point(483, 703);
            txtId.Name = "txtId";
            txtId.PlaceholderText = " Your Entry's ID";
            txtId.ReadOnly = true;
            txtId.Size = new Size(115, 27);
            txtId.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(969, 89);
            label5.Name = "label5";
            label5.Size = new Size(77, 23);
            label5.TabIndex = 21;
            label5.Text = "Status";
            label5.Click += label5_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Lucida Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(445, 703);
            label8.Name = "label8";
            label8.Size = new Size(43, 26);
            label8.TabIndex = 20;
            label8.Text = "ID:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(445, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 1);
            panel1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Britannic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(430, 9);
            label2.Name = "label2";
            label2.Size = new Size(406, 52);
            label2.TabIndex = 14;
            label2.Text = "My Favourite Entry";
            // 
            // button2
            // 
            button2.Location = new Point(852, 614);
            button2.Name = "button2";
            button2.Size = new Size(127, 42);
            button2.TabIndex = 10;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MyFavourite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1299, 726);
            Controls.Add(button2);
            Controls.Add(cbStatus);
            Controls.Add(btnSearch);
            Controls.Add(btnReset);
            Controls.Add(groupBox1);
            Controls.Add(txtSearch);
            Controls.Add(dgFavourite);
            Controls.Add(btnAdd);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "MyFavourite";
            Text = "MyFavourite";
            Load += MyFavourite_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgFavourite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbStatus;
        private Button btnSearch;
        private Button btnExit;
        private Button btnReset;
        private GroupBox groupBox1;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtSearch;
        private DataGridView dgFavourite;
        private Button btnAdd;
        private TextBox txtId;
        private Label label5;
        private Label label8;
        private Panel panel1;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}