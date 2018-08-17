namespace CustomSkoProgressBar
{
    partial class SkoProgressBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblValor
            // 
            this.LblValor.AutoSize = true;
            this.LblValor.BackColor = System.Drawing.Color.Transparent;
            this.LblValor.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValor.Location = new System.Drawing.Point(98, 8);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(24, 18);
            this.LblValor.TabIndex = 0;
            this.LblValor.Text = "0%";
            // 
            // SkoProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.LblValor);
            this.Name = "SkoProgressBar";
            this.Size = new System.Drawing.Size(220, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblValor;
    }
}
