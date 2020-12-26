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
     public partial class frmThongTinCapNhat : Form
     {
          public frmThongTinCapNhat(string temp)
          {
               temp1 = temp;
               InitializeComponent();
          }
          private DataTable table;
          private DataTable table1;
          private Connection connector = new Connection();
          public string temp1;
          private void frmThongTinCapNhat_Load(object sender, EventArgs e)
        {               
               table1 = new DataTable();
               table1 = connector.LoadData("OutPutTableByID", "14", temp1 );
               dataGridView1.DataSource = table1;
         }
    }
}
