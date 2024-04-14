using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSK1
{
    public partial class Form2 : Form
    {
        public Form2(Form1 parent, List<char> results, List<int> timexresults, List<int> timeoresults, List<int> timelimits)
        {
            InitializeComponent();
            this.parent = parent;
            for (int i = 0; i < results.Count; i++)
            {
                this.table.Rows.Add(i.ToString(), results[i].ToString(), 
                    timexresults[i].ToString(), timeoresults[i].ToString(), timelimits[i].ToString());
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

    }
}
