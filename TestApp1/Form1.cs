using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegex_Click(object sender, EventArgs e)
        {
            string input = this.txtInput.Text;
            string pattern = this.txtPattern.Text;
            Regex reg = new Regex(pattern);           
            //foreach(Group g in groups)
            //    System.Diagnostics.Debug.WriteLine(g.Value.ToString().Trim());
            foreach (Match match in reg.Matches(input))
            {
                GroupCollection groups = match.Groups;
                input = input.Replace(groups[0].Value, groups[2].Value + ";");
            }
            this.txtResults.Text = input;
            // System.Diagnostics.Debug.WriteLine("Replaced = " + input);
            System.Diagnostics.Debug.WriteLine("done");
        }
    }
}
