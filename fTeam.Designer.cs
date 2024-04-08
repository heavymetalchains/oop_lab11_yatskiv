
namespace oop_lab11_yatskiv
{
    partial class fTeam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            tbTeamName = new TextBox();
            tbCountry = new TextBox();
            tbBudget = new TextBox();
            tbTotalPlayers = new TextBox();
            tbCoach = new TextBox();
            tbFoundedYear = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            chbWonWorldCup = new CheckBox();
            chbHasStadium = new CheckBox();
            btnOk = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbTeamName);
            groupBox1.Controls.Add(tbCountry);
            groupBox1.Controls.Add(tbBudget);
            groupBox1.Controls.Add(tbTotalPlayers);
            groupBox1.Controls.Add(tbCoach);
            groupBox1.Controls.Add(tbFoundedYear);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(273, 295);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Основні дані";
            // 
            // tbTeamName
            // 
            tbTeamName.Location = new Point(134, 34);
            tbTeamName.Name = "tbTeamName";
            tbTeamName.Size = new Size(125, 27);
            tbTeamName.TabIndex = 2;
            // 
            // tbCountry
            // 
            tbCountry.Location = new Point(134, 255);
            tbCountry.Name = "tbCountry";
            tbCountry.Size = new Size(125, 27);
            tbCountry.TabIndex = 10;
            // 
            // tbBudget
            // 
            tbBudget.Location = new Point(134, 209);
            tbBudget.Name = "tbBudget";
            tbBudget.Size = new Size(125, 27);
            tbBudget.TabIndex = 9;
            // 
            // tbTotalPlayers
            // 
            tbTotalPlayers.Location = new Point(134, 167);
            tbTotalPlayers.Name = "tbTotalPlayers";
            tbTotalPlayers.Size = new Size(125, 27);
            tbTotalPlayers.TabIndex = 8;
            // 
            // tbCoach
            // 
            tbCoach.Location = new Point(134, 81);
            tbCoach.Name = "tbCoach";
            tbCoach.Size = new Size(125, 27);
            tbCoach.TabIndex = 6;
            // 
            // tbFoundedYear
            // 
            tbFoundedYear.Location = new Point(134, 121);
            tbFoundedYear.Name = "tbFoundedYear";
            tbFoundedYear.Size = new Size(125, 27);
            tbFoundedYear.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 255);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 5;
            label6.Text = "Країна";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 209);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 4;
            label5.Text = "Бюджет";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 167);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 3;
            label4.Text = "Всього гравців";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 121);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 2;
            label3.Text = "Рік заснування";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 81);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Тренер";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 0;
            label1.Text = "Назва команди";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chbWonWorldCup);
            groupBox2.Controls.Add(chbHasStadium);
            groupBox2.Location = new Point(12, 313);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Додаткові дані";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // chbWonWorldCup
            // 
            chbWonWorldCup.AutoSize = true;
            chbWonWorldCup.Location = new Point(18, 75);
            chbWonWorldCup.Name = "chbWonWorldCup";
            chbWonWorldCup.Size = new Size(199, 24);
            chbWonWorldCup.TabIndex = 1;
            chbWonWorldCup.Text = "Перемагали в WorldCup";
            chbWonWorldCup.UseVisualStyleBackColor = true;
            // 
            // chbHasStadium
            // 
            chbHasStadium.AutoSize = true;
            chbHasStadium.Location = new Point(18, 35);
            chbHasStadium.Name = "chbHasStadium";
            chbHasStadium.Size = new Size(127, 24);
            chbHasStadium.TabIndex = 0;
            chbHasStadium.Text = "Є свій стадіон";
            chbHasStadium.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(301, 267);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(103, 61);
            btnOk.TabIndex = 2;
            btnOk.Text = "Ок";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(301, 348);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(103, 61);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Закрити";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // fTeam
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(429, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "fTeam";
            Text = "Form1";
            Load += fTeam_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        private void fTeam_Load(object sender, EventArgs e)
        {
            if (TheTeam != null)
            {
                tbTeamName.Text = TheTeam.TeamName;
                tbCoach.Text = TheTeam.Coach;
                tbFoundedYear.Text = TheTeam.FoundedYear.ToString();
                tbTotalPlayers.Text = TheTeam.TotalPlayers.ToString();
                tbBudget.Text = TheTeam.Budget.ToString("0.00");
                if (TheTeam.Country != null) // Перевірка на null для об'єкту Country
                {
                    tbCountry.Text = TheTeam.Country.ToString();
                }
                else
                {
                    tbCountry.Text = ""; // Якщо Country має значення null, встановлюємо пустий рядок
                }
                chbHasStadium.Checked = TheTeam.HasStadium;
                chbWonWorldCup.Checked = TheTeam.WonWorldCup;
            }
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbTeamName;
        private TextBox tbCountry;
        private TextBox tbBudget;
        private TextBox tbTotalPlayers;
        private TextBox tbCoach;
        private TextBox tbFoundedYear;
        private CheckBox chbWonWorldCup;
        private CheckBox chbHasStadium;
        private Button btnOk;
        private Button btnCancel;
    }
}