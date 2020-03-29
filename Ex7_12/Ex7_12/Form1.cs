using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex7_12
{
    public partial class Form1 : Form
    {

        Graphics g;
        Point pStart, pEnd;     	// 定义画图的起始终点
        int ChoiceGraph;        	// 所选择图形枚举
        int penWidth;           	// 画笔宽度
        enum mySelected
        {
            Pencil,          	// 铅笔
            Line,            	// 直线
            Ellipse,         	// 空心椭圆
            FillEllipse,       	// 填充椭圆
            Rec,             	// 空心矩形
            FillRec,         	// 填充矩形
            Eraser          	// 橡皮擦
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                  g = this.pictureBox1.CreateGraphics();         ChoiceGraph = (int)mySelected.Pencil;    		// 默认选择为铅笔工具         penWidth = 3;          	 			// 初始化画笔宽度          btnControl.BackColor = btnBlack.BackColor;  	// 默认黑色笔
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnControl_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //把所有按钮的背景色都设为 White
            btnLine1.BackColor = Color.White;
            btnLine2.BackColor = Color.White;
            btnLine3.BackColor = Color.White;
            btnLine4.BackColor = Color.White;
            btnLine5.BackColor = Color.White;
            ((Button)sender).BackColor = Color.Black;          // 选中的按钮背景色为黑色
            penWidth = Convert.ToInt32(((Button)sender).Tag);   // 将宽度按钮的 Tag 值设为画笔宽度
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //把所有按钮的背景色都设为 White
            btnLine1.BackColor = Color.White;
            btnLine2.BackColor = Color.White;
            btnLine3.BackColor = Color.White;
            btnLine4.BackColor = Color.White;
            btnLine5.BackColor = Color.White;
            ((Button)sender).BackColor = Color.Black;          // 选中的按钮背景色为黑色
            penWidth = Convert.ToInt32(((Button)sender).Tag);   // 将宽度按钮的 Tag 值设为画笔宽度
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //把所有按钮的背景色都设为 White
            btnLine1.BackColor = Color.White;
            btnLine2.BackColor = Color.White;
            btnLine3.BackColor = Color.White;
            btnLine4.BackColor = Color.White;
            btnLine5.BackColor = Color.White;
            ((Button)sender).BackColor = Color.Black;          // 选中的按钮背景色为黑色
            penWidth = Convert.ToInt32(((Button)sender).Tag);   // 将宽度按钮的 Tag 值设为画笔宽度
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //把所有按钮的背景色都设为 White
            btnLine1.BackColor = Color.White;
            btnLine2.BackColor = Color.White;
            btnLine3.BackColor = Color.White;
            btnLine4.BackColor = Color.White;
            btnLine5.BackColor = Color.White;
            ((Button)sender).BackColor = Color.Black;          // 选中的按钮背景色为黑色
            penWidth = Convert.ToInt32(((Button)sender).Tag);   // 将宽度按钮的 Tag 值设为画笔宽度
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //把所有按钮的背景色都设为 White
            btnLine1.BackColor = Color.White;
            btnLine2.BackColor = Color.White;
            btnLine3.BackColor = Color.White;
            btnLine4.BackColor = Color.White;
            btnLine5.BackColor = Color.White;
            ((Button)sender).BackColor = Color.Black;          // 选中的按钮背景色为黑色
            penWidth = Convert.ToInt32(((Button)sender).Tag);   // 将宽度按钮的 Tag 值设为画笔宽度
        }

        private void btnControl_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnControl_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btnControl_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
