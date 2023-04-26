using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vue
{
    public partial class listExprditeur : Form
    {
        public listExprditeur()
        {
            InitializeComponent();
            gestlivraisonEntities1 ctx = new gestlivraisonEntities1();
            var req=from l in ctx.expediteur
                    select l;
            
            dataGridView1.DataSource = req.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
