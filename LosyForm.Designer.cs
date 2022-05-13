
namespace AK8PO_2
{
    partial class LosyForm
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LosyForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.soutezListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.oddilListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.generujButton = new System.Windows.Forms.Button();
            this.generujLosSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.label1.Size = new System.Drawing.Size(562, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOSY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vyber soutěž a poté oddíl, pro který chceš rozpis generovat";
            // 
            // soutezListBox
            // 
            this.soutezListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.soutezListBox.FormattingEnabled = true;
            this.soutezListBox.ItemHeight = 16;
            this.soutezListBox.Location = new System.Drawing.Point(20, 125);
            this.soutezListBox.Name = "soutezListBox";
            this.soutezListBox.Size = new System.Drawing.Size(278, 148);
            this.soutezListBox.TabIndex = 2;
            this.soutezListBox.SelectedIndexChanged += new System.EventHandler(this.soutezListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(17, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soutěž";
            // 
            // oddilListBox
            // 
            this.oddilListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oddilListBox.FormattingEnabled = true;
            this.oddilListBox.ItemHeight = 16;
            this.oddilListBox.Location = new System.Drawing.Point(338, 125);
            this.oddilListBox.Name = "oddilListBox";
            this.oddilListBox.Size = new System.Drawing.Size(207, 148);
            this.oddilListBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(335, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Oddíl";
            // 
            // generujButton
            // 
            this.generujButton.Image = ((System.Drawing.Image)(resources.GetObject("generujButton.Image")));
            this.generujButton.Location = new System.Drawing.Point(225, 315);
            this.generujButton.Name = "generujButton";
            this.generujButton.Size = new System.Drawing.Size(120, 50);
            this.generujButton.TabIndex = 6;
            this.generujButton.Text = "    GENERUJ";
            this.generujButton.UseVisualStyleBackColor = true;
            this.generujButton.Click += new System.EventHandler(this.generujButton_Click);
            // 
            // LosyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 377);
            this.Controls.Add(this.generujButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.oddilListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.soutezListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(578, 416);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(578, 416);
            this.Name = "LosyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TTT - Losy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox soutezListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox oddilListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button generujButton;
        private System.Windows.Forms.SaveFileDialog generujLosSaveFileDialog;
    }
}