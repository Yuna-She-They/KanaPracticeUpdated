using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanaPractice {

    /// <summary>
    /// Holds Events for Event Driven Form
    /// </summary>
    public partial class frmMain : Form {

        /// <summary>
        /// Constructor for class,
        /// this calls initComponents
        /// </summary>
        public frmMain() {
            InitializeComponent();
        }

        /// <summary>
        /// Exits The Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
