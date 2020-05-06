using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Windows.Forms;

namespace bitmapCso
{
    public partial class Form1 : Form
    {
        private static readonly int COLUMN = 16; // 欄
        private static readonly int ROW = 16; // 列
        public Form1()
        {
            InitializeComponent();
        }


        private int startX = 0; // 畫板起始X
        private int startY = 0; // 畫板起始Y

        private readonly Size btnSize = new Size(30, 30); // 畫板每格大小

        private readonly int column = COLUMN; // 欄
        private readonly int row = ROW; // 列

        private Button[,] btnArray = new Button[COLUMN, ROW]; // 按鈕陣列 

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("yutinglia 製作");
            Create_Button();
        }

        private void Create_Button()
        {
            int currX = startX;
            int currY = startY;
            for (int row = 0; row < this.row; row++)
            {
                for (int column = 0; column < this.column; column++)
                {
                    btnArray[column, row] = new Button();
                    btnArray[column, row].Size = btnSize;
                    btnArray[column, row].Location = new Point(currX, currY);
                    btnArray[column, row].BackColor = Color.FromArgb(0, 0, 0, 0);
                    btnArray[column, row].FlatStyle = FlatStyle.Flat;
                    btnArray[column, row].Tag = "0,0,0,0";
                    Controls.Add(btnArray[column, row]);
                    btnArray[column, row].Click += Bitmap_Btn_Click;
                    currX += btnSize.Width - 2;
                }
                currX = startX;
                currY += btnSize.Height - 2;
            }
            // 調整控制板位置
            Height = currY + btnSize.Height + 1;
            panControl.Left = startX + btnSize.Width * ( column - 1 );
        }

