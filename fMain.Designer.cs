namespace oop_lab11_yatskiv
{
    partial class fMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbTeamInfo = new TextBox();
            btnAddTeam = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // tbTeamInfo
            // 
            tbTeamInfo.Location = new Point(12, 12);
            tbTeamInfo.Multiline = true;
            tbTeamInfo.Name = "tbTeamInfo";
            tbTeamInfo.ReadOnly = true;
            tbTeamInfo.Size = new Size(640, 426);
            tbTeamInfo.TabIndex = 0;
            // 
            // btnAddTeam
            // 
            btnAddTeam.Location = new Point(682, 59);
            btnAddTeam.Name = "btnAddTeam";
            btnAddTeam.Size = new Size(94, 59);
            btnAddTeam.TabIndex = 1;
            btnAddTeam.Text = "Додати команду";
            btnAddTeam.UseVisualStyleBackColor = true;
            btnAddTeam.Click += btnAddTeam_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(682, 358);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 2;
            btnClose.Text = "Закрити";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnAddTeam);
            Controls.Add(tbTeamInfo);
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторна робота №11";
            Load += fMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbTeamInfo;
        private Button btnAddTeam;
        private Button btnClose;
    }
}
