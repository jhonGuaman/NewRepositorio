namespace GestiosTareasPendientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string tarea = txtTarea.Text;
            if (!string.IsNullOrEmpty(tarea))
            {
                lstTareas.Items.Add(tarea);
                txtTarea.Clear();
                txtTarea.Focus();
            }
            else
            {
                MessageBox.Show("Ingresa una tarea.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(lstTareas.SelectedItem !=null)
            {
                lstTareas.Items.Remove(lstTareas.SelectedItem);
            }
            else
            {
                MessageBox.Show("Selecciona una tarea para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
