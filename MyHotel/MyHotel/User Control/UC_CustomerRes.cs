using MyHotel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5
{
    public partial class UC_CustomerRes : UserControl
    {
        function fn = new function();
        string query;
        public UC_CustomerRes()
        {
            InitializeComponent();
        }
        public void setComboBox(string query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for(int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }
        
        private void txtRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomNo.Items.Clear();
            query = "select roomNo from rooms where bed = '" + txtBed.Text + "' and roomType = '" + txtRoomType.Text + "' and booked = 'NO'";
            setComboBox(query, txtRoomNo);
        }
        int rid;
        private void txtRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select price, roomid from rooms where roomNo = '" + txtRoomNo.Text + "'";
            DataSet ds = fn.GetData(query);
            txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());
        }

        private void btnAllotCustomer_Click(object sender, EventArgs e)
        {
            if(txtName.Text !="" && txtPhoneNo.Text !="" && txtNationality.Text!="" && txtGender.Text != "" && txtDob.Text != "" && txtIDProof.Text != "" && txtAddress.Text != "" && txtCheckin.Text != "" && txtPrice.Text != "")
            {
                string name = txtName.Text;
                Int64 mobile = Int64.Parse(txtPhoneNo.Text);
                string national = txtNationality.Text;
                string gender = txtGender.Text;
                string dob = txtDob.Text;
                string idproof = txtIDProof.Text;
                string address = txtAddress.Text;
                string checkin = txtCheckin.Text;
                query = "insert into customer (cname,mobile, nationality, gender, dob, idproof, address, checkin, roomid) values ('" + name + "'," + mobile + ",'" + national + "','" + gender + "','" + dob + "','" + idproof + "','" + address + "','" + checkin + "'," + rid + ") update rooms set booked ='YES' where roomNo = '" + txtRoomNo.Text + "'";
                fn.setData(query, "Room Number" +txtRoomNo.Text + "Room check in successfully!");
                clearAll();
            }
            else
            {
                MessageBox.Show("Please don't empty!");
            }
        }
        public void clearAll()
        {
            txtName.Clear();
            txtPhoneNo.Clear();
            txtNationality.Clear();
            txtGender.SelectedIndex = -1;
            txtDob.ResetText();
            txtIDProof.Clear();
            txtAddress.Clear();
            txtCheckin.ResetText();
            txtBed.SelectedIndex = -1;
            txtRoomType.SelectedIndex = -1;
            txtRoomNo.Items.Clear();
            txtPrice.Clear();

        }

        private void txtBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomType.SelectedIndex = -1;
            txtRoomNo.Items.Clear();
            txtPrice.Clear();

        }

        private void UC_CustomerRes_Enter(object sender, EventArgs e)
        {

        }

        private void UC_CustomerRes_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_CustomerRes_Load(object sender, EventArgs e)
        {

        }
    }
}
