using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NetStreamsDebugger {
    public partial class ManageFilters : Form {
        public ManageFilters(BindingSource aFilterBindingSource) {
            InitializeComponent();
            dgvwFilters.DataSource = aFilterBindingSource;
        }

        public BindingSource BoundItems {
            get { return filterBindingSource; }
        }

        private void RegexEdited(object sender, DataGridViewCellEventArgs e) {
            //dgvwFilters.Rows[e.RowIndex].ErrorText = "Invalid Regex!";
        }

        private void ValidateCellValue(object sender, DataGridViewCellValidatingEventArgs e) {
            switch(dgvwFilters.Columns[e.ColumnIndex].HeaderText) {
                case "Pattern":
                    ValidatePatternColumn(e);
                    break;
                default:
                    e.Cancel = false;
                    break;
            }
        }

        private void ValidateCheckboxColumns(DataGridViewCellEventArgs aE) {
            if(aE.RowIndex < 0 || aE.ColumnIndex < 0) return;
            //occurs before the value in the checkbox changed, so we have to do the work ourselves
            bool valueWillBe = !bool.Parse(dgvwFilters.Rows[aE.RowIndex].Cells[aE.ColumnIndex].Value.ToString());
            dgvwFilters.Rows[aE.RowIndex].Cells[aE.ColumnIndex].Value = valueWillBe;
            int excludeIndex = dgvwFilters.Columns.IndexOf(colExclude);
            int includeIndex = dgvwFilters.Columns.IndexOf(colInclude);
            if(dgvwFilters.Columns[aE.ColumnIndex] == colInclude) {
                if(valueWillBe) dgvwFilters.Rows[aE.RowIndex].Cells[excludeIndex].Value = false;
            } else if(dgvwFilters.Columns[aE.ColumnIndex] == colExclude)
                if(valueWillBe) dgvwFilters.Rows[aE.RowIndex].Cells[includeIndex].Value = false;
            dgvwFilters.EndEdit();
        }

        private void ValidatePatternColumn(DataGridViewCellValidatingEventArgs e) {
            if(!IsValidRegex(e.FormattedValue.ToString())) {
                dgvwFilters.Rows[e.RowIndex].ErrorText = "Invalid Regex!";
                e.Cancel = true;
            }
        }

        private static bool IsValidRegex(string aPotentialRegexPattern) {
            try {
                Regex test = new Regex(aPotentialRegexPattern);
                return true;
            } catch {
                return false;
            }
        }

        private void ValidateCellValue(object sender, DataGridViewCellEventArgs e) {
            switch(dgvwFilters.Columns[e.ColumnIndex].HeaderText) {
                case "Include":
                    ValidateCheckboxColumns(e);
                    break;
                case "Exclude":
                    ValidateCheckboxColumns(e);
                    break;
            }
        }

        private void regularExpressionsHelpToolStripMenuItem_Click(object sender, EventArgs e) {
            Process.Start("http://www.regexlib.com");
        }

        private void whatIsThisToolStripMenuItem_Click(object sender, EventArgs e) {
            pnlHelp.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            pnlHelp.Visible = false;
        }
    }
}