using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DemoSharp
{
    public partial class RealChart : Form
    {
        private Queue<double> dataQueue = new Queue<double>(100);

        private double a;
        private double b;
        private double r;
        private double d;
        private double e;
        private double f;
        private double m;
        private double g;
        private double h;
        private double n_min;
        private double n_max;

        private double n0;
        private double p0;
        private double p_min;
        private double p_max;

        private double[] proS = new double[10];
        private double[] nS = new double[10];
        private double total = 0;

        public RealChart()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// 计算事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            InitNum();
            n0 = method_1();
            n0 = Math.Round(n0, 3);

            //n0 小于 n_min
            if(n0 <= n_min){
                p_min = method_3(n_min);
                p0 = method_3(n0);
                p_max = method_3(n_max);

            }//n0 大于 n_max
            else if (n0 >= n_max)
            {
                p_min = method_2(n_min);
                p0 = method_2(n0);
                p_max = method_2(n_max);
            }
            else
            {
                p_min = method_2(n_min);
                p0 = method_2(n0);
                p_max = method_3(n_max);
            }

            //保留三位小数
            p_min = Math.Round(p_min, 3);
            p0 = Math.Round(p0, 3);
            p_max = Math.Round(p_max, 3);

            //MessageBox.Show(string.Format("输入数据：n0:{0}\r\n  p0:{1}\r\n n_min:{2}\r\n p_min:{3}\r\n n_max:{4}\r\n p_max:{5}\r\n",n0,p0,n_min,p_min,n_max,p_max));

            this.textBox_P_MIN.Text = p_min.ToString();
            this.textBox_P_MAX.Text = p_max.ToString();
            this.textBox_P_0.Text = "拐点：" + n0.ToString() + ", 利润：" + p0.ToString();

            InitChart();
            UpdateChart();

            string str_n_list = this.textBox_N_LIST.Text;
            if (str_n_list.Length > 0) {
                proList();
            }
            
            
        }

        private void proList() {

            int num = nS.Length;
            double[] resultList = new double[num];

            for (int i = 0; i < num; i++)
            {
                if (nS[i] <= n0)
                {
                    resultList[i] = method_2(nS[i]);
                }
                else {
                    resultList[i] = method_3(nS[i]);
                }
            }

            double oneResult = 0.0;
            for (int i = 0; i < num; i++)
            {
                oneResult += (resultList[i] * proS[i]);
            }

            string str_result = "";
            for (int i = 0; i < num; i++) {
                str_result += ("金额:" + nS[i] + " 占比：" + proS[i]+ " 利润为：" + resultList[i] + "; ");
            }
            
            str_result += "平均利润为" + oneResult;

            this.textBox_RESULT.Text = str_result;

        } 

        //初始化输入数值，判断数值合理
        private void InitNum() {
            string str_a = this.textBox_A.Text;
            string str_b = this.textBox_B.Text;
            string str_d = this.textBox_D.Text;
            string str_f = this.textBox_F.Text;
            string str_m = this.textBox_M.Text;
            string str_g = this.textBox_G.Text;
            string str_h = this.textBox_H.Text;
            string str_n_min = this.textBox_N1.Text;
            string str_n_max = this.textBox_N2.Text;
            string str_n_list = this.textBox_N_LIST.Text;
            string str_pro_list = this.textBox_PRO_LIST.Text;

            try
            {
                a = System.Convert.ToDouble(str_a);
                b = System.Convert.ToDouble(str_b);
                d = System.Convert.ToDouble(str_d);
                f = System.Convert.ToDouble(str_f) / 100;
                m = System.Convert.ToDouble(str_m) / 100;
                g = System.Convert.ToDouble(str_g) / 100;
                h = System.Convert.ToDouble(str_h) / 100;
                n_min = System.Convert.ToDouble(str_n_min);
                n_max = System.Convert.ToDouble(str_n_max);

                if(str_n_list.Length > 0){
                    string[] pro_list = str_pro_list.Split('-');
                    string[] n_list = str_n_list.Split('-');

                    if (pro_list.Length != n_list.Length) {
                        MessageBox.Show(string.Format("异常：输入参数有误，金额列表与概率列表参数数量不相等"));
                        this.Close();
                    }

                    int num = pro_list.Length;

                    proS = new double[num];
                    nS = new double[num];
                    total = 0;

                    for (int i = 0; i < num; i++)
                    {
                        try
                        {
                            total += System.Convert.ToDouble(pro_list[i]);
                            // total += System.Convert.ToDouble(pro_list[i]);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(string.Format("平均金额参数异常：输入参数有误，请检查" + ex.Message));
                            this.Close();
                        }
                    }

                    for (int i = 0; i < num; i++) {
                        try {
                            double tmp = System.Convert.ToDouble(pro_list[i]) / total;
                            proS[i] = Math.Round(tmp, 3);
                           // total += System.Convert.ToDouble(pro_list[i]);
                            nS[i] = System.Convert.ToDouble(n_list[i]);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(string.Format("平均金额参数异常：输入参数有误，请检查" + ex.Message));
                            this.Close();
                        }
                    }

                    //if (total != 100)
                    //{
                    //    MessageBox.Show("占比总和不为100%");
                    //    this.Close();
                   // }
                }

                r = a / b;
                e = 1 - d;

                //MessageBox.Show(string.Format("输入数据：a:{0}\r\n  b：{1}\r\n  d：{2}\r\n f：{3}\r\n  m：{4}\r\n g：{5}\r\n  h：{6}\r\n  n1：{7}\r\n  n2：{8}\r\n", a, b, d, f, m, g,h,n_min,n_max));

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("异常：输入参数有误，参数需要为数字，且不能省略。B大于0，D范围为0-1"
                     + ex.Message));
                this.Close();
            }
        }

        //公式1 N0 = R/(D*(F+M)+E*(G+H))
        private double method_1(){
            return r / (d * (f + m) + e * (g + h));
        }

        //公式2 P=R-2*N*(D*F+E*G)
        private double method_2(double n)
        {
            //return r - 2 * n * (d * f + e * g);
            return r -  n * (d * f + e * g);
        }

        //公式3 P=R-2*（n0）*（D*F+E*G）+（N-n0)）*(D*M+E*H)
        private double method_3(double n)
        {
            //return r - 2 * n0 * (d * f + e * g) + (n - n0) * (d * m + e * h);
            return r -  n0 * (d * f + e * g) + (n - n0) * (d * m + e * h);
        }

         //更新队列中的值
        private void UpdateChart() {

            //n0 小于 n_min
            if (n0 <= n_min)
            {
                this.chart1.Series[0].Points.AddXY(n_min, p_min);
                this.chart1.Series[0].Points.AddXY(n_max, p_max);
            }//n0 大于 n_max
            else if (n0 >= n_max)
            {
                this.chart1.Series[0].Points.AddXY(n_min, p_min);
                this.chart1.Series[0].Points.AddXY(n_max, p_max);
            }
            else
            {
                this.chart1.Series[0].Points.AddXY(n_min, p_min);
                this.chart1.Series[0].Points.AddXY(n0, p0);
                this.chart1.Series[0].Points.AddXY(n_max, p_max);
            }
        }

        private double Max3(double a, double b, double c) {
            double maxValue = a;
            if (maxValue < b)
            {
                maxValue = b;
            }
            if (maxValue < c)
            {
                maxValue = c;
            }
            return maxValue;
        }

        private double Min3(double a, double b, double c)
        {
            double minValue = a;
            minValue = Math.Min(minValue, b);
            minValue = Math.Min(minValue, c);
            return minValue;
        }
        
        /// <summary>
        /// 初始化图表
        /// </summary>
        private void InitChart()
        {
            //定义图表区域
            this.chart1.ChartAreas.Clear();
            ChartArea chartArea1 = new ChartArea("C1");
            this.chart1.ChartAreas.Add(chartArea1);
            //定义存储和显示点的容器
            this.chart1.Series.Clear();
            Series series1 = new Series("S1");
            series1.ChartArea = "C1";
            this.chart1.Series.Add(series1);
            //设置图表显示样式

            this.chart1.ChartAreas[0].AxisY.Minimum = Min3(p0, p_min, p_max);
            this.chart1.ChartAreas[0].AxisY.Maximum = Max3(p0, p_min, p_max);
            this.chart1.ChartAreas[0].AxisY.Interval = (Max3(p0, p_min, p_max) - Min3(p0, p_min, p_max)) / 10;
            this.chart1.ChartAreas[0].AxisY.Title = "利润";

            this.chart1.ChartAreas[0].AxisX.Minimum = 0;
            this.chart1.ChartAreas[0].AxisX.Maximum = n_max;
            this.chart1.ChartAreas[0].AxisX.Interval = Math.Ceiling(n_max / 10);
            this.chart1.ChartAreas[0].AxisX.Title = "刷卡金额";

            this.chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            this.chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            //设置标题
            this.chart1.Titles.Clear();
            this.chart1.Titles.Add("S01");
            this.chart1.Titles[0].Text = "XXX显示";
            this.chart1.Titles[0].ForeColor = Color.RoyalBlue;
            this.chart1.Titles[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            //设置图表显示样式
            this.chart1.Series[0].Color = Color.Red;
            //线条粗细
            chart1.Series[0].BorderWidth = 2;
            //标记点边框颜色      
            chart1.Series[0].MarkerBorderColor = Color.Blue;
            //标记点边框大小
            chart1.Series[0].MarkerBorderWidth = 2;
            //标记点中心颜色
            chart1.Series[0].MarkerColor = Color.White;//AxisColor
            //标记点大小
            chart1.Series[0].MarkerSize = 4;
            //标记点类型     
            chart1.Series[0].MarkerStyle = MarkerStyle.Circle;

            this.chart1.Titles[0].Text = "利润趋势图";
            this.chart1.Series[0].ChartType = SeriesChartType.Line;

            this.chart1.Series[0].Points.Clear();
        }
    }
}
