namespace ATM_Simulator
{
    partial class ATM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxAccountNo = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnBlank3 = new System.Windows.Forms.Button();
            this.btnBlank2 = new System.Windows.Forms.Button();
            this.btnBlank1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.txtBoxPin = new System.Windows.Forms.TextBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn40 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn500 = new System.Windows.Forms.Button();
            this.btnOther = new System.Windows.Forms.Button();
            this.btnd10 = new System.Windows.Forms.Button();
            this.btnd20 = new System.Windows.Forms.Button();
            this.btnd40 = new System.Windows.Forms.Button();
            this.btnd100 = new System.Windows.Forms.Button();
            this.btnd500 = new System.Windows.Forms.Button();
            this.btndOther = new System.Windows.Forms.Button();
            this.lblWithdraw = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.btnReturnCard = new System.Windows.Forms.Button();
            this.btnDepositCash = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxAccountNo
            // 
            this.txtBoxAccountNo.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAccountNo.Location = new System.Drawing.Point(63, 217);
            this.txtBoxAccountNo.Multiline = true;
            this.txtBoxAccountNo.Name = "txtBoxAccountNo";
            this.txtBoxAccountNo.Size = new System.Drawing.Size(309, 61);
            this.txtBoxAccountNo.TabIndex = 0;
            this.txtBoxAccountNo.TextChanged += new System.EventHandler(this.txtBoxAccountNo_TextChanged);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEnter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(251, 165);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(141, 75);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Yellow;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(251, 84);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(141, 75);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Silver;
            this.btn5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(89, 85);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 75);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Silver;
            this.btn6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(170, 85);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 75);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Silver;
            this.btn7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(9, 166);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 75);
            this.btn7.TabIndex = 11;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Silver;
            this.btn8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(90, 166);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 75);
            this.btn8.TabIndex = 12;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Silver;
            this.btn9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(171, 165);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 75);
            this.btn9.TabIndex = 13;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Silver;
            this.btn0.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(89, 247);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 75);
            this.btn0.TabIndex = 14;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btnBlank3);
            this.panel1.Controls.Add(this.btnBlank2);
            this.panel1.Controls.Add(this.btnBlank1);
            this.panel1.Controls.Add(this.btnEnter);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Location = new System.Drawing.Point(473, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 330);
            this.panel1.TabIndex = 15;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(251, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(141, 75);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Silver;
            this.btn3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(171, 4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 75);
            this.btn3.TabIndex = 20;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Silver;
            this.btn2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(90, 4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 75);
            this.btn2.TabIndex = 19;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Silver;
            this.btn1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(9, 4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 75);
            this.btn1.TabIndex = 18;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // btnBlank3
            // 
            this.btnBlank3.BackColor = System.Drawing.Color.Silver;
            this.btnBlank3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlank3.Location = new System.Drawing.Point(251, 246);
            this.btnBlank3.Name = "btnBlank3";
            this.btnBlank3.Size = new System.Drawing.Size(141, 75);
            this.btnBlank3.TabIndex = 17;
            this.btnBlank3.UseVisualStyleBackColor = false;
            // 
            // btnBlank2
            // 
            this.btnBlank2.BackColor = System.Drawing.Color.Silver;
            this.btnBlank2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlank2.Location = new System.Drawing.Point(170, 246);
            this.btnBlank2.Name = "btnBlank2";
            this.btnBlank2.Size = new System.Drawing.Size(75, 75);
            this.btnBlank2.TabIndex = 16;
            this.btnBlank2.UseVisualStyleBackColor = false;
            // 
            // btnBlank1
            // 
            this.btnBlank1.BackColor = System.Drawing.Color.Silver;
            this.btnBlank1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlank1.Location = new System.Drawing.Point(9, 247);
            this.btnBlank1.Name = "btnBlank1";
            this.btnBlank1.Size = new System.Drawing.Size(75, 75);
            this.btnBlank1.TabIndex = 15;
            this.btnBlank1.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Silver;
            this.btn4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(8, 84);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 75);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(58, 173);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(252, 29);
            this.lblText.TabIndex = 16;
            this.lblText.Text = "Enter Account Number";
            // 
            // txtBoxPin
            // 
            this.txtBoxPin.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPin.Location = new System.Drawing.Point(63, 217);
            this.txtBoxPin.Multiline = true;
            this.txtBoxPin.Name = "txtBoxPin";
            this.txtBoxPin.Size = new System.Drawing.Size(309, 61);
            this.txtBoxPin.TabIndex = 17;
            this.txtBoxPin.Visible = false;
            this.txtBoxPin.TextChanged += new System.EventHandler(this.txtBoxPin_TextChanged);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(58, 127);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(110, 29);
            this.lblWelcome.TabIndex = 18;
            this.lblWelcome.Text = "Welcome";
            this.lblWelcome.Visible = false;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.Location = new System.Drawing.Point(63, 159);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(309, 61);
            this.btnWithdraw.TabIndex = 19;
            this.btnWithdraw.Text = "Withdraw Cash";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Visible = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btn10
            // 
            this.btn10.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10.Location = new System.Drawing.Point(63, 112);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(309, 61);
            this.btn10.TabIndex = 22;
            this.btn10.Text = "£10";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Visible = false;
            this.btn10.Click += new System.EventHandler(this.withdrawCash_Click);
            // 
            // btn20
            // 
            this.btn20.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn20.Location = new System.Drawing.Point(63, 179);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(309, 61);
            this.btn20.TabIndex = 23;
            this.btn20.Text = "£20";
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Visible = false;
            this.btn20.Click += new System.EventHandler(this.withdrawCash_Click);
            // 
            // btn40
            // 
            this.btn40.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn40.Location = new System.Drawing.Point(63, 246);
            this.btn40.Name = "btn40";
            this.btn40.Size = new System.Drawing.Size(309, 61);
            this.btn40.TabIndex = 24;
            this.btn40.Text = "£40";
            this.btn40.UseVisualStyleBackColor = true;
            this.btn40.Visible = false;
            this.btn40.Click += new System.EventHandler(this.withdrawCash_Click);
            // 
            // btn100
            // 
            this.btn100.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn100.Location = new System.Drawing.Point(63, 313);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(309, 61);
            this.btn100.TabIndex = 25;
            this.btn100.Text = "£100";
            this.btn100.UseVisualStyleBackColor = true;
            this.btn100.Visible = false;
            this.btn100.Click += new System.EventHandler(this.withdrawCash_Click);
            // 
            // btn500
            // 
            this.btn500.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn500.Location = new System.Drawing.Point(63, 380);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(309, 61);
            this.btn500.TabIndex = 26;
            this.btn500.Text = "£500";
            this.btn500.UseVisualStyleBackColor = true;
            this.btn500.Visible = false;
            this.btn500.Click += new System.EventHandler(this.withdrawCash_Click);
            // 
            // btnOther
            // 
            this.btnOther.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOther.Location = new System.Drawing.Point(63, 447);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(309, 61);
            this.btnOther.TabIndex = 27;
            this.btnOther.Text = "Other";
            this.btnOther.UseVisualStyleBackColor = true;
            this.btnOther.Visible = false;
            this.btnOther.Click += new System.EventHandler(this.withdrawCash_Click);
            // 
            // lblWithdraw
            // 
            this.lblWithdraw.AutoSize = true;
            this.lblWithdraw.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithdraw.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWithdraw.Location = new System.Drawing.Point(58, 69);
            this.lblWithdraw.Name = "lblWithdraw";
            this.lblWithdraw.Size = new System.Drawing.Size(303, 29);
            this.lblWithdraw.TabIndex = 28;
            this.lblWithdraw.Text = "Select Amount to Withdraw";
            this.lblWithdraw.Visible = false;
            //
            // btnDeposit
            //
            this.btnDepositCash.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositCash.Location = new System.Drawing.Point(63, 159);
            this.btnDepositCash.Name = "btnDepositCash";
            this.btnDepositCash.Size = new System.Drawing.Size(309, 61);
            this.btnDepositCash.TabIndex = 19;
            this.btnDepositCash.Text = "Deposit Cash";
            this.btnDepositCash.UseVisualStyleBackColor = true;
            this.btnDepositCash.Visible = false;
            this.btnDepositCash.Click += new System.EventHandler(this.BtnDeposit_Click);
            // 
            // btnd10
            // 
            this.btnd10.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnd10.Location = new System.Drawing.Point(63, 112);
            this.btnd10.Name = "btnd10";
            this.btnd10.Size = new System.Drawing.Size(309, 61);
            this.btnd10.TabIndex = 22;
            this.btnd10.Text = "£10";
            this.btnd10.UseVisualStyleBackColor = true;
            this.btnd10.Visible = false;
            this.btnd10.Click += new System.EventHandler(this.DepositCash_Click);
            // 
            // btnd20
            // 
            this.btnd20.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnd20.Location = new System.Drawing.Point(63, 179);
            this.btnd20.Name = "btnd20";
            this.btnd20.Size = new System.Drawing.Size(309, 61);
            this.btnd20.TabIndex = 23;
            this.btnd20.Text = "£20";
            this.btnd20.UseVisualStyleBackColor = true;
            this.btnd20.Visible = false;
            this.btnd20.Click += new System.EventHandler(this.DepositCash_Click);
            // 
            // btnd40
            // 
            this.btnd40.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnd40.Location = new System.Drawing.Point(63, 246);
            this.btnd40.Name = "btnd40";
            this.btnd40.Size = new System.Drawing.Size(309, 61);
            this.btnd40.TabIndex = 24;
            this.btnd40.Text = "£40";
            this.btnd40.UseVisualStyleBackColor = true;
            this.btnd40.Visible = false;
            this.btnd40.Click += new System.EventHandler(this.DepositCash_Click);
            // 
            // btnd100
            // 
            this.btnd100.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnd100.Location = new System.Drawing.Point(63, 313);
            this.btnd100.Name = "btnd100";
            this.btnd100.Size = new System.Drawing.Size(309, 61);
            this.btnd100.TabIndex = 25;
            this.btnd100.Text = "£100";
            this.btnd100.UseVisualStyleBackColor = true;
            this.btnd100.Visible = false;
            this.btnd100.Click += new System.EventHandler(this.DepositCash_Click);
            // 
            // btnd500
            // 
            this.btnd500.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnd500.Location = new System.Drawing.Point(63, 380);
            this.btnd500.Name = "btnd500";
            this.btnd500.Size = new System.Drawing.Size(309, 61);
            this.btnd500.TabIndex = 26;
            this.btnd500.Text = "£500";
            this.btnd500.UseVisualStyleBackColor = true;
            this.btnd500.Visible = false;
            this.btnd500.Click += new System.EventHandler(this.DepositCash_Click);
            // 
            // btndOther
            // 
            this.btndOther.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndOther.Location = new System.Drawing.Point(63, 447);
            this.btndOther.Name = "btndOther";
            this.btndOther.Size = new System.Drawing.Size(309, 61);
            this.btndOther.TabIndex = 27;
            this.btndOther.Text = "Other";
            this.btndOther.UseVisualStyleBackColor = true;
            this.btndOther.Visible = false;
            this.btndOther.Click += new System.EventHandler(this.DepositCash_Click);

            //
            // lblDeposit
            //
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDeposit.Location = new System.Drawing.Point(58, 69);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(303, 29);
            this.lblDeposit.TabIndex = 28;
            this.lblDeposit.Text = "Select Amount to Deposit";
            this.lblDeposit.Visible = false;
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckBalance.Location = new System.Drawing.Point(63, 295);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(309, 61);
            this.btnCheckBalance.TabIndex = 20;
            this.btnCheckBalance.Text = "Check Account Balance";
            this.btnCheckBalance.UseVisualStyleBackColor = true;
            this.btnCheckBalance.Visible = false;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // btnReturnCard
            // 
            this.btnReturnCard.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnCard.Location = new System.Drawing.Point(63, 362);
            this.btnReturnCard.Name = "btnReturnCard";
            this.btnReturnCard.Size = new System.Drawing.Size(309, 61);
            this.btnReturnCard.TabIndex = 21;
            this.btnReturnCard.Text = "Return Card";
            this.btnReturnCard.UseVisualStyleBackColor = true;
            this.btnReturnCard.Visible = false;
            this.btnReturnCard.Click += new System.EventHandler(this.btnReturnCard_Click);
            // 
            // btnDepositCash
            // 
            this.btnDepositCash.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositCash.Location = new System.Drawing.Point(63, 228);
            this.btnDepositCash.Name = "btnDepositCash";
            this.btnDepositCash.Size = new System.Drawing.Size(309, 61);
            this.btnDepositCash.TabIndex = 29;
            this.btnDepositCash.Text = "Deposit Cash";
            this.btnDepositCash.UseVisualStyleBackColor = true;
            this.btnDepositCash.Visible = false;
            this.btnDepositCash.Click += new System.EventHandler(this.BtnDeposit_Click);
            // 
            // ATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(940, 574);
            this.Controls.Add(this.lblWithdraw);
            this.Controls.Add(this.btnOther);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnReturnCard);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn40);
            this.Controls.Add(this.btn100);
            this.Controls.Add(this.btn500);
            this.Controls.Add(this.btnd10);
            this.Controls.Add(this.btnd20);
            this.Controls.Add(this.btnd40);
            this.Controls.Add(this.btnd100);
            this.Controls.Add(this.btnd500);

            this.Controls.Add(this.btnDepositCash);
            this.Controls.Add(this.btnCheckBalance);
            this.Controls.Add(this.txtBoxPin);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDepositCash);
            this.Controls.Add(this.txtBoxAccountNo);

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ATM";
            this.Text = "ATM Simulator";
            this.Load += new System.EventHandler(this.ATM_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxAccountNo;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txtBoxPin;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn40;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btn500;
        private System.Windows.Forms.Button btnOther;
        private System.Windows.Forms.Button btnd10;
        private System.Windows.Forms.Button btnd20;
        private System.Windows.Forms.Button btnd40;
        private System.Windows.Forms.Button btnd100;
        private System.Windows.Forms.Button btnd500;
        private System.Windows.Forms.Button btndOther;
        private System.Windows.Forms.Label lblWithdraw;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Button btnBlank1;
        private System.Windows.Forms.Button btnBlank2;
        private System.Windows.Forms.Button btnBlank3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.Button btnReturnCard;
        private System.Windows.Forms.Button btnDepositCash;
    }
}