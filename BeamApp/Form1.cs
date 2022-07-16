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
                //Enter coordinates 
                /*TSG.Point startPoint = new TSG.Point(0, 0, 0);
                TSG.Point endPoint = new TSG.Point(0, 3000, 0);*/

                //Enter coordinates. using interface 
                Tekla.Structures.Model.UI.Picker picker = new Tekla.Structures.Model.UI.Picker();
                TSG.Point startPoint = picker.PickPoint("Pick the start point");
                TSG.Point endPoint = picker.PickPoint("Pick the end point");
                Beam myBeam = new Beam(startPoint,endPoint);
                myBeam.Profile.ProfileString = "L100X16_8509_93";
                myBeam.Material.MaterialString = "C355-5";
                myBeam.Name = InsertBeamName.Text;
                myBeam.Insert();
                myModel.CommitChanges();
            }
        }

        private void InsertBeamName_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
