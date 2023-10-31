namespace mod3chapter2task2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel = new FlowLayoutPanel();
            btnStart = new Button();
            dgvResults = new DataGridView();
            pbHorse1 = new ProgressBar();
            pbHorse2 = new ProgressBar();
            pbHorse3 = new ProgressBar();
            pbHorse4 = new ProgressBar();
            pbHorse5 = new ProgressBar();
            flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Controls.Add(pbHorse1);
            flowLayoutPanel.Controls.Add(pbHorse2);
            flowLayoutPanel.Controls.Add(pbHorse3);
            flowLayoutPanel.Controls.Add(pbHorse4);
            flowLayoutPanel.Controls.Add(pbHorse5);
            flowLayoutPanel.Location = new Point(12, 30);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(776, 122);
            flowLayoutPanel.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(140, 310);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // dgvResults
            // 
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Location = new Point(542, 261);
            dgvResults.Name = "dgvResults";
            dgvResults.RowTemplate.Height = 25;
            dgvResults.Size = new Size(240, 150);
            dgvResults.TabIndex = 2;
            // 
            // pbHorse1
            // 
            pbHorse1.Location = new Point(3, 3);
            pbHorse1.Name = "pbHorse1";
            pbHorse1.Size = new Size(100, 23);
            pbHorse1.TabIndex = 0;
            // 
            // pbHorse2
            // 
            pbHorse2.Location = new Point(109, 3);
            pbHorse2.Name = "pbHorse2";
            pbHorse2.Size = new Size(100, 23);
            pbHorse2.TabIndex = 1;
            // 
            // pbHorse3
            // 
            pbHorse3.Location = new Point(215, 3);
            pbHorse3.Name = "pbHorse3";
            pbHorse3.Size = new Size(100, 23);
            pbHorse3.TabIndex = 2;
            // 
            // pbHorse4
            // 
            pbHorse4.Location = new Point(321, 3);
            pbHorse4.Name = "pbHorse4";
            pbHorse4.Size = new Size(100, 23);
            pbHorse4.TabIndex = 3;
            // 
            // pbHorse5
            // 
            pbHorse5.Location = new Point(427, 3);
            pbHorse5.Name = "pbHorse5";
            pbHorse5.Size = new Size(100, 23);
            pbHorse5.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvResults);
            Controls.Add(btnStart);
            Controls.Add(flowLayoutPanel);
            Name = "Form1";
            Text = "Form1";
            flowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel;
        private ProgressBar pbHorse1;
        private ProgressBar pbHorse2;
        private ProgressBar pbHorse3;
        private ProgressBar pbHorse4;
        private ProgressBar pbHorse5;
        private Button btnStart;
        private DataGridView dgvResults;
    }
}