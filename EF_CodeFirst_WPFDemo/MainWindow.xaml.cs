using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EF_CodeFirst_WPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //DonorContext dcon = new DonorContext("server = .\\SqlExpress;Integrated Security = true;Database = PUBS");
            //Donor d = new Donor();
            //d.DonorID = 101;
            //d.Name = " Manik";
            //d.BloodGrp = "B+";
            //d.City = "Mumbai";


            PatientContext pCon = new PatientContext("server = .\\SqlExpress;Integrated Security = true;Database = PUBS");
            Patient pObj = new Patient();

            pObj.PatientNo = 201;
            pObj.PatientName = "kamal";
            pObj.PatientCity = "Bangalore";
            //Adding Data to table
            pCon.Patients.Add(pObj);

            //saving Changes
            pCon.SaveChanges();

            System.Windows.Forms.MessageBox.Show("Patient table Created\n1 row added");

        }
    }
}
