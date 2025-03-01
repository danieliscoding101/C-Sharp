
namespace ChapiJAlejandroD_14Nov2021
{
    partial class FRombo
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
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profundidad = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtDiagMenor = new System.Windows.Forms.TextBox();
            this.txtDiagMayor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProf = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cálculo de Perímetro, área y volumen de un rombo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView.Location = new System.Drawing.Point(97, 167);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(346, 104);
            this.dataGridView.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Perimetro";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Area";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Volumen";
            this.Column3.Name = "Column3";
            // 
            // Profundidad
            // 
            this.Profundidad.AutoSize = true;
            this.Profundidad.Location = new System.Drawing.Point(52, 87);
            this.Profundidad.Name = "Profundidad";
            this.Profundidad.Size = new System.Drawing.Size(85, 13);
            this.Profundidad.TabIndex = 15;
            this.Profundidad.Text = "Diagonal Menor:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(362, 69);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(129, 42);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtDiagMenor
            // 
            this.txtDiagMenor.Location = new System.Drawing.Point(142, 84);
            this.txtDiagMenor.Name = "txtDiagMenor";
            this.txtDiagMenor.Size = new System.Drawing.Size(100, 20);
            this.txtDiagMenor.TabIndex = 12;
            // 
            // txtDiagMayor
            // 
            this.txtDiagMayor.Location = new System.Drawing.Point(142, 41);
            this.txtDiagMayor.Name = "txtDiagMayor";
            this.txtDiagMayor.Size = new System.Drawing.Size(100, 20);
            this.txtDiagMayor.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Diagonal Mayor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Espesor:";
            // 
            // txtProf
            // 
            this.txtProf.Location = new System.Drawing.Point(142, 126);
            this.txtProf.Name = "txtProf";
            this.txtProf.Size = new System.Drawing.Size(100, 20);
            this.txtProf.TabIndex = 18;
            // 
            // FRombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 320);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Profundidad);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDiagMenor);
            this.Controls.Add(this.txtDiagMayor);
            this.Controls.Add(this.label1);
            this.Name = "FRombo";
            this.Text = "FRombo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label Profundidad;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtDiagMenor;
        private System.Windows.Forms.TextBox txtDiagMayor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProf;
    }
}