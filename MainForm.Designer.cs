
namespace AK8PO_2
{
    partial class MainForm
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vlozOdkazTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.aktualizovanoLabel = new System.Windows.Forms.Label();
            this.aktualizovanoDatumLabel = new System.Windows.Forms.Label();
            this.odeberButton = new System.Windows.Forms.Button();
            this.tabulkyButton = new System.Windows.Forms.Button();
            this.losyButton = new System.Windows.Forms.Button();
            this.soutezeListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.label1.Size = new System.Drawing.Size(562, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "TABLE TENNIS TABLES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(21, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(526, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vlož hypertextový odkaz na stránku s tabulkou regionální soutěže portálu STIS.";
            // 
            // vlozOdkazTextBox
            // 
            this.vlozOdkazTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vlozOdkazTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.vlozOdkazTextBox.Location = new System.Drawing.Point(24, 85);
            this.vlozOdkazTextBox.MaxLength = 100;
            this.vlozOdkazTextBox.Name = "vlozOdkazTextBox";
            this.vlozOdkazTextBox.Size = new System.Drawing.Size(433, 22);
            this.vlozOdkazTextBox.TabIndex = 2;
            this.vlozOdkazTextBox.Text = " sem zadej odkaz";
            this.vlozOdkazTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.vlozOdkazTextBox_MouseClick);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteButton.Location = new System.Drawing.Point(479, 85);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(60, 35);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "OK";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(21, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Moje soutěže";
            // 
            // aktualizovanoLabel
            // 
            this.aktualizovanoLabel.AutoSize = true;
            this.aktualizovanoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aktualizovanoLabel.Location = new System.Drawing.Point(219, 265);
            this.aktualizovanoLabel.Name = "aktualizovanoLabel";
            this.aktualizovanoLabel.Size = new System.Drawing.Size(105, 13);
            this.aktualizovanoLabel.TabIndex = 6;
            this.aktualizovanoLabel.Text = "poslední aktualizace";
            this.aktualizovanoLabel.Visible = false;
            // 
            // aktualizovanoDatumLabel
            // 
            this.aktualizovanoDatumLabel.AutoSize = true;
            this.aktualizovanoDatumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aktualizovanoDatumLabel.Location = new System.Drawing.Point(321, 265);
            this.aktualizovanoDatumLabel.Name = "aktualizovanoDatumLabel";
            this.aktualizovanoDatumLabel.Size = new System.Drawing.Size(97, 13);
            this.aktualizovanoDatumLabel.TabIndex = 7;
            this.aktualizovanoDatumLabel.Text = "01.01. 2000  20:00";
            this.aktualizovanoDatumLabel.Visible = false;
            // 
            // odeberButton
            // 
            this.odeberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odeberButton.Image = ((System.Drawing.Image)(resources.GetObject("odeberButton.Image")));
            this.odeberButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.odeberButton.Location = new System.Drawing.Point(436, 162);
            this.odeberButton.Name = "odeberButton";
            this.odeberButton.Size = new System.Drawing.Size(103, 35);
            this.odeberButton.TabIndex = 8;
            this.odeberButton.Text = "SMAZAT";
            this.odeberButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.odeberButton.UseVisualStyleBackColor = true;
            this.odeberButton.Click += new System.EventHandler(this.odeberButton_Click);
            // 
            // tabulkyButton
            // 
            this.tabulkyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabulkyButton.Image = ((System.Drawing.Image)(resources.GetObject("tabulkyButton.Image")));
            this.tabulkyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabulkyButton.Location = new System.Drawing.Point(111, 313);
            this.tabulkyButton.Name = "tabulkyButton";
            this.tabulkyButton.Size = new System.Drawing.Size(120, 40);
            this.tabulkyButton.TabIndex = 9;
            this.tabulkyButton.Text = "TABULKY ";
            this.tabulkyButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tabulkyButton.UseVisualStyleBackColor = true;
            this.tabulkyButton.Click += new System.EventHandler(this.tabulkyButton_Click);
            // 
            // losyButton
            // 
            this.losyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.losyButton.Image = ((System.Drawing.Image)(resources.GetObject("losyButton.Image")));
            this.losyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.losyButton.Location = new System.Drawing.Point(329, 313);
            this.losyButton.Name = "losyButton";
            this.losyButton.Size = new System.Drawing.Size(120, 40);
            this.losyButton.TabIndex = 9;
            this.losyButton.Text = "  LOSY";
            this.losyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.losyButton.UseVisualStyleBackColor = true;
            this.losyButton.Click += new System.EventHandler(this.losyButton_Click);
            // 
            // soutezeListBox
            // 
            this.soutezeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.soutezeListBox.FormattingEnabled = true;
            this.soutezeListBox.ItemHeight = 24;
            this.soutezeListBox.Location = new System.Drawing.Point(24, 162);
            this.soutezeListBox.Name = "soutezeListBox";
            this.soutezeListBox.Size = new System.Drawing.Size(390, 100);
            this.soutezeListBox.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 377);
            this.Controls.Add(this.soutezeListBox);
            this.Controls.Add(this.losyButton);
            this.Controls.Add(this.tabulkyButton);
            this.Controls.Add(this.odeberButton);
            this.Controls.Add(this.aktualizovanoDatumLabel);
            this.Controls.Add(this.aktualizovanoLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.vlozOdkazTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(578, 416);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(578, 416);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TTT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vlozOdkazTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label aktualizovanoLabel;
        private System.Windows.Forms.Label aktualizovanoDatumLabel;
        private System.Windows.Forms.Button odeberButton;
        private System.Windows.Forms.Button tabulkyButton;
        private System.Windows.Forms.Button losyButton;
        private System.Windows.Forms.ListBox soutezeListBox;
    }
}

