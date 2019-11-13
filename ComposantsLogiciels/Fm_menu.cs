using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComposantsLogiciels
{
    public partial class Fm_menu : Form
    {
        private Modele bd; //ajout de la variable bd avec le Type Modele
        public Fm_menu()
        {
            InitializeComponent();
            bd = new Modele(); //instanciation du modele

        }
    }
}
