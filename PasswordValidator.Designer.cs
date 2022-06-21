using System.Drawing;

namespace PasswordValidator
{
    partial class PasswordValidator
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.PasswordLengthLabel = new System.Windows.Forms.Label();
            this.PasswordSpecialCharLabel = new System.Windows.Forms.Label();
            this.PasswordCapitalCharLabel = new System.Windows.Forms.Label();
            this.PasswordDigitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PasswordLengthLabel
            // 
            this.PasswordLengthLabel.AutoSize = true;
            this.PasswordLengthLabel.Location = new System.Drawing.Point(4, 4);
            this.PasswordLengthLabel.Name = "PasswordLengthLabel";
            this.PasswordLengthLabel.Size = new System.Drawing.Size(122, 17);
            this.PasswordLengthLabel.TabIndex = 0;
            this.PasswordLengthLabel.Text = "12 or more characters";
            this.PasswordLengthLabel.BackColor = Color.Red;
            // 
            // PasswordSpecialCharLabel
            // 
            this.PasswordSpecialCharLabel.AutoSize = true;
            this.PasswordSpecialCharLabel.Location = new System.Drawing.Point(4, 28);
            this.PasswordSpecialCharLabel.Name = "PasswordSpecialCharLabel";
            this.PasswordSpecialCharLabel.Size = new System.Drawing.Size(165, 17);
            this.PasswordSpecialCharLabel.TabIndex = 1;
            this.PasswordSpecialCharLabel.Text = "One or more special characters ";
            this.PasswordSpecialCharLabel.BackColor = Color.Red;

            // 
            // PasswordCapitalCharLabel
            // 
            this.PasswordCapitalCharLabel.AutoSize = true;
            this.PasswordCapitalCharLabel.Location = new System.Drawing.Point(4, 52);
            this.PasswordCapitalCharLabel.Name = "PasswordCapitalCharLabel";
            this.PasswordCapitalCharLabel.Size = new System.Drawing.Size(141, 17);
            this.PasswordCapitalCharLabel.TabIndex = 2;
            this.PasswordCapitalCharLabel.Text = "One or more capital letters";
            this.PasswordCapitalCharLabel.BackColor = Color.Red;
            // 
            // PasswordDigitLabel
            // 
            this.PasswordDigitLabel.AutoSize = true;
            this.PasswordDigitLabel.Location = new System.Drawing.Point(4, 76);
            this.PasswordDigitLabel.Name = "PasswordDigitLabel";
            this.PasswordDigitLabel.Size = new System.Drawing.Size(103, 17);
            this.PasswordDigitLabel.TabIndex = 3;
            this.PasswordDigitLabel.Text = "One or more digits";
            this.PasswordDigitLabel.BackColor = Color.Red;
            // 
            // PasswordValidator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PasswordDigitLabel);
            this.Controls.Add(this.PasswordCapitalCharLabel);
            this.Controls.Add(this.PasswordSpecialCharLabel);
            this.Controls.Add(this.PasswordLengthLabel);
            this.Name = "PasswordValidator";
            this.Size = new System.Drawing.Size(173, 97);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PasswordLengthLabel;
        private System.Windows.Forms.Label PasswordSpecialCharLabel;
        private System.Windows.Forms.Label PasswordCapitalCharLabel;
        private System.Windows.Forms.Label PasswordDigitLabel;
    }
}
