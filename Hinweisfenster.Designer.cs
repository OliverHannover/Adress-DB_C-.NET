
namespace Adress_DB
{
    partial class Hinweisfenster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hinweisfenster));
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_HinweisOben = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBL_Ueberschrift = new System.Windows.Forms.Label();
            this.LBL_HinweisUnten = new System.Windows.Forms.Label();
            this.LBL_oben = new System.Windows.Forms.Label();
            this.LBL_unten = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_Neu = new System.Windows.Forms.Button();
            this.BTN_Aendern = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Image = global::Adress_DB.My.Resources.Resources.Cancel_16x;
            this.BTN_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Cancel.Location = new System.Drawing.Point(379, 9);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(96, 23);
            this.BTN_Cancel.TabIndex = 2;
            this.BTN_Cancel.Text = "abbrechen";
            this.BTN_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Auf Rechtschreibung achten!";
            // 
            // LBL_HinweisOben
            // 
            this.LBL_HinweisOben.AutoSize = true;
            this.LBL_HinweisOben.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_HinweisOben.Location = new System.Drawing.Point(123, 70);
            this.LBL_HinweisOben.Name = "LBL_HinweisOben";
            this.LBL_HinweisOben.Size = new System.Drawing.Size(58, 15);
            this.LBL_HinweisOben.TabIndex = 4;
            this.LBL_HinweisOben.Text = "Hinweis1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.BTN_Neu);
            this.panel1.Controls.Add(this.BTN_Cancel);
            this.panel1.Controls.Add(this.BTN_Aendern);
            this.panel1.Location = new System.Drawing.Point(0, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 43);
            this.panel1.TabIndex = 5;
            // 
            // LBL_Ueberschrift
            // 
            this.LBL_Ueberschrift.AutoSize = true;
            this.LBL_Ueberschrift.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Ueberschrift.Location = new System.Drawing.Point(90, 9);
            this.LBL_Ueberschrift.Name = "LBL_Ueberschrift";
            this.LBL_Ueberschrift.Size = new System.Drawing.Size(299, 24);
            this.LBL_Ueberschrift.TabIndex = 6;
            this.LBL_Ueberschrift.Text = "Neu Anlegen oder Umbenennen?";
            this.LBL_Ueberschrift.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LBL_HinweisUnten
            // 
            this.LBL_HinweisUnten.AutoSize = true;
            this.LBL_HinweisUnten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_HinweisUnten.Location = new System.Drawing.Point(123, 164);
            this.LBL_HinweisUnten.Name = "LBL_HinweisUnten";
            this.LBL_HinweisUnten.Size = new System.Drawing.Size(58, 15);
            this.LBL_HinweisUnten.TabIndex = 7;
            this.LBL_HinweisUnten.Text = "Hinweis2";
            // 
            // LBL_oben
            // 
            this.LBL_oben.AutoSize = true;
            this.LBL_oben.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_oben.Location = new System.Drawing.Point(123, 54);
            this.LBL_oben.Name = "LBL_oben";
            this.LBL_oben.Size = new System.Drawing.Size(103, 16);
            this.LBL_oben.TabIndex = 8;
            this.LBL_oben.Text = "Umbenennen:";
            // 
            // LBL_unten
            // 
            this.LBL_unten.AutoSize = true;
            this.LBL_unten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_unten.Location = new System.Drawing.Point(123, 146);
            this.LBL_unten.Name = "LBL_unten";
            this.LBL_unten.Size = new System.Drawing.Size(100, 16);
            this.LBL_unten.TabIndex = 9;
            this.LBL_unten.Text = "Neu anlegen:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_Neu
            // 
            this.BTN_Neu.Image = global::Adress_DB.My.Resources.Resources.Add_16x;
            this.BTN_Neu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Neu.Location = new System.Drawing.Point(194, 9);
            this.BTN_Neu.Name = "BTN_Neu";
            this.BTN_Neu.Size = new System.Drawing.Size(96, 23);
            this.BTN_Neu.TabIndex = 0;
            this.BTN_Neu.Text = "Neu anlegen";
            this.BTN_Neu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Neu.UseVisualStyleBackColor = true;
            this.BTN_Neu.Click += new System.EventHandler(this.BTN_Neu_Click);
            // 
            // BTN_Aendern
            // 
            this.BTN_Aendern.Image = global::Adress_DB.My.Resources.Resources.Rename_cyan_7x_16x;
            this.BTN_Aendern.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Aendern.Location = new System.Drawing.Point(20, 9);
            this.BTN_Aendern.Name = "BTN_Aendern";
            this.BTN_Aendern.Size = new System.Drawing.Size(96, 23);
            this.BTN_Aendern.TabIndex = 1;
            this.BTN_Aendern.Text = "umbenennen";
            this.BTN_Aendern.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Aendern.UseVisualStyleBackColor = true;
            this.BTN_Aendern.Click += new System.EventHandler(this.BTN_Aendern_Click);
            // 
            // Hinweisfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(487, 289);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LBL_unten);
            this.Controls.Add(this.LBL_oben);
            this.Controls.Add(this.LBL_HinweisUnten);
            this.Controls.Add(this.LBL_Ueberschrift);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LBL_HinweisOben);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Hinweisfenster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hinweis";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Neu;
        private System.Windows.Forms.Button BTN_Aendern;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_HinweisOben;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBL_Ueberschrift;
        private System.Windows.Forms.Label LBL_HinweisUnten;
        private System.Windows.Forms.Label LBL_oben;
        private System.Windows.Forms.Label LBL_unten;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}