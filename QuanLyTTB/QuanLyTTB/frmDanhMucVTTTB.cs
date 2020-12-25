using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTTB
{
     public partial class frmDanhMucVTTTB : Form
     {
          private DataTable table;
          private DataTable table1;
          private Connection connector = new Connection();
          public frmDanhMucVTTTB()
          {
               InitializeComponent();
          }
          
          private void frmDanhMucVTTTB_Load(object sender, EventArgs e)
          {
               table = new DataTable();
               table = connector.LoadData( "OutPutTable","14","");
               dataGridView1.DataSource = table;
          }

          private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {
               string a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
               table1 = new DataTable();
               table1 = connector.LoadData("OutPutTable", "10", a);
               dataGridView2.DataSource = table1;
          }
     }
}
