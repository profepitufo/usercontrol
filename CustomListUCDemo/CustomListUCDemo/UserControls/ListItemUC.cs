using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomListUCDemo.UserControls
{
    public partial class ListItemUC : UserControl
    {
        public ListItemUC()
        {
            InitializeComponent();
        }

        // Definiion de las Propiedades del Control de Usuario.
        // Fields.
        private string titulo;
        private string message;
        private Image photo;
        // Properties.

        #region Propiedades
        [Category("Custom List Properties")]
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; NombreLabel.Text = value; }
        }
        [Category("Custom List Properties")]
        public string Message
        {
            get { return message; }
            set { message = value; InformacionLabel.Text = value; }
        }
        [Category("Custom List Properties")]
        public Image Photo
        {
            get { return photo; }
            set { photo = value; PhotoPictureBox.Image = value; }
        } 
        #endregion


    }
}
