using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace week12
{
    public partial class Form3 : Form
    {
        string connection = "server=localhost;uid=root;pwd=;database=premier_league";
        public MySqlConnection SqlConnection;
        MySqlCommand SqlCommand;
        MySqlDataAdapter SqlDataAdapter;
        DataTable dtplayer = new DataTable();
        DataTable dtplayer2 = new DataTable();
        string sqlQuery;
        MySqlDataReader SqlDataReader;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            SqlConnection = new MySqlConnection(connection);
            SqlConnection.Open();
            sqlQuery = "select team_name as 'team name',team_id as 'team id' from team;";
            SqlCommand = new MySqlCommand(sqlQuery, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(dtplayer2);
            combobox_chooseteam1.DataSource = dtplayer2;
            combobox_chooseteam1.DisplayMember = "team name";
            combobox_chooseteam1.ValueMember = "team id";

           
        }

        private void combobox_chooseteam1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {
            dtplayer.Clear();
            SqlConnection = new MySqlConnection(connection);
            SqlConnection.Open();
            sqlQuery = $"SELECT p.player_name as 'Name', n.nation , p.playing_pos ,p.height, p.weight , p.birthdate FROM player p, nationality n where p.nationality_id = n.nationality_id and team_id = '{combobox_chooseteam1.SelectedValue}' and p.status = 1;";
            SqlCommand = new MySqlCommand(sqlQuery, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(dtplayer);
            dataGridView2.DataSource = dtplayer;
            SqlConnection.Close();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string player = dataGridView2.SelectedCells[0].Value.ToString();
            MessageBox.Show(player);
            if(dataGridView2.Rows.Count <= 11)
            {
                MessageBox.Show("Pemain kurang dari 11");
            }
            else
            {
                string del = $"update player set `status` = 0 where player_name = '{player}'; ; ";
                try
                {
                    SqlConnection.Open();
                    SqlCommand = new MySqlCommand(del,SqlConnection);
                    SqlDataReader = SqlCommand.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    SqlConnection.Close();
                    update();
                }
            }
        }
    }
}
