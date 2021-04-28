using System;

namespace DNA
{
    class Program
    {
        static bool IsValidSequence(string halfDNASequence)
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;

        }
        static string ReplicateSeqeunce(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }
        static void Main(string[] args)
        {
            bool Newcreo = false;
            

            while(true)
                {
                string DNA;
                Console.Write("input DNA : ");
                DNA = Console.ReadLine();
                if (IsValidSequence(DNA) == true)
                {
                    Console.WriteLine("Current half DNA sequence : {0}", DNA);
                    while (true)
                    {
                        Console.Write("Do you want to replicate it ? (Y / N) : ");
                        string replicate = Console.ReadLine();
                        if (replicate == "Y")
                        {
                            Console.WriteLine("Current half DNA sequence:" + ReplicateSeqeunce(DNA));
                            break;
                        }
                        else if (replicate == "N")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please input Y or N.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("That half DNA sequence is invalid.");
                }
                while (true)
                {
                    Console.Write("Do you want to process another sequence ? (Y/N) : ");
                    string ans = Console.ReadLine();
                    if (ans == "Y")
                    {
                        break;
                    }
                    else if (ans == "N")
                    {
                        Newcreo = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please Input Y or N.");
                    }
                }
                if (Newcreo == true)
                {
                    break;
                }

            }
        }

    }
}
