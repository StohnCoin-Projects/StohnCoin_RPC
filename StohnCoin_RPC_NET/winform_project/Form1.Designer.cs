namespace winform_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            txtRPCPort = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtRPCAddress = new TextBox();
            label3 = new Label();
            button3 = new Button();
            label6 = new Label();
            txtTo = new TextBox();
            label7 = new Label();
            txtRPCLogin = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtRPCPassword = new TextBox();
            txtaddresslist = new TextBox();
            btnNewAddress = new Button();
            txtNewAddressLabel = new TextBox();
            button4 = new Button();
            txtSendAmt = new TextBox();
            btnCreateWallet = new Button();
            txtCreateWalletName = new TextBox();
            lstWalletList = new ListBox();
            btnListWallets = new Button();
            btnLoadWallet = new Button();
            btnUnloadWallet = new Button();
            txtLoadedWallet = new TextBox();
            label10 = new Label();
            txtWalletPrefix = new TextBox();
            lblWaletBalance = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label15 = new Label();
            label14 = new Label();
            groupBox2 = new GroupBox();
            label17 = new Label();
            txtWalletToLoad = new TextBox();
            label11 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            label13 = new Label();
            label12 = new Label();
            groupBox4 = new GroupBox();
            lblUncBal = new Label();
            label19 = new Label();
            label16 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(457, 145);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(311, 95);
            button1.TabIndex = 0;
            button1.Text = "Get  Difficulty/Block Count\r\n(Test Connection)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtRPCPort
            // 
            txtRPCPort.BorderStyle = BorderStyle.FixedSingle;
            txtRPCPort.Font = new Font("Segoe UI", 12F);
            txtRPCPort.Location = new Point(273, 108);
            txtRPCPort.Margin = new Padding(4, 5, 4, 5);
            txtRPCPort.Name = "txtRPCPort";
            txtRPCPort.Size = new Size(142, 39);
            txtRPCPort.TabIndex = 1;
            txtRPCPort.Text = "32717";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(9, 37);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(407, 57);
            button2.TabIndex = 2;
            button2.Text = "Get Balance For Selected Wallet";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(21, 58);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 38);
            label1.TabIndex = 4;
            label1.Text = "Node IP";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(21, 113);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 38);
            label2.TabIndex = 5;
            label2.Text = "Node Port";
            // 
            // txtRPCAddress
            // 
            txtRPCAddress.BorderStyle = BorderStyle.FixedSingle;
            txtRPCAddress.Font = new Font("Segoe UI", 12F);
            txtRPCAddress.Location = new Point(137, 52);
            txtRPCAddress.Margin = new Padding(4, 5, 4, 5);
            txtRPCAddress.Name = "txtRPCAddress";
            txtRPCAddress.Size = new Size(278, 39);
            txtRPCAddress.TabIndex = 6;
            txtRPCAddress.Text = "http://192.168.1.66";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(907, 155);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(181, 38);
            label3.TabIndex = 7;
            label3.Text = "[difficulty count]";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(19, 235);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(893, 60);
            button3.TabIndex = 9;
            button3.Text = "Send Stohn Coin From Selected Wallet";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(534, 180);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(143, 38);
            label6.TabIndex = 13;
            label6.Text = "Amount";
            label6.Click += label6_Click;
            // 
            // txtTo
            // 
            txtTo.BorderStyle = BorderStyle.FixedSingle;
            txtTo.Font = new Font("Segoe UI", 12F);
            txtTo.Location = new Point(263, 118);
            txtTo.Margin = new Padding(4, 5, 4, 5);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(648, 39);
            txtTo.TabIndex = 12;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(907, 197);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(181, 38);
            label7.TabIndex = 14;
            label7.Text = "[block count]";
            // 
            // txtRPCLogin
            // 
            txtRPCLogin.BorderStyle = BorderStyle.FixedSingle;
            txtRPCLogin.Font = new Font("Segoe UI", 12F);
            txtRPCLogin.Location = new Point(721, 48);
            txtRPCLogin.Margin = new Padding(4, 5, 4, 5);
            txtRPCLogin.Name = "txtRPCLogin";
            txtRPCLogin.Size = new Size(278, 39);
            txtRPCLogin.TabIndex = 18;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(1009, 55);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(243, 38);
            label8.TabIndex = 17;
            label8.Text = "RPC Passowrd";
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(574, 57);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(143, 38);
            label9.TabIndex = 16;
            label9.Text = "RPC Login";
            // 
            // txtRPCPassword
            // 
            txtRPCPassword.BorderStyle = BorderStyle.FixedSingle;
            txtRPCPassword.Font = new Font("Segoe UI", 12F);
            txtRPCPassword.Location = new Point(1163, 47);
            txtRPCPassword.Margin = new Padding(4, 5, 4, 5);
            txtRPCPassword.Name = "txtRPCPassword";
            txtRPCPassword.PasswordChar = '*';
            txtRPCPassword.Size = new Size(278, 39);
            txtRPCPassword.TabIndex = 15;
            // 
            // txtaddresslist
            // 
            txtaddresslist.BorderStyle = BorderStyle.FixedSingle;
            txtaddresslist.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtaddresslist.Location = new Point(31, 182);
            txtaddresslist.Margin = new Padding(4, 5, 4, 5);
            txtaddresslist.Multiline = true;
            txtaddresslist.Name = "txtaddresslist";
            txtaddresslist.ReadOnly = true;
            txtaddresslist.Size = new Size(579, 190);
            txtaddresslist.TabIndex = 19;
            // 
            // btnNewAddress
            // 
            btnNewAddress.Font = new Font("Segoe UI", 12F);
            btnNewAddress.Location = new Point(534, 115);
            btnNewAddress.Margin = new Padding(4, 5, 4, 5);
            btnNewAddress.Name = "btnNewAddress";
            btnNewAddress.Size = new Size(377, 57);
            btnNewAddress.TabIndex = 20;
            btnNewAddress.Text = "Create Address For Selected Wallet";
            btnNewAddress.UseVisualStyleBackColor = true;
            btnNewAddress.Click += btnNewAddress_Click;
            // 
            // txtNewAddressLabel
            // 
            txtNewAddressLabel.Font = new Font("Segoe UI", 12F);
            txtNewAddressLabel.Location = new Point(306, 122);
            txtNewAddressLabel.Margin = new Padding(4, 5, 4, 5);
            txtNewAddressLabel.Name = "txtNewAddressLabel";
            txtNewAddressLabel.Size = new Size(218, 39);
            txtNewAddressLabel.TabIndex = 21;
            txtNewAddressLabel.Text = "New Address1";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(620, 182);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(231, 92);
            button4.TabIndex = 22;
            button4.Text = "<- List Addresses For Selected Wallet";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtSendAmt
            // 
            txtSendAmt.BorderStyle = BorderStyle.FixedSingle;
            txtSendAmt.Font = new Font("Segoe UI", 12F);
            txtSendAmt.Location = new Point(691, 177);
            txtSendAmt.Margin = new Padding(4, 5, 4, 5);
            txtSendAmt.Name = "txtSendAmt";
            txtSendAmt.Size = new Size(219, 39);
            txtSendAmt.TabIndex = 23;
            txtSendAmt.Text = "1";
            txtSendAmt.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCreateWallet
            // 
            btnCreateWallet.Font = new Font("Segoe UI", 12F);
            btnCreateWallet.Location = new Point(549, 73);
            btnCreateWallet.Margin = new Padding(4, 5, 4, 5);
            btnCreateWallet.Name = "btnCreateWallet";
            btnCreateWallet.Size = new Size(171, 57);
            btnCreateWallet.TabIndex = 25;
            btnCreateWallet.Text = "Create Wallet";
            btnCreateWallet.UseVisualStyleBackColor = true;
            btnCreateWallet.Click += btnCreateWallet_Click;
            // 
            // txtCreateWalletName
            // 
            txtCreateWalletName.BorderStyle = BorderStyle.FixedSingle;
            txtCreateWalletName.Font = new Font("Segoe UI", 12F);
            txtCreateWalletName.Location = new Point(276, 75);
            txtCreateWalletName.Margin = new Padding(4, 5, 4, 5);
            txtCreateWalletName.Name = "txtCreateWalletName";
            txtCreateWalletName.Size = new Size(263, 39);
            txtCreateWalletName.TabIndex = 26;
            // 
            // lstWalletList
            // 
            lstWalletList.FormattingEnabled = true;
            lstWalletList.ItemHeight = 38;
            lstWalletList.Location = new Point(216, 138);
            lstWalletList.Name = "lstWalletList";
            lstWalletList.Size = new Size(354, 232);
            lstWalletList.TabIndex = 28;
            lstWalletList.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnListWallets
            // 
            btnListWallets.Font = new Font("Segoe UI", 12F);
            btnListWallets.Location = new Point(20, 138);
            btnListWallets.Margin = new Padding(4, 5, 4, 5);
            btnListWallets.Name = "btnListWallets";
            btnListWallets.Size = new Size(167, 57);
            btnListWallets.TabIndex = 29;
            btnListWallets.Text = "List Wallets ->";
            btnListWallets.UseVisualStyleBackColor = true;
            btnListWallets.Click += button6_Click;
            // 
            // btnLoadWallet
            // 
            btnLoadWallet.Font = new Font("Segoe UI", 12F);
            btnLoadWallet.Location = new Point(533, 555);
            btnLoadWallet.Margin = new Padding(4, 5, 4, 5);
            btnLoadWallet.Name = "btnLoadWallet";
            btnLoadWallet.Size = new Size(187, 57);
            btnLoadWallet.TabIndex = 31;
            btnLoadWallet.Text = "Load Wallet";
            btnLoadWallet.UseVisualStyleBackColor = true;
            btnLoadWallet.Click += btnLoadWallet_Click;
            // 
            // btnUnloadWallet
            // 
            btnUnloadWallet.Font = new Font("Segoe UI", 12F);
            btnUnloadWallet.Location = new Point(33, 632);
            btnUnloadWallet.Margin = new Padding(4, 5, 4, 5);
            btnUnloadWallet.Name = "btnUnloadWallet";
            btnUnloadWallet.Size = new Size(700, 57);
            btnUnloadWallet.TabIndex = 32;
            btnUnloadWallet.Text = "Unload Selected Wallet From List";
            btnUnloadWallet.UseVisualStyleBackColor = true;
            btnUnloadWallet.Click += btnUnloadWallet_Click;
            // 
            // txtLoadedWallet
            // 
            txtLoadedWallet.BorderStyle = BorderStyle.FixedSingle;
            txtLoadedWallet.Font = new Font("Segoe UI", 12F);
            txtLoadedWallet.Location = new Point(273, 381);
            txtLoadedWallet.Margin = new Padding(4, 5, 4, 5);
            txtLoadedWallet.Name = "txtLoadedWallet";
            txtLoadedWallet.Size = new Size(298, 39);
            txtLoadedWallet.TabIndex = 33;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.Location = new Point(20, 384);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(245, 38);
            label10.TabIndex = 34;
            label10.Text = "Selected Wallet";
            // 
            // txtWalletPrefix
            // 
            txtWalletPrefix.BorderStyle = BorderStyle.FixedSingle;
            txtWalletPrefix.Font = new Font("Segoe UI", 12F);
            txtWalletPrefix.Location = new Point(429, 52);
            txtWalletPrefix.Margin = new Padding(4, 5, 4, 5);
            txtWalletPrefix.Name = "txtWalletPrefix";
            txtWalletPrefix.ReadOnly = true;
            txtWalletPrefix.Size = new Size(119, 39);
            txtWalletPrefix.TabIndex = 35;
            txtWalletPrefix.Text = "/wallet/";
            // 
            // lblWaletBalance
            // 
            lblWaletBalance.Font = new Font("Segoe UI", 12F);
            lblWaletBalance.Location = new Point(687, 29);
            lblWaletBalance.Margin = new Padding(4, 0, 4, 0);
            lblWaletBalance.Name = "lblWaletBalance";
            lblWaletBalance.Size = new Size(181, 38);
            lblWaletBalance.TabIndex = 36;
            lblWaletBalance.Text = "[balance]";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(31, 122);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(224, 42);
            label4.TabIndex = 37;
            label4.Text = "Address To Send To";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(txtRPCAddress);
            groupBox1.Controls.Add(txtRPCPort);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtWalletPrefix);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtRPCPassword);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtRPCLogin);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            groupBox1.Location = new Point(46, 20);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1471, 277);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "SETP 1: Connect To Node";
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI", 12F);
            label15.Location = new Point(777, 197);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(109, 38);
            label15.TabIndex = 42;
            label15.Text = "Block:";
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(777, 155);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(136, 38);
            label14.TabIndex = 41;
            label14.Text = "Difficulty:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(btnLoadWallet);
            groupBox2.Controls.Add(txtWalletToLoad);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnUnloadWallet);
            groupBox2.Controls.Add(txtCreateWalletName);
            groupBox2.Controls.Add(btnCreateWallet);
            groupBox2.Controls.Add(lstWalletList);
            groupBox2.Controls.Add(txtLoadedWallet);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(btnListWallets);
            groupBox2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            groupBox2.Location = new Point(46, 320);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(750, 712);
            groupBox2.TabIndex = 39;
            groupBox2.TabStop = false;
            groupBox2.Text = "STEP 2: Make Wallets / Load Wallets";
            // 
            // label17
            // 
            label17.Font = new Font("Segoe UI", 12F);
            label17.Location = new Point(13, 422);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(720, 92);
            label17.TabIndex = 40;
            label17.Text = "Note: You can also just type a wallet name here if you don't want to load the list. Just make sure you got the right name!";
            // 
            // txtWalletToLoad
            // 
            txtWalletToLoad.BorderStyle = BorderStyle.FixedSingle;
            txtWalletToLoad.Font = new Font("Segoe UI", 12F);
            txtWalletToLoad.Location = new Point(216, 557);
            txtWalletToLoad.Margin = new Padding(4, 5, 4, 5);
            txtWalletToLoad.Name = "txtWalletToLoad";
            txtWalletToLoad.Size = new Size(308, 39);
            txtWalletToLoad.TabIndex = 39;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(20, 513);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(720, 65);
            label11.TabIndex = 38;
            label11.Text = "If a previously made wallet isn't in the list, you need to load it";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(20, 85);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(247, 38);
            label5.TabIndex = 37;
            label5.Text = "Wallet Name To Make:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(txtNewAddressLabel);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(btnNewAddress);
            groupBox3.Controls.Add(txtaddresslist);
            groupBox3.Controls.Add(button4);
            groupBox3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            groupBox3.Location = new Point(804, 320);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.Size = new Size(933, 383);
            groupBox3.TabIndex = 40;
            groupBox3.TabStop = false;
            groupBox3.Text = "STEP 3: Make Addresses For Wallet";
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(31, 47);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(880, 70);
            label13.TabIndex = 39;
            label13.Text = "Note: If a wallet is not selected in the list, address actions are performed for the Default wallet assigned in the stohn.conf file for the node";
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(31, 127);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(330, 38);
            label12.TabIndex = 38;
            label12.Text = "Address Name To Make:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblUncBal);
            groupBox4.Controls.Add(label19);
            groupBox4.Controls.Add(lblWaletBalance);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(button2);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(button3);
            groupBox4.Controls.Add(txtSendAmt);
            groupBox4.Controls.Add(txtTo);
            groupBox4.Controls.Add(label6);
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox4.Location = new Point(804, 713);
            groupBox4.Margin = new Padding(4, 5, 4, 5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 5, 4, 5);
            groupBox4.Size = new Size(933, 318);
            groupBox4.TabIndex = 41;
            groupBox4.TabStop = false;
            groupBox4.Text = "STEP 4: MISC";
            // 
            // lblUncBal
            // 
            lblUncBal.Font = new Font("Segoe UI", 12F);
            lblUncBal.Location = new Point(687, 67);
            lblUncBal.Margin = new Padding(4, 0, 4, 0);
            lblUncBal.Name = "lblUncBal";
            lblUncBal.Size = new Size(146, 38);
            lblUncBal.TabIndex = 38;
            lblUncBal.Text = "[balance]";
            // 
            // label19
            // 
            label19.Font = new Font("Segoe UI", 12F);
            label19.Location = new Point(454, 67);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(181, 38);
            label19.TabIndex = 39;
            label19.Text = "Unconfirmed:";
            // 
            // label16
            // 
            label16.Font = new Font("Segoe UI", 12F);
            label16.Location = new Point(454, 29);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(181, 38);
            label16.TabIndex = 37;
            label16.Text = "Balance:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1757, 1053);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Stohn coin RPC Tester";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TextBox txtRPCPort;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox txtRPCAddress;
        private Label label3;
        private Button button3;
        private Label label6;
        private TextBox txtTo;
        private Label label7;
        private TextBox txtRPCLogin;
        private Label label8;
        private Label label9;
        private TextBox txtRPCPassword;
        private TextBox txtaddresslist;
        private Button btnNewAddress;
        private TextBox txtNewAddressLabel;
        private Button button4;
        private TextBox txtSendAmt;
        private Button btnCreateWallet;
        private TextBox txtCreateWalletName;
        private ListBox lstWalletList;
        private Button btnListWallets;
        private Button btnLoadWallet;
        private Button btnUnloadWallet;
        private TextBox txtLoadedWallet;
        private Label label10;
        private TextBox txtWalletPrefix;
        private Label lblWaletBalance;
        private Label label4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label11;
        private Label label5;
        private TextBox txtWalletToLoad;
        private GroupBox groupBox3;
        private Label label13;
        private Label label12;
        private Label label15;
        private Label label14;
        private GroupBox groupBox4;
        private Label label16;
        private Label label17;
        private Label lblUncBal;
        private Label label19;
    }
}
