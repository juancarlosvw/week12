using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace week12
{
    public partial class Form1 : Form
    {
        string connection = "server=localhost;uid=root;pwd=;database=premier_league";
        public MySqlConnection SqlConnection;
        MySqlCommand SqlCommand;
        MySqlDataAdapter SqlDataAdapter;
        DataTable dtplayer = new DataTable();
        DataTable dtplayer2 = new DataTable();
        string sqlQuery;
        MySqlDataReader SqlDataReader;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection = new MySqlConnection(connection);
            SqlConnection.Open();
            sqlQuery = "select nationality_id as 'nation id',nation as 'nation' from nationality;";
            SqlCommand = new MySqlCommand(sqlQuery,SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(dtplayer);
            combobox_nation.DataSource = dtplayer;
            combobox_nation.DisplayMember = "nation";
            combobox_nation.ValueMember = "nation id";

            SqlConnection = new MySqlConnection(connection);
            SqlConnection.Open();
            sqlQuery = "select team_name as 'team name',team_id as 'team id' from team;";
            SqlCommand = new MySqlCommand(sqlQuery, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(dtplayer2);
            combobox_teamname.DataSource = dtplayer2;
            combobox_teamname.DisplayMember = "team name";
            combobox_teamname.ValueMember = "team id";
            Form2 second = new Form2();
            Form3 third = new Form3();
            third.Show();
            second.Show();
        }

        private void button_addplayer_Click(object sender, EventArgs e)
        {
            string dtp = dateTimePicker1.Value.ToString("yyyy-MM-dd",CultureInfo.InvariantCulture);
            string namaplayer = txtbox_name.Text;
            int nomerteam = Convert.ToInt32(txtbox_teamnumber.Text);
            string pos = txtbox_pos.Text;
            int height = Convert.ToInt32(txtbox_height.Text);
            int weight = Convert.ToInt32(txtbox_weight.Text);
            string nation = combobox_nation.Text;
            string teamname = combobox_teamname.SelectedValue.ToString();
            string id = txtbox_id.Text;
            string apa = $"insert into player value ('{id}',{nomerteam},'{namaplayer}','{nation}','{pos}',{height},{weight},'{dtp}','{teamname}',1,0);";
            SqlCommand = new MySqlCommand(apa, SqlConnection);
            SqlDataReader = SqlCommand.ExecuteReader();
        }
    }
}
