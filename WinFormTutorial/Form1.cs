using WinFormTutorial.Datos;

namespace WinFormTutorial
{
    public partial class Form1 : Form
    {
        private Persona _persona;
        public Form1()
        {
            InitializeComponent();

            _persona = new Persona();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = personName.Text;
            int.TryParse(personAge.Text, out int age);

            if (age > 0 && !string.IsNullOrWhiteSpace(name))
            {
                _persona.AddPersona(name, age);
                personAge.Text = "";
                personName.Text = "";
                ErrorText.Text = "";
            }
            else
            {
                ErrorText.Text = "No se ha podido guardar la información.\n Asegurate de que la información sea correcta e\n inténtalo de nuevo";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ShowButtom_Click(object sender, EventArgs e)
        {
            listPersonas.Items.Clear();
            listPersonas.Items.AddRange(_persona.GetPersonaList());
            listPersonas.Items.RemoveAt(listPersonas.Items.Count - 1);
        }

        private void personAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
