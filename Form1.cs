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
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
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
        private bool dataRace; //keeps track of the d

        private Semaphore semaphore = new Semaphore(1, 1); //used for the non data race

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
                txtBoxAccountNo.Text = txtBoxAccountNo.Text.Substring(0, 6);  // if the length is greater than 6, truncate the text to 6
                txtBoxAccountNo.SelectionStart = txtBoxAccountNo.Text.Length;  // set the cursor position 
            }
        }

        private void txtBoxPin_TextChanged(object sender, EventArgs e)
        {
        
            if (txtBoxPin.Text.Length > 4) //check if the pin is at the limit
            {
                txtBoxPin.Text = txtBoxPin.Text.Substring(0, 4);   // if the length is greater than 4 , truncate the text to 4 
                txtBoxPin.SelectionStart = txtBoxPin.Text.Length;  // set the cursor position 
            }
        }


        // this method handles the click event of the number buttons.
        private void numberButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                if (txtBoxAccountNo.Visible) 
                {
                    txtBoxAccountNo.Text += button.Text;
                }
                else if (txtBoxPin.Visible) 
                {
                    txtBoxPin.Text += button.Text;

                }
            }
        }



        /**
        *this method handles the click event of the cancel button by either restarting the login process
        *or displaying the welcome page
        */
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtBoxAccountNo.Visible || txtBoxPin.Visible)
            {
                restartLoginProcess();
                clearTextFromTextBox();
            }
            else
            {
                clearTextFromTextBox();
                lblText.Visible = false;
                displayWelcomePage(true);
                displayWithdrawCash(false);
                displayDepositCash(false);
                
            }
        }

        /**
         * this fucnitons clears the current text in a textBox
        */
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextFromTextBox();
        }

        //helper function for clear button
        private void clearTextFromTextBox()
        {
            if (txtBoxAccountNo.Visible == true)
            {
                txtBoxAccountNo.Text = "";
            }
            else if (txtBoxPin.Visible == true)
            {
                txtBoxPin.Text = "";
            }
        }


        //this funtion handles the input validation
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtBoxPin.Visible || txtBoxAccountNo.Visible)
            {
                if (txtBoxPin.Visible)
                {
                    validatePIN();
                }
                else if (txtBoxAccountNo.Visible)
                {
                    validateAccountNumber();

                }
            }
        }


        // This method validates the entered account number.
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

        // This method validates the entered PIN.
        private void validatePIN()
        {
           
                int pinEntered;
                if (!int.TryParse(txtBoxPin.Text, out pinEntered)) // get the entered PIN from the TextBox
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
                

                // if the loop finishes without finding a matching account number then display an error message
                if (!accountFound)
                {
                    MessageBox.Show("Error");
                    restartLoginProcess();
                }
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

        //helper function for visibility of the different pages
        private void setControlsVisibility(bool visible, params Control[] controls)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => setControlsVisibility(visible, controls)));
                return;
            }
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
                        btnOther_Click(sender, e, "deposit");
                        return;
                }
                Console.WriteLine(amount.ToString());


                PerformDeposit(amount);
            }
        }

        // this function updates the user interface - the lblMessage
        private void updateUI() {
            //calls the update function for the label message to make sure it's in sync with the user interface thread. 
            this.Invoke((MethodInvoker)delegate
            {
                lblMessage.Update();
            });
        }


        private void btnCheckBalance_Click(object sender, EventArgs e)
        {

            if (activeAccount != null)  //check if an active account exists.

            { // get the balance of the active account and display it.
                int balance = activeAccount.getBalance();
                displayAccountBalance(balance);

            }
        }


        // This function handles the click event of the return card button.
        private void btnReturnCard_Click(object sender, EventArgs e)
        {

            // hide the welcome page, display a goodbye message, and make the message label visible.
            displayWelcomePage(false);
            ChangeMessageText("Goodbye!");
            lblMessage.Visible = true;

            // update UI 
            updateUI();
            Thread.Sleep(2000);

            // hide the message label, and restart the login process.
            lblMessage.Visible = false;
            restartLoginProcess();
        }


        /**
         * this function handles other button click event. It takes in the transactiontype. eg deposit or withdrawal
         */
        private void btnOther_Click(object sender, EventArgs e, string transactionType)
        {
            InputDialog inputDialog = null;

            if (transactionType == "withdrawal")
            {
                Console.WriteLine("Withdrawl taking place...");
                inputDialog = new InputDialog("Enter the amount you would like to withdraw", "Withdraw Cash", "0");
            }
            else if (transactionType == "deposit")
            {
                inputDialog = new InputDialog("Enter the amount you would like to deposit", "Deposit Cash", "0");
                Console.WriteLine("deposti taking place...");
            }
            else
            {
                MessageBox.Show("Invalid transaction type.");
                return;
            }

            if (inputDialog.ShowDialog() == DialogResult.OK)
            {
                int amount;
                if (int.TryParse(inputDialog.InputValue, out amount)) // check if the input is a valid integer
                {
                    if (transactionType == "withdrawal")
                    {
                        PerformWithdrawal(amount);
                    }
                    else if (transactionType == "deposit")
                    {
                        PerformDeposit(amount);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid amount.");
                }
            }
            else
            {
                MessageBox.Show("Transaction canceled.");
            }
        }


        //helper function for UI
        private void ChangeMessageText(string newText)
        {
            // Update the text of lblMessage
            lblMessage.Text = newText;
        }


        private void displayTransactionOutcome(int amount, int balance, string type)
        {
            if (type == "withdrawal")
            {
                ChangeMessageText("Successfully withdrew £" + amount + " Bank Balance: £" + balance);
            }
            else {
                ChangeMessageText("Successfully deposited £" + amount + " Bank Balance: £" + balance);
            }
            lblMessage.Visible = true;
            updateUI();
            Thread.Sleep(2000);

            lblMessage.Visible = false;
        }

        private void displayAccountBalance(int balance)
        {
            displayWelcomePage(false);
            ChangeMessageText("Bank Balance: £" + balance);
            lblMessage.Visible = true;
            updateUI();
            Thread.Sleep(2000);
            lblMessage.Visible = false;
            displayWelcomePage(true);
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
            ChangeMessageText("Processing Transaction. Please wait...");
            displayDepositCash(false);
            lblMessage.Visible = true;
            updateUI();
            if (activeAccount != null)
            {
                Console.WriteLine("Performing deposit operation...");

                if (dataRace) // simulate the data race
                {
                    Console.WriteLine("Simulating data race scenario for deposit...");
                    int currentBalance = activeAccount.getBalance(); // read bank account total into local variable
                    Thread.Sleep(5000); // simulate processing time for data race
                    currentBalance += amount; // change total 
                    activeAccount.setBalance(currentBalance); // set total into the bank account total

                    // display a message for successful deposit
                    displayTransactionOutcome(amount, activeAccount.getBalance(), "deposit");
                    lblMessage.Visible = false;
                    displayWelcomePage(true); 
                  
                }
                else
                {
                    Thread.Sleep(5000); // simulate processing time 
                    semaphore.WaitOne(); //use a semaphore for critical section
                 
                    try
                    {
                        Console.WriteLine("Executing deposit operation with semaphore...");

                        int currentBalance = activeAccount.getBalance(); // Read bank account total into local variable
                       
                        Console.WriteLine("currentBalance: {0}", currentBalance);

                        currentBalance += amount; // Change total according to the operation
                        activeAccount.setBalance(currentBalance); // Write total into the bank account total

                        // Display a message indicating successful deposit
                        displayTransactionOutcome(amount, activeAccount.getBalance(), "deposit");
                        lblMessage.Visible = false;
                        displayWelcomePage(true); // Display the welcome page again
                       
                        Console.WriteLine("Finished deposit operation with semaphore...");
                    }
                    finally
                    {
                        // release the semaphore after the critical section
                        semaphore.Release();
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

            ChangeMessageText("Processing Transaction. Please wait...");
            displayWithdrawCash(false);
            lblMessage.Visible = true;
            updateUI();
            if (activeAccount != null)
            {
                Console.WriteLine("Performing withdrawal operation...");

                if (dataRace) // Simulate the data race
                {
                    Console.WriteLine("Simulating data race scenario for withdrawal...");
                    int currentBalance = activeAccount.getBalance(); // read bank account total into local variable
                    Thread.Sleep(5000); // simulate processing time for data race scenario

                    if (activeAccount.decrementBalance(amount))
                    {
                        currentBalance -= amount; // change total 
                        activeAccount.setBalance(currentBalance); // set total into the bank account total

                        // display a message indicating successful withdrawal
                        displayTransactionOutcome(amount, activeAccount.getBalance(), "withdrawal");
                        lblMessage.Visible = false;
                        displayWelcomePage(true); // display the welcome page again
                    }
                    else {

                        MessageBox.Show($"Insufficient funds. Your current balance is £{activeAccount.getBalance()}");
                        lblMessage.Visible = false;
                        displayWelcomePage(true); // display the welcome page again
                    }
                }
                else
                {

                    Thread.Sleep(5000); // simulate processing time 
                    semaphore.WaitOne(); //semaphore for critical section
                    try
                    {
                        Console.WriteLine("Executing withdrawal operation with semaphore...");

                        int currentBalance = activeAccount.getBalance(); // Read bank account total into local variable
                        Console.WriteLine("currentBalance: {0}", currentBalance);


                        if (activeAccount.decrementBalance(amount))
                        {
                            currentBalance -= amount; // Change total according to the operation
                            activeAccount.setBalance(currentBalance); // Write total into the bank account total
                           
                            // Display a message indicating successful withdrawal
                            displayTransactionOutcome(amount, activeAccount.getBalance(), "withdrawal");
                            lblMessage.Visible = false;
                            displayWelcomePage(true); // display the welcome page again
                            
                           
                            Console.WriteLine("Finished withdrawal operation with semaphore...");
                        }
                        else
                        {
                            MessageBox.Show($"Insufficient funds. Your current balance is £{activeAccount.getBalance()}");
                            lblMessage.Visible = false;
                            displayWelcomePage(true); // display the welcome page again
                        }
                    }
                    finally
                    {
                        // release the semaphore after the critical section
                        semaphore.Release();
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
                        btnOther_Click(sender, e, "withdrawal");
                        return;
                }
                    PerformWithdrawal(amount);
                
            }
        }

      
    }


     //custom input dialog form used for the other button
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
                return false;
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