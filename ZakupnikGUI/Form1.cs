namespace ZakupnikGUI
{
    public partial class Form1 : Form
    {
        UserControl[] userControls;
        public Form1()
        {
            InitializeComponent();
            userControls = new UserControl[]
            {
                controlAddRecipe1, controlShoppingCart1,controlRecipesList1, helloControl1
            };
            ShowControl(3);

        }

        void ShowControl (int c)
        {
            for (int i = 0; i < userControls.Length; i++)
            {
                userControls[i].Hide();
            }
            userControls[c].Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShoppingList_Click(object sender, EventArgs e)
        {
            ShowControl(1);
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
           ShowControl(0);
        }

        private void btnRecipesList_Click(object sender, EventArgs e)
        {
            ShowControl(2);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
