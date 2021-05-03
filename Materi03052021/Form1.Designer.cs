
namespace Materi03052021
{
    partial class teamEditor
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
            this.namateamTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stadiumLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.managerLabel = new System.Windows.Forms.Label();
            this.topscorerLabel = new System.Windows.Forms.Label();
            this.playersDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.playersDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // namateamTextbox
            // 
            this.namateamTextbox.Location = new System.Drawing.Point(172, 38);
            this.namateamTextbox.Name = "namateamTextbox";
            this.namateamTextbox.Size = new System.Drawing.Size(265, 22);
            this.namateamTextbox.TabIndex = 0;
            this.namateamTextbox.TextChanged += new System.EventHandler(this.namateamTextbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stadium";
            // 
            // stadiumLabel
            // 
            this.stadiumLabel.AutoSize = true;
            this.stadiumLabel.Location = new System.Drawing.Point(169, 82);
            this.stadiumLabel.Name = "stadiumLabel";
            this.stadiumLabel.Size = new System.Drawing.Size(13, 17);
            this.stadiumLabel.TabIndex = 3;
            this.stadiumLabel.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Manager";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Top Scorer";
            // 
            // managerLabel
            // 
            this.managerLabel.AutoSize = true;
            this.managerLabel.Location = new System.Drawing.Point(169, 125);
            this.managerLabel.Name = "managerLabel";
            this.managerLabel.Size = new System.Drawing.Size(13, 17);
            this.managerLabel.TabIndex = 6;
            this.managerLabel.Text = "-";
            // 
            // topscorerLabel
            // 
            this.topscorerLabel.AutoSize = true;
            this.topscorerLabel.Location = new System.Drawing.Point(169, 166);
            this.topscorerLabel.Name = "topscorerLabel";
            this.topscorerLabel.Size = new System.Drawing.Size(13, 17);
            this.topscorerLabel.TabIndex = 7;
            this.topscorerLabel.Text = "-";
            // 
            // playersDgv
            // 
            this.playersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playersDgv.Location = new System.Drawing.Point(47, 212);
            this.playersDgv.Name = "playersDgv";
            this.playersDgv.RowHeadersWidth = 51;
            this.playersDgv.RowTemplate.Height = 24;
            this.playersDgv.Size = new System.Drawing.Size(616, 463);
            this.playersDgv.TabIndex = 8;
            this.playersDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClicked);
            // 
            // teamEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 687);
            this.Controls.Add(this.playersDgv);
            this.Controls.Add(this.topscorerLabel);
            this.Controls.Add(this.managerLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stadiumLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namateamTextbox);
            this.Name = "teamEditor";
            this.Text = "Team Editor";
            this.Load += new System.EventHandler(this.teamEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playersDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namateamTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label stadiumLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label managerLabel;
        private System.Windows.Forms.Label topscorerLabel;
        private System.Windows.Forms.DataGridView playersDgv;
    }
}

