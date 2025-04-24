using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MorseDecoder;

namespace MorseDecoder
{
    public partial class Form1 : Form
    {
        private Dictionary<char, string> morseCode;
        private Dictionary<string, char> reverseMorseCode;
        private bool isPlaying = false;
        private SoundPlayer dotPlayer;
        private SoundPlayer dashPlayer;

        private string RemoveDiacritics(string text)
        {
            string normalized = text.Normalize(NormalizationForm.FormD);
            return new string(normalized
                .Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                .ToArray());
        }

        public Form1()
        {
            InitializeComponent();
            btnConvert.Left = (tabPageEncode.ClientSize.Width - btnConvert.Width) / 2;
            int gap = 20;
            int totalWidth = btnPlay.Width + gap + btnStop.Width;

            int startX = (tabPageEncode.ClientSize.Width - totalWidth) / 2;

            btnPlay.Left = startX;
            btnStop.Left = startX + btnPlay.Width + gap;

            btnConvertDe.Left = (tabPageDecode.ClientSize.Width - btnConvertDe.Width) / 2;


            morseCode = MorseLibrary.MorseCode;
            reverseMorseCode = morseCode.ToDictionary(pair => pair.Value, pair => pair.Key);
            dotPlayer = new SoundPlayer("dot.wav");
            dashPlayer = new SoundPlayer("dash.wav");

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            labelWarning.Text = "";
            StringBuilder result = new StringBuilder();
            string inputText = RemoveDiacritics(textInput.Text);
            inputText = inputText.ToUpper();

            List<char> unknownChars = new List<char>();

            for (int i = 0; i < inputText.Length; i++)
            {
                if (morseCode.ContainsKey(inputText[i]))
                {
                    result.Append(morseCode[inputText[i]]);
                } else
                {
                    result.Append(" ");
                    unknownChars.Add(inputText[i]);
                }
                result.Append(" ");
            }
            textOutput.Text = result.ToString();

            if (unknownChars.Count > 0)
            {
                string unknown = string.Join(", ", unknownChars.Distinct().Select(ch => $"\"{ch}\""));
                labelWarning.Text = $"Výchozí text obsahuje neznámé symboly: {unknown}";
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            isPlaying = true;

            Task.Run(() =>
            {
                string outputText = textOutput.Text;

                for (int i = 0; i < outputText.Length; i++)
                {
                    if (!isPlaying)
                        break;

                    char c = outputText[i];

                    switch (c)
                    {
                        case '.':
                            if (!isPlaying)
                                break;
                            dotPlayer.PlaySync();
                            break;
                        case '-':
                            if (!isPlaying)
                                break;
                            dashPlayer.PlaySync();
                            break;
                        case ' ':
                            Thread.Sleep(100);
                            break;
                        case '/':
                            Thread.Sleep(300);
                            break;
                    }
                }
            });
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            isPlaying = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string message = "Morseovka, Verze 1.0\nSemestrální práce AK2TP 2025\nBy M D";
            const string caption = "O programu";
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnConvertDe_Click(object sender, EventArgs e)
        {
            labelWarningDecode.Text = "";
            StringBuilder result = new StringBuilder();
            string inputText = textInputDe.Text;
            string[] words = inputText.Split('/');

            List<string> unknownString = new List<string>();

            int wordCounter = 0;
            foreach (string word in words)
            {
                string[] letters = word.Split(' ');

                foreach (string letter in letters)
                {
                    if (reverseMorseCode.ContainsKey(letter))
                    {
                        result.Append(reverseMorseCode[letter]);
                    }
                    else
                    {
                        result.Append('?');
                        unknownString.Add(letter);
                    }
                }

                wordCounter++;
                if (wordCounter < words.Length)
                {
                    result.Append(' ');
                }
            }
            textOutputDe.Text = result.ToString();

            if (unknownString.Count > 0)
            {
                string unknown = string.Join(", ", unknownString.Distinct().Select(str => $"\"{str}\""));
                labelWarningDecode.Text = $"Výchozí text obsahuje neznámé symboly: {unknown}";
            }
        }

        private void tabPageDecode_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageEncode)
            {
                textInput.Text = "";
                textOutput.Text = "";
                labelWarning.Text = "";
            }
            else if (tabControl1.SelectedTab == tabPageDecode)
            {
                textInputDe.Text = "";
                textOutputDe.Text = "";
                labelWarningDecode.Text = "";
            }
        }
    }
}
