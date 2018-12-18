using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltraReplacer.Core.Factories;

namespace UltraReplacer.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            foreach (var replacement in ReplaceOptionsFactory.GetInstance().GetOptions().Replacements)
            {
                richTextBoxMainText.Text = richTextBoxMainText.Text.Replace(replacement.OriginalText, replacement.ReplacementText);
            }
        }
    }
}
