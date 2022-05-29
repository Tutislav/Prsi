namespace Prsi
{
    partial class Hra
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDalsiKolo = new System.Windows.Forms.Button();
            this.balicekKaret = new System.Windows.Forms.Panel();
            this.buttonPrava = new System.Windows.Forms.Button();
            this.buttonLeva = new System.Windows.Forms.Button();
            this.labelPenizeSouper = new System.Windows.Forms.Label();
            this.labelPenizeHrac = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonPredatTah = new System.Windows.Forms.Button();
            this.pictureBoxZmenenaBarva = new System.Windows.Forms.PictureBox();
            this.panelZmenaBarvy = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonZmenitNaKule = new System.Windows.Forms.Button();
            this.buttonZmenitNaZaludy = new System.Windows.Forms.Button();
            this.buttonZmenitNaListy = new System.Windows.Forms.Button();
            this.buttonZmenitNaSrdce = new System.Windows.Forms.Button();
            this.balicekOdehranychKaret = new System.Windows.Forms.Panel();
            this.hracovaRuka = new System.Windows.Forms.FlowLayoutPanel();
            this.souperovaRuka = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buttonHra = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonNovaHra = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonNastaveni = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxObtiznost = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.comboBoxVzhledKaret = new System.Windows.Forms.ToolStripComboBox();
            this.buttonZvuk = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonKonec = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonVsadit = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonZvysitSazku = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxSazka = new System.Windows.Forms.ToolStripTextBox();
            this.buttonSnizitSazku = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZmenenaBarva)).BeginInit();
            this.panelZmenaBarvy.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDalsiKolo);
            this.panel1.Controls.Add(this.balicekKaret);
            this.panel1.Controls.Add(this.buttonPrava);
            this.panel1.Controls.Add(this.buttonLeva);
            this.panel1.Controls.Add(this.labelPenizeSouper);
            this.panel1.Controls.Add(this.labelPenizeHrac);
            this.panel1.Controls.Add(this.labelInfo);
            this.panel1.Controls.Add(this.buttonPredatTah);
            this.panel1.Controls.Add(this.pictureBoxZmenenaBarva);
            this.panel1.Controls.Add(this.panelZmenaBarvy);
            this.panel1.Controls.Add(this.balicekOdehranychKaret);
            this.panel1.Controls.Add(this.hracovaRuka);
            this.panel1.Controls.Add(this.souperovaRuka);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 657);
            this.panel1.TabIndex = 0;
            // 
            // buttonDalsiKolo
            // 
            this.buttonDalsiKolo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.buttonDalsiKolo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDalsiKolo.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDalsiKolo.ForeColor = System.Drawing.Color.White;
            this.buttonDalsiKolo.Location = new System.Drawing.Point(280, 286);
            this.buttonDalsiKolo.Name = "buttonDalsiKolo";
            this.buttonDalsiKolo.Size = new System.Drawing.Size(120, 40);
            this.buttonDalsiKolo.TabIndex = 12;
            this.buttonDalsiKolo.Text = "Další kolo";
            this.buttonDalsiKolo.UseVisualStyleBackColor = true;
            this.buttonDalsiKolo.Click += new System.EventHandler(this.buttonDalsiKolo_Click);
            // 
            // balicekKaret
            // 
            this.balicekKaret.Location = new System.Drawing.Point(799, 234);
            this.balicekKaret.Name = "balicekKaret";
            this.balicekKaret.Size = new System.Drawing.Size(120, 189);
            this.balicekKaret.TabIndex = 11;
            // 
            // buttonPrava
            // 
            this.buttonPrava.BackgroundImage = global::Prsi.Properties.Resources.prava;
            this.buttonPrava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPrava.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.buttonPrava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrava.ForeColor = System.Drawing.Color.White;
            this.buttonPrava.Location = new System.Drawing.Point(1220, 465);
            this.buttonPrava.Name = "buttonPrava";
            this.buttonPrava.Size = new System.Drawing.Size(25, 192);
            this.buttonPrava.TabIndex = 10;
            this.buttonPrava.UseVisualStyleBackColor = true;
            this.buttonPrava.Click += new System.EventHandler(this.buttonPrava_Click);
            // 
            // buttonLeva
            // 
            this.buttonLeva.BackgroundImage = global::Prsi.Properties.Resources.leva;
            this.buttonLeva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLeva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.buttonLeva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeva.ForeColor = System.Drawing.Color.White;
            this.buttonLeva.Location = new System.Drawing.Point(19, 465);
            this.buttonLeva.Name = "buttonLeva";
            this.buttonLeva.Size = new System.Drawing.Size(25, 192);
            this.buttonLeva.TabIndex = 9;
            this.buttonLeva.UseVisualStyleBackColor = true;
            this.buttonLeva.Click += new System.EventHandler(this.buttonLeva_Click);
            // 
            // labelPenizeSouper
            // 
            this.labelPenizeSouper.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPenizeSouper.ForeColor = System.Drawing.Color.White;
            this.labelPenizeSouper.Location = new System.Drawing.Point(1114, 97);
            this.labelPenizeSouper.Name = "labelPenizeSouper";
            this.labelPenizeSouper.Size = new System.Drawing.Size(131, 23);
            this.labelPenizeSouper.TabIndex = 8;
            this.labelPenizeSouper.Text = "penizeSouper";
            this.labelPenizeSouper.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPenizeHrac
            // 
            this.labelPenizeHrac.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPenizeHrac.ForeColor = System.Drawing.Color.White;
            this.labelPenizeHrac.Location = new System.Drawing.Point(1114, 439);
            this.labelPenizeHrac.Name = "labelPenizeHrac";
            this.labelPenizeHrac.Size = new System.Drawing.Size(131, 23);
            this.labelPenizeHrac.TabIndex = 7;
            this.labelPenizeHrac.Text = "penizeHrac";
            this.labelPenizeHrac.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfo.ForeColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(80, 280);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(114, 43);
            this.labelInfo.TabIndex = 6;
            this.labelInfo.Text = "label1";
            // 
            // buttonPredatTah
            // 
            this.buttonPredatTah.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.buttonPredatTah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPredatTah.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPredatTah.ForeColor = System.Drawing.Color.White;
            this.buttonPredatTah.Location = new System.Drawing.Point(434, 309);
            this.buttonPredatTah.Name = "buttonPredatTah";
            this.buttonPredatTah.Size = new System.Drawing.Size(120, 40);
            this.buttonPredatTah.TabIndex = 5;
            this.buttonPredatTah.Text = "Předat tah";
            this.buttonPredatTah.UseVisualStyleBackColor = true;
            this.buttonPredatTah.Click += new System.EventHandler(this.buttonPredatTah_Click);
            // 
            // pictureBoxZmenenaBarva
            // 
            this.pictureBoxZmenenaBarva.Location = new System.Drawing.Point(516, 234);
            this.pictureBoxZmenenaBarva.Name = "pictureBoxZmenenaBarva";
            this.pictureBoxZmenenaBarva.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxZmenenaBarva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxZmenenaBarva.TabIndex = 4;
            this.pictureBoxZmenenaBarva.TabStop = false;
            // 
            // panelZmenaBarvy
            // 
            this.panelZmenaBarvy.Controls.Add(this.label2);
            this.panelZmenaBarvy.Controls.Add(this.buttonZmenitNaKule);
            this.panelZmenaBarvy.Controls.Add(this.buttonZmenitNaZaludy);
            this.panelZmenaBarvy.Controls.Add(this.buttonZmenitNaListy);
            this.panelZmenaBarvy.Controls.Add(this.buttonZmenitNaSrdce);
            this.panelZmenaBarvy.Location = new System.Drawing.Point(204, 252);
            this.panelZmenaBarvy.Name = "panelZmenaBarvy";
            this.panelZmenaBarvy.Size = new System.Drawing.Size(224, 107);
            this.panelZmenaBarvy.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Změnit na:";
            // 
            // buttonZmenitNaKule
            // 
            this.buttonZmenitNaKule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonZmenitNaKule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.buttonZmenitNaKule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZmenitNaKule.ForeColor = System.Drawing.Color.White;
            this.buttonZmenitNaKule.Location = new System.Drawing.Point(171, 54);
            this.buttonZmenitNaKule.Name = "buttonZmenitNaKule";
            this.buttonZmenitNaKule.Size = new System.Drawing.Size(50, 50);
            this.buttonZmenitNaKule.TabIndex = 3;
            this.buttonZmenitNaKule.UseVisualStyleBackColor = true;
            this.buttonZmenitNaKule.Click += new System.EventHandler(this.buttonZmenitNaKule_Click);
            // 
            // buttonZmenitNaZaludy
            // 
            this.buttonZmenitNaZaludy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonZmenitNaZaludy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.buttonZmenitNaZaludy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZmenitNaZaludy.ForeColor = System.Drawing.Color.White;
            this.buttonZmenitNaZaludy.Location = new System.Drawing.Point(115, 54);
            this.buttonZmenitNaZaludy.Name = "buttonZmenitNaZaludy";
            this.buttonZmenitNaZaludy.Size = new System.Drawing.Size(50, 50);
            this.buttonZmenitNaZaludy.TabIndex = 2;
            this.buttonZmenitNaZaludy.UseVisualStyleBackColor = true;
            this.buttonZmenitNaZaludy.Click += new System.EventHandler(this.buttonZmenitNaZaludy_Click);
            // 
            // buttonZmenitNaListy
            // 
            this.buttonZmenitNaListy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonZmenitNaListy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.buttonZmenitNaListy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZmenitNaListy.ForeColor = System.Drawing.Color.White;
            this.buttonZmenitNaListy.Location = new System.Drawing.Point(59, 54);
            this.buttonZmenitNaListy.Name = "buttonZmenitNaListy";
            this.buttonZmenitNaListy.Size = new System.Drawing.Size(50, 50);
            this.buttonZmenitNaListy.TabIndex = 1;
            this.buttonZmenitNaListy.UseVisualStyleBackColor = true;
            this.buttonZmenitNaListy.Click += new System.EventHandler(this.buttonZmenitNaListy_Click);
            // 
            // buttonZmenitNaSrdce
            // 
            this.buttonZmenitNaSrdce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonZmenitNaSrdce.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.buttonZmenitNaSrdce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZmenitNaSrdce.ForeColor = System.Drawing.Color.White;
            this.buttonZmenitNaSrdce.Location = new System.Drawing.Point(3, 54);
            this.buttonZmenitNaSrdce.Name = "buttonZmenitNaSrdce";
            this.buttonZmenitNaSrdce.Size = new System.Drawing.Size(50, 50);
            this.buttonZmenitNaSrdce.TabIndex = 0;
            this.buttonZmenitNaSrdce.UseVisualStyleBackColor = true;
            this.buttonZmenitNaSrdce.Click += new System.EventHandler(this.buttonZmenitNaSrdce_Click);
            // 
            // balicekOdehranychKaret
            // 
            this.balicekOdehranychKaret.Location = new System.Drawing.Point(572, 234);
            this.balicekOdehranychKaret.Name = "balicekOdehranychKaret";
            this.balicekOdehranychKaret.Size = new System.Drawing.Size(120, 189);
            this.balicekOdehranychKaret.TabIndex = 2;
            // 
            // hracovaRuka
            // 
            this.hracovaRuka.Location = new System.Drawing.Point(50, 465);
            this.hracovaRuka.Name = "hracovaRuka";
            this.hracovaRuka.Size = new System.Drawing.Size(1164, 192);
            this.hracovaRuka.TabIndex = 1;
            // 
            // souperovaRuka
            // 
            this.souperovaRuka.Location = new System.Drawing.Point(50, -95);
            this.souperovaRuka.Name = "souperovaRuka";
            this.souperovaRuka.Size = new System.Drawing.Size(1164, 189);
            this.souperovaRuka.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonHra,
            this.buttonVsadit,
            this.buttonZvysitSazku,
            this.textBoxSazka,
            this.buttonSnizitSazku});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buttonHra
            // 
            this.buttonHra.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonNovaHra,
            this.buttonNastaveni,
            this.buttonKonec});
            this.buttonHra.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHra.Name = "buttonHra";
            this.buttonHra.Size = new System.Drawing.Size(46, 26);
            this.buttonHra.Text = "Hra";
            // 
            // buttonNovaHra
            // 
            this.buttonNovaHra.Name = "buttonNovaHra";
            this.buttonNovaHra.Size = new System.Drawing.Size(149, 26);
            this.buttonNovaHra.Text = "Nová hra";
            this.buttonNovaHra.Click += new System.EventHandler(this.buttonNovaHra_Click);
            // 
            // buttonNastaveni
            // 
            this.buttonNastaveni.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comboBoxObtiznost,
            this.toolStripSeparator1,
            this.comboBoxVzhledKaret,
            this.buttonZvuk});
            this.buttonNastaveni.Name = "buttonNastaveni";
            this.buttonNastaveni.Size = new System.Drawing.Size(149, 26);
            this.buttonNastaveni.Text = "Nastavení";
            // 
            // comboBoxObtiznost
            // 
            this.comboBoxObtiznost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxObtiznost.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxObtiznost.Items.AddRange(new object[] {
            "Normální obtížnost",
            "Těžká obtížnost"});
            this.comboBoxObtiznost.Name = "comboBoxObtiznost";
            this.comboBoxObtiznost.Size = new System.Drawing.Size(160, 30);
            this.comboBoxObtiznost.ToolTipText = "Obtížnost";
            this.comboBoxObtiznost.SelectedIndexChanged += new System.EventHandler(this.comboBoxObtiznost_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(217, 6);
            // 
            // comboBoxVzhledKaret
            // 
            this.comboBoxVzhledKaret.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVzhledKaret.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxVzhledKaret.Items.AddRange(new object[] {
            "Mariášové karty",
            "Kanastové karty"});
            this.comboBoxVzhledKaret.Name = "comboBoxVzhledKaret";
            this.comboBoxVzhledKaret.Size = new System.Drawing.Size(160, 30);
            this.comboBoxVzhledKaret.ToolTipText = "Vzhled karet";
            this.comboBoxVzhledKaret.SelectedIndexChanged += new System.EventHandler(this.comboBoxVzhledKaret_SelectedIndexChanged);
            // 
            // buttonZvuk
            // 
            this.buttonZvuk.Name = "buttonZvuk";
            this.buttonZvuk.Size = new System.Drawing.Size(220, 26);
            this.buttonZvuk.Text = "Zvuk";
            this.buttonZvuk.Click += new System.EventHandler(this.buttonZvuk_Click);
            // 
            // buttonKonec
            // 
            this.buttonKonec.Name = "buttonKonec";
            this.buttonKonec.Size = new System.Drawing.Size(149, 26);
            this.buttonKonec.Text = "Konec";
            this.buttonKonec.Click += new System.EventHandler(this.buttonKonec_Click);
            // 
            // buttonVsadit
            // 
            this.buttonVsadit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonVsadit.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVsadit.Name = "buttonVsadit";
            this.buttonVsadit.Size = new System.Drawing.Size(81, 26);
            this.buttonVsadit.Text = "Vsadit si";
            this.buttonVsadit.Click += new System.EventHandler(this.buttonVsadit_Click);
            // 
            // buttonZvysitSazku
            // 
            this.buttonZvysitSazku.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonZvysitSazku.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZvysitSazku.Name = "buttonZvysitSazku";
            this.buttonZvysitSazku.Size = new System.Drawing.Size(38, 26);
            this.buttonZvysitSazku.Text = "➕";
            this.buttonZvysitSazku.Click += new System.EventHandler(this.buttonZvysitSazku_Click);
            // 
            // textBoxSazka
            // 
            this.textBoxSazka.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.textBoxSazka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSazka.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSazka.Name = "textBoxSazka";
            this.textBoxSazka.Size = new System.Drawing.Size(40, 26);
            this.textBoxSazka.Text = "50";
            this.textBoxSazka.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSnizitSazku
            // 
            this.buttonSnizitSazku.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonSnizitSazku.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSnizitSazku.Name = "buttonSnizitSazku";
            this.buttonSnizitSazku.Size = new System.Drawing.Size(38, 26);
            this.buttonSnizitSazku.Text = "➖";
            this.buttonSnizitSazku.Click += new System.EventHandler(this.buttonSnizitSazku_Click);
            // 
            // Hra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Hra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prší";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Hra_FormClosing);
            this.Load += new System.EventHandler(this.Hra_Load);
            this.Resize += new System.EventHandler(this.Hra_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZmenenaBarva)).EndInit();
            this.panelZmenaBarvy.ResumeLayout(false);
            this.panelZmenaBarvy.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel balicekOdehranychKaret;
        private System.Windows.Forms.FlowLayoutPanel hracovaRuka;
        private System.Windows.Forms.FlowLayoutPanel souperovaRuka;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem buttonHra;
        private System.Windows.Forms.ToolStripMenuItem buttonNovaHra;
        private System.Windows.Forms.ToolStripMenuItem buttonKonec;
        private System.Windows.Forms.ToolStripMenuItem buttonNastaveni;
        private System.Windows.Forms.Panel panelZmenaBarvy;
        private System.Windows.Forms.Button buttonZmenitNaSrdce;
        private System.Windows.Forms.Button buttonZmenitNaKule;
        private System.Windows.Forms.Button buttonZmenitNaZaludy;
        private System.Windows.Forms.Button buttonZmenitNaListy;
        private System.Windows.Forms.PictureBox pictureBoxZmenenaBarva;
        private System.Windows.Forms.Button buttonPredatTah;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.ToolStripComboBox comboBoxObtiznost;
        private System.Windows.Forms.Label labelPenizeSouper;
        private System.Windows.Forms.Label labelPenizeHrac;
        private System.Windows.Forms.ToolStripMenuItem buttonVsadit;
        private System.Windows.Forms.ToolStripTextBox textBoxSazka;
        private System.Windows.Forms.ToolStripMenuItem buttonZvysitSazku;
        private System.Windows.Forms.ToolStripMenuItem buttonSnizitSazku;
        private System.Windows.Forms.ToolStripComboBox comboBoxVzhledKaret;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLeva;
        private System.Windows.Forms.Button buttonPrava;
        private System.Windows.Forms.Panel balicekKaret;
        private System.Windows.Forms.Button buttonDalsiKolo;
        private System.Windows.Forms.ToolStripMenuItem buttonZvuk;
    }
}

