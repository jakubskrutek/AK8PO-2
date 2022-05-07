
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
            this.okButton = new System.Windows.Forms.Button();
            this.soutezeListView = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.aktualizovanoLabel = new System.Windows.Forms.Label();
            this.aktualizovanoDatumLabel = new System.Windows.Forms.Label();
            this.aktualizujButton = new System.Windows.Forms.Button();
            this.zapisyButton = new System.Windows.Forms.Button();
            this.tabulkyButton = new System.Windows.Forms.Button();
            this.losyButton = new System.Windows.Forms.Button();
            this.uspesnostiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(251, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TABLE TENNIS TABLES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(41, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(522, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vlož hypertextový odkaz na stránku s tabulkou regionální soutěže portálu STIS";
            // 
            // vlozOdkazTextBox
            // 
            this.vlozOdkazTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vlozOdkazTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.vlozOdkazTextBox.Location = new System.Drawing.Point(44, 97);
            this.vlozOdkazTextBox.MaxLength = 100;
            this.vlozOdkazTextBox.Name = "vlozOdkazTextBox";
            this.vlozOdkazTextBox.Size = new System.Drawing.Size(470, 22);
            this.vlozOdkazTextBox.TabIndex = 2;
            this.vlozOdkazTextBox.Text = " sem zadej odkaz";
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.okButton.Image = ((System.Drawing.Image)(resources.GetObject("okButton.Image")));
            this.okButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.okButton.Location = new System.Drawing.Point(534, 89);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(60, 35);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // soutezeListView
            // 
            this.soutezeListView.HideSelection = false;
            this.soutezeListView.Location = new System.Drawing.Point(44, 178);
            this.soutezeListView.Name = "soutezeListView";
            this.soutezeListView.Size = new System.Drawing.Size(328, 88);
            this.soutezeListView.TabIndex = 4;
            this.soutezeListView.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(44, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Přidané soutěže";
            // 
            // aktualizovanoLabel
            // 
            this.aktualizovanoLabel.AutoSize = true;
            this.aktualizovanoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aktualizovanoLabel.Location = new System.Drawing.Point(392, 194);
            this.aktualizovanoLabel.Name = "aktualizovanoLabel";
            this.aktualizovanoLabel.Size = new System.Drawing.Size(106, 18);
            this.aktualizovanoLabel.TabIndex = 6;
            this.aktualizovanoLabel.Text = "Žádné soutěže";
            // 
            // aktualizovanoDatumLabel
            // 
            this.aktualizovanoDatumLabel.AutoSize = true;
            this.aktualizovanoDatumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aktualizovanoDatumLabel.Location = new System.Drawing.Point(396, 230);
            this.aktualizovanoDatumLabel.Name = "aktualizovanoDatumLabel";
            this.aktualizovanoDatumLabel.Size = new System.Drawing.Size(95, 18);
            this.aktualizovanoDatumLabel.TabIndex = 7;
            this.aktualizovanoDatumLabel.Text = "01.01. 2000";
            // 
            // aktualizujButton
            // 
            this.aktualizujButton.Image = ((System.Drawing.Image)(resources.GetObject("aktualizujButton.Image")));
            this.aktualizujButton.Location = new System.Drawing.Point(534, 194);
            this.aktualizujButton.Name = "aktualizujButton";
            this.aktualizujButton.Size = new System.Drawing.Size(60, 60);
            this.aktualizujButton.TabIndex = 8;
            this.aktualizujButton.UseVisualStyleBackColor = true;
            // 
            // zapisyButton
            // 
            this.zapisyButton.Location = new System.Drawing.Point(355, 349);
            this.zapisyButton.Name = "zapisyButton";
            this.zapisyButton.Size = new System.Drawing.Size(90, 40);
            this.zapisyButton.TabIndex = 9;
            this.zapisyButton.Text = "ZÁPISY";
            this.zapisyButton.UseVisualStyleBackColor = true;
            // 
            // tabulkyButton
            // 
            this.tabulkyButton.Location = new System.Drawing.Point(47, 349);
            this.tabulkyButton.Name = "tabulkyButton";
            this.tabulkyButton.Size = new System.Drawing.Size(90, 40);
            this.tabulkyButton.TabIndex = 9;
            this.tabulkyButton.Text = "TABULKY";
            this.tabulkyButton.UseVisualStyleBackColor = true;
            // 
            // losyButton
            // 
            this.losyButton.Location = new System.Drawing.Point(206, 349);
            this.losyButton.Name = "losyButton";
            this.losyButton.Size = new System.Drawing.Size(90, 40);
            this.losyButton.TabIndex = 9;
            this.losyButton.Text = "LOSY";
            this.losyButton.UseVisualStyleBackColor = true;
            // 
            // uspesnostiButton
            // 
            this.uspesnostiButton.Location = new System.Drawing.Point(504, 349);
            this.uspesnostiButton.Name = "uspesnostiButton";
            this.uspesnostiButton.Size = new System.Drawing.Size(90, 40);
            this.uspesnostiButton.TabIndex = 9;
            this.uspesnostiButton.Text = "ÚSPĚŠNOSTI";
            this.uspesnostiButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.losyButton);
            this.Controls.Add(this.tabulkyButton);
            this.Controls.Add(this.uspesnostiButton);
            this.Controls.Add(this.zapisyButton);
            this.Controls.Add(this.aktualizujButton);
            this.Controls.Add(this.aktualizovanoDatumLabel);
            this.Controls.Add(this.aktualizovanoLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.soutezeListView);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.vlozOdkazTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vlozOdkazTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ListView soutezeListView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label aktualizovanoLabel;
        private System.Windows.Forms.Label aktualizovanoDatumLabel;
        private System.Windows.Forms.Button aktualizujButton;
        private System.Windows.Forms.Button zapisyButton;
        private System.Windows.Forms.Button tabulkyButton;
        private System.Windows.Forms.Button losyButton;
        private System.Windows.Forms.Button uspesnostiButton;
    }
}

