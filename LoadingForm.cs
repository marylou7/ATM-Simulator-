using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Simulator
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            Loading();
            InitializeComponent();
            
        }

        private async void Loading()
        {
            this.SuspendLayout();

            // Label to display the processing message
            Label processingLabel = new Label();
            processingLabel.Text = "Processing Transaction";
            processingLabel.Dock = DockStyle.Top;
            processingLabel.TextAlign = ContentAlignment.MiddleCenter;

            // Label to display a message asking the user to wait
            Label waitLabel = new Label();
            waitLabel.Text = "Please wait while your transaction is being processed...";
            waitLabel.Dock = DockStyle.Fill;
            waitLabel.TextAlign = ContentAlignment.MiddleCenter;

            // Add controls to the form
            this.Controls.Add(waitLabel);
            this.Controls.Add(processingLabel);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(300, 150);
            this.ResumeLayout(false);

            
           
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
