namespace teste
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnImportFile = new System.Windows.Forms.Button();
            this.btnExportFile = new System.Windows.Forms.Button();
            this.panelExportFileSubmenu = new System.Windows.Forms.Panel();
            this.btnJSON = new System.Windows.Forms.Button();
            this.btnXML = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.nameFileBox = new System.Windows.Forms.TextBox();
            this.nameFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.teste = new System.Windows.Forms.Label();
            this.panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelExportFileSubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelSideMenu.Controls.Add(this.pictureBox1);
            this.panelSideMenu.Controls.Add(this.btnImportFile);
            this.panelSideMenu.Controls.Add(this.btnExportFile);
            this.panelSideMenu.Controls.Add(this.panelExportFileSubmenu);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(195, 600);
            this.panelSideMenu.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnImportFile
            // 
            this.btnImportFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImportFile.FlatAppearance.BorderSize = 0;
            this.btnImportFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportFile.Font = new System.Drawing.Font("MesloLGS NF", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportFile.ForeColor = System.Drawing.Color.White;
            this.btnImportFile.Image = ((System.Drawing.Image)(resources.GetObject("btnImportFile.Image")));
            this.btnImportFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportFile.Location = new System.Drawing.Point(3, 117);
            this.btnImportFile.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.btnImportFile.Name = "btnImportFile";
            this.btnImportFile.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnImportFile.Size = new System.Drawing.Size(173, 40);
            this.btnImportFile.TabIndex = 1;
            this.btnImportFile.Text = "Import File";
            this.btnImportFile.UseVisualStyleBackColor = true;
            this.btnImportFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExportFile
            // 
            this.btnExportFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExportFile.FlatAppearance.BorderSize = 0;
            this.btnExportFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportFile.Font = new System.Drawing.Font("MesloLGS NF", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportFile.ForeColor = System.Drawing.Color.White;
            this.btnExportFile.Image = ((System.Drawing.Image)(resources.GetObject("btnExportFile.Image")));
            this.btnExportFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportFile.Location = new System.Drawing.Point(3, 180);
            this.btnExportFile.Name = "btnExportFile";
            this.btnExportFile.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExportFile.Size = new System.Drawing.Size(173, 35);
            this.btnExportFile.TabIndex = 2;
            this.btnExportFile.Text = "Export File";
            this.btnExportFile.UseVisualStyleBackColor = true;
            this.btnExportFile.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelExportFileSubmenu
            // 
            this.panelExportFileSubmenu.Controls.Add(this.btnJSON);
            this.panelExportFileSubmenu.Controls.Add(this.btnXML);
            this.panelExportFileSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelExportFileSubmenu.Location = new System.Drawing.Point(3, 221);
            this.panelExportFileSubmenu.Name = "panelExportFileSubmenu";
            this.panelExportFileSubmenu.Size = new System.Drawing.Size(173, 138);
            this.panelExportFileSubmenu.TabIndex = 3;
            // 
            // btnJSON
            // 
            this.btnJSON.BackColor = System.Drawing.Color.Transparent;
            this.btnJSON.FlatAppearance.BorderSize = 0;
            this.btnJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJSON.Font = new System.Drawing.Font("MesloLGS NF", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJSON.ForeColor = System.Drawing.Color.Snow;
            this.btnJSON.Image = ((System.Drawing.Image)(resources.GetObject("btnJSON.Image")));
            this.btnJSON.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJSON.Location = new System.Drawing.Point(35, 39);
            this.btnJSON.Name = "btnJSON";
            this.btnJSON.Size = new System.Drawing.Size(88, 25);
            this.btnJSON.TabIndex = 1;
            this.btnJSON.Text = "JSON";
            this.btnJSON.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnJSON.UseVisualStyleBackColor = false;
            this.btnJSON.Click += new System.EventHandler(this.btnJSON_Click);
            // 
            // btnXML
            // 
            this.btnXML.BackColor = System.Drawing.Color.Transparent;
            this.btnXML.FlatAppearance.BorderSize = 0;
            this.btnXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXML.Font = new System.Drawing.Font("MesloLGS NF", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXML.ForeColor = System.Drawing.Color.Snow;
            this.btnXML.Image = ((System.Drawing.Image)(resources.GetObject("btnXML.Image")));
            this.btnXML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXML.Location = new System.Drawing.Point(35, 3);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(79, 30);
            this.btnXML.TabIndex = 0;
            this.btnXML.Text = "XML";
            this.btnXML.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXML.UseVisualStyleBackColor = false;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(195, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 10);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(901, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 23);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // nameFileBox
            // 
            this.nameFileBox.Location = new System.Drawing.Point(313, 59);
            this.nameFileBox.Name = "nameFileBox";
            this.nameFileBox.Size = new System.Drawing.Size(179, 20);
            this.nameFileBox.TabIndex = 3;
            // 
            // nameFilePath
            // 
            this.nameFilePath.Location = new System.Drawing.Point(313, 94);
            this.nameFilePath.Name = "nameFilePath";
            this.nameFilePath.Size = new System.Drawing.Size(350, 20);
            this.nameFilePath.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(239, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Arquivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(239, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Diretório";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(715, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quantidade de arquivos persistidos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teste
            // 
            this.teste.AutoSize = true;
            this.teste.BackColor = System.Drawing.Color.Transparent;
            this.teste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teste.Font = new System.Drawing.Font("MesloLGS NF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teste.ForeColor = System.Drawing.Color.Red;
            this.teste.Location = new System.Drawing.Point(786, 82);
            this.teste.Name = "teste";
            this.teste.Size = new System.Drawing.Size(0, 34);
            this.teste.TabIndex = 12;
            this.teste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.teste);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameFilePath);
            this.Controls.Add(this.nameFileBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelExportFileSubmenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelSideMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnImportFile;
        private System.Windows.Forms.Button btnExportFile;
        private System.Windows.Forms.Panel panelExportFileSubmenu;
        private System.Windows.Forms.Button btnJSON;
        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox nameFileBox;
        private System.Windows.Forms.TextBox nameFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label teste;
    }
}

