using System;
using System.IO;
using System.Text;

namespace Slot12
{
    class Program
    {
        private static string FILE_NAME = @"MyFile.txt";
        private static string TEXT = "ABCDEFGHIKLMNOPQRSTVXYZ" +
                            "abcdefghiklmnopqrstvxys" +
                            "0123456789" +
                            "!@#$%^&*";

        private static Random random = new Random();
        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
                int option = GetInt(0, 3, "Enter your option");
                switch (option)
                {
                    case 1:
                        DemoFileStream();
                        break;
                    case 2:
                        DemoFileClass();
                        break;
                    case 3:
                        DemoStreamReaderAndWriter();
                        break;
                    case 4:
                        DemoBinaryReaderAndWriter();
                        break;
                    case 0:
                        return;
                }
            }

        }

        public static void Menu()
        {
            Console.WriteLine("1. Demo File Stream");
            Console.WriteLine("2. Demo File Class");
            Console.WriteLine("3. Demo Stream Reader & Writer");
            Console.WriteLine("4. Demo Binary Reader & Writer");
        }

        public static int GetInt(int min, int max, string message)
        {
            Console.Write($"{message}: ");
            while (true)
            {
                try
                {
                    int option = Convert.ToInt32(Console.ReadLine());
                    if (option < min || option > max)
                    {
                        throw new Exception($"Option must in range {min} - {max}");
                    }
                    return option;
                }
                catch (FormatException)
                {
                    Console.WriteLine("You have enterd wrong format!");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}");
                    Console.Write("Please enter again your option");
                }
            }
        }

        public static void DemoBinaryReaderAndWriter()
        {
            Console.WriteLine("4. Demo Binary Reader And Writer");
            FileInfo fi = new FileInfo(FILE_NAME);

            using BinaryWriter bw = new BinaryWriter(fi.OpenWrite());
            Console.WriteLine($"Base stream is {bw.BaseStream}");

            bw.Write(100);
            bw.Write(100.99);
            bw.Write("Lam");

            bw.Close();
            Console.WriteLine("File was created");

            using BinaryReader br = new BinaryReader(fi.OpenRead());
            Console.WriteLine(br.ReadDouble());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadString());
            Console.WriteLine();
        }

        public static void DemoStreamReaderAndWriter()
        {
            Console.WriteLine("3. Demo Stream Writer & Reader");

            using StreamWriter writer = new StreamWriter(FILE_NAME);

            for (int i = 0; i < 10; i++)
            {
                string password = "";
                for (int j = 0; j < 8; j++)
                {
                    password += TEXT[random.Next(TEXT.Length)];
                }
                writer.WriteLine($"Password {i + 1}: {password}");

            }
            writer.Close();


            string ouput = null;
            using StreamReader sr = new StreamReader(FILE_NAME);
            while ((ouput = sr.ReadLine()) != null)
            {
                Console.WriteLine(ouput);
            }
            sr.Close();
            Console.WriteLine();



        }

        public static void DemoFileStream()
        {
            Console.WriteLine("1. Demo File Stream");
            // Create new file
            using FileStream fs = File.Open("file.dat", FileMode.Create);

            // Original message
            string message = "My name is Lam";

            // Covert message to byte array
            byte[] messageAsByteArray = Encoding.Default.GetBytes(message);

            // Write encoded byte array to file
            int length = messageAsByteArray.Length;
            fs.Write(messageAsByteArray, 0, length);

            // Reset internal position of  
            fs.Position = 0;

            // create new bytes array to store bytes get from file
            byte[] bytesFromFile = new byte[length];

            Console.WriteLine("Byte from file: ");

            // Iterate through bytes in filestream
            for (int i = 0; i < length; i++)
            {
                byte b = (byte)fs.ReadByte();
                bytesFromFile[i] = b;
                Console.Write($"{bytesFromFile[i],5}");
            }

            // 
            Console.Write("\nDecoded Message: ");
            Console.WriteLine(Encoding.Default.GetString(bytesFromFile));
            Console.WriteLine();
        }

        public static void DemoFileClass()
        {
            Console.WriteLine("2. Demo File Class");



            Random random = new Random();

            if (!File.Exists(FILE_NAME))
            {
                using StreamWriter sw = File.CreateText(FILE_NAME);
                for (int i = 0; i < 10; i++)
                {
                    string password = "";
                    for (int j = 0; j < 8; j++)
                    {
                        password += TEXT[random.Next(TEXT.Length)];
                    }
                    sw.WriteLine($"Password {i + 1}: {password}");

                }

            }

            using StreamReader sr = File.OpenText(FILE_NAME);
            string s;

            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }

    }
}
