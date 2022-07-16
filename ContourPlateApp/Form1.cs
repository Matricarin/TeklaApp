using System;
using System.Collections;
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
using Tekla.Structures.Model.UI;

namespace ContourPlateApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void CreateCP_Click(object sender, EventArgs e)
        {
            Model myModel = new Model();
            if (myModel.GetConnectionStatus())
            {
                Picker picker = new Picker();
                //Creating an array of points that the user enters
                ArrayList pickedPoints = picker.PickPoints(Picker.PickPointEnum.PICK_POLYGON, "Pick polygon points");

                //Creating an empty array of points for the contour plate
                ArrayList contourPoints = new ArrayList();
                //We pass through the array of entered points, converting them into contour points, filling in the array for contour points.
                foreach (TSG.Point point in pickedPoints)
                {
                    ContourPoint contourPoint = new ContourPoint(point, new Chamfer());
                    contourPoints.Add(contourPoint);
                }

                Tekla.Structures.Model.ContourPlate CP = new Tekla.Structures.Model.ContourPlate();
                CP.Contour.ContourPoints = contourPoints;
                CP.Profile.ProfileString = "PL" + ProfilePartName.Text;
                CP.Material.MaterialString = MaterialPartName.Text;
                CP.Class = ProfilePartName.Text;
                CP.Name = PartName.Text;

                CP.Insert();
                myModel.CommitChanges();
            }            
        }

        private void CreatePolyBeam_Click(object sender, EventArgs e)
        {
            Model myModel = new Model();
            if (myModel.GetConnectionStatus())
            {
                Picker picker = new Picker();
                //Creating an array of points that the user enters
                ArrayList pickedPoints = picker.PickPoints(Picker.PickPointEnum.PICK_POLYGON, "Pick polygon points");

                //Creating an empty array of points for the contour plate
                ArrayList contourPoints = new ArrayList();
                //We pass through the array of entered points, converting them into contour points, filling in the array for contour points.
                foreach (TSG.Point point in pickedPoints)
                {
                    ContourPoint contourPoint = new ContourPoint(point, new Chamfer());
                    contourPoints.Add(contourPoint);
                }

                Tekla.Structures.Model.PolyBeam PB = new Tekla.Structures.Model.PolyBeam();
                PB.Contour.ContourPoints = contourPoints;
                PB.Profile.ProfileString = "PL" + ProfilePartName2.Text;
                PB.Material.MaterialString = MaterialPartName2.Text;
                PB.Class = "15";
                PB.Name = PartName2.Text;

                PB.Insert();
                myModel.CommitChanges();
            }
        }
    }
}
