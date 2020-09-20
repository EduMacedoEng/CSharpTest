namespace TesteFortes
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
            this.label3 = new System.Windows.Forms.Label();
            this.teste = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelExportFileSubmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(260, 738);
            this.panelSideMenu.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.btnImportFile.Location = new System.Drawing.Point(4, 145);
            this.btnImportFile.Margin = new System.Windows.Forms.Padding(4, 25, 4, 25);
            this.btnImportFile.Name = "btnImportFile";
            this.btnImportFile.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnImportFile.Size = new System.Drawing.Size(231, 49);
            this.btnImportFile.TabIndex = 1;
            this.btnImportFile.Text = "Import File";
            this.btnImportFile.UseVisualStyleBackColor = true;
            this.btnImportFile.Click += new System.EventHandler(this.importFile);
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
            this.btnExportFile.Location = new System.Drawing.Point(4, 223);
            this.btnExportFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExportFile.Name = "btnExportFile";
            this.btnExportFile.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnExportFile.Size = new System.Drawing.Size(231, 43);
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
            this.panelExportFileSubmenu.Location = new System.Drawing.Point(4, 274);
            this.panelExportFileSubmenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelExportFileSubmenu.Name = "panelExportFileSubmenu";
            this.panelExportFileSubmenu.Size = new System.Drawing.Size(231, 170);
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
            this.btnJSON.Location = new System.Drawing.Point(47, 48);
            this.btnJSON.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnJSON.Name = "btnJSON";
            this.btnJSON.Size = new System.Drawing.Size(117, 31);
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
            this.btnXML.Location = new System.Drawing.Point(47, 4);
            this.btnXML.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(105, 37);
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
            this.panel1.Location = new System.Drawing.Point(260, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 12);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1201, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 28);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.closeWindow);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(953, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 17);
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
            this.teste.Location = new System.Drawing.Point(1048, 101);
            this.teste.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teste.Name = "teste";
            this.teste.Size = new System.Drawing.Size(0, 43);
            this.teste.TabIndex = 12;
            this.teste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(393, 144);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(709, 411);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 738);
            this.Controls.Add(this.teste);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1267, 738);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelExportFileSubmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label teste;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

