namespace Receptor
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_puerto = new System.Windows.Forms.TextBox();
            this.bt_escuchar = new System.Windows.Forms.Button();
            this.rbt_log = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dg_datos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "KDC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // tb_nombre
            // 
            this.tb_nombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_nombre.Location = new System.Drawing.Point(117, 80);
            this.tb_nombre.Multiline = true;
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(172, 39);
            this.tb_nombre.TabIndex = 2;
            this.tb_nombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Puerto:";
            // 
            // tb_puerto
            // 
            this.tb_puerto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_puerto.Location = new System.Drawing.Point(428, 80);
            this.tb_puerto.Multiline = true;
            this.tb_puerto.Name = "tb_puerto";
            this.tb_puerto.Size = new System.Drawing.Size(172, 39);
            this.tb_puerto.TabIndex = 4;
            // 
            // bt_escuchar
            // 
            this.bt_escuchar.Location = new System.Drawing.Point(638, 83);
            this.bt_escuchar.Name = "bt_escuchar";
            this.bt_escuchar.Size = new System.Drawing.Size(75, 23);
            this.bt_escuchar.TabIndex = 5;
            this.bt_escuchar.Text = "Escuchar ";
            this.bt_escuchar.UseVisualStyleBackColor = true;
            this.bt_escuchar.Click += new System.EventHandler(this.bt_escuchar_Click);
            // 
            // rbt_log
            // 
            this.rbt_log.Location = new System.Drawing.Point(49, 169);
            this.rbt_log.Name = "rbt_log";
            this.rbt_log.Size = new System.Drawing.Size(384, 136);
            this.rbt_log.TabIndex = 6;
            this.rbt_log.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "LOGS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "LOGS";
            // 
            // dg_datos
            // 
            this.dg_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_datos.Location = new System.Drawing.Point(49, 368);
            this.dg_datos.Name = "dg_datos";
            this.dg_datos.Size = new System.Drawing.Size(384, 150);
            this.dg_datos.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.dg_datos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbt_log);
            this.Controls.Add(this.bt_escuchar);
            this.Controls.Add(this.tb_puerto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_puerto;
        private System.Windows.Forms.Button bt_escuchar;
        private System.Windows.Forms.RichTextBox rbt_log;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dg_datos;
    }
}

