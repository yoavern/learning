using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Monopol
{
    public partial class FormMenu : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        public FormMenu(OleDbConnection dataConnection,bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void UsersClick(object sender, EventArgs e)
        {
            if (isManager)
            {
                this.Hide();
                FormTblUsers frUsers = new FormTblUsers();
                frUsers.Show();
                frUsers.Disposed += new EventHandler(frUsers_Disposed);
            }
            else
            {
                MessageBox.Show("access denied, you don't have the right privileges",

            "Please fix", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
        void frUsers_Disposed(object sender, EventArgs e)
        {
            this.Show(); 
            this.Activate();
        }

        private void CitiesClick(object sender, EventArgs e)
        {
            this.Hide();
            FormTblCities frCities = new FormTblCities(isManager);
            frCities.Show();
            frCities.Disposed += new EventHandler(frCities_Disposed);
        }
        void frCities_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();

        }

        private void BoardsClick(object sender, EventArgs e)
        {
            this.Hide();
            FormTblBoards frBoards = new FormTblBoards(isManager);
            frBoards.Show();
            frBoards.Disposed += new EventHandler(frBoards_Disposed);
        }
        void frBoards_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();

        }

        private void ObjectTypesClick(object sender, EventArgs e)
        {
            this.Hide();
            FormTblObjectTypes frObjectTypes = new FormTblObjectTypes(isManager);
            frObjectTypes.Show();
            frObjectTypes.Disposed += new EventHandler(frObjectTypes_Disposed);
        }
        void frObjectTypes_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();

        }

        private void ObjectsInBoardClick(object sender, EventArgs e)
        {
            this.Hide();
            FormTblObjectsInBoard frObjectsInBoard = new FormTblObjectsInBoard(isManager);
            frObjectsInBoard.Show();
            frObjectsInBoard.Disposed += new EventHandler(frObjectsInBoard_Disposed);
        }
        void frObjectsInBoard_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();

        }

        private void GamesClick(object sender, EventArgs e)
        {
            this.Hide();
            FormTblGames frGames = new FormTblGames(isManager);
            frGames.Show();
            frGames.Disposed += new EventHandler(frGames_Disposed);
        }
        void frGames_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();

        }

        private void ActionsClick(object sender, EventArgs e)
        {
            this.Hide();
            FormTblActions frActions = new FormTblActions(isManager);
            frActions.Show();
            frActions.Disposed += new EventHandler(frActions_Disposed);
        }
        void frActions_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();

        }

        private void StepsClick(object sender, EventArgs e)
        {
            this.Hide();
            FormTblSteps frSteps = new FormTblSteps(isManager);
            frSteps.Show();
            frSteps.Disposed += new EventHandler(frSteps_Disposed);
        }
        void frSteps_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();

        }

        private void addUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddUser frm = new FormAddUser(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(FrAddUser_Disposed);
        }
        void FrAddUser_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void addCity_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddCities frm = new FormAddCities(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(FrAddCities_Disposed);
        }
        void FrAddCities_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void addBoards_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddBoards frm = new FormAddBoards(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(FrAddBoards_Disposed);
        }
        void FrAddBoards_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void addObjectTypes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddObjectTypes frm = new FormAddObjectTypes(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(FrAddObjectTypes_Disposed);
        }
        void FrAddObjectTypes_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void addObjectsInBoard_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddObjectsInBoard frm = new FormAddObjectsInBoard(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(FrAddObjectsInBoard_Disposed);
        }
        void FrAddObjectsInBoard_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void addGames_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddGames frm = new FormAddGames(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(FrAddGames_Disposed);
        }
        void FrAddGames_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void addActions_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddActions frm = new FormAddActions(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(FrAddActions_Disposed);
        }
        void FrAddActions_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void addSteps_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddSteps frm = new FormAddSteps(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(FrAddSteps_Disposed);
        }
        void FrAddSteps_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void updateUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateUsers frm = new FormUpdateUsers(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(FrUpdateUsers_Disposed);
        }
        void FrUpdateUsers_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }


        private void updateBoards_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateBoards frm = new FormUpdateBoards(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(FrUpdateBoards_Disposed);
        }
        void FrUpdateBoards_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void updateObjectTypes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateObjectTypes frm = new FormUpdateObjectTypes(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(FrUpdateObjectTypes_Disposed);
        }
        void FrUpdateObjectTypes_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void updateObjectsInBoard_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateObjectsInBoard frm = new FormUpdateObjectsInBoard(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(FrUpdateObjectsInBoard_Disposed);
        }

        void FrUpdateObjectsInBoard_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void updateGames_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateGames frm = new FormUpdateGames(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(FrUpdateGames_Disposed);
        }

        void FrUpdateGames_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void updateActions_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateActions frm = new FormUpdateActions(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(FrUpdateActions_Disposed);
        }

        void FrUpdateActions_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void updateSteps_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateSteps frm = new FormUpdateSteps(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(FrUpdateSteps_Disposed);
        }

        void FrUpdateSteps_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void monopolGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormControlPlayMonopol frm = new FormControlPlayMonopol(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(FrPlayMonopol_Disposed);
        }
        void FrPlayMonopol_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void RptGamesByPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRptGamesByPlayer frm = new FormRptGamesByPlayer(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(FrRptGamesByPlayer_Disposed);
        }
        void FrRptGamesByPlayer_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }
        private void FormRptStepsByGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRptStepsByGame frm = new FormRptStepsByGame(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(FrRptStepsByGame_Disposed);
        }
        void FrRptStepsByGame_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void FormChartGamesByPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChartGamesByPlayer frm = new FormChartGamesByPlayer(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(FrChartGamesByPlayer_Disposed);
        }
        void FrChartGamesByPlayer_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void FormChartStepsByGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChartStepsByGame frm = new FormChartStepsByGame(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(FrChartStepsByGame_Disposed);
        }
        void FrChartStepsByGame_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        


    }
}
