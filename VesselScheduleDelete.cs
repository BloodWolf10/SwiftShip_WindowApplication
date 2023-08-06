﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftShip_WindowApplication
{
    public partial class VesselScheduleDelete : Form
    {
        public VesselScheduleDelete()
        {
            InitializeComponent();
        }

        DBAccess ObjDBAccess = new DBAccess();

        SqlConnection connection = new SqlConnection(DBAccess.strConnString);

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VesselScheduleDelete_Load(object sender, EventArgs e)
        {
            // Code to Populate DataGrid
            string query = "SELECT * FROM VesselSchedule;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            VesselDataGrid.DataSource = dataTable;
        }

        private void VesselDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = VesselDataGrid.Rows[e.RowIndex];
                txtBxVesselID.Text = row.Cells["VesselId"].Value.ToString();


                // Populate other TextBoxes with respective columns from the database table.
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string VesselId = txtBxVesselID.Text;
            int ItemId = int.Parse(VesselId);

            DialogResult dialogbox = MessageBox.Show("Are you sure you want to Delete this Item?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);

            if (dialogbox == DialogResult.OK)
            {
                string query = "Delete From VesselSchedule Where VesselId='" + ItemId + "'";

                SqlCommand deleteCommand = new SqlCommand(query);

                int row = ObjDBAccess.executeQuery(deleteCommand);

                if (row == 1)
                {
                    MessageBox.Show("Record Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Refresh the DataGridView to reflect the changes
                    VesselDataGrid.DataSource = null;
                    VesselScheduleDelete_Load(sender, e); // Reload the data

                }

                else
                {
                    MessageBox.Show("Record Failed to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();

            }

            else if (dialogbox == DialogResult.Cancel)
            {
                // Reload Page if they donot want to delete account
                VesselScheduleDelete_Load(sender, e);
            }

        }
    }
}
