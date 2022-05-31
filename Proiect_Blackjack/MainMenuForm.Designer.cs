
namespace Proiect_Blackjack
{
    partial class MainMenuForm
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
            this.newGameBtn = new System.Windows.Forms.Button();
            this.rulesBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newGameBtn
            // 
            this.newGameBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.newGameBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.newGameBtn.FlatAppearance.BorderSize = 3;
            this.newGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newGameBtn.Location = new System.Drawing.Point(421, 306);
            this.newGameBtn.Margin = new System.Windows.Forms.Padding(4);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(216, 58);
            this.newGameBtn.TabIndex = 0;
            this.newGameBtn.Text = "Joc nou";
            this.newGameBtn.UseVisualStyleBackColor = false;
            this.newGameBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // rulesBtn
            // 
            this.rulesBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.rulesBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rulesBtn.FlatAppearance.BorderSize = 3;
            this.rulesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rulesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rulesBtn.Location = new System.Drawing.Point(421, 372);
            this.rulesBtn.Margin = new System.Windows.Forms.Padding(4);
            this.rulesBtn.Name = "rulesBtn";
            this.rulesBtn.Size = new System.Drawing.Size(216, 58);
            this.rulesBtn.TabIndex = 2;
            this.rulesBtn.Text = "Reguli";
            this.rulesBtn.UseVisualStyleBackColor = false;
            this.rulesBtn.Click += new System.EventHandler(this.rulesBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.quitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.quitBtn.FlatAppearance.BorderSize = 3;
            this.quitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.quitBtn.Location = new System.Drawing.Point(421, 437);
            this.quitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(216, 58);
            this.quitBtn.TabIndex = 3;
            this.quitBtn.Text = "Iesire";
            this.quitBtn.UseVisualStyleBackColor = false;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Green;
            this.titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.titleLabel.Location = new System.Drawing.Point(403, 76);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(247, 60);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Blackjack";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(732, 523);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Autor: Florea Tudor - Dorin";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect_Blackjack.Properties.Resources.Felt_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.rulesBtn);
            this.Controls.Add(this.newGameBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joc Blackjack - Meniu principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Button rulesBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label1;
    }
}