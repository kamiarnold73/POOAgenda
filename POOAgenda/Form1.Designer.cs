namespace POOAgenda
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            TxtNombre = new TextBox();
            TxtTelefono = new TextBox();
            BtnAgregar = new Button();
            DgvContactos = new DataGridView();
            Contacto = new DataGridViewTextBoxColumn();
            Agenda = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DgvContactos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 49);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 88);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Telefono";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(126, 46);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(125, 27);
            TxtNombre.TabIndex = 2;
            // 
            // TxtTelefono
            // 
            TxtTelefono.Location = new Point(126, 85);
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(125, 27);
            TxtTelefono.TabIndex = 3;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(55, 129);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(94, 29);
            BtnAgregar.TabIndex = 4;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // DgvContactos
            // 
            DgvContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvContactos.Columns.AddRange(new DataGridViewColumn[] { Contacto, Agenda });
            DgvContactos.Location = new Point(39, 184);
            DgvContactos.Name = "DgvContactos";
            DgvContactos.RowHeadersWidth = 51;
            DgvContactos.Size = new Size(300, 188);
            DgvContactos.TabIndex = 5;
            DgvContactos.CellContentClick += DgvContactos_CellContentClick;
            // 
            // Contacto
            // 
            Contacto.HeaderText = "Contacto";
            Contacto.MinimumWidth = 6;
            Contacto.Name = "Contacto";
            Contacto.Width = 125;
            // 
            // Agenda
            // 
            Agenda.HeaderText = "Agenda";
            Agenda.MinimumWidth = 6;
            Agenda.Name = "Agenda";
            Agenda.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DgvContactos);
            Controls.Add(BtnAgregar);
            Controls.Add(TxtTelefono);
            Controls.Add(TxtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DgvContactos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtNombre;
        private TextBox TxtTelefono;
        private Button BtnAgregar;
        private DataGridView DgvContactos;
        private DataGridViewTextBoxColumn Contacto;
        private DataGridViewTextBoxColumn Agenda;
    }
}
