using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoRPN
{
    public partial class Form1 : Form
    {
        Stack<BinaryTreeNode> nodeStack = new Stack<BinaryTreeNode>(1000);
        Stack<BinaryTreeNode> operatorStack = new Stack<BinaryTreeNode>(1000);
        string[] x = new string[26];
        string[] y = new string[26];
        int i = 0;
        int j = 0;
        string[] _token = new string[10000];
        public Form1()
        {
            InitializeComponent();
        }
        private void Form_Load(object sender, EventArgs e)
        {

        }
        void xoapt(string[] List, int pos)
        {
            for (int n = pos; n < List.Count() - 1; n++)
                List[n] = List[n + 1];
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            string str = txtInfixExpression.Text;
            for (int n = 0; n < i; n++)
            {
                if (Token.IsNumber(y[n]))
                    str = str.Replace(x[n], y[n]);
                else str = str.Replace(x[n], "(" + y[n] + ")");
            }
            Parser k = new Parser(str);
            k.LRN(k.InfixToExpessionTree());
            lblResult.Text = k.KQ.ToString();
            lblPRN.Text = k.PRN.ToString();
            _token = k.token;
            int dem = 0;
            for (int n = 0; n < k.strn; n++)
            {
                ListViewItem item = new ListViewItem();
                if (dem > _token.Count() - 1)
                {
                    item.Text = "";
                }
                else if (Token.IsOperator(_token[dem]))
                {
                    if ((dem == 0) || (dem > 0 && _token[dem - 1] == "("))
                    {
                        if (Token.IsNumber(_token[dem + 1]))
                        {
                            item.Text = _token[dem] + _token[dem + 1];
                            dem++;
                        }
                    }
                    else item.Text = _token[dem];
                }
                else item.Text = _token[dem];
                dem++;
                listView1.Items.Add(item);
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, k.StrOpS[n]);
                item.SubItems.Add(subitem);
                subitem = new ListViewItem.ListViewSubItem(item, k.StrNodeS[n]);
                item.SubItems.Add(subitem);
            }
        }

        private void btnGan_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            string str = txtInfixExpression.Text;
            if (Token.IsLetter(str))
            {
                x[i] = str;
                i++;
                txtInfixExpression.Clear();
            }
            else
            {
                int dem;
                int check = 0;
                for (dem = 0; dem < i - 1; dem++)
                    if (i != 1 && x[i - 1] == x[dem])
                    {
                        check = 1;
                        break;
                    }
                if (check == 1)
                {
                    y[j] = txtInfixExpression.Text;
                    listView2.Items.RemoveAt(dem);
                    item.Text = x[dem];
                    listView2.Items.Add(item);
                    ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, y[j]);
                    item.SubItems.Add(subitem);
                    xoapt(x, dem);
                    xoapt(y, dem);
                    i--;
                }
                else
                {
                    y[j] = txtInfixExpression.Text;
                    item.Text = x[i - 1];
                    listView2.Items.Add(item);
                    ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, y[j]);
                    item.SubItems.Add(subitem);
                    j++;
                }
                txtInfixExpression.Clear();
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            i = 0;
            j = 0;
            listView1.Clear();
            listView2.Clear();
        }
    }
}
