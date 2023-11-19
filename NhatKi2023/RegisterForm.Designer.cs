namespace NhatKi2023
{
    partial class RegisterForm
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
            components = new System.ComponentModel.Container();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            txtName2 = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPass2 = new TextBox();
            txtComPass = new TextBox();
            btnRegister = new Button();
            cbShowPass = new CheckBox();
            pictureBox2 = new PictureBox();
            lblSignIn = new LinkLabel();
            label5 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(450, 68);
            label1.Name = "label1";
            label1.Size = new Size(381, 44);
            label1.TabIndex = 10;
            label1.Text = "Register to TheDiary";
            // 
            // txtName2
            // 
            txtName2.BackColor = Color.FromArgb(230, 231, 233);
            txtName2.BorderStyle = BorderStyle.None;
            txtName2.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtName2.ForeColor = SystemColors.WindowText;
            txtName2.Location = new Point(519, 161);
            txtName2.Multiline = true;
            txtName2.Name = "txtName2";
            txtName2.Size = new Size(277, 28);
            txtName2.TabIndex = 13;
            txtName2.TextChanged += txtName2_TextChanged;
            txtName2.Enter += txtName2_Enter;
            txtName2.Leave += txtName2_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._21;
            pictureBox1.Location = new Point(-5, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(468, 527);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SlateGray;
            label2.Location = new Point(519, 133);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 19;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SlateGray;
            label3.Location = new Point(519, 204);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 19;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.SlateGray;
            label4.Location = new Point(519, 272);
            label4.Name = "label4";
            label4.Size = new Size(179, 21);
            label4.TabIndex = 19;
            label4.Text = "Confirm Password";
            // 
            // txtPass2
            // 
            txtPass2.BackColor = Color.FromArgb(230, 231, 233);
            txtPass2.BorderStyle = BorderStyle.None;
            txtPass2.Font = new Font("Lucida Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass2.Location = new Point(519, 230);
            txtPass2.Multiline = true;
            txtPass2.Name = "txtPass2";
            txtPass2.PasswordChar = '•';
            txtPass2.Size = new Size(277, 27);
            txtPass2.TabIndex = 13;
            txtPass2.LocationChanged += txtPass2_LocationChanged;
            txtPass2.TextChanged += txtPass2_TextChanged;
            txtPass2.Enter += txtPass2_Enter;
            txtPass2.Leave += txtPass2_Leave;
            // 
            // txtComPass
            // 
            txtComPass.BackColor = Color.FromArgb(230, 231, 233);
            txtComPass.BorderStyle = BorderStyle.None;
            txtComPass.Font = new Font("Lucida Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtComPass.Location = new Point(519, 298);
            txtComPass.Multiline = true;
            txtComPass.Name = "txtComPass";
            txtComPass.PasswordChar = '•';
            txtComPass.Size = new Size(277, 27);
            txtComPass.TabIndex = 13;
            txtComPass.TextChanged += txtComPass_TextChanged;
            txtComPass.Enter += txtComPass_Enter;
            txtComPass.Leave += txtComPass_Leave;
            // 
            // btnRegister
            // 
            btnRegister.AccessibleRole = AccessibleRole.SplitButton;
            btnRegister.BackColor = Color.FromArgb(116, 86, 174);
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = SystemColors.ButtonHighlight;
            btnRegister.Location = new Point(564, 376);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(165, 48);
            btnRegister.TabIndex = 20;
            btnRegister.Text = "CONFIRM";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // cbShowPass
            // 
            cbShowPass.AutoSize = true;
            cbShowPass.Cursor = Cursors.Hand;
            cbShowPass.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbShowPass.ForeColor = Color.Gray;
            cbShowPass.Location = new Point(673, 340);
            cbShowPass.Name = "cbShowPass";
            cbShowPass.Size = new Size(123, 21);
            cbShowPass.TabIndex = 25;
            cbShowPass.Text = "Show password";
            cbShowPass.UseVisualStyleBackColor = true;
            cbShowPass.CheckedChanged += cbShowPass_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Image = Properties.Resources.a9b2f152157575_59075366924b0;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // lblSignIn
            // 
            lblSignIn.AutoSize = true;
            lblSignIn.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblSignIn.ForeColor = SystemColors.ControlText;
            lblSignIn.LinkColor = Color.FromArgb(116, 86, 174);
            lblSignIn.Location = new Point(721, 443);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(75, 22);
            lblSignIn.TabIndex = 29;
            lblSignIn.TabStop = true;
            lblSignIn.Text = "Sign In";
            lblSignIn.LinkClicked += lblSignIn_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(511, 444);
            label5.Name = "label5";
            label5.Size = new Size(218, 22);
            label5.TabIndex = 28;
            label5.Text = "Already have an account? ";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(766, 488);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 30;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(872, 529);
            Controls.Add(btnExit);
            Controls.Add(lblSignIn);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(cbShowPass);
            Controls.Add(btnRegister);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtComPass);
            Controls.Add(txtPass2);
            Controls.Add(txtName2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            MouseLeave += RegisterForm_MouseLeave;
            MouseMove += RegisterForm_MouseMove;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private TextBox txtName2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPass2;
        private TextBox txtComPass;
        private Button btnRegister;
        private CheckBox cbShowPass;
        private PictureBox pictureBox2;
        private LinkLabel lblSignIn;
        private Label label5;
        private System.Windows.Forms.Timer timer1;
        private Button btnExit;
    }
}