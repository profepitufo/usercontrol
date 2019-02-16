using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomListUCDemo.UserControls;
using CustomListUCDemo.Properties;

namespace CustomListUCDemo
{
    public partial class FormCustomListUC : Form
    {
        public FormCustomListUC()
        {
            InitializeComponent();
        }

        private void FormCustomListUC_Load(object sender, EventArgs e)
        {
            DisplayItems();
        }

        // Metodo que despliega los Controles.
        private void DisplayItems()
        {
            ListItemUC[] listItemUC = new ListItemUC[20];
            for (int i = 0; i < listItemUC.Length; i++)
            {
                listItemUC[i] = new ListItemUC();
                listItemUC[i].Titulo = "Header Title";
                listItemUC[i].Message = "Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus.";
                listItemUC[i].Photo = Resources.Fox;
                listItemUC[i].Width = FlowLayoutPanelList.Width - 50;

                if (FlowLayoutPanelList.Controls.Count < 0)
                {
                    FlowLayoutPanelList.Controls.Clear();
                }
                else
                {
                    FlowLayoutPanelList.Controls.Add(listItemUC[i]);
                }
            }

        }
    }
}
