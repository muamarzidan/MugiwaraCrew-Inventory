using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inventory_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=mugiwaracrew";//actually this is sercet
            string query = "SELECT * FROM tabel_mugiwara";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt; 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=mugiwaracrew";//actually this code is secret
            string query = "INSERT INTO tabel_mugiwara(Firstname,Lastname,Weapon,Gender,Position)VALUES('" + this.Firstname.Text + "','" + this.Lastname.Text + "','" + this.Weapon.Text + "','" + this.Gender.Text + "','" + this.Position.Text + "')";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Succesfully saved");
            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=mugiwaracrew";//actually this code is secret
            string query = "SELECT * FROM tabel_mugiwara";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void MI_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=mugiwaracrew";//actually this code is secret
            string query = "UPDATE tabel_mugiwara SET Firstname='" + this.Firstname.Text + "',Lastname='" + this.Lastname.Text + "',Weapon='" + this.Weapon.Text + "',Gender='" + this.Gender.Text + "',Position='" + this.Position.Text + "' WHERE IDCrew='" + this.IDCrew.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Data has been succesfully deleted!");
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=mugiwaracrew";//actually this code is secret
            string query = "DELETE FROM tabel_mugiwara WHERE IDcrew='"+ this.IDCrew.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Record has been update succesfully");
            conn.Close();

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=mugiwaracrew";//actually this code is secret
            MySqlConnection con = new MySqlConnection(connection);
            MySqlDataAdapter da;
            DataTable dt;
            con.Open();
            da = new MySqlDataAdapter("SELECT * FROM tabel_mugiwara WHERE Firstname LIKE'" + this.textBox1.Text + "%' OR Lastname LIKE'" + this.textBox1.Text + "%'", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
    }

        private void Lastname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
