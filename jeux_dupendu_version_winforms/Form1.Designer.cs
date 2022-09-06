
namespace ppcwin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Papier = new System.Windows.Forms.Button();
            this.Pierre = new System.Windows.Forms.Button();
            this.Ciseaux = new System.Windows.Forms.Button();
            this.textbox_ordinateur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxresultat = new System.Windows.Forms.TextBox();
            this.labl2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Papier
            // 
            this.Papier.Location = new System.Drawing.Point(242, 174);
            this.Papier.Name = "Papier";
            this.Papier.Size = new System.Drawing.Size(85, 23);
            this.Papier.TabIndex = 2;
            this.Papier.Text = "Papier";
            this.Papier.UseVisualStyleBackColor = true;
            this.Papier.Click += new System.EventHandler(this.Papier_Click);
            // 
            // Pierre
            // 
            this.Pierre.Location = new System.Drawing.Point(345, 174);
            this.Pierre.Name = "Pierre";
            this.Pierre.Size = new System.Drawing.Size(75, 23);
            this.Pierre.TabIndex = 3;
            this.Pierre.Text = "Pierre";
            this.Pierre.UseVisualStyleBackColor = true;
            this.Pierre.Click += new System.EventHandler(this.Pierre_Click);
            // 
            // Ciseaux
            // 
            this.Ciseaux.Location = new System.Drawing.Point(442, 174);
            this.Ciseaux.Name = "Ciseaux";
            this.Ciseaux.Size = new System.Drawing.Size(75, 23);
            this.Ciseaux.TabIndex = 4;
            this.Ciseaux.Text = "Ciseaux";
            this.Ciseaux.UseVisualStyleBackColor = true;
            this.Ciseaux.Click += new System.EventHandler(this.Ciseaux_Click);
            // 
            // textbox_ordinateur
            // 
            this.textbox_ordinateur.Location = new System.Drawing.Point(289, 217);
            this.textbox_ordinateur.Name = "textbox_ordinateur";
            this.textbox_ordinateur.Size = new System.Drawing.Size(198, 23);
            this.textbox_ordinateur.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Résultat du Match ";
            // 
            // textboxresultat
            // 
            this.textboxresultat.Location = new System.Drawing.Point(320, 307);
            this.textboxresultat.Name = "textboxresultat";
            this.textboxresultat.Size = new System.Drawing.Size(148, 23);
            this.textboxresultat.TabIndex = 7;
            this.textboxresultat.TextChanged += new System.EventHandler(this.textboxresultat_TextChanged);
            // 
            // labl2
            // 
            this.labl2.AutoSize = true;
            this.labl2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labl2.Location = new System.Drawing.Point(209, 37);
            this.labl2.Name = "labl2";
            this.labl2.Size = new System.Drawing.Size(374, 32);
            this.labl2.TabIndex = 8;
            this.labl2.Text = "le Jeux du Papier , Pierre , Ciseaux";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(306, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Que choisis tu ?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labl2);
            this.Controls.Add(this.textboxresultat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_ordinateur);
            this.Controls.Add(this.Ciseaux);
            this.Controls.Add(this.Pierre);
            this.Controls.Add(this.Papier);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "le Jeux du Papier , Pierre , Ciseaux";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Papier;
        private System.Windows.Forms.Button Pierre;
        private System.Windows.Forms.Button Ciseaux;
        private System.Windows.Forms.TextBox textbox_ordinateur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxresultat;
        private System.Windows.Forms.Label labl2;
        private System.Windows.Forms.Label label2;
    }
}

