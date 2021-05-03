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
    public partial class EditPlayerInfo : Form
    {
        public string idPlayer;
        private string playerName, playerTeam, playerNation, playerHeight, playerWeight;
        private bool changedKeeper = false;
        private sqlFunction sqlFunc;
        public teamEditor teamEditor;
        public EditPlayerInfo()
        {
            InitializeComponent();
        }

        

        private void EditPlayerInfo_Load(object sender, EventArgs e)
        {
            string connString = "datasource=localhost;port=3306;username=root;password=;database=premier_league";
            string sqlQuery;
            sqlFunc = new sqlFunction(connString);

            //Get Name, Team, Country, Height, Weight
            sqlQuery = "SELECT p.player_name `Nama Pemain`, t.team_name `Nama Tim`, n.nation `Asal Negara`, dp.height `Tinggi`, dp.weight `Berat` FROM deskripsi_pemain dp, player p, team t, nationality n WHERE p.player_id = dp.player_id AND t.team_id = dp.team_id AND n.nationality_id = dp.nationality_id AND dp.player_id = '"+ idPlayer +"'";
            DataTable infoDt = sqlFunc.selectQuery(sqlQuery);
            playerName = infoDt.Rows[0]["Nama Pemain"].ToString();
            playerTeam = infoDt.Rows[0]["Nama Tim"].ToString();
            playerNation = infoDt.Rows[0]["Asal Negara"].ToString();
            playerHeight = infoDt.Rows[0]["Tinggi"].ToString();
            playerWeight = infoDt.Rows[0]["Berat"].ToString();

            //Fill with Data
            nameLabel.Text = playerName;
            teamLabel.Text = playerTeam;
            nationLabel.Text = playerNation;
            heightTextbox.Text = playerHeight;
            weightTextbox.Text = playerWeight;
        }

        private void heightTextbox_TextChanged(object sender, EventArgs e)
        {
            itemsChangedChecker();
        }

        private void weightTextbox_TextChanged(object sender, EventArgs e)
        {
            itemsChangedChecker();
        }
        private void ubahButton_Click(object sender, EventArgs e)
        {
            string sqlQuery = "UPDATE deskripsi_pemain SET height = "+ heightTextbox.Text +", weight = " + weightTextbox.Text +" WHERE player_id = '" + idPlayer +"'";
            sqlFunc.updateQuery(sqlQuery);
            MessageBox.Show("Data telah diupdate!");
            teamEditor.namateamTextbox_TextChanged(sender, e);
            this.Close();
        }

        private void itemsChangedChecker()
        {
            if(heightTextbox.Text != playerHeight || weightTextbox.Text != playerWeight)
            {
                ubahButton.Enabled = true;
                changedKeeper = true;
            }
            else
            {
                ubahButton.Enabled = false;
                changedKeeper = false;
            }
        }

    }
}
