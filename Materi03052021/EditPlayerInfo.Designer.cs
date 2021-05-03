
namespace Materi03052021
{
    partial class EditPlayerInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.teamLabel = new System.Windows.Forms.Label();
            this.heightTextbox = new System.Windows.Forms.TextBox();
            this.weightTextbox = new System.Windows.Forms.TextBox();
            this.ubahButton = new System.Windows.Forms.Button();
            this.nationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Asal Tim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Negara";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tinggi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Berat";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(129, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(16, 21);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "-";
            // 
            // teamLabel
            // 
            this.teamLabel.AutoSize = true;
            this.teamLabel.Location = new System.Drawing.Point(129, 72);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(16, 21);
            this.teamLabel.TabIndex = 6;
            this.teamLabel.Text = "-";
            // 
            // heightTextbox
            // 
            this.heightTextbox.Location = new System.Drawing.Point(132, 183);
            this.heightTextbox.Name = "heightTextbox";
            this.heightTextbox.Size = new System.Drawing.Size(244, 22);
            this.heightTextbox.TabIndex = 8;
            this.heightTextbox.TextChanged += new System.EventHandler(this.heightTextbox_TextChanged);
            // 
            // weightTextbox
            // 
            this.weightTextbox.Location = new System.Drawing.Point(132, 239);
            this.weightTextbox.Name = "weightTextbox";
            this.weightTextbox.Size = new System.Drawing.Size(244, 22);
            this.weightTextbox.TabIndex = 9;
            this.weightTextbox.TextChanged += new System.EventHandler(this.weightTextbox_TextChanged);
            // 
            // ubahButton
            // 
            this.ubahButton.Enabled = false;
            this.ubahButton.Location = new System.Drawing.Point(132, 295);
            this.ubahButton.Name = "ubahButton";
            this.ubahButton.Size = new System.Drawing.Size(123, 25);
            this.ubahButton.TabIndex = 10;
            this.ubahButton.Text = "Ubah";
            this.ubahButton.UseVisualStyleBackColor = true;
            this.ubahButton.Click += new System.EventHandler(this.ubahButton_Click);
            // 
            // nationLabel
            // 
            this.nationLabel.AutoSize = true;
            this.nationLabel.Location = new System.Drawing.Point(132, 126);
            this.nationLabel.Name = "nationLabel";
            this.nationLabel.Size = new System.Drawing.Size(13, 17);
            this.nationLabel.TabIndex = 11;
            this.nationLabel.Text = "-";
            // 
            // EditPlayerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 344);
            this.Controls.Add(this.nationLabel);
            this.Controls.Add(this.ubahButton);
            this.Controls.Add(this.weightTextbox);
            this.Controls.Add(this.heightTextbox);
            this.Controls.Add(this.teamLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditPlayerInfo";
            this.Text = "EditPlayerInfo";
            this.Load += new System.EventHandler(this.EditPlayerInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label teamLabel;
        private System.Windows.Forms.TextBox heightTextbox;
        private System.Windows.Forms.TextBox weightTextbox;
        private System.Windows.Forms.Button ubahButton;
        private System.Windows.Forms.Label nationLabel;
    }
}