namespace Expendio
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.lblImagen = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.pictureBox2 = new System.Windows.Forms.PictureBox();
         this.btnTecateLight = new System.Windows.Forms.Button();
         this.btnTecateRoja = new System.Windows.Forms.Button();
         this.btnIngresar = new System.Windows.Forms.Button();
         this.txtUsuario = new System.Windows.Forms.TextBox();
         this.txtContraseña = new System.Windows.Forms.TextBox();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
         this.SuspendLayout();
         // 
         // lblImagen
         // 
         this.lblImagen.Image = ((System.Drawing.Image)(resources.GetObject("lblImagen.Image")));
         this.lblImagen.Location = new System.Drawing.Point(154, 9);
         this.lblImagen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
         this.lblImagen.Name = "lblImagen";
         this.lblImagen.Size = new System.Drawing.Size(403, 139);
         this.lblImagen.TabIndex = 1;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(257, 199);
         this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(220, 23);
         this.label3.TabIndex = 3;
         this.label3.Text = "_____________________";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(257, 272);
         this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(220, 23);
         this.label4.TabIndex = 6;
         this.label4.Text = "_____________________";
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
         this.pictureBox1.Location = new System.Drawing.Point(216, 258);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(32, 32);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
         this.pictureBox1.TabIndex = 7;
         this.pictureBox1.TabStop = false;
         // 
         // pictureBox2
         // 
         this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
         this.pictureBox2.Location = new System.Drawing.Point(216, 180);
         this.pictureBox2.Name = "pictureBox2";
         this.pictureBox2.Size = new System.Drawing.Size(32, 32);
         this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
         this.pictureBox2.TabIndex = 8;
         this.pictureBox2.TabStop = false;
         // 
         // btnTecateLight
         // 
         this.btnTecateLight.FlatAppearance.BorderSize = 0;
         this.btnTecateLight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnTecateLight.Image = ((System.Drawing.Image)(resources.GetObject("btnTecateLight.Image")));
         this.btnTecateLight.Location = new System.Drawing.Point(626, 27);
         this.btnTecateLight.Name = "btnTecateLight";
         this.btnTecateLight.Size = new System.Drawing.Size(61, 99);
         this.btnTecateLight.TabIndex = 9;
         this.btnTecateLight.UseVisualStyleBackColor = true;
         this.btnTecateLight.Click += new System.EventHandler(this.btnTecateLight_Click);
         // 
         // btnTecateRoja
         // 
         this.btnTecateRoja.FlatAppearance.BorderSize = 0;
         this.btnTecateRoja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnTecateRoja.Image = ((System.Drawing.Image)(resources.GetObject("btnTecateRoja.Image")));
         this.btnTecateRoja.Location = new System.Drawing.Point(31, 27);
         this.btnTecateRoja.Name = "btnTecateRoja";
         this.btnTecateRoja.Size = new System.Drawing.Size(61, 99);
         this.btnTecateRoja.TabIndex = 10;
         this.btnTecateRoja.UseVisualStyleBackColor = true;
         this.btnTecateRoja.Click += new System.EventHandler(this.btnTecateRoja_Click);
         // 
         // btnIngresar
         // 
         this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(193)))), ((int)(((byte)(104)))));
         this.btnIngresar.FlatAppearance.BorderSize = 2;
         this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnIngresar.Location = new System.Drawing.Point(201, 318);
         this.btnIngresar.Name = "btnIngresar";
         this.btnIngresar.Size = new System.Drawing.Size(310, 41);
         this.btnIngresar.TabIndex = 11;
         this.btnIngresar.Text = "Ingresar";
         this.btnIngresar.UseVisualStyleBackColor = true;
         this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
         // 
         // txtUsuario
         // 
         this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
         this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtUsuario.ForeColor = System.Drawing.Color.White;
         this.txtUsuario.Location = new System.Drawing.Point(261, 185);
         this.txtUsuario.Name = "txtUsuario";
         this.txtUsuario.Size = new System.Drawing.Size(207, 27);
         this.txtUsuario.TabIndex = 12;
         this.txtUsuario.Text = "Usuario";
         this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
         this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
         // 
         // txtContraseña
         // 
         this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
         this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtContraseña.ForeColor = System.Drawing.Color.White;
         this.txtContraseña.Location = new System.Drawing.Point(261, 263);
         this.txtContraseña.Name = "txtContraseña";
         this.txtContraseña.Size = new System.Drawing.Size(207, 27);
         this.txtContraseña.TabIndex = 13;
         this.txtContraseña.Text = "Contraseña";
         this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
         this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
         this.ClientSize = new System.Drawing.Size(722, 395);
         this.Controls.Add(this.txtContraseña);
         this.Controls.Add(this.txtUsuario);
         this.Controls.Add(this.btnIngresar);
         this.Controls.Add(this.btnTecateRoja);
         this.Controls.Add(this.btnTecateLight);
         this.Controls.Add(this.pictureBox2);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.lblImagen);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label4);
         this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.ForeColor = System.Drawing.Color.White;
         this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
         this.MaximizeBox = false;
         this.Name = "Form1";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "LogIn";
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Label lblImagen;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.PictureBox pictureBox2;
      private System.Windows.Forms.Button btnTecateLight;
      private System.Windows.Forms.Button btnTecateRoja;
      private System.Windows.Forms.Button btnIngresar;
      private System.Windows.Forms.TextBox txtUsuario;
      private System.Windows.Forms.TextBox txtContraseña;
   }
}

