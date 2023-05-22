using DBLayer;
using Evaluation_Manager.Repositories;
using EvaluationManagerV2.Models;
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
    public partial class FrmFinalReport : Form
    {
        public FrmFinalReport()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmFinalReport_Load(object sender, EventArgs e)
        {
            var results = GenerateStudentReport();
            dgvRezultati.DataSource = results;
        }

        private List<StudentReportView> GenerateStudentReport()
        {
            var allStudents = StudentRepository.GetStudents();
            var examReports = new List<StudentReportView>();

            foreach (var student in allStudents)
            {
                if (student.HasSignature() == true)
                {
                    var examReport = new StudentReportView(student);
                    examReports.Add(examReport);
                }
            }

            return examReports;
        }
    }
}
