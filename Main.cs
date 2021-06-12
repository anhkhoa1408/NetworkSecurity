using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace NETWORK_SECURITY_APP
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public static char Ceasar_Check(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }
            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }

        public static string Ceasar_Encrypt(string input, int key)
        {
            string output = string.Empty;
            foreach (char ch in input)
                output += Ceasar_Check(ch, key);
            return output;
        }

        public static string Ceasar_Decrypt(string text, int shift)
        {
            char[] characters = text.ToCharArray();
            for (int i = 0; i < characters.Length; i++)
            {
                char c = characters[i];
                char letter = Char.ToLower(characters[i]);
                if (char.IsLetter(letter))
                {
                    letter = (char)(letter - shift);
                    if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    else if (letter < 'a')
                    {
                        letter = (char)(letter + 26);
                    }

                    if (char.IsLower(c))
                        characters[i] = letter;
                    else
                        characters[i] = Char.ToUpper(letter);
                }
            }
            return new string(characters);
        }

        public static string[] Ceasar_Bruteforce(string text)
        {
            string[] arr = new string[26];
            int index = 0;
            string text_temp = text.ToLower();
            var characterCount = new Dictionary<char, int>();
            foreach (char c in text_temp)
            {
                if (characterCount.ContainsKey(c))
                    characterCount[c]++;
                else
                    characterCount[c] = 1;
            }

            foreach (KeyValuePair<char, int> pair in characterCount.OrderByDescending(i => i.Value))
            {
                int shift = 0;
                char c = pair.Key;

                if (char.IsLetter(c))
                {
                    while (c != 'e')
                    {
                        c--;
                        shift++;
                        if (c > 'z')
                        {
                            c = (char)(c - 26);
                        }
                        else if (c < 'a')
                        {
                            c = (char)(c + 26);
                        }
                    }
                    if (c == 'e')
                    {
                        arr[index] += "Key is " + shift.ToString();
                        arr[index] += System.Environment.NewLine;
                        arr[index] += System.Environment.NewLine;
                        string decrypted = Ceasar_Decrypt(text, shift);
                        arr[index] += decrypted;
                    }
                }
                if (index < 25)
                    index++;
            }
            arr = arr.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            return arr;
        }


        public static char[][] BuildCleanMatrix(int rows, int cols)
        {
            char[][] result = new char[rows][];

            for (int row = 0; row < result.Length; row++)
            {
                result[row] = new char[cols];
            }

            return result;
        }

        public static string BuildStringFromMatrix(char[][] matrix)
        {
            string result = string.Empty;

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] != '\0')
                    {
                        result += matrix[row][col];
                    }
                }
            }
            return result;
        }

        public static string RailFence_Encrypt(string clearText, int key)
        {
            string result = string.Empty;

            char[][] matrix = BuildCleanMatrix(key, clearText.Length);

            int rowIncrement = 1;
            for (int row = 0, col = 0; col < matrix[row].Length; col++)
            {
                if (row + rowIncrement == matrix.Length || row + rowIncrement == -1)
                {
                    rowIncrement *= -1;
                }

                matrix[row][col] = clearText[col];

                row += rowIncrement;
            }

            result = BuildStringFromMatrix(matrix);

            return result;
        }

        public static String RailFence_Decrypt(String text, int key)
        {
            char[,] rail = new char[key, text.Length];
            for (int i = 0; i < key; i++)
                for (int j = 0; j < text.Length; j++)
                    rail[i, j] = '_';

            bool dir_down = true;
            int row = 0, col = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (row == 0)
                    dir_down = true;
                if (row == key - 1)
                    dir_down = false;

                rail[row, col++] = '*';
                if (dir_down)
                {
                    row += 1;
                }
                else
                {
                    row -= 1;
                }
            }


            int index = 0;
            for (int i = 0; i < key; i++)
                for (int j = 0; j < text.Length; j++)
                    if (rail[i, j] == '*' && index < text.Length)
                        rail[i, j] = text[index++];



            string result = "";

            row = 0;
            col = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (row == 0)
                    dir_down = true;
                if (row == key - 1)
                    dir_down = false;

                if (rail[row, col] != '*')
                    result += rail[row, col++].ToString();

                if (dir_down)
                {
                    row += 1;
                }
                else
                {
                    row -= 1;
                }
            }
            return result;
        }

        public static string[] RailFence_Loop(string text)
        {
            string[] result = new string[text.Length - 2];
            for (int z = 2; z < text.Length; z++)
            {
                int key = z;
                result[z - 2] = "Key is " + key.ToString();
                result[z - 2] += System.Environment.NewLine;
                result[z - 2] += System.Environment.NewLine;
                result[z - 2] += RailFence_Decrypt(text, key);
                
            }
            return result;
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (techniqueBox.Text == "")
            {
                string message = "You must choose encryption technique";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                techniqueBox.Focus();
                return;
            }
            if (keyBox.Text == "")
            {
                string message = "You must enter key";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                keyBox.Focus();
                return;
            }

            if (!int.TryParse(keyBox.Text, out int n))
            {
                string message = "You must enter key as number";
                string title = "Invalid key";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                keyBox.Focus();
                return;
            }

            if (Int32.Parse(keyBox.Text) < 0)
            {
                string message = "You must enter key greater than or equal to 0";
                string title = "Invalid key";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                keyBox.Focus();
                return;
            }

            if (inputEncryptBox.Text == "")
            {
                string message = "You must enter text";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                inputEncryptBox.Focus();
                return;
            }

            if (techniqueBox.Text == "Ceasar")
            {
                string result = Ceasar_Encrypt(inputEncryptBox.Text, Int32.Parse(keyBox.Text));
                string title = "Result";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(result, title, buttons);
                System.IO.File.WriteAllText(path + @"\result.txt", result);
            }
            else if (techniqueBox.Text == "Rail Fence")
            {
                string message = "";
                string title = "";
                MessageBoxButtons buttons;
                if (Int32.Parse(keyBox.Text) < 2)
                {
                    message = "You must choose key greater than or equal to 2";
                    title = "Invalid key";
                    buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                    techniqueBox.Focus();
                    return;
                }
                string result = RailFence_Encrypt(inputEncryptBox.Text, Int32.Parse(keyBox.Text));
                title = "Result";
                buttons = MessageBoxButtons.OK;
                MessageBox.Show(result, title, buttons);
                System.IO.File.WriteAllText(path + @"\result.txt", result);
            }
            else if (techniqueBox.Text == "Combine")
            {
                string message = "";
                string title = "";
                MessageBoxButtons buttons;
                if (Int32.Parse(keyBox.Text) < 2)
                {
                    message = "You must choose key greater than or equal to 2";
                    title = "Invalid key";
                    buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                    techniqueBox.Focus();
                    return;
                }
                string firstResult = Ceasar_Encrypt(inputEncryptBox.Text, Int32.Parse(keyBox.Text));
                string finalResult = RailFence_Encrypt(firstResult, Int32.Parse(keyBox.Text));
                title = "Result";
                buttons = MessageBoxButtons.OK;
                MessageBox.Show(finalResult, title, buttons);
                System.IO.File.WriteAllText(path + @"\result.txt", finalResult);
            }

        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            if (inputDecryptBox.Text == "")
            {
                string message = "You must enter text";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                inputEncryptBox.Focus();
                return;
            }
            if (decryptTechnique.Text == "Ceasar")
            {
                string[] str = Ceasar_Bruteforce(inputDecryptBox.Text);
                Output output = new Output(str);
                output.Show();
            }
            else if (decryptTechnique.Text == "Rail Fence")
            {
                string[] result = RailFence_Loop(inputDecryptBox.Text);
                Output output = new Output(result);
                output.Show();
            }    
        }
    }
}
