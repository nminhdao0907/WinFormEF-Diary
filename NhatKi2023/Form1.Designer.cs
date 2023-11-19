namespace NhatKi2023
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            btnLogin = new Button();
            label3 = new Label();
            label2 = new Label();
            txtPass = new TextBox();
            cbShowPass = new CheckBox();
            label5 = new Label();
            lblSignUp = new LinkLabel();
            txtName = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._21;
            pictureBox1.Location = new Point(-4, -18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(468, 527);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(470, 76);
            label1.Name = "label1";
            label1.Size = new Size(364, 48);
            label1.TabIndex = 1;
            label1.Text = "Login to TheDiary";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Image = Properties.Resources.a9b2f152157575_59075366924b0;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.AccessibleRole = AccessibleRole.SplitButton;
            btnLogin.BackColor = Color.FromArgb(116, 86, 174);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(578, 350);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(165, 48);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SlateGray;
            label3.Location = new Point(515, 234);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 22;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SlateGray;
            label2.Location = new Point(515, 158);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 23;
            label2.Text = "Username";
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.FromArgb(230, 231, 233);
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Lucida Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(515, 264);
            txtPass.Multiline = true;
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '•';
            txtPass.Size = new Size(277, 28);
            txtPass.TabIndex = 20;
            txtPass.TextChanged += txtPass_TextChanged;
            txtPass.Enter += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;
            // 
            // cbShowPass
            // 
            cbShowPass.AutoSize = true;
            cbShowPass.BackColor = Color.Transparent;
            cbShowPass.Cursor = Cursors.Hand;
            cbShowPass.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbShowPass.ForeColor = Color.Gray;
            cbShowPass.Location = new Point(669, 308);
            cbShowPass.Name = "cbShowPass";
            cbShowPass.Size = new Size(123, 21);
            cbShowPass.TabIndex = 24;
            cbShowPass.Text = "Show password";
            cbShowPass.UseVisualStyleBackColor = false;
            cbShowPass.CheckedChanged += cbShowPass_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(526, 424);
            label5.Name = "label5";
            label5.Size = new Size(196, 22);
            label5.TabIndex = 26;
            label5.Text = "Don't have an account? ";
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblSignUp.ForeColor = SystemColors.ControlText;
            lblSignUp.LinkColor = Color.FromArgb(116, 86, 174);
            lblSignUp.Location = new Point(716, 423);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(78, 22);
            lblSignUp.TabIndex = 27;
            lblSignUp.TabStop = true;
            lblSignUp.Text = "Sign Up";
            lblSignUp.LinkClicked += lblSignUp_LinkClicked;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(230, 231, 233);
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(515, 191);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(277, 28);
            txtName.TabIndex = 28;
            txtName.TextChanged += txtName_TextChanged;
            txtName.Enter += txtName_Enter;
            txtName.Leave += txtName_Leave;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(499, 466);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 29;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Visible = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(874, 507);
            Controls.Add(btnExit);
            Controls.Add(txtName);
            Controls.Add(lblSignUp);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(cbShowPass);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPass);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "frmLogin";
            Load += Form1_Load;
            MouseLeave += Form1_MouseLeave;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Button btnLogin;
        private Label label3;
        private Label label2;
        private TextBox txtPass;
        private CheckBox cbShowPass;
        private Label label5;
        private LinkLabel lblSignUp;
        private TextBox txtName;
        private System.Windows.Forms.Timer timer1;
        private Button btnExit;
    }
}