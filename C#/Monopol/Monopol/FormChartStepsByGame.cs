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
    public partial class FormChartStepsByGame : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        private int counter;
        private int[] arrGameIDS;
        private int[] arrGameMoves;
        public FormChartStepsByGame(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            CountGames();
            arrGameIDS = new int[counter];
            arrGameMoves = new int[counter];
            FillArrGameIDS();
            FillArrGameMoves();
            ShowChart();
            EditDataGridView(); 
        }




         private void CountGames()
         {
             try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   COUNT(gameID) " +
                                          "FROM     tblGames  ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                counter = dataReader.GetInt32(0);
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Count tblGames failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }

         private void FillArrGameIDS()
         {
             try
             {
                 int k = 0;
                 OleDbCommand datacommand = new OleDbCommand();
                 datacommand.Connection = dataConnection;
                 datacommand.CommandText = "SELECT   gameID " +
                                           "FROM     tblGames  " +
                                           "ORDER BY gameID";
                 OleDbDataReader dataReader = datacommand.ExecuteReader();
                 while (dataReader.Read())
                 {
                     arrGameIDS[k] = dataReader.GetInt32(0);
                     k++;
                 }
                 dataReader.Close();
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Select tblGames failed " +
                                  ex.Message, "Errors",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }

         private void FillArrGameMoves()
         {
             for (int idx = 0; idx < arrGameIDS.Length; idx++)
                 CountGames(idx);
         }

         private void CountGames(int idx)
         {
             try
             {
                 OleDbCommand datacommand = new OleDbCommand();
                 datacommand.Connection = dataConnection;
                 datacommand.CommandText = "SELECT  gameMoves " +
                                           "FROM    tblGames  " +
                                           "WHERE   gameID = " + arrGameIDS[idx];
                 OleDbDataReader dataReader = datacommand.ExecuteReader();
                 dataReader.Read();
                 arrGameMoves[idx] = dataReader.GetInt32(0);
                 dataReader.Close();
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Select tblGames failed " +
                                  ex.Message, "Errors",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }

         private void ShowChart()
         {
             try
             {
                 chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
                 chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;

                 chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoom(1, 8);
                 chart1.ChartAreas["ChartArea1"].CursorX.IsUserSelectionEnabled = true;
                 chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoomable = true;
                 chart1.ChartAreas["ChartArea1"].AxisX.ScrollBar.IsPositionedInside = true;
                 chart1.ChartAreas["ChartArea1"].AxisY.ScrollBar.IsPositionedInside = true;

                 for (int i = 0; i < arrGameIDS.Length; i++)
                 {
                     chart1.Series["מהלכים"].Points.AddXY(arrGameIDS[i], arrGameMoves[i]);
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Show chart failed " +
                                  ex.Message, "Errors",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }


         private void EditDataGridView()
         {
             try
             {
                 for (int i = 0; i < arrGameIDS.Length; i++)
                 {
                     DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                     row.Cells[0].Value = arrGameIDS[i];
                     row.Cells[1].Value = arrGameMoves[i].ToString();
                     dataGridView1.Rows.Add(row);
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Edit dataGridView item failed " + ex.Message, "Errors",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }
    }
}
