namespace GestiosTareasPendientes
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
            panel1 = new Panel();
            lstTareas = new ListBox();
            btnEliminar = new Button();
            btnAgregar = new Button();
            txtTarea = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lstTareas);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(txtTarea);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 315);
            panel1.TabIndex = 0;
            // 
            // lstTareas
            // 
            lstTareas.FormattingEnabled = true;
            lstTareas.ItemHeight = 15;
            lstTareas.Location = new Point(57, 103);
            lstTareas.Name = "lstTareas";
            lstTareas.Size = new Size(280, 109);
            lstTareas.TabIndex = 3;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(57, 237);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 23);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar Tarea";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(57, 64);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(120, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar Tarea";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtTarea
            // 
            txtTarea.Location = new Point(57, 24);
            txtTarea.Name = "txtTarea";
            txtTarea.Size = new Size(153, 23);
            txtTarea.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 315);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Gestion de Tareas Pendientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox lstTareas;
        private Button btnEliminar;
        private Button btnAgregar;
        private TextBox txtTarea;
    }
}
