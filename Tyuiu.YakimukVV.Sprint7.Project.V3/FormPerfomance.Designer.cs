namespace Tyuiu.YakimukVV.Sprint7.Project.V3
{
    partial class FormPerformance
    {
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// <param name="disposing">
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        private void InitializeComponent()
        {
            labelAverage = new Label();
            labelCount = new Label();
            labelHighest = new Label();
            labelLowest = new Label();
            SuspendLayout();
            // 
            // labelAverage
            // 
            labelAverage.Anchor = AnchorStyles.Bottom;
            labelAverage.AutoSize = true;
            labelAverage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelAverage.Location = new Point(7, 9);
            labelAverage.Name = "labelAverage";
            labelAverage.Size = new Size(215, 21);
            labelAverage.TabIndex = 1;
            labelAverage.Text = "Средний балл группы: 0.0";
            labelAverage.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelCount
            // 
            labelCount.Anchor = AnchorStyles.Bottom;
            labelCount.AutoSize = true;
            labelCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelCount.Location = new Point(7, 39);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(202, 21);
            labelCount.TabIndex = 2;
            labelCount.Text = "Количество учащихся: 0";
            labelCount.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelHighest
            // 
            labelHighest.Anchor = AnchorStyles.Bottom;
            labelHighest.AutoSize = true;
            labelHighest.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelHighest.Location = new Point(7, 69);
            labelHighest.Name = "labelHighest";
            labelHighest.Size = new Size(211, 21);
            labelHighest.TabIndex = 3;
            labelHighest.Text = "Высший балл группы: 0.0";
            labelHighest.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelLowest
            // 
            labelLowest.Anchor = AnchorStyles.Bottom;
            labelLowest.AutoSize = true;
            labelLowest.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelLowest.Location = new Point(7, 100);
            labelLowest.Name = "labelLowest";
            labelLowest.Size = new Size(210, 21);
            labelLowest.TabIndex = 4;
            labelLowest.Text = "Низший балл группы: 0.0";
            labelLowest.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormPerformance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(431, 203);
            Controls.Add(labelLowest);
            Controls.Add(labelHighest);
            Controls.Add(labelCount);
            Controls.Add(labelAverage);
            Name = "FormPerformance";
            Text = "Успеваемость группы";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelHighest;
        private System.Windows.Forms.Label labelLowest;
    }
}
