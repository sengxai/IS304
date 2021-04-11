using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayExerciseProject
{
    public partial class frmArrayExercise : Form
    {
        string[] strMeetingRooms;
        
        

        public frmArrayExercise()
        {
            InitializeComponent();
        }

        private void frmArrayExercise_Load(object sender, EventArgs e)
        {
            strMeetingRooms = new string[3];
            strMeetingRooms[0] = "Ho-Chunk";
            strMeetingRooms[1] = "Ojibwe";
            strMeetingRooms[2] = "Dakota";
            
        }

        private void btnGetRooms_Click(object sender, EventArgs e)
        {
            lblRooms.Text = strMeetingRooms[0];
            lblRooms.Text = lblRooms.Text + Environment.NewLine + strMeetingRooms[1];
            lblRooms.Text = lblRooms.Text + Environment.NewLine + strMeetingRooms[2];
        }
    }
}
