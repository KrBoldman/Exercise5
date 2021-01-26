using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_5
{
    public partial class PlayfairCipher : Form
    {
        //All instances of j are made to be i, the table has to be square for the cipher to work.
        static char[] alphabet = new char[]
            { 'A', 'B', 'C', 'D', 'E',
            'F', 'G', 'H', 'I', 'K',
            'L', 'M', 'N', 'O', 'P',
            'Q', 'R', 'S', 'T', 'U',
            'V', 'W', 'X', 'Y', 'Z' };

        public PlayfairCipher()
        {
            InitializeComponent();
        }

        private void keywordTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void keywordLabel_Click(object sender, EventArgs e)
        {

        }

        public static char[,] fill2DArray(char[] oneD)
        {
            int count = 0;
            char[,] temp = new char[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    temp[i, j] = oneD[count];
                    count++;
                }
            }
            return temp;
        }

        public static char[,] createMatrix(string keyword)
        {
            string realKeyword = removeDuplicates(keyword).ToUpper();
            char[] matrix1D = new char[25];

            for (int i = 0; i < realKeyword.Length; i++)
            {
                if (realKeyword[i] == 'J')
                    matrix1D[i] = 'I';
                else
                    matrix1D[i] = realKeyword[i];
            }
            int count = realKeyword.Length;
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (realKeyword.IndexOf(alphabet[i]) == -1)
                {
                    matrix1D[count] = alphabet[i];
                    count++;
                }
            }
            return fill2DArray(matrix1D);
        }

        public static string removeDuplicates(string word)
        {
            string temp = "";
            string wordConvert = "";
            for(int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'j')
                    wordConvert += 'i';

                else
                    wordConvert += word[i];
            }
            for (int i = 0; i < wordConvert.Length; i++)
            {
                if (wordConvert[i] == ' ')
                    i++;

                bool alreadyPresent = false;
                for (int j = 0; j < i; j++)
                {
                    if (wordConvert[j] == word[i])
                        alreadyPresent = true;
                }

                if (!alreadyPresent)
                    temp += wordConvert[i];
            }
            return temp;
        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            if (inputTxtBox.Text != "" && keywordTxtBox.Text != "")
            {
                char[,] matrix = createMatrix(keywordTxtBox.Text);
                outputTxtBox.Text = convertText(matrix, inputTxtBox.Text);
            }
            else
            {
                MessageBox.Show("Invalid Inputs. Keyword and Input Text fields must not be blank.");
            }

        }
        public string convertText(char[,] matrix, string input)
        {
            input = input.ToUpper();
            string temp = "";
            char curr = ' ';
            for (int i = 0; i < input.Length; i++)
            {
                curr = input[i];
                for (int j = 0; j < 5; j++)
                {
                    for (int x = 0; x < 5; x++)
                    {
                        if (input[i] == 'J')
                        {
                            if ('I' == matrix[j, x])
                                curr = matrix[x, j];
                        }
                        else if (input[i] == matrix[j, x])
                            curr = matrix[x, j];
                    }
                }
                temp += curr;
            }
            return temp;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            outputTxtBox.Text = "";
            inputTxtBox.Text = "";
            keywordTxtBox.Text = "";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
