using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockchainAssignment
{
    public partial class BlockchainApp : Form
    {
        Blockchain blockchain;

        public BlockchainApp()
        {
            InitializeComponent();
            blockchain = new Blockchain();
            richTextBox1.Text = "New Blockchain Initialised!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBox1.Text, out int index))
                richTextBox1.Text = blockchain.getBlock(index);
            else
                richTextBox1.Text = "Not a number";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String privKey;
            Wallet.Wallet myNewWallet = new Wallet.Wallet(out privKey);
            publicKey.Text = myNewWallet.publicID;
            this.privateKey.Text = privKey;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Wallet.Wallet.ValidatePrivateKey(privateKey.Text, publicKey.Text))
            {
                richTextBox1.Text = "Keys are valid";
            }
            else
            {
                richTextBox1.Text = "Keys are invalid";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Transaction newTransaction = new Transaction(publicKey.Text, receiver.Text, Double.Parse(amount.Text), Double.Parse(fee.Text), privateKey.Text);
            blockchain.transactionPool.Add(newTransaction);
            richTextBox1.Text = newTransaction.ToString();
        }

        private void privateKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Block newBlock = new Block(blockchain.getLastBlock(), blockchain.GetPendingTransactions(), publicKey.Text);
            blockchain.Blocks.Add(newBlock);
            blockchain.AdjustDifficulty(); 
            richTextBox1.Text = newBlock.ToString();
        }




        private void checkBalance_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = blockchain.GetBalance(publicKey.Text).ToString() + " Assignment Coin";
            
        }

        private void validateChain_Click(object sender, EventArgs e)
        {
            //Contiguity Checks
            bool valid = true;

            if(blockchain.Blocks.Count == 1)
            {
                if (!blockchain.validateMerkleRoot(blockchain.Blocks[0]))
                {
                    richTextBox1.Text = "Blockchain is invalid";

                }
                else
                {
                    richTextBox1.Text = "Blockchain is valid";
                }
                return;
            }
            for (int i=1; i<blockchain.Blocks.Count - 1; i++)
            {
                if (blockchain.Blocks[i].prevHash != blockchain.Blocks[i - 1].hash || !blockchain.validateMerkleRoot(blockchain.Blocks[i]))
                {
                    richTextBox1.Text = "Blockchain is invalid";
                    return;
                }
            }

            if (valid)
            {
                richTextBox1.Text = "Blockchain is valid";
            }
            else
            {
                richTextBox1.Text = "Blockchain is invalid";
            }
        }

        private void btnGreedy_Click(object sender, EventArgs e)
        {
            blockchain.SelectionPreference = TransactionSelectionPreference.Greedy;
            MessageBox.Show("Greedy preference selected: Highest fees first.");
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            blockchain.SelectionPreference = TransactionSelectionPreference.Random;
            MessageBox.Show("Random preference selected.");
        }

        private void btnAltruistic_Click(object sender, EventArgs e)
        {
            blockchain.SelectionPreference = TransactionSelectionPreference.Altruistic;
            MessageBox.Show("Altruistic preference selected: Oldest first.");
        }

        private void btnAddressBased_Click(object sender, EventArgs e)
        {
           
            blockchain.SelectionPreference = TransactionSelectionPreference.AddressBased;
            MessageBox.Show("Preferred address prioritized");
        }

    }
}
