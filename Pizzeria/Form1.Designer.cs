
namespace Pizzeria
{
    partial class menuprincipal
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
            this.menulateral = new System.Windows.Forms.Panel();
            this.menusuperior = new System.Windows.Forms.Panel();
            this.espaciador = new System.Windows.Forms.Panel();
            this.bt_analisis = new System.Windows.Forms.Button();
            this.smenu_analisis = new System.Windows.Forms.Panel();
            this.areatrabajo = new System.Windows.Forms.Panel();
            this.menulateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // menulateral
            // 
            this.menulateral.AutoScroll = true;
            this.menulateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.menulateral.Controls.Add(this.smenu_analisis);
            this.menulateral.Controls.Add(this.bt_analisis);
            this.menulateral.Controls.Add(this.espaciador);
            this.menulateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.menulateral.Location = new System.Drawing.Point(0, 0);
            this.menulateral.Name = "menulateral";
            this.menulateral.Size = new System.Drawing.Size(250, 481);
            this.menulateral.TabIndex = 0;
            // 
            // menusuperior
            // 
            this.menusuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.menusuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.menusuperior.Location = new System.Drawing.Point(250, 0);
            this.menusuperior.Name = "menusuperior";
            this.menusuperior.Size = new System.Drawing.Size(438, 80);
            this.menusuperior.TabIndex = 1;
            // 
            // espaciador
            // 
            this.espaciador.Dock = System.Windows.Forms.DockStyle.Top;
            this.espaciador.Location = new System.Drawing.Point(0, 0);
            this.espaciador.Name = "espaciador";
            this.espaciador.Size = new System.Drawing.Size(250, 80);
            this.espaciador.TabIndex = 0;
            // 
            // bt_analisis
            // 
            this.bt_analisis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(37)))), ((int)(((byte)(33)))));
            this.bt_analisis.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_analisis.FlatAppearance.BorderSize = 0;
            this.bt_analisis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_analisis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_analisis.ForeColor = System.Drawing.Color.White;
            this.bt_analisis.Location = new System.Drawing.Point(0, 80);
            this.bt_analisis.Name = "bt_analisis";
            this.bt_analisis.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bt_analisis.Size = new System.Drawing.Size(250, 45);
            this.bt_analisis.TabIndex = 1;
            this.bt_analisis.Text = "Análisis";
            this.bt_analisis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_analisis.UseVisualStyleBackColor = false;
            // 
            // smenu_analisis
            // 
            this.smenu_analisis.Dock = System.Windows.Forms.DockStyle.Top;
            this.smenu_analisis.Location = new System.Drawing.Point(0, 125);
            this.smenu_analisis.Name = "smenu_analisis";
            this.smenu_analisis.Size = new System.Drawing.Size(250, 221);
            this.smenu_analisis.TabIndex = 2;
            // 
            // areatrabajo
            // 
            this.areatrabajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.areatrabajo.Location = new System.Drawing.Point(250, 80);
            this.areatrabajo.Name = "areatrabajo";
            this.areatrabajo.Size = new System.Drawing.Size(438, 401);
            this.areatrabajo.TabIndex = 3;
            // 
            // menuprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(688, 481);
            this.Controls.Add(this.areatrabajo);
            this.Controls.Add(this.menusuperior);
            this.Controls.Add(this.menulateral);
            this.IsMdiContainer = true;
            this.Name = "menuprincipal";
            this.menulateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menulateral;
        private System.Windows.Forms.Panel menusuperior;
        private System.Windows.Forms.Button bt_analisis;
        private System.Windows.Forms.Panel espaciador;
        private System.Windows.Forms.Panel smenu_analisis;
        private System.Windows.Forms.Panel areatrabajo;
    }
}

