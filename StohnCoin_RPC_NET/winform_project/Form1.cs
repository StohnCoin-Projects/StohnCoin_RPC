
using Bitnet.Client;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Net;

namespace winform_project
{
    public partial class Form1 : Form
    {
        //NOTE: This does not include every single Stohncoin RPC command. If you need to add more add them to the BITNETCLIENT.CS File
        //this should be enough to get started as it contained the basic wallet functions.  If you need help, search for Bitcoin RPC commands.
        //the cool thing about StohnCoin is that most of its commands are derived from Bitcoin, and there ae TONS of bitcoin stack exchange
        //questions and answers. even Chat GPT knows how to talk to a Bitcoin node.  So the available resources are nearly endless!
        //this was made by me, Rogelio T, 4/6/2024 , for accessing a StohnCoin Node. rowjelio@yahoo.com 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //set up the RPC Connection
                BitnetClient bc = new BitnetClient(BuildRPCURL());
                bc.Credentials = new NetworkCredential(txtRPCLogin.Text, txtRPCPassword.Text);

                //basic functions that return a single value to test if the node can be contacted.
                var p = bc.GetDifficulty();
                var po = bc.GetBlockCount();

                //display the output!
                label3.Text = p.ToString();
                label7.Text = po.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNewAddress_Click(object sender, EventArgs e)
        {
            try
            {
                txtaddresslist.Text = "";

                //setup the RPC connection
                BitnetClient bc = new BitnetClient(BuildRPCURL());
                bc.Credentials = new NetworkCredential(txtRPCLogin.Text, txtRPCPassword.Text);

                //make a new address
                var wqw = bc.GetNewAddress(txtNewAddressLabel.Text);

                //list all addresses
                var wereaa = bc.ListReceivedByAddress(1, true);

                //loop thrugh all addresses and display them
                foreach (JObject addressInfo in wereaa)
                {
                    // Access individual address information here
                    string address = addressInfo["address"].ToString();
                    string account = addressInfo["label"].ToString();
                    decimal amount = (decimal)addressInfo["amount"];

                    // Do something with the address information
                    txtaddresslist.Text = txtaddresslist.Text + ($"Address: {address}, Account: {account}, Amount: {amount}") + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                txtaddresslist.Text = "";

                //set up rpc connection
                BitnetClient bc = new BitnetClient(BuildRPCURL());
                bc.Credentials = new NetworkCredential(txtRPCLogin.Text, txtRPCPassword.Text);

                //list addresses
                var wereaa = bc.ListReceivedByAddress(1, true);

                foreach (JObject addressInfo in wereaa)
                {
                    // Access individual address information here
                    string address = addressInfo["address"].ToString();
                    string account = addressInfo["label"].ToString();
                    decimal amount = (decimal)addressInfo["amount"];

                    // Do something with the address information
                    txtaddresslist.Text = txtaddresslist.Text + ($"Address: {address}, Account: {account}, Amount: {amount}") + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //need to call settxfee first 
                //.00001
                //set up rpc connection
                BitnetClient bc = new BitnetClient(BuildRPCURL());
                bc.Credentials = new NetworkCredential(txtRPCLogin.Text, txtRPCPassword.Text);

                //set the fee manually.
                bc.SetTXFee("0.00001");

                //send stohn coin.
                //this will use the selected stohn wallet from the drop down list
                bc.SendToAddress(txtTo.Text, float.Parse(txtSendAmt.Text), "test", "");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //set up rpc connection
                BitnetClient bc = new BitnetClient(BuildRPCURL());
                bc.Credentials = new NetworkCredential(txtRPCLogin.Text, txtRPCPassword.Text);

                //get wallet info
                var wereaa = bc.GetWalletInfo();

                //sometimes you have to loop through objects as jvalues. 
                //this is not needed here. in fact it doesnt work here
                //foreach (JValue WalletInfo in wereaa)
                //{
                //    // Access individual address information here
                //    string address = WalletInfo.ToString();
                //    lstWalletList.Items.Add(address);
                //}

                //loop through all of the properties for the wallet.
                //if the property says "balance" then its the balance
                //if the property is called "unconfirmed_balance" then it's the unconfirmed balance
                IList<JToken> listy = wereaa;
                for (int i = 0; i < listy.Count; i++)
                {
                    JProperty addressInfo = (JProperty)listy[i];
                    if (addressInfo.Name == "balance")
                    {
                        lblWaletBalance.Text = addressInfo.Value.ToString();
                    }

                    else if (addressInfo.Name == "unconfirmed_balance")
                    {
                        lblUncBal.Text = addressInfo.Value.ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        /// <summary>
        /// builds the RPC URL. if you need a secific wallet the wallet name is part of the URL. otherwise it will not specify and use the default wallet
        /// </summary>
        /// <returns>RPC URL</returns>
        private string BuildRPCURL()
        {
            if (txtLoadedWallet.Text != "")
            {
                
                return txtRPCAddress.Text + ":" + txtRPCPort.Text + txtWalletPrefix.Text + txtLoadedWallet.Text;
            }
            else
            {
                return txtRPCAddress.Text + ":" + txtRPCPort.Text;
            }
        }
        private void btnCreateWallet_Click(object sender, EventArgs e)
        {
            try
            {
                //set up rpc connection
                BitnetClient bc = new BitnetClient(txtRPCAddress.Text + ":" + txtRPCPort.Text);
                bc.Credentials = new NetworkCredential(txtRPCLogin.Text, txtRPCPassword.Text);

                //creates the wallet, returns the name of the wallet
                //which is the name you just gave it.. so really you don't need the variable
                var wow2 = bc.CreateWallet(txtCreateWalletName.Text);

                //get a list of the wallets
                var qqww = bc.ListWallets();

                //clear the listbox to set it up again
                lstWalletList.Items.Clear();

                //go through each wallet and list them in the listbox
                foreach (JValue WalletInfo in qqww)
                {
                    // Access individual address information here
                    string tester = WalletInfo.ToString();
                    lstWalletList.Items.Add(WalletInfo.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstWalletList.SelectedItems.Count > 0)
            {
                txtLoadedWallet.Text = lstWalletList.Items[lstWalletList.SelectedIndex].ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                //set up rpc connection
                BitnetClient bc = new BitnetClient(txtRPCAddress.Text + ":" + txtRPCPort.Text);
                bc.Credentials = new NetworkCredential(txtRPCLogin.Text, txtRPCPassword.Text);

                //list all the wallets
                var qqww = bc.ListWallets();

           
                //clear the listbox because we're gonna fill it up again
                lstWalletList.Items.Clear();

                foreach (JValue WalletInfo in qqww)
                {
                    // Access individual address information here
                    string address = WalletInfo.ToString();
                    lstWalletList.Items.Add(address);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {


                txtaddresslist.Text = "";
                //set up rpc connection
                BitnetClient bc = new BitnetClient(txtRPCAddress.Text + ":" + txtRPCPort.Text);
                bc.Credentials = new NetworkCredential(txtRPCLogin.Text, txtRPCPassword.Text);

                try
                {
                    bc.LoadWallet(txtLoadedWallet.Text);
                }
                catch
                { 
                    //there is alot of reason for error. one reason is that the
                    //wallet was already loaded 
                }

                //list adresses with value (true would list addresses with zero amount)
                var wereaa = bc.ListReceivedByAddress(1, false);

                foreach (JObject addressInfo in wereaa)
                {
                    // Access individual address information here
                    string address = addressInfo["address"].ToString();
                    string account = addressInfo["label"].ToString();

                    //Amount is NOT the balance!!
                    //its the total amount received by the address!, if you send stohn, the value stays! and if you receive more
                    //it goes higher. it's like an ever increasing accumuative total.
                    decimal amount = (decimal)addressInfo["amount"];

                    // Do something with the address information
                    txtaddresslist.Text = txtaddresslist.Text + ($"Address: {address}, Account: {account}, Amount: {amount}") + Environment.NewLine;

                }


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };

        }

        private void btnLoadWallet_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstWalletList.Items.Count > 0)
                {
                    //set up rpc connection
                    BitnetClient bc = new BitnetClient(BuildRPCURL());
                    bc.Credentials = new NetworkCredential(txtRPCLogin.Text, txtRPCPassword.Text);

                    //load the wallet!!
                    bc.LoadWallet(txtWalletToLoad.Text);

                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };
        }

        private void btnUnloadWallet_Click(object sender, EventArgs e)
        {
            try
            {
                //Setup RPC connection
                BitnetClient bc = new BitnetClient(txtRPCAddress.Text + ":" + txtRPCPort.Text);
                bc.Credentials = new NetworkCredential(txtRPCLogin.Text, txtRPCPassword.Text);

                bc.UnLoadWallet(txtLoadedWallet.Text);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
