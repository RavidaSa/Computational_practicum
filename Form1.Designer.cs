namespace DE_Comp
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
            this.Chart1 = new LiveCharts.WinForms.CartesianChart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxX0 = new System.Windows.Forms.TextBox();
            this.textBoxY0 = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxSteps = new System.Windows.Forms.TextBox();
            this.textBoxIntervalFrom = new System.Windows.Forms.TextBox();
            this.labelIntervalFrom = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.Chart2 = new LiveCharts.WinForms.CartesianChart();
            this.Chart3 = new LiveCharts.WinForms.CartesianChart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart1
            // 
            this.Chart1.Location = new System.Drawing.Point(12, 12);
            this.Chart1.Name = "Chart1";
            this.Chart1.Size = new System.Drawing.Size(461, 189);
            this.Chart1.TabIndex = 0;
            this.Chart1.Text = "cartesianChart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(455, 188);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "x0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "y0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Steps";
            // 
            // textBoxX0
            // 
            this.textBoxX0.Location = new System.Drawing.Point(114, 230);
            this.textBoxX0.Name = "textBoxX0";
            this.textBoxX0.Size = new System.Drawing.Size(100, 22);
            this.textBoxX0.TabIndex = 6;
            this.textBoxX0.Text = "1";
            // 
            // textBoxY0
            // 
            this.textBoxY0.Location = new System.Drawing.Point(114, 260);
            this.textBoxY0.Name = "textBoxY0";
            this.textBoxY0.Size = new System.Drawing.Size(100, 22);
            this.textBoxY0.TabIndex = 7;
            this.textBoxY0.Text = "-2";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(114, 290);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 22);
            this.textBoxX.TabIndex = 8;
            this.textBoxX.Text = "700";
            // 
            // textBoxSteps
            // 
            this.textBoxSteps.Location = new System.Drawing.Point(114, 320);
            this.textBoxSteps.Name = "textBoxSteps";
            this.textBoxSteps.Size = new System.Drawing.Size(100, 22);
            this.textBoxSteps.TabIndex = 9;
            this.textBoxSteps.Text = "100";
            // 
            // textBoxIntervalFrom
            // 
            this.textBoxIntervalFrom.Location = new System.Drawing.Point(114, 349);
            this.textBoxIntervalFrom.Name = "textBoxIntervalFrom";
            this.textBoxIntervalFrom.Size = new System.Drawing.Size(100, 22);
            this.textBoxIntervalFrom.TabIndex = 10;
            this.textBoxIntervalFrom.Text = "10";
            // 
            // labelIntervalFrom
            // 
            this.labelIntervalFrom.AutoSize = true;
            this.labelIntervalFrom.Location = new System.Drawing.Point(33, 352);
            this.labelIntervalFrom.Name = "labelIntervalFrom";
            this.labelIntervalFrom.Size = new System.Drawing.Size(72, 17);
            this.labelIntervalFrom.TabIndex = 12;
            this.labelIntervalFrom.Text = "Error from";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(364, 346);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 14;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // Chart2
            // 
            this.Chart2.Location = new System.Drawing.Point(479, 12);
            this.Chart2.Name = "Chart2";
            this.Chart2.Size = new System.Drawing.Size(461, 189);
            this.Chart2.TabIndex = 15;
            this.Chart2.Text = "cartesianChart1";
            // 
            // Chart3
            // 
            this.Chart3.Location = new System.Drawing.Point(479, 207);
            this.Chart3.Name = "Chart3";
            this.Chart3.Size = new System.Drawing.Size(461, 189);
            this.Chart3.TabIndex = 16;
            this.Chart3.Text = "cartesianChart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 568);
            this.Controls.Add(this.Chart3);
            this.Controls.Add(this.Chart2);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelIntervalFrom);
            this.Controls.Add(this.textBoxIntervalFrom);
            this.Controls.Add(this.textBoxSteps);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.textBoxY0);
            this.Controls.Add(this.textBoxX0);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart Chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxX0;
        private System.Windows.Forms.TextBox textBoxY0;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxSteps;
        private System.Windows.Forms.TextBox textBoxIntervalFrom;
        private System.Windows.Forms.Label labelIntervalFrom;
        private System.Windows.Forms.Button buttonCalculate;
        private LiveCharts.WinForms.CartesianChart Chart2;
        private LiveCharts.WinForms.CartesianChart Chart3;
    }
}

