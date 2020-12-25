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
          private int check;
          public frmDanhMucVTTTB()
          {
               InitializeComponent();
          }
          
          private void frmDanhMucVTTTB_Load(object sender, EventArgs e)
          {
               reset();
               Enable();
          }
          public void reset()
          {
               table = new DataTable();
               table = connector.LoadData("OutPutTable", "14", "");
               dataGridView1.DataSource = table;
          }
          public void Enable()
          {
               btnThem.Enabled = true;
               btnSua.Enabled = true;
               btnXoa.Enabled = true;
               btnLuu.Enabled = false;
               btnHuy.Enabled = false;
          }
          private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {
               string a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
               table1 = new DataTable();
               table1 = connector.LoadData("OutPutTable", "10", a);
               dataGridView2.DataSource = table1;
               tbMaTTB.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
               tbTenTTB.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
               tbLoai.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
               tbNgayNhap.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
               tbNgayXuat.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
          }

          private void btnHuy_Click(object sender, EventArgs e)
          {
               ResetValue();
               Enable();
          }
          public void ResetValue()
          {
               tbMaTTB.ResetText();
               tbTenTTB.ResetText();
               tbLoai.ResetText();
               tbTT.ResetText();
               tbNgayNhap.ResetText();
               tbNgayXuat.ResetText();

          }

          private void btnThem_Click(object sender, EventArgs e)
          {
               ResetValue();
               tbMaTTB.Enabled = false;
               btnThem.Enabled = false;
               btnSua.Enabled =  false;
               btnXoa.Enabled =  false;
               btnLuu.Enabled = true;
               btnHuy.Enabled = true;
               check = 0;
          }

          private void btnSua_Click(object sender, EventArgs e)
          {
               tbMaTTB.Enabled = false;
               btnThem.Enabled = false;
               btnSua.Enabled = false;
               btnXoa.Enabled = false;
               btnLuu.Enabled = true;
               btnHuy.Enabled = true;
               check = 1;
          }

          private void btnLuu_Click(object sender, EventArgs e)
          {

               if (tbNgayXuat.Text == "") tbNgayXuat.Text = null;
               if(check == 0)
               {
                    connector.InsertUpdateObject("AddObject","14","","",tbNgayNhap.Text,tbNgayXuat.Text, "",tbTenTTB.Text,tbLoai.Text,"","","");
                    reset();
                    ResetValue();
                    Enable();
               }

          }
         
     }
}
