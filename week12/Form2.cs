using MySql.Data.MySqlClient;
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

namespace week12
{
    public partial class Form2 : Form
    {
        string connection = "server=localhost;uid=root;pwd=;database=premier_league";
        public MySqlConnection SqlConnection;
        MySqlCommand SqlCommand;
        MySqlDataAdapter SqlDataAdapter;
        DataTable dtplayer = new DataTable();
        DataTable dtplayer2 = new DataTable();
        DataTable dtplayer3 = new DataTable();
        DataTable dtplayer4 = new DataTable();
        string sqlQuery;
        MySqlDataReader SqlDataReader;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            SqlConnection = new MySqlConnection(connection);
            
            sqlQuery = "select team_name as 'team name',team_id as 'team id' from team;";
            SqlCommand = new MySqlCommand(sqlQuery, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(dtplayer2);
            combobox_chooseteam.DataSource = dtplayer2;
            combobox_chooseteam.DisplayMember = "team name";
            combobox_chooseteam.ValueMember = "team id";

            updatenotwork();
        }

        private void combobox_chooseteam_SelectionChangeCommitted(object sender, EventArgs e)
        {
            update();

        }

        private void update()
        {
            dtplayer.Clear();
            string comm = $"select manager_name,t.team_name,m.birthdate,n.nation from manager m,nationality n,team t where n.nationality_id = m.nationality_id and m.manager_id = t.manager_id and team_id = '{combobox_chooseteam.SelectedValue.ToString()}';";
            SqlCommand = new MySqlCommand(comm, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(dtplayer);
            dataGridView3.DataSource = dtplayer;
        }

        private void updatenotwork()
        {
            dtplayer4.Clear();
            string com = "select m.manager_name as 'name',n.nation as 'nationality',m.birthdate from manager m,nationality n where m.nationality_id = n.nationality_id and m.working = 0;";
            SqlCommand = new MySqlCommand(com, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(dtplayer4);
            dataGridView4.DataSource = dtplayer4;
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            update();
            DataTable dt1 = new DataTable();
            string namamanager = dataGridView3.SelectedCells[0].Value.ToString();
            string teamid = combobox_chooseteam.SelectedValue.ToString();
            string comm = $"select manager_id from manager where working = 0;";
            SqlCommand = new MySqlCommand(comm,SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(dt1);
            
            

            DataTable dt2 = new DataTable();
            sqlQuery = $"select manager_id from team where team_id = '{teamid}';";
            SqlCommand = new MySqlCommand(sqlQuery, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(dt2);

            string managerlama = dt2.Rows[0][0].ToString();
            string managerbaru = dt1.Rows[0][0].ToString();
            MessageBox.Show(managerlama,managerbaru);

            try
            {
                SqlConnection.Open();
                sqlQuery = $"update Team set manager_id = '{managerbaru}' where team_id = '{combobox_chooseteam.SelectedValue}';";
                SqlCommand = new MySqlCommand(sqlQuery,SqlConnection);
                SqlDataReader = SqlCommand.ExecuteReader();
                SqlConnection.Close();
                SqlConnection.Open();
                sqlQuery = $"update manager set working = 0 where manager_id = '{managerlama}';";
                SqlCommand = new MySqlCommand(sqlQuery,SqlConnection);
                SqlDataReader = SqlCommand.ExecuteReader();
                SqlConnection.Close();
                SqlConnection.Open();
                sqlQuery = $"update manager set working = 1 where manager_id = '{managerbaru}';";
                SqlCommand = new MySqlCommand(sqlQuery, SqlConnection);
                SqlDataReader = SqlCommand.ExecuteReader();
                SqlConnection.Close();
                SqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SqlConnection.Close();
                updatenotwork();
                update();
            }
        }
    }
}
