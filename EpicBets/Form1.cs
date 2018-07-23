using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpicBets
{
    public partial class PatallaLogin : Form
    {
        public PatallaLogin()
        {
            InitializeComponent();
        }

        //Cuando carga la ventana...
        private void PatallaLogin_Load(object sender, EventArgs e)
        {
            //Cambiar resolucion ventana
            this.Size = new Size(300, 450);
            this.FormBorderStyle = FormBorderStyle.None;
            this.CenterToScreen();
        }
    }
}
