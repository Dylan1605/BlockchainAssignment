using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BlockchainAssignment
{
    class Block
    {
        public int index;
        DateTime timestamp;
        public String hash;
        public String prevHash;


        public List<Transaction> transactionList = new List<Transaction>();
        public String merkleRoot;

        public long nonce = 0;
        public int difficulty = 4;

        public double reward = 1.0;
        public double fees = 0.0;

        public String minerAddress = String.Empty;

        public double MiningTimeInSeconds { get; set; }


        /* Genesis Block Constructor */
        public Block()
        {
            this.index = 0;
            this.timestamp = DateTime.Now;
            this.prevHash = String.Empty;
            this.transactionList = new List<Transaction>();
            this.hash = Mine();
        }

        public Block(int index, String hash)
        {
            this.index = index + 1;
            this.timestamp = DateTime.Now;
            this.prevHash = hash;
            this.hash = Mine();
        }

        public Block(Block block, List<Transaction> transactions, String minerAddress)
        {
            this.index = block.index + 1;
            this.timestamp = DateTime.Now;
            this.prevHash = block.hash;

            this.minerAddress = minerAddress;
            transactions.Add(CreateRewardTransaction(transactions));

            this.transactionList = transactions;
            this.merkleRoot = MerkleRoot(transactions);

            this.hash = Mine();
        }

        public String CreateHash(long enonce)
        {
            SHA256 hasher = SHA256Managed.Create();
            String input = index.ToString() + prevHash + timestamp.ToString() + enonce.ToString() + reward.ToString() + merkleRoot;
            Byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder hash = new StringBuilder();
            foreach (byte x in hashByte)
            {
                hash.Append(x.ToString("x2"));
            }
            return hash.ToString();
        }


        public string Mine()
        {
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;

            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

            string minedHash = String.Empty;
            int successfulNonce = 0;

            int numberOfThreads = 4;

            // Create and start mining tasks
            Task[] miningTasks = new Task[numberOfThreads];
            for (int i = 0; i < numberOfThreads; i++)
            {
                // Each thread will have a unique starting nonce (enonce)
                long enonce = i;
                miningTasks[i] = Task.Run(() =>
                {
                    string hash;
                    do
                    {
                        if (token.IsCancellationRequested)
                        {
                            
                            token.ThrowIfCancellationRequested();
                        }

                        
                        hash = CreateHash(enonce);
                        enonce += numberOfThreads; // Increment by the number of threads to maintain uniqueness
                    }
                    while (!hash.StartsWith(new string('0', difficulty)) && !token.IsCancellationRequested);

                    if (!token.IsCancellationRequested)
                    {
                        lock (this)
                        {
                            if (minedHash == String.Empty) 
                            {
                                minedHash = hash;
                                successfulNonce = (int)enonce;
                                tokenSource.Cancel();
                            }
                        }
                    }
                }, token);
            }
            try
            {
                Task.WaitAny(miningTasks);
            }
            catch (OperationCanceledException) { }

            stopwatch.Stop();
            Console.WriteLine($"Mining took {stopwatch.ElapsedMilliseconds} milliseconds with {numberOfThreads} threads.");
            
            nonce = successfulNonce;
            return minedHash;
        }



        public static String MerkleRoot(List<Transaction> transactionList)
        {
            List<String> hashes = transactionList.Select(t => t.hash).ToList();
            if (hashes.Count == 0)
            {
                return String.Empty;
            }
            if (hashes.Count == 1)
            {
                return hashes[0];
            }
            while (hashes.Count != 1)
            {
                List<String> merkleLeaves = new List<String>();
                for (int i = 0; i < hashes.Count; i += 2)
                {
                    if (i == hashes.Count - 1)
                    {
                        merkleLeaves.Add(HashCode.HashTools.CombineHash(hashes[i], hashes[i]));
                    }
                    else
                    {
                        merkleLeaves.Add(HashCode.HashTools.CombineHash(hashes[i], hashes[i + 1]));
                    }
                }
                hashes = merkleLeaves;
            }

            return hashes[0];
        }

        public Transaction CreateRewardTransaction(List<Transaction> transactions)
        {
            double fees = transactions.Aggregate(0.0, (acc, t) => acc + t.fee);
            return new Transaction("Mine Rewards", minerAddress, (reward + fees), 0, "");
        }

        public override string ToString()
        {
            return "Index: " + index.ToString() +
                "\nTimestamp: " + timestamp.ToString() +
                "\nHash: " + hash +
                "\nPrevious Hash: " + prevHash +
                "\nTransactions: " + String.Join("\n", transactionList) +
                "\nNonce: " + nonce.ToString() +
                "\nDifficulty: " + difficulty.ToString() +
                "\nMerkle Root: " + merkleRoot +
                "\nReward: " + reward.ToString() +
                "\nFees: " + fees.ToString() +
                "\nMiner's Address: " + minerAddress;
               

        }
    }
}