        private void Bitmap_Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if ( rdbChColor.Checked)
            {
                int r = Convert.ToInt32(numR.Value);
                int g = Convert.ToInt32(numG.Value);
                int b = Convert.ToInt32(numB.Value);
                int a = Convert.ToInt32(numA.Value);

                string rStr = numR.Value.ToString();
                string gStr = numG.Value.ToString();
                string bStr = numB.Value.ToString();
                string aStr = numA.Value.ToString();

                btn.BackColor = Color.FromArgb(a, r, g, b);
                btn.Tag = rStr + "," + gStr + "," + bStr + "," + aStr;
            }
            if (rdbCheck.Checked)
            {
                Color color = btn.BackColor;
                lblCheckR.Text = "R : " + color.R.ToString();
                lblCheckG.Text = "G : " + color.G.ToString();
                lblCheckB.Text = "B : " + color.B.ToString();
                lblCheckA.Text = "A : " + color.A.ToString();
                lblCheckTag.Text = "Tag : " + btn.Tag.ToString();
            }
            if (rdbClean.Checked)
            {
                btn.BackColor = Color.FromArgb(0, 0, 0, 0);
                btn.Tag = "0,0,0,0";
            }
        }

        private void RGB_ValueChanged(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(numR.Value);
            int g = Convert.ToInt32(numG.Value);
            int b = Convert.ToInt32(numB.Value);
            int a = Convert.ToInt32(numA.Value);

            panColor.BackColor = Color.FromArgb(a,r,g,b);
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            OutputToLua();
            MessageBox.Show("輸出完成");
        }

        private void OutputToLua()
        {
            using (StreamWriter sw = new StreamWriter(txtName.Text + ".lua"))
            {
                sw.WriteLine(txtName.Text + " = {}");
                sw.WriteLine(txtName.Text + ".__index = " + txtName.Text);
                // 輸出顏色編碼
                sw.WriteLine("local line = {}");
                for (int row = 0; row < this.row; row++)
                {
                    sw.Write("line[" + (row + 1) + "] = \"");
                    for (int column = 0; column < this.column; column++)
                    {
                        sw.Write(btnArray[column, row].Tag.ToString() + "/");
                    }
                    sw.Write("\"");
                    sw.WriteLine();
                }
                // 輸出code
                sw.WriteLine("");
                sw.WriteLine("function split(s, p)");
                sw.WriteLine("    local rt= {}");
                sw.WriteLine("    string.gsub(s, '[^'..p..']+', function(w) table.insert(rt, w) end )");
                sw.WriteLine("    return rt");
                sw.WriteLine("end");
                sw.WriteLine("function " + txtName.Text + ".Create(x,y,w,h,l)");
                sw.WriteLine("    local bitBox = {}");
                sw.WriteLine("    for i = 1, 16 do");
                sw.WriteLine("        bitBox[i] = {}");
                sw.WriteLine("        for j = 1, 16 do");
                sw.WriteLine("            bitBox[i][j] = 0");
                sw.WriteLine("        end");
                sw.WriteLine("    end");
                sw.WriteLine("    startX = tonumber(x)");
                sw.WriteLine("    startY = tonumber(y)");
                sw.WriteLine("    currX = tonumber(startX)");
                sw.WriteLine("    currY = tonumber(startY)");
                sw.WriteLine("    boxWidth = tonumber(w)");
                sw.WriteLine("    boxHeight = tonumber(h)");
                sw.WriteLine("    m = 1");
                sw.WriteLine("    if l == 1 then");
                sw.WriteLine("        m = -1");
                sw.WriteLine("    end");
                sw.WriteLine("    for i = 1,16 do");
                sw.WriteLine("        colorArray = split(line[i],'/')");
                sw.WriteLine("        for j = 1,16 do");
                sw.WriteLine("            colorArray2 = split(colorArray[j],',')");
                sw.WriteLine("            colorR = tonumber(colorArray2[1])");
                sw.WriteLine("            colorG = tonumber(colorArray2[2])");
                sw.WriteLine("            colorB = tonumber(colorArray2[3])");
                sw.WriteLine("            colorA = tonumber(colorArray2[4])");
                sw.WriteLine("            if colorA ~= 0 then");
                sw.WriteLine("                bitBox[i][j] = UI.Box.Create()");
                sw.WriteLine("                bitBox[i][j]:Set({x=currX,y=currY,width=boxWidth,height=boxHeight,r=colorR,g=colorG,b=colorB,a=colorA})");
                sw.WriteLine("            end");
                sw.WriteLine("            currX = currX + boxWidth - m");
                sw.WriteLine("        end");
                sw.WriteLine("        currX = startX");
                sw.WriteLine("        currY = currY + boxHeight - m ");
                sw.WriteLine("    end");
                sw.WriteLine("    local self = setmetatable(bitBox, " + txtName.Text + ")");
                sw.WriteLine("    return self");
                sw.WriteLine("end");
                sw.WriteLine("function " + txtName.Text + ":Set(x,y,w,h,l)");
                sw.WriteLine("    startX = tonumber(x)");
                sw.WriteLine("    startY = tonumber(y)");
                sw.WriteLine("    currX = tonumber(startX)");
                sw.WriteLine("    currY = tonumber(startY)");
                sw.WriteLine("    boxWidth = tonumber(w)");
                sw.WriteLine("    boxHeight = tonumber(h)");
                sw.WriteLine("    m = 1");
                sw.WriteLine("    if l == 1 then");
                sw.WriteLine("        m = -1");
                sw.WriteLine("    end");
                sw.WriteLine("    for i = 1,16 do");
                sw.WriteLine("        for j = 1,16 do");
                sw.WriteLine("            if self[i][j] ~= 0 then");
                sw.WriteLine("                self[i][j]:Set({x=currX,y=currY,width=boxWidth,height=boxHeight})");
                sw.WriteLine("            end");
                sw.WriteLine("            currX = currX + boxWidth - m");
                sw.WriteLine("        end");
                sw.WriteLine("        currX = startX");
                sw.WriteLine("        currY = currY + boxHeight - m ");
                sw.WriteLine("    end");
                sw.WriteLine("end");
                sw.WriteLine("function " + txtName.Text + ":Show()");
                sw.WriteLine("    for i = 1,16 do");
                sw.WriteLine("        for j = 1,16 do");
                sw.WriteLine("            if self[i][j] ~= 0 then");
                sw.WriteLine("                self[i][j]:Show()");
                sw.WriteLine("            end");
                sw.WriteLine("        end");
                sw.WriteLine("    end");
                sw.WriteLine("end");
                sw.WriteLine("function " + txtName.Text + ":Hide()");
                sw.WriteLine("    for i = 1,16 do");
                sw.WriteLine("        for j = 1,16 do");
                sw.WriteLine("            if self[i][j] ~= 0 then");
                sw.WriteLine("                self[i][j]:Hide()");
                sw.WriteLine("            end");
                sw.WriteLine("        end");
                sw.WriteLine("    end");
                sw.WriteLine("end");
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("確認清除畫板?", "Sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                for (int row = 0; row < this.row; row++)
                {
                    for (int column = 0; column < this.column; column++)
                    {
                        btnArray[column, row].BackColor = Color.FromArgb(0, 0, 0, 0);
                        btnArray[column, row].Tag = "0,0,0,0";
                    }
                }
            }
        }
    }
}
