using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    public enum TransactionSelectionPreference
    {
        Greedy,
        Random,
        Altruistic,
        AddressBased
    }


    class Blockchain
    {
        public List<Block> Blocks;

        public int transactionsPerBlock = 5;
        public static int difficulty = 2; // Starting difficulty, adjust as needed
        public List<Transaction> transactionPool;

        public TransactionSelectionPreference SelectionPreference { get; set; } = TransactionSelectionPreference.Greedy;
        public string PreferredAddress { get; set; } = "";




        public Blockchain()
        {
            Blocks = new List<Block>() {
                new Block()
            };
            transactionPool = new List<Transaction>();
        }

        public String getBlock(int index)
        {
            if (index >= 0 && index < Blocks.Count)
                return Blocks[index].ToString();
            return "Block does not Exist";
        }

        public Block getLastBlock()
        {
            return Blocks[Blocks.Count - 1];
        }

        public List<Transaction> GetPendingTransactions()
        {
            List<Transaction> selectedTransactions = new List<Transaction>();
            switch (SelectionPreference)
            {
                case TransactionSelectionPreference.Greedy:
                    selectedTransactions = transactionPool.OrderByDescending(t => t.fee).Take(transactionsPerBlock).ToList();
                    break;
                case TransactionSelectionPreference.Random:
                    Random rnd = new Random();
                    selectedTransactions = transactionPool.OrderBy(t => rnd.Next()).Take(transactionsPerBlock).ToList();
                    break;
                case TransactionSelectionPreference.Altruistic:
                    selectedTransactions = transactionPool.OrderBy(t => t.timestamp).Take(transactionsPerBlock).ToList();
                    break;
                case TransactionSelectionPreference.AddressBased:
                    selectedTransactions = transactionPool.Where(t => t.senderAddress == PreferredAddress || t.recipientAddress == PreferredAddress).Concat(transactionPool.Except(selectedTransactions)).Take(transactionsPerBlock).ToList();
                    break;
                default:
                    selectedTransactions = transactionPool.Take(transactionsPerBlock).ToList();
                    break;
            }
            transactionPool = transactionPool.Except(selectedTransactions).ToList();
            return selectedTransactions;
        }



        public override string ToString()
        {
            return String.Join("\n", Blocks);
        }

        public double GetBalance(String address)
        {
            double balance = 0.0;
            foreach(Block b in Blocks)
            {
                foreach(Transaction t in b.transactionList)
                {
                    if (t.recipientAddress.Equals(address))
                    {
                        balance += t.amount;
                    }
                    if (t.senderAddress.Equals(address))
                    {
                        balance -= (t.amount + t.fee);
                    }
                }
            }
            return balance;
        }
        
        public bool validateMerkleRoot(Block b)
        {
            String reMerkle = Block.MerkleRoot(b.transactionList);
            return reMerkle.Equals(b.merkleRoot);
        }

        public void AdjustDifficulty()
        {
            const int targetBlockTime = 60; // Target block time in seconds
            const int adjustmentInterval = 10;

            if (Blocks.Count >= adjustmentInterval)
            {
                var recentBlocks = Blocks.Skip(Math.Max(0, Blocks.Count - adjustmentInterval)).Take(adjustmentInterval).ToList();
                var averageMiningTime = recentBlocks.Average(block => block.MiningTimeInSeconds);

                if (averageMiningTime < targetBlockTime)
                {
                    difficulty++;
                }
                else if (averageMiningTime > targetBlockTime)
                {
                    difficulty = Math.Max(difficulty - 1, 1);
                }
            }
        }



    }
}
