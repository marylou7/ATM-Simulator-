﻿/**
 * ATM Simulator Team 6
 * Team members:
 * - Marylou das Chagas e Silva 2501402
 * - Lirit Dampier 2560877 
 * - Troy Tsang 2506759
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Simulator
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(0, 0); // set the location of the startform
        }

        private void btnDataRace_Click(object sender, EventArgs e)
        {
            StartATMThreads();


        }

        private void btnNoDataRace_Click(object sender, EventArgs e)
        {
            StartATMThreads();
        }



        private void StartATMThreads()
        {
            ATM atm1 = new ATM(); // instance of the first ATM form
            atm1.StartPosition = FormStartPosition.Manual;// set the location of the first instance
            atm1.Location = new System.Drawing.Point(0, 0); // set the position of the first for
           
            ATM atm2 = new ATM();  // instance of the second ATM form
            atm2.StartPosition = FormStartPosition.Manual;  // set the location of the second instance
            atm2.Location = new System.Drawing.Point(atm1.Width, 0); // set the position of the second form

            
            Thread atmThread1 = new Thread(() => ShowForm(atm1)); // start a new thread for the first ATM
            atmThread1.Start();
        
            Thread atmThread2 = new Thread(() => ShowForm(atm2));     // start a new thread for the second ATM
            atmThread2.Start();

            this.Hide();   // hide the current form - startform
        }

        private void ShowForm(ATM atm)
        {
            // Show the form
            atm.ShowDialog();
        }

    }
}
