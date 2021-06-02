using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Materi03052021
{
    public partial class teamEditor : Form
    {
        private sqlFunction sqlFunc;
        private string idTeam;
        public teamEditor()
        {
            InitializeComponent();
        }

        private void teamEditor_Load(object sender, EventArgs e)
        {
            //Prepare SQL Functions
            string connString = "datasource=localhost;port=3306;username=root;password=;database=premier_league";
            string sqlQuery;
            sqlFunc = new sqlFunction(connString);            
        }        

        public void namateamTextbox_TextChanged(object sender, EventArgs e)
        {
            //Check if team name exist
            string sqlQuery = "SELECT team_id `ID` FROM team WHERE team_name = '"+ namateamTextbox.Text +"'";
            DataTable teamDt = sqlFunc.selectQuery(sqlQuery);


            if(teamDt.Rows.Count > 0)
            {
                idTeam = teamDt.Rows[0]["ID"].ToString();
                teamExist(idTeam);
            }
            else
            {
                teamDoesntExist();
                idTeam = "";
            }

        }
        private void teamExist(string idTeam)
        {
            string sqlQuery;

            //Get Stadium, City and Capacity
            sqlQuery = "SELECT home_stadium `Stadium`, capacity `Capacity`, city `City` FROM team t WHERE t.team_id = '"+ idTeam +"'";
            DataTable stadiumcountrycapacityDt = sqlFunc.selectQuery(sqlQuery);

            //Get Manager
            sqlQuery = "SELECT manager_name `Name` FROM manager m, team t WHERE t.manager_id = m.manager_id AND t.team_id = '" + idTeam + "'";
            DataTable managerDt = sqlFunc.selectQuery(sqlQuery);

            //Get Top Scorer of Team
            sqlQuery = "SELECT p.player_name `Nama Pemain`, SUM(IF(d.`type` = 'GO', 1, IF(d.`type` = 'GP',1,0))) `Score` FROM player p, dmatch d WHERE d.player_id = p.player_id AND p.team_id = '"+ idTeam +"' GROUP BY p.player_name ORDER BY `Score` DESC, `Nama Pemain` ASC LIMIT 1";
            DataTable topscorerDt = sqlFunc.selectQuery(sqlQuery);

            //Get DataGridView Datas
            sqlQuery = "SELECT p.player_name `Nama Pemain`, n.nation `Negara`, dp.height `Tinggi`, dp.weight `Berat` FROM player p, nationality n, team t, deskripsi_pemain dp WHERE p.player_id = dp.player_id AND dp.team_id = '" + idTeam + "' AND n.nationality_id = dp.nationality_id AND t.team_id = p.team_id";
            DataTable playersDescriptionDt = sqlFunc.selectQuery(sqlQuery);

            //Fill DataGridView
            playersDgv.DataSource = playersDescriptionDt;

            //Fill Stadium, City and Capacity
            string stadiumName = stadiumcountrycapacityDt.Rows[0]["Stadium"].ToString();
            string cityName = stadiumcountrycapacityDt.Rows[0]["City"].ToString();
            string capacityAmount = stadiumcountrycapacityDt.Rows[0]["Capacity"].ToString();

            string sccFormatString = String.Format("{0}, {1} ({2})", cityName, stadiumName, capacityAmount);
            stadiumLabel.Text = sccFormatString;

            //FIll Manager
            string managerName = managerDt.Rows[0]["Name"].ToString();
            managerLabel.Text = managerName;

            //Fill Top Scorer
            string topScorer = topscorerDt.Rows[0]["Nama Pemain"].ToString();
            topscorerLabel.Text = topScorer;

            string forTestingPurposes;

            
        }        

        private void teamDoesntExist()
        {
            //Empty Stadium, City and Capacity
            stadiumLabel.Text = "";

            //Empty Manager
            managerLabel.Text = "";

            //Empty Scorer
            topscorerLabel.Text = "";

            //Empty DGV
            playersDgv.DataSource = null;
        }
        private void cellClicked(object sender, DataGridViewCellEventArgs e)
        {
            string namaPlayer = playersDgv.Rows[e.RowIndex].Cells[0].Value.ToString();

            //Get ID by Name
            string sqlQuery = "SELECT player_id `ID` FROM player WHERE player_name = '"+ namaPlayer +"'";
            DataTable idPlayerDt = sqlFunc.selectQuery(sqlQuery);
            string idPlayer = idPlayerDt.Rows[0]["ID"].ToString();

            //Send ID and Show Second Form
            EditPlayerInfo epi = new EditPlayerInfo();
            epi.idPlayer = idPlayer;
            epi.teamEditor = this;

            epi.ShowDialog();

        }
    }
}
