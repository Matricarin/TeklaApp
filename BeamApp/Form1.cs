using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tekla.Structures;
using Tekla.Structures.Model;
using TSG = Tekla.Structures.Geometry3d;

namespace BeamApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BeamButton_Click(object sender, EventArgs e)
        {
            Model myModel = new Model();
            if (myModel.GetConnectionStatus())
            {
                TSG.Point startPoint = new TSG.Point(0, 0, 0);
                TSG.Point endPoint = new TSG.Point(0, 3000, 0);
                Beam myBeam = new Beam();
            }
        }
    }
}
