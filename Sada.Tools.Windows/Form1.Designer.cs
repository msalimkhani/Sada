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
            groupBox5 = new GroupBox();
            btnInsertJWT = new Button();
            txtAudience = new TextBox();
            txtIssuer = new TextBox();
            txtKeyJWT = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            btnLoad = new Button();
            btnBrowseJson = new Button();
            txtJsonPath = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            gbInsert.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
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
            tabPage2.Controls.Add(groupBox5);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(573, 350);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "JWT tools";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnInsertJWT);
            groupBox5.Controls.Add(txtAudience);
            groupBox5.Controls.Add(txtIssuer);
            groupBox5.Controls.Add(txtKeyJWT);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(label3);
            groupBox5.Location = new Point(8, 127);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(557, 199);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Jwt Secret Insertor";
            // 
            // btnInsertJWT
            // 
            btnInsertJWT.Location = new Point(476, 170);
            btnInsertJWT.Name = "btnInsertJWT";
            btnInsertJWT.Size = new Size(75, 23);
            btnInsertJWT.TabIndex = 6;
            btnInsertJWT.Text = "Insert";
            btnInsertJWT.UseVisualStyleBackColor = true;
            btnInsertJWT.Click += btnInsertJWT_Click;
            // 
            // txtAudience
            // 
            txtAudience.Location = new Point(75, 115);
            txtAudience.Name = "txtAudience";
            txtAudience.Size = new Size(476, 23);
            txtAudience.TabIndex = 5;
            // 
            // txtIssuer
            // 
            txtIssuer.Location = new Point(75, 66);
            txtIssuer.Name = "txtIssuer";
            txtIssuer.Size = new Size(476, 23);
            txtIssuer.TabIndex = 4;
            // 
            // txtKeyJWT
            // 
            txtKeyJWT.Location = new Point(75, 31);
            txtKeyJWT.Name = "txtKeyJWT";
            txtKeyJWT.Size = new Size(476, 23);
            txtKeyJWT.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 118);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 2;
            label5.Text = "Audience :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 69);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 1;
            label4.Text = "Issuer :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 34);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 0;
            label3.Text = "Key :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnLoad);
            groupBox3.Controls.Add(btnBrowseJson);
            groupBox3.Controls.Add(txtJsonPath);
            groupBox3.Location = new Point(8, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(557, 97);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "appsettings.json";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(6, 68);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(545, 23);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnBrowseJson
            // 
            btnBrowseJson.Location = new Point(528, 22);
            btnBrowseJson.Name = "btnBrowseJson";
            btnBrowseJson.Size = new Size(23, 23);
            btnBrowseJson.TabIndex = 1;
            btnBrowseJson.Text = "...";
            btnBrowseJson.UseVisualStyleBackColor = true;
            btnBrowseJson.Click += btnBrowseJson_Click;
            // 
            // txtJsonPath
            // 
            txtJsonPath.Enabled = false;
            txtJsonPath.Location = new Point(6, 22);
            txtJsonPath.Name = "txtJsonPath";
            txtJsonPath.Size = new Size(517, 23);
            txtJsonPath.TabIndex = 0;
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
            tabPage2.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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
        private GroupBox groupBox5;
        private GroupBox groupBox3;
        private Button btnBrowseJson;
        private TextBox txtJsonPath;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnInsertJWT;
        private TextBox txtAudience;
        private TextBox txtIssuer;
        private TextBox txtKeyJWT;
        private Button btnLoad;
    }
}
