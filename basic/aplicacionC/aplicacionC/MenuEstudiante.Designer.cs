
namespace Clase11_f10_12ArreglosMetodos
{
    partial class MenuEstudiante
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
            this.btnBurbuja = new System.Windows.Forms.Button();
            this.btnShell = new System.Windows.Forms.Button();
            this.btnInsercion = new System.Windows.Forms.Button();
            this.btnHeapSort = new System.Windows.Forms.Button();
            this.btnMergeSort = new System.Windows.Forms.Button();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.btnSecuencial = new System.Windows.Forms.Button();
            this.btnBinaria = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBurbuja
            // 
            this.btnBurbuja.Location = new System.Drawing.Point(12, 61);
            this.btnBurbuja.Name = "btnBurbuja";
            this.btnBurbuja.Size = new System.Drawing.Size(103, 35);
            this.btnBurbuja.TabIndex = 2;
            this.btnBurbuja.Text = "BURBUJA";
            this.btnBurbuja.UseVisualStyleBackColor = true;
            this.btnBurbuja.Click += new System.EventHandler(this.btnBurbuja_Click);
            // 
            // btnShell
            // 
            this.btnShell.Location = new System.Drawing.Point(144, 61);
            this.btnShell.Name = "btnShell";
            this.btnShell.Size = new System.Drawing.Size(103, 35);
            this.btnShell.TabIndex = 3;
            this.btnShell.Text = "SHELL";
            this.btnShell.UseVisualStyleBackColor = true;
            this.btnShell.Click += new System.EventHandler(this.btnShell_Click);
            // 
            // btnInsercion
            // 
            this.btnInsercion.Location = new System.Drawing.Point(12, 114);
            this.btnInsercion.Name = "btnInsercion";
            this.btnInsercion.Size = new System.Drawing.Size(103, 35);
            this.btnInsercion.TabIndex = 4;
            this.btnInsercion.Text = "INSERCION";
            this.btnInsercion.UseVisualStyleBackColor = true;
            this.btnInsercion.Click += new System.EventHandler(this.btnInsercion_Click);
            // 
            // btnHeapSort
            // 
            this.btnHeapSort.Location = new System.Drawing.Point(144, 114);
            this.btnHeapSort.Name = "btnHeapSort";
            this.btnHeapSort.Size = new System.Drawing.Size(103, 35);
            this.btnHeapSort.TabIndex = 5;
            this.btnHeapSort.Text = "HEAPSORT";
            this.btnHeapSort.UseVisualStyleBackColor = true;
            this.btnHeapSort.Click += new System.EventHandler(this.btnHeapSort_Click);
            // 
            // btnMergeSort
            // 
            this.btnMergeSort.Location = new System.Drawing.Point(12, 171);
            this.btnMergeSort.Name = "btnMergeSort";
            this.btnMergeSort.Size = new System.Drawing.Size(103, 35);
            this.btnMergeSort.TabIndex = 6;
            this.btnMergeSort.Text = "MERGE SORT";
            this.btnMergeSort.UseVisualStyleBackColor = true;
            this.btnMergeSort.Click += new System.EventHandler(this.btnMergeSort_Click);
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.Location = new System.Drawing.Point(144, 171);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(103, 35);
            this.btnQuickSort.TabIndex = 7;
            this.btnQuickSort.Text = "QUICK SORT";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // btnSecuencial
            // 
            this.btnSecuencial.Location = new System.Drawing.Point(357, 61);
            this.btnSecuencial.Name = "btnSecuencial";
            this.btnSecuencial.Size = new System.Drawing.Size(104, 35);
            this.btnSecuencial.TabIndex = 8;
            this.btnSecuencial.Text = "SECUENCIAL";
            this.btnSecuencial.UseVisualStyleBackColor = true;
            this.btnSecuencial.Click += new System.EventHandler(this.btnSecuencial_Click);
            // 
            // btnBinaria
            // 
            this.btnBinaria.Location = new System.Drawing.Point(483, 61);
            this.btnBinaria.Name = "btnBinaria";
            this.btnBinaria.Size = new System.Drawing.Size(104, 35);
            this.btnBinaria.TabIndex = 9;
            this.btnBinaria.Text = "BINARIA";
            this.btnBinaria.UseVisualStyleBackColor = true;
            this.btnBinaria.Click += new System.EventHandler(this.btnBinaria_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "MÉTODOS DE BÚSQUEDA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "MÉTODOS DE ORDENAMIENTO";
            // 
            // MenuEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 254);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBinaria);
            this.Controls.Add(this.btnSecuencial);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.btnMergeSort);
            this.Controls.Add(this.btnHeapSort);
            this.Controls.Add(this.btnInsercion);
            this.Controls.Add(this.btnShell);
            this.Controls.Add(this.btnBurbuja);
            this.Name = "MenuEstudiante";
            this.Text = "MenuEstudiante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBurbuja;
        private System.Windows.Forms.Button btnShell;
        private System.Windows.Forms.Button btnInsercion;
        private System.Windows.Forms.Button btnHeapSort;
        private System.Windows.Forms.Button btnMergeSort;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.Button btnSecuencial;
        private System.Windows.Forms.Button btnBinaria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}