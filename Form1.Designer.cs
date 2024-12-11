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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(121, 171, 162);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
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
            lstTareas.BackColor = Color.FromArgb(187, 187, 136);
            lstTareas.FormattingEnabled = true;
            lstTareas.ItemHeight = 15;
            lstTareas.Location = new Point(57, 103);
            lstTareas.Name = "lstTareas";
            lstTareas.Size = new Size(280, 109);
            lstTareas.TabIndex = 3;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 192, 128);
            btnEliminar.ForeColor = Color.IndianRed;
            btnEliminar.Location = new Point(122, 218);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 23);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar Tarea";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(218, 247, 166);
            btnAgregar.ForeColor = Color.Peru;
            btnAgregar.Image = Properties.Resources.agregar;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(57, 46);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(135, 28);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar Tarea";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtTarea
            // 
            txtTarea.BackColor = Color.FromArgb(192, 192, 255);
            txtTarea.BorderStyle = BorderStyle.None;
            txtTarea.Location = new Point(57, 24);
            txtTarea.Name = "txtTarea";
            txtTarea.Size = new Size(159, 16);
            txtTarea.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Location = new Point(242, 43);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.task_management_icon_free_vector;
            pictureBox1.Location = new Point(330, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox lstTareas;
        private Button btnEliminar;
        private Button btnAgregar;
        private TextBox txtTarea;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
