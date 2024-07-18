
namespace Front
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
            this.TboxNombreIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TboxApellidoIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCrearUsr = new System.Windows.Forms.Button();
            this.LbMensaje = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TboxApellidoMod = new System.Windows.Forms.TextBox();
            this.TboxNombreMod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TboxNombreIn
            // 
            this.TboxNombreIn.Location = new System.Drawing.Point(42, 111);
            this.TboxNombreIn.Name = "TboxNombreIn";
            this.TboxNombreIn.Size = new System.Drawing.Size(140, 20);
            this.TboxNombreIn.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Creacion";
            // 
            // TboxApellidoIn
            // 
            this.TboxApellidoIn.Location = new System.Drawing.Point(42, 162);
            this.TboxApellidoIn.Name = "TboxApellidoIn";
            this.TboxApellidoIn.Size = new System.Drawing.Size(140, 20);
            this.TboxApellidoIn.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido";
            // 
            // BtnCrearUsr
            // 
            this.BtnCrearUsr.Location = new System.Drawing.Point(62, 209);
            this.BtnCrearUsr.Name = "BtnCrearUsr";
            this.BtnCrearUsr.Size = new System.Drawing.Size(96, 32);
            this.BtnCrearUsr.TabIndex = 5;
            this.BtnCrearUsr.Text = "Crear usuario";
            this.BtnCrearUsr.UseVisualStyleBackColor = true;
            // 
            // LbMensaje
            // 
            this.LbMensaje.AutoSize = true;
            this.LbMensaje.Location = new System.Drawing.Point(87, 288);
            this.LbMensaje.Name = "LbMensaje";
            this.LbMensaje.Size = new System.Drawing.Size(19, 13);
            this.LbMensaje.TabIndex = 6;
            this.LbMensaje.Text = "***";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(269, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(296, 343);
            this.dataGridView1.TabIndex = 7;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(646, 209);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(96, 32);
            this.BtnModificar.TabIndex = 12;
            this.BtnModificar.Text = "Modifcar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(671, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(671, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nombre";
            // 
            // TboxApellidoMod
            // 
            this.TboxApellidoMod.Location = new System.Drawing.Point(626, 162);
            this.TboxApellidoMod.Name = "TboxApellidoMod";
            this.TboxApellidoMod.Size = new System.Drawing.Size(140, 20);
            this.TboxApellidoMod.TabIndex = 9;
            // 
            // TboxNombreMod
            // 
            this.TboxNombreMod.Location = new System.Drawing.Point(626, 111);
            this.TboxNombreMod.Name = "TboxNombreMod";
            this.TboxNombreMod.Size = new System.Drawing.Size(140, 20);
            this.TboxNombreMod.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(662, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Modificacion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TboxApellidoMod);
            this.Controls.Add(this.TboxNombreMod);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LbMensaje);
            this.Controls.Add(this.BtnCrearUsr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TboxApellidoIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TboxNombreIn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TboxNombreIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TboxApellidoIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCrearUsr;
        private System.Windows.Forms.Label LbMensaje;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TboxApellidoMod;
        private System.Windows.Forms.TextBox TboxNombreMod;
        private System.Windows.Forms.Label label6;
    }
}

