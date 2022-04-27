using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace PerfectTablesTopperReturns
{
    public partial class Form1 : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddReturn_Click(object sender, EventArgs e)
        {
            string size = cmbSize.GetItemText(cmbSize.SelectedItem);
            string design = cmbDesign.GetItemText(cmbDesign.SelectedItem);
            string colour = cmbColour.GetItemText(cmbColour.SelectedItem);
            int number = (int)numNumber.Value;

            if (cmbSize.SelectedItem != null & cmbDesign.SelectedItem != null & cmbColour.SelectedItem != null)
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Returns(Size, Design, Colour, Number) values (@Size, @Design, @Colour, @Number)", con);
                cmd.Parameters.AddWithValue("@Size", size);
                cmd.Parameters.AddWithValue("@Design", design);
                cmd.Parameters.AddWithValue("@Colour", colour);
                cmd.Parameters.AddWithValue("@Number", number);
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (i > 0)
                {
                    MessageBox.Show("Added the following return\n\n" + size + "\n" + design + "\n" + colour + "\nNumber: " + number);
                }
                else
                {
                    MessageBox.Show("FAILED: Return not added");
                }
            }
            else
            {
                MessageBox.Show("Please ensure you have selected an option for the size, design, colour and number");
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "select * from Returns";
            using (var adapter = new SqlDataAdapter(query, con))
            {
                var table = new DataTable();
                adapter.Fill(table);
                dataFound.DataSource = table;
            }
            con.Close();
            int results = dataFound.Rows.Count - 1;
            txtResults.Text = results.ToString();
        }

        private void btnSearchSize_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "select * from Returns where Size='" + cmbColour.GetItemText(cmbSizeS.SelectedItem) + "'";
            using (var adapter = new SqlDataAdapter(query, con))
            {
                var table = new DataTable();
                adapter.Fill(table);
                dataFound.DataSource = table;
            }
            con.Close();
            int results = dataFound.Rows.Count - 1;
            txtResults.Text = results.ToString();
        }

        private void btnSearchDesign_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "select * from Returns where Design='" + cmbColour.GetItemText(cmbDesignS.SelectedItem) + "'";
            using (var adapter = new SqlDataAdapter(query, con))
            {
                var table = new DataTable();
                adapter.Fill(table);
                dataFound.DataSource = table;
            }
            con.Close();
            int results = dataFound.Rows.Count - 1;
            txtResults.Text = results.ToString();
        }

        private void btnSearchColour_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "select * from Returns where Colour='" + cmbColour.GetItemText(cmbColourS.SelectedItem) + "'";
            using (var adapter = new SqlDataAdapter(query, con))
            {
                var table = new DataTable();
                adapter.Fill(table);
                dataFound.DataSource = table;
            }
            con.Close();
            int results = dataFound.Rows.Count - 1;
            txtResults.Text = results.ToString();
        }

        private void btnSearchNumber_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "select * from Returns where Number='" + (int)numNumberS.Value + "'";
            using (var adapter = new SqlDataAdapter(query, con))
            {
                var table = new DataTable();
                adapter.Fill(table);
                dataFound.DataSource = table;
            }
            con.Close();
            int results = dataFound.Rows.Count - 1;
            txtResults.Text = results.ToString();
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this row?", "Deletion Prompt", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Returns where Id='" + dataFound.SelectedRows[0].Cells[0].Value.ToString() + "'", con);
                dataFound.Rows.RemoveAt(dataFound.SelectedRows[0].Index);
                cmd.ExecuteNonQuery();
                con.Close();
                int results = dataFound.Rows.Count - 1;
                txtResults.Text = results.ToString();
                MessageBox.Show("Row Deleted");
            }
            else
            {
                MessageBox.Show("Row not removed");
            }
        }
    }
}