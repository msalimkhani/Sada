namespace Sada.Tools.Windows
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            btnInitSecrets = new Button();
            gbInsert = new GroupBox();
            btnInsert = new Button();
            txtValue = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtKey = new TextBox();
            groupBox1 = new GroupBox();
            btnBrowse = new Button();
            txtPath = new TextBox();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            gbInsert.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(581, 378);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(573, 350);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "User Secrets";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(gbInsert);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 69);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(567, 278);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnInitSecrets);
            groupBox4.Dock = DockStyle.Right;
            groupBox4.Location = new Point(411, 19);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(153, 256);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            // 
            // btnInitSecrets
            // 
            btnInitSecrets.Location = new Point(6, 22);
            btnInitSecrets.Name = "btnInitSecrets";
            btnInitSecrets.Size = new Size(141, 228);
            btnInitSecrets.TabIndex = 3;
            btnInitSecrets.Text = "Init User Secrets";
            btnInitSecrets.UseVisualStyleBackColor = true;
            btnInitSecrets.Click += btnInitSecrets_Click;
            // 
            // gbInsert
            // 
            gbInsert.Controls.Add(btnInsert);
            gbInsert.Controls.Add(txtValue);
            gbInsert.Controls.Add(label2);
            gbInsert.Controls.Add(label1);
            gbInsert.Controls.Add(txtKey);
            gbInsert.Dock = DockStyle.Left;
            gbInsert.Enabled = false;
            gbInsert.Location = new Point(3, 19);
            gbInsert.Name = "gbInsert";
            gbInsert.Size = new Size(400, 256);
            gbInsert.TabIndex = 2;
            gbInsert.TabStop = false;
            gbInsert.Text = "Insert :";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(315, 227);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // txtValue
            // 
            txtValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtValue.Location = new Point(47, 66);
            txtValue.Multiline = true;
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(343, 155);
            txtValue.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 69);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 2;
            label2.Text = "Value :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 1;
            label1.Text = "Key : ";
            // 
            // txtKey
            // 
            txtKey.Location = new Point(47, 19);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(343, 23);
            txtKey.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBrowse);
            groupBox1.Controls.Add(txtPath);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(567, 66);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Startup Project :";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(538, 22);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(29, 23);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtPath
            // 
            txtPath.Enabled = false;
            txtPath.Location = new Point(6, 22);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(527, 23);
            txtPath.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(573, 350);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "JWT tools";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 378);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            gbInsert.ResumeLayout(false);
            gbInsert.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TabPage tabPage2;
        private Button btnBrowse;
        private TextBox txtPath;
        private GroupBox groupBox4;
        private Button btnInitSecrets;
        private GroupBox gbInsert;
        private Button btnInsert;
        private TextBox txtValue;
        private Label label2;
        private Label label1;
        private TextBox txtKey;
    }
}
