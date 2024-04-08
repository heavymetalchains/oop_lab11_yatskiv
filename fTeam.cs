using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_lab11_yatskiv
{
    public partial class fTeam : Form
    {
        public Team TheTeam;

        public fTeam(Team t)
        {
            TheTeam = t;

            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TheTeam.TeamName = tbTeamName.Text.Trim();
            TheTeam.Coach = tbCoach.Text.Trim();
            TheTeam.FoundedYear = int.Parse(tbFoundedYear.Text.Trim());
            TheTeam.TotalPlayers = int.Parse(tbTotalPlayers.Text.Trim());
            TheTeam.Budget = double.Parse(tbBudget.Text.Trim());
            TheTeam.Country = tbCountry.Text.Trim();
            TheTeam.HasStadium = chbHasStadium.Checked;
            TheTeam.WonWorldCup = chbWonWorldCup.Checked;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
