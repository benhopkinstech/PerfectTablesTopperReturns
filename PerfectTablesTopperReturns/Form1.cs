using System.Data.SqlClient;

namespace PerfectTablesTopperReturns
{
    public partial class Form1 : Form
    {
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

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\benho\source\repos\PerfectTablesTopperReturns\PerfectTablesTopperReturns\db.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Returns(Size, Design, Colour, Number) values (@Size, @Design, @Colour, @Number)", con);
            cmd.Parameters.AddWithValue("@Size", size);
            cmd.Parameters.AddWithValue("@Design", design);
            cmd.Parameters.AddWithValue("@Colour", colour);
            cmd.Parameters.AddWithValue("@Number", number);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Added " + size + " " + design + " " + colour + " Number " + number);
            }
            else
            {
                MessageBox.Show("FAILED: Return not added");
            }
            con.Close();
        }
    }
}