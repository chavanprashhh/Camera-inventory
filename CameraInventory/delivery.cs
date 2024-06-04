using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CameraInventory
{
    public partial class delivery : Form
    {

        deliv del = new deliv();
        public delivery()
        {
            InitializeComponent();
        }

        private void delivery_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = del.getlist();
        }
    }
}
