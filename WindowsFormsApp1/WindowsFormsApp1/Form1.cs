using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text.Trim();

            format(text);

        }


        public static bool Compare<ICompare>(ICompare left, string operators, ICompare right) where ICompare : IComparable
        {
            switch (operators)
            {
                case "==": return left.CompareTo(right) == 0;
                case "!=": return left.CompareTo(right) != 0;
                case ">" : return left.CompareTo(right) > 0;
                case ">=": return left.CompareTo(right) >= 0;
                case "<" : return left.CompareTo(right) < 0;
                case "<=": return left.CompareTo(right) <= 0;
                default  : throw new ArgumentException("Invalid comparison operator: {0}", operators);
            }
        }

        public void format(string str)
        {
            string[] line =  str.Split('\n');

            string text = string.Empty;

            text = line[0].Replace("If", string.Empty).Replace("Then", string.Empty).Trim();

            string split = string.Empty;
            if (text.Contains("AND"))
            {
                split = "AND";
            }
            else if (text.Contains("OR"))
            {
                split = "OR";
            }

            int index = text.IndexOf("AND");
            Console.WriteLine(text.Substring(index));

            string[] arr = text.Split(new string[] { split }, StringSplitOptions.None);

        }




    }
}
