using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZakupnikGUI
{
    public partial class ControlAddRecipe : UserControl
    {
        private List<string> lista = new List<string>();
        private string _tempStr;

        public ControlAddRecipe()
        {
            InitializeComponent();



        }


        private void ControlAddRecipe_Load(object sender, EventArgs e)
        {

        }

        private void AddIngridend_Click(object sender, EventArgs e)
        {
            lista.Add(textBoxIng.Text);
            _tempStr = $"{_tempStr}{textBoxIng.Text}\n";
            labelAddIng.Text = _tempStr;
            textBoxIng.Clear();

        }

        private void AddRecipe_Click(object sender, EventArgs e)
        {
            Core core = new Core();
            core.AddNewRecipe(textBoxTitle.Text, lista);
            textBoxTitle.Clear();
            _tempStr = "";
            labelAddIng.Text = "Dodane składniki";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Core core = new Core();
            core.SafeToFile();
        }
    }
}
