namespace Zaznaczenie
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
            this.naszCzekboks = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // naszCzekboks
            // 
            this.naszCzekboks.AutoSize = true;
            this.naszCzekboks.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.naszCzekboks.Location = new System.Drawing.Point(262, 163);
            this.naszCzekboks.Name = "naszCzekboks";
            this.naszCzekboks.Size = new System.Drawing.Size(241, 50);
            this.naszCzekboks.TabIndex = 0;
            this.naszCzekboks.Text = "checkBox1";
            this.naszCzekboks.UseVisualStyleBackColor = true;
            this.naszCzekboks.CheckedChanged += new System.EventHandler(this.naszCzekboks_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 367);
            this.Controls.Add(this.naszCzekboks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox naszCzekboks;
    }
}

