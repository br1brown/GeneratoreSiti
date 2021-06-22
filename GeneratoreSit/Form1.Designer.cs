namespace GeneratoreSit
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.txtPath = new System.Windows.Forms.TextBox();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.drpdFont = new System.Windows.Forms.ComboBox();
			this.btnPath = new System.Windows.Forms.Button();
			this.v = new System.Windows.Forms.Label();
			this.lPercorso = new System.Windows.Forms.Label();
			this.lNome = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txttitolo = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cbtn = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtContent = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.numCol = new System.Windows.Forms.NumericUpDown();
			this.btnGenera = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.pColor = new System.Windows.Forms.PictureBox();
			this.progr = new System.Windows.Forms.ProgressBar();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.Menu = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numCol)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pColor)).BeginInit();
			this.SuspendLayout();
			// 
			// txtPath
			// 
			this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPath.Location = new System.Drawing.Point(169, 15);
			this.txtPath.Margin = new System.Windows.Forms.Padding(4);
			this.txtPath.Name = "txtPath";
			this.txtPath.ReadOnly = true;
			this.txtPath.Size = new System.Drawing.Size(275, 27);
			this.txtPath.TabIndex = 0;
			this.txtPath.DoubleClick += new System.EventHandler(this.txtPath_TextChanged);
			// 
			// txtUser
			// 
			this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtUser.Location = new System.Drawing.Point(169, 50);
			this.txtUser.Margin = new System.Windows.Forms.Padding(4);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(317, 27);
			this.txtUser.TabIndex = 1;
			// 
			// txtName
			// 
			this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtName.Location = new System.Drawing.Point(169, 85);
			this.txtName.Margin = new System.Windows.Forms.Padding(4);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(317, 27);
			this.txtName.TabIndex = 2;
			this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			// 
			// drpdFont
			// 
			this.drpdFont.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.drpdFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.drpdFont.FormattingEnabled = true;
			this.drpdFont.Location = new System.Drawing.Point(169, 120);
			this.drpdFont.Margin = new System.Windows.Forms.Padding(4);
			this.drpdFont.Name = "drpdFont";
			this.drpdFont.Size = new System.Drawing.Size(317, 28);
			this.drpdFont.TabIndex = 3;
			this.drpdFont.SelectedIndexChanged += new System.EventHandler(this.drpdFont_SelectedIndexChanged);
			// 
			// btnPath
			// 
			this.btnPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPath.Location = new System.Drawing.Point(452, 14);
			this.btnPath.Margin = new System.Windows.Forms.Padding(4);
			this.btnPath.Name = "btnPath";
			this.btnPath.Size = new System.Drawing.Size(35, 29);
			this.btnPath.TabIndex = 4;
			this.btnPath.Text = ">>";
			this.btnPath.UseVisualStyleBackColor = true;
			this.btnPath.Click += new System.EventHandler(this.txtPath_TextChanged);
			// 
			// v
			// 
			this.v.AutoSize = true;
			this.v.Location = new System.Drawing.Point(99, 54);
			this.v.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.v.Name = "v";
			this.v.Size = new System.Drawing.Size(58, 20);
			this.v.TabIndex = 5;
			this.v.Text = "Autore";
			// 
			// lPercorso
			// 
			this.lPercorso.AutoSize = true;
			this.lPercorso.Location = new System.Drawing.Point(19, 18);
			this.lPercorso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lPercorso.Name = "lPercorso";
			this.lPercorso.Size = new System.Drawing.Size(134, 20);
			this.lPercorso.TabIndex = 6;
			this.lPercorso.Text = "Percorso output*";
			// 
			// lNome
			// 
			this.lNome.AutoSize = true;
			this.lNome.Location = new System.Drawing.Point(99, 89);
			this.lNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lNome.Name = "lNome";
			this.lNome.Size = new System.Drawing.Size(59, 20);
			this.lNome.TabIndex = 7;
			this.lNome.Text = "Nome*";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(110, 124);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 20);
			this.label2.TabIndex = 8;
			this.label2.Text = "Font*";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.txttitolo);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtContent);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.numCol);
			this.groupBox1.Location = new System.Drawing.Point(13, 243);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(476, 243);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Pagina Principale";
			// 
			// txttitolo
			// 
			this.txttitolo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txttitolo.Location = new System.Drawing.Point(14, 57);
			this.txttitolo.Margin = new System.Windows.Forms.Padding(4);
			this.txttitolo.Name = "txttitolo";
			this.txttitolo.Size = new System.Drawing.Size(458, 27);
			this.txttitolo.TabIndex = 15;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(11, 29);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 20);
			this.label4.TabIndex = 14;
			this.label4.Text = "Titolo pagina";
			// 
			// cbtn
			// 
			this.cbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbtn.AutoSize = true;
			this.cbtn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cbtn.Checked = true;
			this.cbtn.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbtn.Location = new System.Drawing.Point(169, 212);
			this.cbtn.Name = "cbtn";
			this.cbtn.Size = new System.Drawing.Size(84, 24);
			this.cbtn.TabIndex = 13;
			this.cbtn.Text = "Bottoni";
			this.cbtn.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 96);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 20);
			this.label3.TabIndex = 11;
			this.label3.Text = "Contenuto";
			// 
			// txtContent
			// 
			this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtContent.Location = new System.Drawing.Point(8, 120);
			this.txtContent.Margin = new System.Windows.Forms.Padding(4);
			this.txtContent.Multiline = true;
			this.txtContent.Name = "txtContent";
			this.txtContent.Size = new System.Drawing.Size(483, 115);
			this.txtContent.TabIndex = 10;
			this.txtContent.Enter += new System.EventHandler(this.txtContent_Enter);
			this.txtContent.Leave += new System.EventHandler(this.txtContent_Leave);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(341, 24);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 20);
			this.label1.TabIndex = 10;
			this.label1.Text = "Colonne";
			// 
			// numCol
			// 
			this.numCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numCol.Location = new System.Drawing.Point(419, 22);
			this.numCol.Margin = new System.Windows.Forms.Padding(4);
			this.numCol.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.numCol.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numCol.Name = "numCol";
			this.numCol.Size = new System.Drawing.Size(49, 27);
			this.numCol.TabIndex = 0;
			this.numCol.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// btnGenera
			// 
			this.btnGenera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGenera.Enabled = false;
			this.btnGenera.Location = new System.Drawing.Point(15, 494);
			this.btnGenera.Margin = new System.Windows.Forms.Padding(4);
			this.btnGenera.Name = "btnGenera";
			this.btnGenera.Size = new System.Drawing.Size(472, 56);
			this.btnGenera.TabIndex = 10;
			this.btnGenera.Text = "GENERA";
			this.btnGenera.UseVisualStyleBackColor = true;
			this.btnGenera.Click += new System.EventHandler(this.btnGenera_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(100, 158);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 20);
			this.label5.TabIndex = 12;
			this.label5.Text = "Colore";
			// 
			// pColor
			// 
			this.pColor.BackColor = System.Drawing.Color.LightGray;
			this.pColor.Location = new System.Drawing.Point(169, 158);
			this.pColor.Margin = new System.Windows.Forms.Padding(4);
			this.pColor.Name = "pColor";
			this.pColor.Size = new System.Drawing.Size(316, 29);
			this.pColor.TabIndex = 13;
			this.pColor.TabStop = false;
			this.pColor.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// progr
			// 
			this.progr.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.progr.Location = new System.Drawing.Point(0, 558);
			this.progr.Margin = new System.Windows.Forms.Padding(4);
			this.progr.Maximum = 5;
			this.progr.Name = "progr";
			this.progr.Size = new System.Drawing.Size(502, 15);
			this.progr.Step = 1;
			this.progr.TabIndex = 14;
			// 
			// Menu
			// 
			this.Menu.AutoSize = true;
			this.Menu.Location = new System.Drawing.Point(413, 212);
			this.Menu.Name = "Menu";
			this.Menu.Size = new System.Drawing.Size(72, 24);
			this.Menu.TabIndex = 16;
			this.Menu.Text = "Menu";
			this.Menu.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(502, 573);
			this.Controls.Add(this.Menu);
			this.Controls.Add(this.progr);
			this.Controls.Add(this.cbtn);
			this.Controls.Add(this.pColor);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnGenera);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lNome);
			this.Controls.Add(this.lPercorso);
			this.Controls.Add(this.v);
			this.Controls.Add(this.btnPath);
			this.Controls.Add(this.drpdFont);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.txtPath);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximumSize = new System.Drawing.Size(520, 620);
			this.MinimumSize = new System.Drawing.Size(520, 620);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Generatore Siti";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numCol)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pColor)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox drpdFont;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Label v;
        private System.Windows.Forms.Label lPercorso;
        private System.Windows.Forms.Label lNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numCol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnGenera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pColor;
        private System.Windows.Forms.ProgressBar progr;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txttitolo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbtn;
		private System.Windows.Forms.CheckBox Menu;
	}
}

