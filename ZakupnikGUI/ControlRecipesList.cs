using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZakupnikGUI
{
    public partial class ControlRecipesList : UserControl
    {
        private int mIndex = -1;
        private string _tempStr;


        public ControlRecipesList()
        {
            InitializeComponent();

        }

        private void ControlRecipesList_Load(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            mIndex++;
            if (mIndex < MainDict.Dict.Count)
            {

                labelTitle.Text = MainDict.DicList()[mIndex];
                foreach (var item in MainDict.Dict[MainDict.DicList()[mIndex]].Ingridiens)
                {
                    _tempStr = $"{_tempStr}{item}\n";
                }
                labelIngredients.Text = _tempStr;
                _tempStr = "";

            }
            else
            {
                mIndex = MainDict.Dict.Count - 1;
            }


        }

        private void buttonPre_Click(object sender, EventArgs e)
        {
            if (mIndex <= MainDict.Dict.Count && mIndex > 0)
            {
                mIndex--;
                labelTitle.Text = MainDict.DicList()[mIndex];
                foreach (var item in MainDict.Dict[MainDict.DicList()[mIndex]].Ingridiens)
                {
                    _tempStr = $"{_tempStr}{item}\n";
                }
                labelIngredients.Text = _tempStr;
                _tempStr = "";
            }
            else
            {
                mIndex = mIndex;
            }

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            Core core = new Core();
            core.DeleteRecipe(MainDict.DicList()[mIndex]);
            mIndex = -1;
            labelIngredients.Text = "Usunięto";
            labelTitle.Text = "Usunięto";
        }
    }
}
