using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneHareketEttirme
{
    public partial class frmNesne : Form
    {
        public frmNesne()
        {
            InitializeComponent();
        }

        private void frmNesne_Load(object sender, EventArgs e)
        {

        }

        private void frmNesne_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pictureNesne.Location.X;
            int y = pictureNesne.Location.Y;

            if (e.KeyCode==Keys.Right && x<=680)
            {
                x = x + 5;
            }
            if (e.KeyCode==Keys.Left && x>=1)
            {
                x = x - 5;
            }
            if (e.KeyCode==Keys.Down && y<=340)
            {
                y = y + 5;
            }
            if (e.KeyCode==Keys.Up && y>=1)
            {
                y = y - 5;
            }
            pictureNesne.Location = new Point(x,y);
        }
    }
}
