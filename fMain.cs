namespace oop_lab11_yatskiv
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            Team team = new Team();

            fTeam ft = new fTeam(team);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                tbTeamInfo.Text += string.Format("Назва команди: {0}, Тренер: {1}, Рік заснування: {2}. Всього гравців: {3}. Бюджет: {4:0.00}. Країна: {5}. Є власний стідон: {6}  Перемагали в WorldCup: {7} \r\n",
                    team.TeamName, team.Coach, team.FoundedYear, team.TotalPlayers, team.Budget, team.Country, team.HasStadium ? "Так" : "Ні",
                    team.WonWorldCup ? "Так" : "Hi");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?",
       "Припинити роботу", MessageBoxButtons.OKCancel,
        MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }
    }
}
