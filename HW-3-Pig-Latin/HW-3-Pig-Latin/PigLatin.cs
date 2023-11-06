using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_3_Pig_Latin
{
    public partial class PigLatin : Form
    {
        public PigLatin()
        {
            InitializeComponent();
        }

        private void btnPig_Click(object sender, EventArgs e)
        {
            string text = InTextBox.Text;
            if (text.Trim() == "")
            {
                MessageBox.Show("Please enter some text.", "Input Error");
                InTextBox.Focus();
            }
            else
            {
                OutText.Text = translate(text);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter text into the first speech bubble. Then click the pig to translate it to pig latin!", "Help");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            InTextBox.Clear();
            OutText.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string translate(string text)
        {
            
            StringBuilder sb = new StringBuilder();

            string[] words = text.Split(' ');
            foreach (string word in words) 
            {
                sb.Append(translate_Word(word) + " ");
            }

            return sb.ToString();
        }

        private string translate_Word(string word)
        {
            string t_word = "";

            ArrayList vowels = new ArrayList() { 'a', 'e', 'i', 'u', 'o', 'A', 'E', 'I', 'U', 'O' };

            if (vowels.Contains(word[0]))
            {
                t_word = word + "way";
                return t_word;
            }

            if (isConsonat(word[0]))
            {
                StringBuilder cons = new StringBuilder();
                int count = 0;

                foreach (char ch in word)
                {
                    if (isNumOrSymbol(ch))
                    {
                        //Don’t translate words that contain numbers or symbols. For example, 123 should be left as 123, and bill@microsoft.com should be left as bill@microsoft.com.
                        return word;
                    }

                    if (count == 1)
                    {
                        //If a word starts with the letter Y, the Y should be treated as a consonant. If the Y appears anywhere else in the word, it should be treated as a vowel.
                        vowels.Add('y');
                        vowels.Add('Y');
                    }

                    if (vowels.Contains(ch))
                    {
                        //loop until first vowel
                        return word.Substring(count, word.Length - count) + cons.ToString() + "ay";
                    }

                    else 
                    {
                        cons.Append(ch);
                    }

                    count++;
                }
            }

            return t_word;
        }

        private bool isConsonat(char c)
        {
            if ((c >= 65 && c <= 90) || (c >= 97 && c <= 122))
            {
                return true;
            }

            return false;
        }

        private bool isNumOrSymbol(char c)
        //ascii table https://www.asciitable.com/
        {
            if ((c >= 33 && c <= 64) || (c >= 91 && c <= 96 ))
            {
                return true;
            }

            return false;
        }


    }
}
