namespace DemoSharp
{
    partial class RealChart
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_A = new System.Windows.Forms.Label();
            this.label_B = new System.Windows.Forms.Label();
            this.label_D = new System.Windows.Forms.Label();
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.textBox_D = new System.Windows.Forms.TextBox();
            this.label_F = new System.Windows.Forms.Label();
            this.label_M = new System.Windows.Forms.Label();
            this.label_G = new System.Windows.Forms.Label();
            this.label_H = new System.Windows.Forms.Label();
            this.label_N1 = new System.Windows.Forms.Label();
            this.label_N2 = new System.Windows.Forms.Label();
            this.textBox_F = new System.Windows.Forms.TextBox();
            this.textBox_M = new System.Windows.Forms.TextBox();
            this.textBox_N1 = new System.Windows.Forms.TextBox();
            this.textBox_G = new System.Windows.Forms.TextBox();
            this.textBox_H = new System.Windows.Forms.TextBox();
            this.textBox_N2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_P_MIN = new System.Windows.Forms.TextBox();
            this.textBox_P_MAX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_P_0 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_RESULT = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_N_LIST = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_PRO_LIST = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(903, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(84, 110);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "计算";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // chart1
            // 
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart1.Location = new System.Drawing.Point(12, 212);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(975, 422);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // label_A
            // 
            this.label_A.AutoSize = true;
            this.label_A.Location = new System.Drawing.Point(4, 13);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(71, 12);
            this.label_A.TabIndex = 6;
            this.label_A.Text = "A：套餐费用";
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Location = new System.Drawing.Point(5, 45);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(71, 12);
            this.label_B.TabIndex = 7;
            this.label_B.Text = "B：返还月份";
            // 
            // label_D
            // 
            this.label_D.AutoSize = true;
            this.label_D.Location = new System.Drawing.Point(680, 14);
            this.label_D.Name = "label_D";
            this.label_D.Size = new System.Drawing.Size(71, 12);
            this.label_D.TabIndex = 8;
            this.label_D.Text = "D：刷卡比例";
            // 
            // textBox_A
            // 
            this.textBox_A.Location = new System.Drawing.Point(84, 8);
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.Size = new System.Drawing.Size(67, 21);
            this.textBox_A.TabIndex = 9;
            this.textBox_A.Text = "600";
            // 
            // textBox_B
            // 
            this.textBox_B.Location = new System.Drawing.Point(84, 42);
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.Size = new System.Drawing.Size(67, 21);
            this.textBox_B.TabIndex = 10;
            this.textBox_B.Text = "6";
            // 
            // textBox_D
            // 
            this.textBox_D.Location = new System.Drawing.Point(763, 9);
            this.textBox_D.Name = "textBox_D";
            this.textBox_D.Size = new System.Drawing.Size(67, 21);
            this.textBox_D.TabIndex = 11;
            this.textBox_D.Text = "0.6";
            // 
            // label_F
            // 
            this.label_F.AutoSize = true;
            this.label_F.Location = new System.Drawing.Point(171, 11);
            this.label_F.Name = "label_F";
            this.label_F.Size = new System.Drawing.Size(71, 12);
            this.label_F.TabIndex = 12;
            this.label_F.Text = "F：刷卡成本";
            // 
            // label_M
            // 
            this.label_M.AutoSize = true;
            this.label_M.Location = new System.Drawing.Point(171, 46);
            this.label_M.Name = "label_M";
            this.label_M.Size = new System.Drawing.Size(71, 12);
            this.label_M.TabIndex = 13;
            this.label_M.Text = "M：刷卡利润";
            // 
            // label_G
            // 
            this.label_G.AutoSize = true;
            this.label_G.Location = new System.Drawing.Point(350, 14);
            this.label_G.Name = "label_G";
            this.label_G.Size = new System.Drawing.Size(71, 12);
            this.label_G.TabIndex = 14;
            this.label_G.Text = "G：扫码成本";
            // 
            // label_H
            // 
            this.label_H.AutoSize = true;
            this.label_H.Location = new System.Drawing.Point(350, 46);
            this.label_H.Name = "label_H";
            this.label_H.Size = new System.Drawing.Size(71, 12);
            this.label_H.TabIndex = 15;
            this.label_H.Text = "H：扫码利润";
            // 
            // label_N1
            // 
            this.label_N1.AutoSize = true;
            this.label_N1.Location = new System.Drawing.Point(521, 14);
            this.label_N1.Name = "label_N1";
            this.label_N1.Size = new System.Drawing.Size(71, 12);
            this.label_N1.TabIndex = 16;
            this.label_N1.Text = "N：起始金额";
            // 
            // label_N2
            // 
            this.label_N2.AutoSize = true;
            this.label_N2.Location = new System.Drawing.Point(522, 49);
            this.label_N2.Name = "label_N2";
            this.label_N2.Size = new System.Drawing.Size(71, 12);
            this.label_N2.TabIndex = 17;
            this.label_N2.Text = "N：结束金额";
            // 
            // textBox_F
            // 
            this.textBox_F.Location = new System.Drawing.Point(248, 8);
            this.textBox_F.Name = "textBox_F";
            this.textBox_F.Size = new System.Drawing.Size(65, 21);
            this.textBox_F.TabIndex = 18;
            this.textBox_F.Text = "0.43";
            // 
            // textBox_M
            // 
            this.textBox_M.Location = new System.Drawing.Point(248, 43);
            this.textBox_M.Name = "textBox_M";
            this.textBox_M.Size = new System.Drawing.Size(65, 21);
            this.textBox_M.TabIndex = 19;
            this.textBox_M.Text = "0.17";
            // 
            // textBox_N1
            // 
            this.textBox_N1.Location = new System.Drawing.Point(599, 11);
            this.textBox_N1.Name = "textBox_N1";
            this.textBox_N1.Size = new System.Drawing.Size(69, 21);
            this.textBox_N1.TabIndex = 20;
            this.textBox_N1.Text = "0";
            // 
            // textBox_G
            // 
            this.textBox_G.Location = new System.Drawing.Point(427, 11);
            this.textBox_G.Name = "textBox_G";
            this.textBox_G.Size = new System.Drawing.Size(69, 21);
            this.textBox_G.TabIndex = 21;
            this.textBox_G.Text = "0.23";
            // 
            // textBox_H
            // 
            this.textBox_H.Location = new System.Drawing.Point(427, 43);
            this.textBox_H.Name = "textBox_H";
            this.textBox_H.Size = new System.Drawing.Size(69, 21);
            this.textBox_H.TabIndex = 22;
            this.textBox_H.Text = "0.15";
            // 
            // textBox_N2
            // 
            this.textBox_N2.Location = new System.Drawing.Point(599, 45);
            this.textBox_N2.Name = "textBox_N2";
            this.textBox_N2.Size = new System.Drawing.Size(69, 21);
            this.textBox_N2.TabIndex = 23;
            this.textBox_N2.Text = "200000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 27;
            this.label4.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 28;
            this.label5.Text = "起始金额利润：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(596, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 29;
            this.label6.Text = "结束金额利润：";
            // 
            // textBox_P_MIN
            // 
            this.textBox_P_MIN.Location = new System.Drawing.Point(448, 8);
            this.textBox_P_MIN.Name = "textBox_P_MIN";
            this.textBox_P_MIN.ReadOnly = true;
            this.textBox_P_MIN.Size = new System.Drawing.Size(100, 21);
            this.textBox_P_MIN.TabIndex = 30;
            // 
            // textBox_P_MAX
            // 
            this.textBox_P_MAX.Location = new System.Drawing.Point(691, 8);
            this.textBox_P_MAX.Name = "textBox_P_MAX";
            this.textBox_P_MAX.ReadOnly = true;
            this.textBox_P_MAX.Size = new System.Drawing.Size(100, 21);
            this.textBox_P_MAX.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 32;
            this.label7.Text = "拐点及利润：";
            // 
            // textBox_P_0
            // 
            this.textBox_P_0.Location = new System.Drawing.Point(88, 8);
            this.textBox_P_0.Name = "textBox_P_0";
            this.textBox_P_0.ReadOnly = true;
            this.textBox_P_0.Size = new System.Drawing.Size(219, 21);
            this.textBox_P_0.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox_P_0);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox_P_MAX);
            this.panel1.Controls.Add(this.textBox_P_MIN);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 38);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox_A);
            this.panel2.Controls.Add(this.label_A);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label_B);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label_D);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox_B);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox_D);
            this.panel2.Controls.Add(this.textBox_N2);
            this.panel2.Controls.Add(this.label_F);
            this.panel2.Controls.Add(this.textBox_H);
            this.panel2.Controls.Add(this.label_M);
            this.panel2.Controls.Add(this.textBox_G);
            this.panel2.Controls.Add(this.label_G);
            this.panel2.Controls.Add(this.textBox_N1);
            this.panel2.Controls.Add(this.label_H);
            this.panel2.Controls.Add(this.textBox_M);
            this.panel2.Controls.Add(this.label_N1);
            this.panel2.Controls.Add(this.textBox_F);
            this.panel2.Controls.Add(this.label_N2);
            this.panel2.Location = new System.Drawing.Point(16, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 74);
            this.panel2.TabIndex = 35;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBox_RESULT);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.textBox_N_LIST);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.textBox_PRO_LIST);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(12, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(975, 85);
            this.panel3.TabIndex = 35;
            // 
            // textBox_RESULT
            // 
            this.textBox_RESULT.Location = new System.Drawing.Point(66, 54);
            this.textBox_RESULT.Name = "textBox_RESULT";
            this.textBox_RESULT.ReadOnly = true;
            this.textBox_RESULT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_RESULT.Size = new System.Drawing.Size(893, 21);
            this.textBox_RESULT.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(11, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 16);
            this.label14.TabIndex = 37;
            this.label14.Text = "结果：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(806, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 12);
            this.label13.TabIndex = 28;
            this.label13.Text = "%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(427, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 12);
            this.label12.TabIndex = 36;
            this.label12.Text = "示例：30-30-40";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 12);
            this.label9.TabIndex = 35;
            this.label9.Text = "示例：50000-100000-150000";
            // 
            // textBox_N_LIST
            // 
            this.textBox_N_LIST.Location = new System.Drawing.Point(92, 6);
            this.textBox_N_LIST.Name = "textBox_N_LIST";
            this.textBox_N_LIST.Size = new System.Drawing.Size(297, 21);
            this.textBox_N_LIST.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 32;
            this.label8.Text = "金额列表:";
            // 
            // textBox_PRO_LIST
            // 
            this.textBox_PRO_LIST.Location = new System.Drawing.Point(510, 6);
            this.textBox_PRO_LIST.Name = "textBox_PRO_LIST";
            this.textBox_PRO_LIST.Size = new System.Drawing.Size(290, 21);
            this.textBox_PRO_LIST.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(427, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 28;
            this.label10.Text = "比例分布：";
            // 
            // RealChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 638);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnStart);
            this.Name = "RealChart";
            this.Text = "盈利计算器-刘毅飞 18121292596";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label_A;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.Label label_D;
        private System.Windows.Forms.TextBox textBox_A;
        private System.Windows.Forms.TextBox textBox_B;
        private System.Windows.Forms.TextBox textBox_D;
        private System.Windows.Forms.Label label_F;
        private System.Windows.Forms.Label label_M;
        private System.Windows.Forms.Label label_G;
        private System.Windows.Forms.Label label_H;
        private System.Windows.Forms.Label label_N1;
        private System.Windows.Forms.Label label_N2;
        private System.Windows.Forms.TextBox textBox_F;
        private System.Windows.Forms.TextBox textBox_M;
        private System.Windows.Forms.TextBox textBox_N1;
        private System.Windows.Forms.TextBox textBox_G;
        private System.Windows.Forms.TextBox textBox_H;
        private System.Windows.Forms.TextBox textBox_N2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_P_MIN;
        private System.Windows.Forms.TextBox textBox_P_MAX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_P_0;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_N_LIST;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_PRO_LIST;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_RESULT;
    }
}

