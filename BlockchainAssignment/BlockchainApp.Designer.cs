namespace BlockchainAssignment
{
    partial class BlockchainApp
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.publicKey = new System.Windows.Forms.TextBox();
            this.privateKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.TextBox();
            this.fee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.receiver = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.validateChain = new System.Windows.Forms.Button();
            this.checkBalance = new System.Windows.Forms.Button();
            this.btnGreedy = new System.Windows.Forms.Button();
            this.btnAltruistic = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnAddressBased = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.Location = new System.Drawing.Point(18, 18);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(984, 481);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 526);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Print Block";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 526);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 26);
            this.textBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(849, 511);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 66);
            this.button2.TabIndex = 3;
            this.button2.Text = "Generate Wallet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // publicKey
            // 
            this.publicKey.Location = new System.Drawing.Point(602, 511);
            this.publicKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.publicKey.Name = "publicKey";
            this.publicKey.Size = new System.Drawing.Size(236, 26);
            this.publicKey.TabIndex = 4;
            // 
            // privateKey
            // 
            this.privateKey.Location = new System.Drawing.Point(602, 546);
            this.privateKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.privateKey.Name = "privateKey";
            this.privateKey.Size = new System.Drawing.Size(236, 26);
            this.privateKey.TabIndex = 5;
            this.privateKey.TextChanged += new System.EventHandler(this.privateKey_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 515);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Public Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 557);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Private Key";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(849, 586);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 35);
            this.button3.TabIndex = 8;
            this.button3.Text = "Validate Keys";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 683);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 66);
            this.button4.TabIndex = 9;
            this.button4.Text = "Create Transaction";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(240, 665);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(76, 26);
            this.amount.TabIndex = 10;
            // 
            // fee
            // 
            this.fee.Location = new System.Drawing.Point(240, 706);
            this.fee.Name = "fee";
            this.fee.Size = new System.Drawing.Size(76, 26);
            this.fee.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 666);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 706);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 700);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Receiver Key";
            // 
            // receiver
            // 
            this.receiver.Location = new System.Drawing.Point(501, 700);
            this.receiver.Name = "receiver";
            this.receiver.Size = new System.Drawing.Size(358, 26);
            this.receiver.TabIndex = 15;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(20, 617);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 58);
            this.button5.TabIndex = 16;
            this.button5.Text = "Generate New Block";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // validateChain
            // 
            this.validateChain.Location = new System.Drawing.Point(848, 633);
            this.validateChain.Name = "validateChain";
            this.validateChain.Size = new System.Drawing.Size(162, 32);
            this.validateChain.TabIndex = 17;
            this.validateChain.Text = "Validate Chain";
            this.validateChain.UseVisualStyleBackColor = true;
            this.validateChain.Click += new System.EventHandler(this.validateChain_Click);
            // 
            // checkBalance
            // 
            this.checkBalance.Location = new System.Drawing.Point(654, 586);
            this.checkBalance.Name = "checkBalance";
            this.checkBalance.Size = new System.Drawing.Size(155, 31);
            this.checkBalance.TabIndex = 18;
            this.checkBalance.Text = "Check Balance";
            this.checkBalance.UseVisualStyleBackColor = true;
            this.checkBalance.Click += new System.EventHandler(this.checkBalance_Click);
            // 
            // btnGreedy
            // 
            this.btnGreedy.Location = new System.Drawing.Point(1021, 240);
            this.btnGreedy.Name = "btnGreedy";
            this.btnGreedy.Size = new System.Drawing.Size(113, 51);
            this.btnGreedy.TabIndex = 19;
            this.btnGreedy.Text = "Greedy";
            this.btnGreedy.UseVisualStyleBackColor = true;
            this.btnGreedy.Click += new System.EventHandler(this.btnGreedy_Click);
            // 
            // btnAltruistic
            // 
            this.btnAltruistic.Location = new System.Drawing.Point(1021, 297);
            this.btnAltruistic.Name = "btnAltruistic";
            this.btnAltruistic.Size = new System.Drawing.Size(113, 54);
            this.btnAltruistic.TabIndex = 20;
            this.btnAltruistic.Text = "Altruistic";
            this.btnAltruistic.UseVisualStyleBackColor = true;
            this.btnAltruistic.Click += new System.EventHandler(this.btnAltruistic_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(1021, 357);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(113, 51);
            this.btnRandom.TabIndex = 21;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnAddressBased
            // 
            this.btnAddressBased.Location = new System.Drawing.Point(1021, 414);
            this.btnAddressBased.Name = "btnAddressBased";
            this.btnAddressBased.Size = new System.Drawing.Size(113, 57);
            this.btnAddressBased.TabIndex = 22;
            this.btnAddressBased.Text = "Address based";
            this.btnAddressBased.UseVisualStyleBackColor = true;
            this.btnAddressBased.Click += new System.EventHandler(this.btnAddressBased_Click);
            // 
            // BlockchainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1160, 771);
            this.Controls.Add(this.btnAddressBased);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnAltruistic);
            this.Controls.Add(this.btnGreedy);
            this.Controls.Add(this.checkBalance);
            this.Controls.Add(this.validateChain);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.receiver);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fee);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.privateKey);
            this.Controls.Add(this.publicKey);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BlockchainApp";
            this.Text = "Blockchain App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox publicKey;
        private System.Windows.Forms.TextBox privateKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.TextBox fee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox receiver;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button validateChain;
        private System.Windows.Forms.Button checkBalance;
        private System.Windows.Forms.Button btnGreedy;
        private System.Windows.Forms.Button btnAltruistic;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnAddressBased;
    }
}

