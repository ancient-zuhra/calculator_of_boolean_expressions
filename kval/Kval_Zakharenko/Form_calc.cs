using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kval_Zakharenko
{
    public partial class Калькулятор : Form
    {
        Закони frmzak = new Закони();
        Elektroschemes elektro = new Elektroschemes();
        public Калькулятор()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            button_disagr.Text = Encoding.UTF8.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes("\u00AC")));
            buttton_conun.Text = Encoding.UTF8.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes("\u2227")));
            button_disun.Text= Encoding.UTF8.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes("\u2228")));
            button_impl.Text = Encoding.UTF8.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes("\u21D2")));
        }      
        string destodv(int a)
        {
            string ans = "";
            while (a != 0)
            {
                ans += (a % 2).ToString();
                a /= 2;

            }
            return ans;
        }
        string con = Encoding.UTF8.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes("\u2227")));
        string disun = Encoding.UTF8.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes("\u2228")));
        string impl = Encoding.UTF8.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes("\u21D2"))); 
            string equal = "↔";
        string disagr = Encoding.UTF8.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes("\u00AC")));

        bool is_log_op(char a)
        {
                     string c = a.ToString();
            if (c == con) return true;
            if (c == disun) return true;
            if (c == equal) return true; if (c == disagr) return true;
            if (c == impl) return true;
            return false;
        }

        int colzminn = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            colzminn = 0;
            string vir = textBox_main.Text;
            string con = Encoding.UTF8.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes("\u2227")));
            string disun = Encoding.UTF8.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes("\u2228")));
            string impl = Encoding.UTF8.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes("\u21D2"))); ;
            string equal = "↔";
            string disagr = Encoding.UTF8.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes("\u00AC")));
            int colotkskob = 0, colzakskob = 0;
            for (int i = 0; i < vir.Length; i++)
            {
                if (vir[i] == '(')
                {
                    colotkskob++;
                }
                if (vir[i] == ')')
                {
                    colzakskob++;
                }
            }
            if (vir.Contains("AB") || vir.Contains("AA") || vir.Contains("AC") || vir.Contains("AD") || vir.Contains("BA") || vir.Contains("BB") || vir.Contains("BC") ||
                vir.Contains("BD") || vir.Contains("CA") || vir.Contains("CB") || vir.Contains("CC") || vir.Contains("CD") || vir.Contains("DD") || vir.Contains("DA") ||
                vir.Contains("DB") || vir.Contains("DC") || vir.Contains("A(") || vir.Contains("B(") || vir.Contains("C(") || vir.Contains("D(") || vir.Contains(con + con)
                || vir.Contains(con + disun) || vir.Contains(con + impl) || vir.Contains(con + equal) || vir.Contains(disun + con) || vir.Contains(disun + disun) ||
                vir.Contains(disun + impl) || vir.Contains(disun + equal) || vir.Contains(impl + con) || vir.Contains(impl + disun) || vir.Contains(impl + impl) || vir.Contains(impl + equal) ||
                vir.Contains(equal + con) || vir.Contains(equal + disun) || vir.Contains(equal + impl) || vir.Contains(equal + equal) || vir.Contains(equal + ")") || vir.Contains(con + ")") 
                || vir.Contains(disun + ")")|| vir.Contains(impl + ")") || vir.Contains("(" + equal) || vir.Contains("(" + con)
                || vir.Contains("(" + disun) || vir.Contains("(" + impl)|| vir.Contains("A"+disagr)|| vir.Contains("B" + disagr)||vir.Contains("C" + disagr)|| vir.Contains("D" + disagr))
            {
                MessageBox.Show("Syntax error (clearing textbox)");
                dataGridView1.Rows.Clear();
                textBox_main.Clear(); dataGridView1.ColumnCount = 0; button_B.Enabled = false;
                button_C.Enabled = false;
                button_D.Enabled = false;
                return;
                //проверка на правильность синтаксиса

            }
            else
            {
                if ((colotkskob != colzakskob))
                {
                MessageBox.Show("Неправильная скобочная последовательность!");
                    dataGridView1.Rows.Clear();
                    dataGridView1.ColumnCount = 0;
                    return;
                }
            else
           {
               {
                    if (textBox_main.Text.Contains("A"))
                    {
                         colzminn++;
                    }
                    if (textBox_main.Text.Contains("B"))
                    {
                        colzminn++;
                    }
                    if (textBox_main.Text.Contains("C"))
                    {
                       colzminn++;
                    }
                    if (textBox_main.Text.Contains("D"))
                    {
                    colzminn++;
                    }
                    if (((colzminn == 3) || (colzminn == 4)) && ((colzakskob == 0) || (colotkskob == 0)))
                    {
                        MessageBox.Show("Неправильная скобочная последовательность!");
                        dataGridView1.Rows.Clear();
                        dataGridView1.ColumnCount = 0;
                        return;
                   }
                   else
                    {
                            dataGridView1.RowCount = (int)Math.Pow((double)2, (double)colzminn);
                            int zn = (int)Math.Pow((double)2, (double)colzminn);
                            dataGridView1.ColumnCount = colzminn;
                            string[] names = { "A", "B", "C", "D" };
                            for (int i = 0; i < colzminn; i++)
                            {
                                dataGridView1.Columns[i].HeaderText = names[i];
                            }
                            for (int i = 0; i < zn; i++)
                            {
                                for (int j = 0; j < colzminn; j++)
                                {

                                    if (i == 0)
                                    {
                                        dataGridView1.Rows[i].Cells[j].Value = 0;
                                    }

                                }
                            }
                            for (int i = 0; i < zn; i++)
                            {

                                string cur = destodv(zn - i - 1);
                                for (int j = 0; j < colzminn; j++)
                                {
                                    dataGridView1.Rows[i].Cells[j].Value = j < cur.Length ? cur[j] - '0' : 0;
                                }

                            }


                            char[] a = new char[textBox_main.Text.Length];
                            for (int i = 0; i < textBox_main.Text.Length; i++)
                            {
                                a[i] = textBox_main.Text[i];
                            }

                            Stack<char> ans = new Stack<char>();
                            string[] log_op = { con, disun, impl, equal, disagr };
                            int colskob = 1, dd = 0;
                            for (int i = 0; i < textBox_main.Text.Length; i++)
                            {
                                if (textBox_main.Text[i] == '(')
                                {
                                    colskob++;
                                }
                                if (textBox_main.Text[i].ToString() == disagr) ++dd;
                            }
                            //MessageBox.Show(dataGridView1.ColumnCount.ToString());
                            dataGridView1.ColumnCount = colskob + colzminn + dd;
                            Stack<int> q = new Stack<int>();
                            int k = 1;
                            for (int i = 0; i < textBox_main.Text.Length; i++)
                            {
                                if (textBox_main.Text[i] == '(')
                                    q.Push(i);
                                else if (textBox_main.Text[i] == ')')
                                {
                                    int newcolstolb1 = colzminn + k;
                                    if (newcolstolb1 != dataGridView1.ColumnCount)                                     
                                        dataGridView1.Columns[newcolstolb1 - 1].HeaderText = textBox_main.Text.Substring(q.First() + 1, i - q.First() - 1);
                                    q.Pop();
                                    ++k;
                                }
                                if (textBox_main.Text[i].ToString() == disagr)
                                {
                                    q.Push(i);
                                }
                                else if (q.Count() > 0 && textBox_main.Text[q.First()].ToString() == disagr)
                                {
                                    int newcolstolb1 = colzminn + k;
                                    if (newcolstolb1 != dataGridView1.ColumnCount)
                                        dataGridView1.Columns[newcolstolb1 - 1].HeaderText = textBox_main.Text.Substring(q.First(), i - q.First() + 1);
                                    q.Pop();
                                    ++k;
                                }
                            }
                            for (int num = 0; num < zn; num++)
                            {
                                k = 1;
                                string S = "("; string stitle = "";
                                for (int i = 0; i < textBox_main.Text.Length; i++)
                                {
                                    stitle += textBox_main.Text[i];
                                    if (textBox_main.Text[i] >= 'A' && textBox_main.Text[i] <= 'D')
                                    {                                                                                                      
                                        S += dataGridView1.Rows[num].Cells[textBox_main.Text[i] - 'A'].Value;
                                    }
                                    else S += textBox_main.Text[i];
                                }
                                S += ")";
                                // MessageBox.Show(S);
                                for (int i = 0; i < S.Length; i++)
                                {
                                    if (S[i] != ')')
                                    {
                                        ans.Push(S[i]);
                                    }
                                    else
                                    {
                                        char c = ans.First();
                                        string sum1 = "";
                                        while (c != '(')
                                        {
                                            sum1 += c;
                                            ans.Pop();
                                            c = ans.First();
                                        }
                                        string sum = "";
                                        for (int l = sum1.Count() - 1; l >= 0; l--)
                                        {
                                            sum += sum1[l];
                                        }
                                        ans.Pop();
                                        //MessageBox.Show(sum);
                                        Stack<string> last = new Stack<string>();
                                        char cur = '0';
                                        for (int j = 0; j < sum.Length; j++)
                                        {
                                            if (is_log_op(sum[j]) == true)
                                            {
                                                last.Push(sum[j].ToString());
                                            }
                                            else
                                            {

                                                char ch = sum[j];
                                                while (last.Count != 0)
                                                {
                                                    string op1 = last.First();
                                                    if (op1 != disagr) break;
                                                    last.Pop();
                                                    if (ch == '1')
                                                    {
                                                        ch = '0';
                                                    }
                                                    else
                                                    {
                                                        ch = '1';
                                                    }
                                                    int newcolstolb2 = colzminn + k;
                                                    dataGridView1.Rows[num].Cells[newcolstolb2 - 1].Value = ch;
                                                    ++k;
                                                }
                                                string op = "";
                                                if (last.Count == 0) {
                                                    cur = ch;
                                                }
                                                else
                                                {
                                                    op = last.First();
                                                    last.Pop();
                                                }
                                                if (op == con)
                                                {
                                                    if (cur == ch && cur == '1')
                                                    {
                                                        cur = '1';
                                                    }
                                                    else
                                                    {
                                                        cur = '0';
                                                    }
                                                }

                                                if (op == disun)
                                                {
                                                    if (cur == ch && cur == '0')
                                                    {
                                                        cur = '0';
                                                    }
                                                    else
                                                    {
                                                        cur = '1';
                                                    }
                                                }
                                                if (op == impl)
                                                {
                                                    if (cur == '1' && ch == '0')
                                                    {
                                                        cur = '0';
                                                    }
                                                    else cur = '1';

                                                }
                                                if (op == equal)
                                                {
                                                    if (cur == ch)
                                                    {
                                                        cur = '1';
                                                    }
                                                    else cur = '0';
                                                }

                                            }
                                        }
                                        //MessageBox.Show(cur.ToString());
                                        int newcolstolb1 = colzminn + k;
                                        ans.Push(cur.ToString()[0]);
                                        dataGridView1.Rows[num].Cells[newcolstolb1 - 1].Value = cur;
                                        ++k;
                                    }
                                }
                                // MessageBox.Show(ans.First().ToString());
                                ans.Pop();

                            }
                            int newcolstolb = dataGridView1.ColumnCount - 1;
                            if (dataGridView1.Columns[dataGridView1.ColumnCount - 2].HeaderText == dataGridView1.Columns[dataGridView1.ColumnCount - 1].HeaderText)
                            {
                                dataGridView1.Columns.Remove(dataGridView1.Columns[newcolstolb-1]);
                                dataGridView1.ColumnCount--;
                            }
                            
                            dataGridView1.Columns[newcolstolb].DefaultCellStyle.ForeColor = Color.Red;                     
                            dataGridView1.Columns[newcolstolb].HeaderText = textBox_main.Text;
                            label2.Text = colzminn.ToString();
                        }
               }
        }
    }
  //
}

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_main.Text += Encoding.UTF8.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes("\u2227"))); ;
        }
        int[] used = new int[4];
        private void button_A_Click(object sender, EventArgs e)
        {
            textBox_main.Text += "A";
          
        }

        private void button_B_Click(object sender, EventArgs e)
        {
            textBox_main.Text += "B";
           
        }
       
        private void button_C_Click(object sender, EventArgs e)
        {
           
            textBox_main.Text += "C";
           
         
        }

        private void button_D_Click(object sender, EventArgs e)
        {
            textBox_main.Text += "D";
            
            
        }

        private void button_disun_Click(object sender, EventArgs e)
        {
            textBox_main.Text += Encoding.UTF8.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes("\u2228")));
        }

        private void button_impl_Click(object sender, EventArgs e)
        {
            textBox_main.Text += Encoding.UTF8.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes("\u21D2")));
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            textBox_main.Text += "↔";
        }

        private void button_disagr_Click(object sender, EventArgs e)
        {
            textBox_main.Text += Encoding.UTF8.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes("\u00AC"))); 
        }

        private void button_levskobka_Click(object sender, EventArgs e)
        {
            textBox_main.Text += "(";
        }

        private void button_pravskobka_Click(object sender, EventArgs e)
        {
            textBox_main.Text += ")";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox_main.Text = "";
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 0;
            button_B.Enabled = false;
            button_C.Enabled = false;
            button_D.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox_main.Text != "")
            {
                textBox_main.Text = textBox_main.Text.Remove(((int)(textBox_main.Text.Length) - 1), 1);
            }
            else return;
            
        }

        private void textBox_main_TextChanged(object sender, EventArgs e)
        {
            if (textBox_main.Text.Contains("A"))
            {
                button_B.Enabled = true;
            }
            if (textBox_main.Text.Contains("A") && textBox_main.Text.Contains("B"))
            {
                button_C.Enabled = true;
            }
            if (textBox_main.Text.Contains("A") && textBox_main.Text.Contains("B") && textBox_main.Text.Contains("C"))
            {
                button_D.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            frmzak.StartPosition = FormStartPosition.CenterScreen;
            frmzak.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            elektro.StartPosition = FormStartPosition.CenterScreen;
            elektro.Show();
        }
    }
}
