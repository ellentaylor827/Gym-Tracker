using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymTracker
{
    public partial class mainMenu : UserControl
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Link to the github issues page
        /// </summary>
        private void reportIssueButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("This button takes to directly to the github page, do you wish to directly open the link?","Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                System.Diagnostics.Process.Start("https://github.com/ellentaylor827/Gym-Tracker/issues");
            }
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the changed cell is in the "Color" column
            if (e.ColumnIndex == dataGridView1.Columns["Category"].Index && e.RowIndex >= 0 )
            {
                DataGridViewCell changedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                Color color = updateExerciseSelection(changedCell.Value.ToString());
            }
        }

        public Color updateExerciseSelection(string category)
        {
            switch(category)
            {
                case "Arms":
                    Color cellColor = Color.FromName(category);
                    return cellColor;
            }
            return Color.FromName(category);
        }
    }
}
