namespace PasswordValidator
{
    partial class Form1
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.passwordValidator1 = new PasswordValidator();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.passwordLengthSelector = new System.Windows.Forms.NumericUpDown();
            this.RequiredLengthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLengthSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordValidator1
            // 
            this.passwordValidator1.Location = new System.Drawing.Point(11, 38);
            this.passwordValidator1.Name = "passwordValidator1";
            this.passwordValidator1.PasswordLength = 12;
            this.passwordValidator1.Size = new System.Drawing.Size(173, 97);
            this.passwordValidator1.SpecialChars = "";
            this.passwordValidator1.TabIndex = 14;
            this.passwordValidator1.Valid = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Type in characters you consider special";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 20);
            this.textBox2.TabIndex = 17;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Validate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwordLengthSelector
            // 
            this.passwordLengthSelector.Location = new System.Drawing.Point(111, 202);
            this.passwordLengthSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.passwordLengthSelector.Name = "passwordLengthSelector";
            this.passwordLengthSelector.Size = new System.Drawing.Size(74, 20);
            this.passwordLengthSelector.TabIndex = 16;
            this.passwordLengthSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.passwordLengthSelector.ValueChanged += new System.EventHandler(this.passwordLengthSelector_ValueChanged_1);
            // 
            // RequiredLengthLabel
            // 
            this.RequiredLengthLabel.AutoSize = true;
            this.RequiredLengthLabel.Location = new System.Drawing.Point(11, 209);
            this.RequiredLengthLabel.Name = "RequiredLengthLabel";
            this.RequiredLengthLabel.Size = new System.Drawing.Size(82, 13);
            this.RequiredLengthLabel.TabIndex = 19;
            this.RequiredLengthLabel.Text = "Required length";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RequiredLengthLabel);
            this.Controls.Add(this.passwordValidator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwordLengthSelector);
            this.Name = "Form1";
            this.Text = "Tester kontrolek";
            ((System.ComponentModel.ISupportInitialize)(this.passwordLengthSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PasswordValidator passwordValidator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown passwordLengthSelector;
        private System.Windows.Forms.Label RequiredLengthLabel;
    }
}

