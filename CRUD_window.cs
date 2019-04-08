using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyProduct
{
    public partial class CRUD_window : Form
    {
        public CRUD_window()
        {
            InitializeComponent();


        }

        private void CRUD_window_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productStoreDataSet.ProductTable' table. You can move, or remove it, as needed.
            this.productTableTableAdapter.FillBy(this.productStoreDataSet.ProductTable);

        }



        private void BTN_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.JPG; *.PNG; *.GIF)| *.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }



        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[3].Value;

            MemoryStream ms = new MemoryStream(img);



            pictureBox1.Image = Image.FromStream(ms);
            textID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textDescription.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();


        }

        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            string cmdIns = "INSERT into ProductTable (ID, FullName, Description, ProductImage) VALUES (@ID, @Name, @Description, @Image)";

            String connString = "Data Source=PN1841951;Initial Catalog=ProductStore;Integrated Security=True";



            using (SqlConnection myConnect = new SqlConnection(connString))
            {
                using (SqlCommand command = new SqlCommand(cmdIns))
                {

                    command.Connection = myConnect;
                    command.Parameters.AddWithValue("@ID", textID.Text);
                    command.Parameters.AddWithValue("@Name", textName.Text);
                    command.Parameters.AddWithValue("@Description", textDescription.Text);

                    MemoryStream ms1 = new MemoryStream();
                    pictureBox1.Image.Save(ms1, pictureBox1.Image.RawFormat);
                    byte[] myPhoto = ms1.ToArray();
                    command.Parameters.AddWithValue("@Image", myPhoto);
                    myConnect.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted");
                    this.productTableTableAdapter.FillBy(this.productStoreDataSet.ProductTable);

                }

            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            string cmdUpd = " UPDATE[dbo].[ProductTable] SET  ID = @ID, FullName = @Name, Description = @Description, ProductImage = @Image WHERE ID = @ID";

            String connString = "Data Source=PN1841951;Initial Catalog=ProductStore;Integrated Security=True";




            using (SqlConnection myConnect = new SqlConnection(connString))
            {
                using (SqlCommand command = new SqlCommand(cmdUpd))
                {

                    command.Connection = myConnect;
                    command.Parameters.AddWithValue("@ID", textID.Text);
                    command.Parameters.AddWithValue("@Name", textName.Text);
                    command.Parameters.AddWithValue("@Description", textDescription.Text);

                    MemoryStream ms1 = new MemoryStream();
                    pictureBox1.Image.Save(ms1, pictureBox1.Image.RawFormat);
                    byte[] myPhoto = ms1.ToArray();
                    command.Parameters.AddWithValue("@Image", myPhoto);
                    myConnect.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data Updated");
                    this.productTableTableAdapter.FillBy(this.productStoreDataSet.ProductTable);

                }



            }



        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string cmdUpd = "delete from [dbo].[ProductTable]  WHERE ID = @ID";

            String connString = "Data Source=PN1841951;Initial Catalog=ProductStore;Integrated Security=True";




            using (SqlConnection myConnect = new SqlConnection(connString))
            {
                using (SqlCommand command = new SqlCommand(cmdUpd))
                {

                    command.Connection = myConnect;
                    command.Parameters.AddWithValue("@ID", textID.Text);
                    command.Parameters.AddWithValue("@Name", textName.Text);
                    command.Parameters.AddWithValue("@Description", textDescription.Text);

                    MemoryStream ms1 = new MemoryStream();
                    pictureBox1.Image.Save(ms1, pictureBox1.Image.RawFormat);
                    byte[] myPhoto = ms1.ToArray();
                    command.Parameters.AddWithValue("@Image", myPhoto);
                    myConnect.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data Updated");
                    this.productTableTableAdapter.FillBy(this.productStoreDataSet.ProductTable);

                }

            }
        }
    }
}
