namespace Tyuiu.YakimukVV.Sprint7.Project.V3
{
    partial class FormDetails
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelDetails = new Label();
            SuspendLayout();
            // 
            // labelDetails
            // 
            labelDetails.BackColor = SystemColors.MenuBar;
            labelDetails.Dock = DockStyle.Fill;
            labelDetails.Font = new Font("Arial", 12F, FontStyle.Bold);
            labelDetails.Location = new Point(0, 0);
            labelDetails.Name = "labelDetails";
            labelDetails.Size = new Size(511, 182);
            labelDetails.TabIndex = 0;
            labelDetails.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 182);
            Controls.Add(labelDetails);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormDetails";
            Text = "Сведения о предмете";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label labelDetails;
    }
}
