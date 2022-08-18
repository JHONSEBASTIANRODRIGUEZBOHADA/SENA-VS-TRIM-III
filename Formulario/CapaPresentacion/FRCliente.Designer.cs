namespace CapaPresentacion
{
    partial class FRCliente
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
            this.LnkId = new System.Windows.Forms.Label();
            this.LnkNombre = new System.Windows.Forms.Label();
            this.LnkApellido = new System.Windows.Forms.Label();
            this.LnkFoto = new System.Windows.Forms.Label();
            this.LnkSeleccionar = new System.Windows.Forms.LinkLabel();
            this.PicFoto = new System.Windows.Forms.PictureBox();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.NumericUpDown();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId)).BeginInit();
            this.SuspendLayout();
            // 
            // LnkId
            // 
            this.LnkId.AutoSize = true;
            this.LnkId.Location = new System.Drawing.Point(66, 43);
            this.LnkId.Name = "LnkId";
            this.LnkId.Size = new System.Drawing.Size(25, 20);
            this.LnkId.TabIndex = 0;
            this.LnkId.Text = "Id:";
            this.LnkId.Click += new System.EventHandler(this.label1_Click);
            // 
            // LnkNombre
            // 
            this.LnkNombre.AutoSize = true;
            this.LnkNombre.Location = new System.Drawing.Point(49, 91);
            this.LnkNombre.Name = "LnkNombre";
            this.LnkNombre.Size = new System.Drawing.Size(67, 20);
            this.LnkNombre.TabIndex = 1;
            this.LnkNombre.Text = "Nombre:";
            // 
            // LnkApellido
            // 
            this.LnkApellido.AutoSize = true;
            this.LnkApellido.Location = new System.Drawing.Point(51, 153);
            this.LnkApellido.Name = "LnkApellido";
            this.LnkApellido.Size = new System.Drawing.Size(69, 20);
            this.LnkApellido.TabIndex = 2;
            this.LnkApellido.Text = "Apellido:";
            // 
            // LnkFoto
            // 
            this.LnkFoto.AutoSize = true;
            this.LnkFoto.Location = new System.Drawing.Point(66, 232);
            this.LnkFoto.Name = "LnkFoto";
            this.LnkFoto.Size = new System.Drawing.Size(42, 20);
            this.LnkFoto.TabIndex = 3;
            this.LnkFoto.Text = "Foto:";
            // 
            // LnkSeleccionar
            // 
            this.LnkSeleccionar.AutoSize = true;
            this.LnkSeleccionar.Location = new System.Drawing.Point(49, 335);
            this.LnkSeleccionar.Name = "LnkSeleccionar";
            this.LnkSeleccionar.Size = new System.Drawing.Size(85, 20);
            this.LnkSeleccionar.TabIndex = 4;
            this.LnkSeleccionar.TabStop = true;
            this.LnkSeleccionar.Text = "Seleccionar";
            // 
            // PicFoto
            // 
            this.PicFoto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PicFoto.Location = new System.Drawing.Point(165, 198);
            this.PicFoto.Name = "PicFoto";
            this.PicFoto.Size = new System.Drawing.Size(150, 88);
            this.PicFoto.TabIndex = 5;
            this.PicFoto.TabStop = false;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnNuevo.Location = new System.Drawing.Point(165, 331);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(94, 29);
            this.BtnNuevo.TabIndex = 6;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnEliminar.Location = new System.Drawing.Point(305, 331);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(94, 29);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnGuardar.Location = new System.Drawing.Point(439, 331);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(94, 29);
            this.BtnGuardar.TabIndex = 8;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(165, 41);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(150, 27);
            this.TxtId.TabIndex = 9;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(165, 88);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(150, 27);
            this.TxtNombre.TabIndex = 10;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(165, 146);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(150, 27);
            this.TxtApellido.TabIndex = 11;
            // 
            // FRCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.PicFoto);
            this.Controls.Add(this.LnkSeleccionar);
            this.Controls.Add(this.LnkFoto);
            this.Controls.Add(this.LnkApellido);
            this.Controls.Add(this.LnkNombre);
            this.Controls.Add(this.LnkId);
            this.Name = "FRCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FRCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LnkId;
        private Label LnkNombre;
        private Label LnkApellido;
        private Label LnkFoto;
        private LinkLabel LnkSeleccionar;
        private PictureBox PicFoto;
        private Button BtnNuevo;
        private Button BtnEliminar;
        private Button BtnGuardar;
        private NumericUpDown TxtId;
        private TextBox TxtNombre;
        private TextBox TxtApellido;
    }
}