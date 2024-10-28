namespace MiPrimerForm.Formularios
{
    partial class FrmProducto
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
            this.tabRegistro = new System.Windows.Forms.TabControl();
            this.tabpage1 = new System.Windows.Forms.TabPage();
            this.tabGrid = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabRegistro.SuspendLayout();
            this.tabpage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabRegistro
            // 
            this.tabRegistro.Controls.Add(this.tabpage1);
            this.tabRegistro.Controls.Add(this.tabGrid);
            this.tabRegistro.Location = new System.Drawing.Point(43, 13);
            this.tabRegistro.Name = "tabRegistro";
            this.tabRegistro.SelectedIndex = 0;
            this.tabRegistro.Size = new System.Drawing.Size(694, 334);
            this.tabRegistro.TabIndex = 0;
            // 
            // tabpage1
            // 
            this.tabpage1.Controls.Add(this.checkBox1);
            this.tabpage1.Controls.Add(this.textBox3);
            this.tabpage1.Controls.Add(this.label3);
            this.tabpage1.Controls.Add(this.textBox2);
            this.tabpage1.Controls.Add(this.label2);
            this.tabpage1.Controls.Add(this.textBox1);
            this.tabpage1.Controls.Add(this.label1);
            this.tabpage1.Location = new System.Drawing.Point(4, 22);
            this.tabpage1.Name = "tabpage1";
            this.tabpage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage1.Size = new System.Drawing.Size(686, 308);
            this.tabpage1.TabIndex = 0;
            this.tabpage1.Text = "Datos del Producto";
            this.tabpage1.UseVisualStyleBackColor = true;
            // 
            // tabGrid
            // 
            this.tabGrid.Location = new System.Drawing.Point(4, 22);
            this.tabGrid.Name = "tabGrid";
            this.tabGrid.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrid.Size = new System.Drawing.Size(686, 308);
            this.tabGrid.TabIndex = 1;
            this.tabGrid.Text = "Registros Guardados";
            this.tabGrid.UseVisualStyleBackColor = true;
            this.tabGrid.Click += new System.EventHandler(this.tabGeneral_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(119, 125);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(119, 176);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(43, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "IVA";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabRegistro);
            this.Name = "FrmProducto";
            this.Text = "Producto";
            this.tabRegistro.ResumeLayout(false);
            this.tabpage1.ResumeLayout(false);
            this.tabpage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabRegistro;
        private System.Windows.Forms.TabPage tabpage1;
        private System.Windows.Forms.TabPage tabGrid;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
    }
}