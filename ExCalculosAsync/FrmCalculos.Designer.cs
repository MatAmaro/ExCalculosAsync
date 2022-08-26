namespace ExCalculosAsync
{
    partial class FrmCalculos
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
            this.lsbListaExibição = new System.Windows.Forms.ListBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblAguardeCalculo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsbListaExibição
            // 
            this.lsbListaExibição.FormattingEnabled = true;
            this.lsbListaExibição.ItemHeight = 15;
            this.lsbListaExibição.Location = new System.Drawing.Point(12, 12);
            this.lsbListaExibição.Name = "lsbListaExibição";
            this.lsbListaExibição.Size = new System.Drawing.Size(520, 199);
            this.lsbListaExibição.TabIndex = 0;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(230, 241);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(84, 40);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblAguardeCalculo
            // 
            this.lblAguardeCalculo.AutoSize = true;
            this.lblAguardeCalculo.Location = new System.Drawing.Point(182, 308);
            this.lblAguardeCalculo.Name = "lblAguardeCalculo";
            this.lblAguardeCalculo.Size = new System.Drawing.Size(0, 15);
            this.lblAguardeCalculo.TabIndex = 2;
            // 
            // FrmCalculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 389);
            this.Controls.Add(this.lblAguardeCalculo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lsbListaExibição);
            this.Name = "FrmCalculos";
            this.Text = "FrmCalculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lsbListaExibição;
        private Button btnCalcular;
        private Label lblAguardeCalculo;
    }
}