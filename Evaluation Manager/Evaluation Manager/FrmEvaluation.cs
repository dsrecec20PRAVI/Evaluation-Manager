using Evaluation_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager
{
    public partial class FrmEvaluation : Form
    {
        public FrmEvaluation(Models.Student student)
        {
            InitializeComponent();
            Text = student.ToString();
        }

        private void FrmEvaluation_Load(object sender, EventArgs e)
        {
            var activities = ActivityRepository.GetActivities();
            cboActivities.DataSource = activities;
        }
    }
}
