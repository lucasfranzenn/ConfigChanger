namespace ChangeConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            txt_host = new TextBox();
            txt_user = new TextBox();
            label2 = new Label();
            txt_pwd = new TextBox();
            label3 = new Label();
            txt_port = new TextBox();
            label4 = new Label();
            txt_db = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(459, 276);
            button1.Name = "button1";
            button1.Size = new Size(121, 40);
            button1.TabIndex = 5;
            button1.Text = "Atualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 44);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 1;
            label1.Text = "Ip Servidor";
            // 
            // txt_host
            // 
            txt_host.BorderStyle = BorderStyle.FixedSingle;
            txt_host.Location = new Point(21, 67);
            txt_host.Name = "txt_host";
            txt_host.Size = new Size(125, 27);
            txt_host.TabIndex = 0;
            // 
            // txt_user
            // 
            txt_user.BorderStyle = BorderStyle.FixedSingle;
            txt_user.Location = new Point(189, 67);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(125, 27);
            txt_user.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 44);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 3;
            label2.Text = "Usuário ";
            // 
            // txt_pwd
            // 
            txt_pwd.BorderStyle = BorderStyle.FixedSingle;
            txt_pwd.Location = new Point(356, 67);
            txt_pwd.Name = "txt_pwd";
            txt_pwd.Size = new Size(125, 27);
            txt_pwd.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(356, 44);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 5;
            label3.Text = "Senha";
            // 
            // txt_port
            // 
            txt_port.BorderStyle = BorderStyle.FixedSingle;
            txt_port.Location = new Point(21, 126);
            txt_port.Name = "txt_port";
            txt_port.Size = new Size(125, 27);
            txt_port.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 103);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 7;
            label4.Text = "Porta";
            // 
            // txt_db
            // 
            txt_db.BorderStyle = BorderStyle.FixedSingle;
            txt_db.Location = new Point(189, 126);
            txt_db.Name = "txt_db";
            txt_db.Size = new Size(125, 27);
            txt_db.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(189, 103);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 9;
            label5.Text = "Banco de dados";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(743, 383);
            Controls.Add(txt_db);
            Controls.Add(label5);
            Controls.Add(txt_port);
            Controls.Add(label4);
            Controls.Add(txt_pwd);
            Controls.Add(label3);
            Controls.Add(txt_user);
            Controls.Add(label2);
            Controls.Add(txt_host);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Config.ini Changer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox txt_host;
        private TextBox txt_user;
        private Label label2;
        private TextBox txt_pwd;
        private Label label3;
        private TextBox txt_port;
        private Label label4;
        private TextBox txt_db;
        private Label label5;
    }
}