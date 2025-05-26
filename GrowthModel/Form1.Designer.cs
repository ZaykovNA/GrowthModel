namespace GrowthModelWinForms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonCompute = new System.Windows.Forms.Button();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.textBoxX0 = new System.Windows.Forms.TextBox();
            this.textBoxt0 = new System.Windows.Forms.TextBox();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxMethod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCompute
            // 
            this.buttonCompute.Location = new System.Drawing.Point(115, 390);
            this.buttonCompute.Name = "buttonCompute";
            this.buttonCompute.Size = new System.Drawing.Size(102, 23);
            this.buttonCompute.TabIndex = 0;
            this.buttonCompute.Text = "Вычислить";
            this.buttonCompute.UseVisualStyleBackColor = true;
            this.buttonCompute.Click += new System.EventHandler(this.buttonCompute_Click);
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(227, 28);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(100, 22);
            this.textBoxR.TabIndex = 1;
            this.textBoxR.Text = "0.5";
            this.textBoxR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(227, 65);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(100, 22);
            this.textBoxK.TabIndex = 2;
            this.textBoxK.Text = "100";
            this.textBoxK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxX0
            // 
            this.textBoxX0.Location = new System.Drawing.Point(227, 102);
            this.textBoxX0.Name = "textBoxX0";
            this.textBoxX0.Size = new System.Drawing.Size(100, 22);
            this.textBoxX0.TabIndex = 3;
            this.textBoxX0.Text = "10";
            this.textBoxX0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxt0
            // 
            this.textBoxt0.Location = new System.Drawing.Point(227, 140);
            this.textBoxt0.Name = "textBoxt0";
            this.textBoxt0.Size = new System.Drawing.Size(100, 22);
            this.textBoxt0.TabIndex = 4;
            this.textBoxt0.Text = "0";
            this.textBoxt0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(227, 178);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(100, 22);
            this.textBoxT.TabIndex = 5;
            this.textBoxT.Text = "10";
            this.textBoxT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(227, 217);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 22);
            this.textBoxN.TabIndex = 6;
            this.textBoxN.Text = "100";
            this.textBoxN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(658, 450);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // comboBoxMethod
            // 
            this.comboBoxMethod.FormattingEnabled = true;
            this.comboBoxMethod.Location = new System.Drawing.Point(180, 290);
            this.comboBoxMethod.Name = "comboBoxMethod";
            this.comboBoxMethod.Size = new System.Drawing.Size(147, 24);
            this.comboBoxMethod.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Темп роста r";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Вместимость среды K";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Начальная популяция x0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Начальное время t0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Конечное время T";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Кол-во шагов по времени N";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Выбор метода";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxN);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxT);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxMethod);
            this.splitContainer1.Panel1.Controls.Add(this.buttonCompute);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxt0);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxR);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxX0);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxK);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chart1);
            this.splitContainer1.Size = new System.Drawing.Size(992, 450);
            this.splitContainer1.SplitterDistance = 330;
            this.splitContainer1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCompute;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.TextBox textBoxK;
        private System.Windows.Forms.TextBox textBoxX0;
        private System.Windows.Forms.TextBox textBoxt0;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBoxMethod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

