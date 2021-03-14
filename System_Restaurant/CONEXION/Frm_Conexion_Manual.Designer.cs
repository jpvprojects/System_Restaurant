namespace System_Restaurant.CONEXION
{
    partial class Frm_Conexion_Manual
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cnString = new System.Windows.Forms.TextBox();
            this.btn_encriptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese cadena de conexion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(27, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(476, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Una vez que estes listo dale a \"Generar cadena de conexion\", se creara un Archivo" +
    " que contendra\r\ntu conexion Encryptada. Ahora tu conexion es mas segura ante pos" +
    "ibles hackers.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_cnString
            // 
            this.txt_cnString.Location = new System.Drawing.Point(30, 98);
            this.txt_cnString.Multiline = true;
            this.txt_cnString.Name = "txt_cnString";
            this.txt_cnString.Size = new System.Drawing.Size(473, 50);
            this.txt_cnString.TabIndex = 2;
            // 
            // btn_encriptar
            // 
            this.btn_encriptar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_encriptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_encriptar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_encriptar.ForeColor = System.Drawing.Color.White;
            this.btn_encriptar.Location = new System.Drawing.Point(30, 164);
            this.btn_encriptar.Name = "btn_encriptar";
            this.btn_encriptar.Size = new System.Drawing.Size(289, 40);
            this.btn_encriptar.TabIndex = 3;
            this.btn_encriptar.Text = "Generar cadena de conexión";
            this.btn_encriptar.UseVisualStyleBackColor = false;
            this.btn_encriptar.Click += new System.EventHandler(this.btn_encriptar_Click);
            // 
            // Frm_Conexion_Manual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(515, 216);
            this.Controls.Add(this.btn_encriptar);
            this.Controls.Add(this.txt_cnString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Conexion_Manual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexion Manual";
            this.Load += new System.EventHandler(this.Frm_Conexion_Manual_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cnString;
        private System.Windows.Forms.Button btn_encriptar;
    }
}