/**
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

    public partial class ATM : Form
    {
        private Account activeAccount; //local referance to the array of accounts
        private Account[] ac; //this is a referance to the account that is being used
        private bool dataRace;

        public ATM(Account[] ac, bool dr)
        {
            InitializeComponent();

            // set the TextBox to be read-only to disable keyboard input for both account and pin
            txtBoxAccountNo.ReadOnly = true;
            txtBoxPin.ReadOnly = true;
            this.dataRace = dr; // true if data race, false if no data race
            this.ac = ac;

        }

        private void ATM_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxAccountNo_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxAccountNo.Text.Length > 6) //check if the account number is at the limit
            {
                txtBoxAccountNo.Text = txtBoxAccountNo.Text.Substring(0, 6);  // if the length is greater than 6 digits, truncate the text to 6 digits
                txtBoxAccountNo.SelectionStart = txtBoxAccountNo.Text.Length;  // set the cursor position to the end of the text
            }
        }

        private void txtBoxPin_TextChanged(object sender, EventArgs e)
        {
            TextBox pinTextBox = sender as TextBox;
            if (pinTextBox.Text.Length > 4) //check if the pin is at the limit
            {
                // if the length is greater than 4 digits, truncate the text to 4 digits
                pinTextBox.Text = pinTextBox.Text.Substring(0, 4);
                // set the cursor position to the end of the text
                pinTextBox.SelectionStart = pinTextBox.Text.Length;
            }
        }


        private void numberButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                if (txtBoxAccountNo.Visible) // check if the account number TextBox is visible
                {
                    txtBoxAccountNo.Text += button.Text;
                }
                else if (txtBoxPin.Visible) // check if the PIN TextBox is visible
                {
                    txtBoxPin.Text += button.Text;
                }
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtBoxAccountNo.Visible || txtBoxPin.Visible)
            {
                restartLoginProcess();
            }
            else
            {
                displayWelcomePage(true);
                displayWithdrawCash(false);
                displayDepositCash(false);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (txtBoxAccountNo.Visible == true)
            {
                txtBoxAccountNo.Text = ""; // clear the text in the textbox
            }
            else if (txtBoxPin.Visible == true)
            {
                txtBoxPin.Text = ""; // clear the text in the pin textbox
            }
        }


        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtBoxPin.Visible || txtBoxAccountNo.Visible)
            {
                if (txtBoxPin.Visible)
                {
                    validatePIN();
                }
                else
                {
                    validateAccountNumber();
                }
            }
        }


        private void validateAccountNumber()
        {
            if (txtBoxAccountNo.Text.Length < 6) // check if the account number is less than 6 digits
            {
                MessageBox.Show("Please enter a valid 6-digit account number.");
                txtBoxAccountNo.Text = "";
                return;
            }

            // check that this is account exists
            int accountNumber = int.Parse(txtBoxAccountNo.Text); // get the entered account number from the TextBox
            bool accountFound = false;
            foreach (Account acc in ac)
            {
                acc.resetAttempts();
                accountFound = true;
                lblText.Text = "Please enter PIN:"; // change the text of lblAccountNo to "Please enter PIN"
                txtBoxPin.Visible = true;
                txtBoxAccountNo.Visible = false; // hide the account number TextBox

            }

            if (accountFound == false)
            {
                // entered account number is not found
                MessageBox.Show("An account with this number doesn't exist. ");
                txtBoxAccountNo.Clear();
            }
        }

        private void validatePIN()
        {
            int pinEntered;
            if (!int.TryParse(txtBoxPin.Text, out pinEntered)) // Get the entered PIN from the TextBox
            {
                MessageBox.Show("Please enter a 4-digit PIN.");
                return;
            }

            int accountNumber = int.Parse(txtBoxAccountNo.Text); // get the entered account number from the TextBox

            bool accountFound = false;
            activeAccount = null;

            foreach (Account acc in ac)
            {
                if (acc.getAccountNum() == accountNumber) // check if the account number matches
                {
                    accountFound = true;
                    if (acc.checkPin(pinEntered)) // check if the PIN is correct for the found account
                    {
                        txtBoxPin.Visible = false; // hide the PIN TextBox
                        lblText.Text = "";
                        activeAccount = acc;  // set the current user account
                        displayWelcomePage(true);
                        MessageBox.Show("PIN is correct. Proceed to main menu.");
                    }
                    else
                    {
                        MessageBox.Show("Incorrect PIN. Please try again");
                        if (acc.getAttempts() != 0)
                        {
                            // if this account still has attempts left
                            txtBoxPin.Clear();
                            int numAttempts = acc.getAttempts();
                            int newAttempts;
                            newAttempts = numAttempts - 1;
                            acc.decreaseAttempts(newAttempts);
                            return;
                        }
                        else
                        {
                            // too many wrong attempts made, don't let this user continue guessing the pin.
                            MessageBox.Show("Too many wrong PIN attempts, please try again later");
                            restartLoginProcess();
                        }
                    }
                }
            }

            // if the loop finishes without finding a matching account number then display an error message
            if (!accountFound)
            {
                MessageBox.Show("Error");
                restartLoginProcess();
            }
        }



        private void restartLoginProcess()
        {
            // make the account number TextBox visible again
            txtBoxAccountNo.Text = "";
            txtBoxAccountNo.Visible = true;
            txtBoxPin.Text = "";
            txtBoxPin.Visible = false;
            lblWelcome.Visible = false;
            btnWithdraw.Visible = false;
            btnDepositCash.Visible = false;
            btnCheckBalance.Visible = false;
            btnReturnCard.Visible = false;
            lblText.Text = "Enter Account Number";
        }

        //helper function for the different pages
        private void setControlsVisibility(bool visible, params Control[] controls)
        {
            foreach (Control control in controls)
            {
                control.Visible = visible;
            }
        }

        private void displayWelcomePage(bool visible)
        {
            setControlsVisibility(visible, lblWelcome, btnWithdraw, btnCheckBalance, btnReturnCard, btnDepositCash);
        }

        private void displayWithdrawCash(bool visible)
        {
            setControlsVisibility(visible, lblWithdraw, btn10, btn20, btn40, btn100, btn500, btnOther);
        }

        private void displayDepositCash(bool visible)
        {
            setControlsVisibility(visible, lblDeposit, btnd10, btnd20, btnd40, btnd100, btnd500, btndOther);
        }


        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            displayWelcomePage(false);
            displayWithdrawCash(true);
        }

        private void BtnDeposit_Click(object sender, EventArgs e)
        {
            displayWelcomePage(false);
            displayDepositCash(true);
        }

        private void DepositCash_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {

                int amount = 0;
                switch (button.Name)
                {
                    case "btnd10":
                        amount = 10;
                        break;
                    case "btnd20":
                        amount = 20;
                        break;
                    case "btnd40":
                        amount = 40;
                        break;
                    case "btnd100":
                        amount = 100;
                        break;
                    case "btnd500":
                        amount = 500;
                        break;
                    case "btndOther":
                        btnOther_Click(sender, e);
                        break;
                }
                Console.WriteLine(amount.ToString());
                if (amount > 0) // if amount is greater than 0, perform the deposit
                {

                    PerformDeposit(amount);

                }
            }
        }




        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            if (activeAccount != null)
            {
                int balance = activeAccount.getBalance();
                MessageBox.Show($"Your account balance is : £{balance}"); // Display the user's account balance
            }
        }

        private void btnReturnCard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye!");
            restartLoginProcess();
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            InputDialog inputDialog = new InputDialog("Enter the amount you would like to withdraw", "Withdraw Cash", "0");

            if (inputDialog.ShowDialog() == DialogResult.OK)
            {
                int amount;
                if (int.TryParse(inputDialog.InputValue, out amount)) // check if the input is a valid integer
                {
                    PerformWithdrawal(amount);
                }
                else
                {
               
                    MessageBox.Show("Please enter a valid amount.");
                }
            }
            else
            {
                MessageBox.Show("Withdrawal canceled.");
            }
        }

        /**
         * function to deposit an amount into the active account
         * @param amount
         * 
         * This function deposits the specified amount into the active account. 
         * It first checks if the account is null
         * If a data race is simulated, an artificial delay of 5 seconds 
         * is used for processing time.
         */
        private void PerformDeposit(int amount)
        {
            if (activeAccount != null)
            {
                int currentBalance = activeAccount.getBalance();  // create a local variable to hold the current balance
                Thread.Sleep(5000); // simulate processing time for data race scenario

                if (dataRace) // simulate the data race
                {
                    currentBalance += amount; // add the amount to the local varibale after the artificial delay

                    activeAccount.setBalance(currentBalance); // update the balance after the delay

                    // Display a message indicating successful deposit
                    MessageBox.Show($"Successfully deposited £{amount}. Your current balance is £{activeAccount.getBalance()}");
                    displayWelcomePage(true); // Display the welcome page again
                    displayDepositCash(false);
                }
                else
                {
                    lock (activeAccount)   // use lock for critical section ie balance update
                    {
                        currentBalance += amount; // add the amount to the local varibale after the artificial delay

                        activeAccount.setBalance(currentBalance); // update the balance after the delay

                        // display a message indicating successful deposit
                        MessageBox.Show($"Successfully deposited £{amount}. Your current balance is £{activeAccount.getBalance()}");
                        displayWelcomePage(true); // display the welcome page again
                        displayDepositCash(false);
                    }
                }
            }
        }

        /**
         * function to withdraw an amount into the active account
         * @param amount
         * 
         * This function withdroaw the specified amount into the active account. 
         * It first checks if the account is null
         * If a data race is simulated, an artificial delay of 5 seconds 
         * is used for processing time.
         */
        private void PerformWithdrawal(int amount)
        {
            if (activeAccount != null)
            {

                int currentBalance = activeAccount.getBalance(); // create a local variable to hold the current balance
                Thread.Sleep(5000); // simulate processing time for data race scenario

                if (dataRace) // simulate the data race
                {
                    currentBalance -= amount; // add the amount to the local varibale after the artificial delay

                    activeAccount.setBalance(currentBalance); // update the balance after the delay

                    // display a message indicating successful withdrawal
                    MessageBox.Show($"Successfully withdrew £{amount}. Your current balance is £{activeAccount.getBalance()}");
                    displayWelcomePage(true); // display the welcome page again
                    displayWithdrawCash(false);
                }
                else
                {
                    lock (activeAccount)  // use lock for critical section ie balance update
                    {
                        if (activeAccount.getBalance() >= amount) // check if there are sufficient funds
                        {
                            currentBalance -= amount; // add the amount to the local varibale after the artificial delay

                            activeAccount.setBalance(currentBalance); // update the balance after the delay

                            // Display a message indicating successful withdrawal
                            MessageBox.Show($"Successfully withdrew £{amount}. Your current balance is £{activeAccount.getBalance()}");
                            displayWelcomePage(true); // Display the welcome page again
                            displayWithdrawCash(false);

                        }
                        else
                        {
                            MessageBox.Show($"Insufficient funds. Your current balance is £{activeAccount.getBalance()}");
                        }
                    }
                }
            }
        }



        private void withdrawCash_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                int amount = 0;
                switch (button.Name)
                {
                    case "btn10":
                        amount = 10;
                        break;
                    case "btn20":
                        amount = 20;
                        break;
                    case "btn40":
                        amount = 40;
                        break;
                    case "btn100":
                        amount = 100;
                        break;
                    case "btn500":
                        amount = 500;
                        break;
                    case "btnOther":
                        btnOther_Click(sender, e);
                        break;
                }

                if (amount > 0) // if amount is greater than 0, perform the withdrawal
                {
                    PerformWithdrawal(amount);
                }
            }
        }


    }

    public class InputDialog : Form
    {
        private TextBox textBox;
        private Button okButton;

        public string InputValue => textBox.Text;

        public InputDialog(string prompt, string title, string defaultInput)
        {
            InitializeComponents(prompt, title, defaultInput);
        }

        private void InitializeComponents(string prompt, string title, string defaultInput)
        {
            this.Text = title;
            this.Width = 300;
            this.Height = 150;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label label = new Label();
            label.Text = prompt;
            label.Dock = DockStyle.Top;

            textBox = new TextBox();
            textBox.Text = defaultInput;
            textBox.Dock = DockStyle.Top;

            okButton = new Button();
            okButton.Text = "OK";
            okButton.DialogResult = DialogResult.OK;
            okButton.Dock = DockStyle.Bottom;

            this.Controls.Add(label);
            this.Controls.Add(textBox);
            this.Controls.Add(okButton);
        }
    }


    /**
    * The Account class encapusulates all features of a simple bank account
    */
    public class Account
    {

        //the attributes for the account
        private int balance;
        private int pin;
        private int accountNum;
        private int numAttempts; // number of pin attempts

        // a constructor that takes initial values for each of the attributes (balance, pin, accountNumber)
        public Account(int balance, int pin, int accountNum, int numAttempts)
        {
            this.balance = balance;
            this.pin = pin;
            this.accountNum = accountNum;
            this.numAttempts = numAttempts;
        }

        //getter and setter functions for balance
        public int getBalance()
        {
            return balance;
        }
        public void setBalance(int newBalance)
        {
            this.balance = newBalance;
        }
        //getter for accountNum
        public int getAccountNum()
        {
            return accountNum;
        }
        // get number of attempts
        public int getAttempts()
        {
            return numAttempts;
        }
        // reset numattempts 
        public void resetAttempts()
        {
            numAttempts = 3;
        }
        // decrement attempts
        public void decreaseAttempts(int newAttempts)
        {
            this.numAttempts = newAttempts;
        }


        /*
         *   This funciton allows us to decrement the balance of an account
         *   it perfomes a simple check to ensure the balance is greater tha
         *   the amount being deleted
         *   
         *   returns:
         *   true if the transactions if possible
         *   false if there are insufficent funds in the account
         */
        public Boolean decrementBalance(int amount)
        {
            if (this.balance > amount)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return true;
            }
        }

        /*
        * This funciton check the account pin against the argument passed to it
        *
        * returns:
        * true if they match
        * false if they do not
        */
        public Boolean checkPin(int pinEntered)
        {
            if (pinEntered == pin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}