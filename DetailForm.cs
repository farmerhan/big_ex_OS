using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Required namespaces
using System.Management;
using System.Dynamic;
using System.Diagnostics;

namespace ProcessesManangement
{
    public partial class DetailForm : Form
    {
        private Process[] _processes = Process.GetProcesses();
        private string id_form1;

        public DetailForm()
        {
            InitializeComponent();
        }

        //Tạo contructor mới để nhận tham số từ form 1
        public DetailForm(string id)
        {
            InitializeComponent();
            this.id_form1 = id;
        }

        //Events
        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void cmbProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        //Khi nhận id truyền đến thì form sẽ load lên
        private void DetailForm_Load(object sender, EventArgs e)
        {
            foreach (Process process in _processes)
            {
                if (process.Id.ToString() == id_form1)
                {
                    propertyGridGeneral.SelectedObject = process;
                    propertyGridStartInfo.SelectedObject = process.StartInfo;
                }
            }
        }
        
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
