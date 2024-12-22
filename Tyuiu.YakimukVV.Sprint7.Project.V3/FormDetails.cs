using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.YakimukVV.Sprint7.Project.V3
{
    public partial class FormDetails : Form
    {
        public FormDetails(string details)
        {
            InitializeComponent(); 
            labelDetails.Text = details;
        }
    }
}
