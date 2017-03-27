namespace CMPE1600ICA10Wanderer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            this.components = new System.ComponentModel.Container();
            this.UI_TrackBar_NumberOfIterations = new System.Windows.Forms.TrackBar();
            this.UI_FixedLabel_Min = new System.Windows.Forms.Label();
            this.UI_FixedLabel_Max = new System.Windows.Forms.Label();
            this.UI_FixedLabel_NumberOfIterations = new System.Windows.Forms.Label();
            this.UI_Timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UI_TrackBar_NumberOfIterations)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_TrackBar_NumberOfIterations
            // 
            this.UI_TrackBar_NumberOfIterations.Location = new System.Drawing.Point(12, 26);
            this.UI_TrackBar_NumberOfIterations.Maximum = 5000;
            this.UI_TrackBar_NumberOfIterations.Minimum = 100;
            this.UI_TrackBar_NumberOfIterations.Name = "UI_TrackBar_NumberOfIterations";
            this.UI_TrackBar_NumberOfIterations.Size = new System.Drawing.Size(274, 45);
            this.UI_TrackBar_NumberOfIterations.TabIndex = 0;
            this.UI_TrackBar_NumberOfIterations.TickFrequency = 100;
            this.UI_TrackBar_NumberOfIterations.Value = 100;
            this.UI_TrackBar_NumberOfIterations.Scroll += new System.EventHandler(this.UI_TrackBar_NumberOfIterations_Scroll);
            // 
            // UI_FixedLabel_Min
            // 
            this.UI_FixedLabel_Min.AutoSize = true;
            this.UI_FixedLabel_Min.Location = new System.Drawing.Point(9, 58);
            this.UI_FixedLabel_Min.Name = "UI_FixedLabel_Min";
            this.UI_FixedLabel_Min.Size = new System.Drawing.Size(25, 13);
            this.UI_FixedLabel_Min.TabIndex = 1;
            this.UI_FixedLabel_Min.Text = "100";
            // 
            // UI_FixedLabel_Max
            // 
            this.UI_FixedLabel_Max.AutoSize = true;
            this.UI_FixedLabel_Max.Location = new System.Drawing.Point(255, 58);
            this.UI_FixedLabel_Max.Name = "UI_FixedLabel_Max";
            this.UI_FixedLabel_Max.Size = new System.Drawing.Size(31, 13);
            this.UI_FixedLabel_Max.TabIndex = 2;
            this.UI_FixedLabel_Max.Text = "5000";
            // 
            // UI_FixedLabel_NumberOfIterations
            // 
            this.UI_FixedLabel_NumberOfIterations.AutoSize = true;
            this.UI_FixedLabel_NumberOfIterations.Location = new System.Drawing.Point(97, 58);
            this.UI_FixedLabel_NumberOfIterations.Name = "UI_FixedLabel_NumberOfIterations";
            this.UI_FixedLabel_NumberOfIterations.Size = new System.Drawing.Size(102, 13);
            this.UI_FixedLabel_NumberOfIterations.TabIndex = 3;
            this.UI_FixedLabel_NumberOfIterations.Text = "Number of Iterations";
            // 
            // UI_Timer1
            // 
            this.UI_Timer1.Enabled = true;
            this.UI_Timer1.Interval = 20;
            this.UI_Timer1.Tick += new System.EventHandler(this.UI_Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 93);
            this.Controls.Add(this.UI_FixedLabel_NumberOfIterations);
            this.Controls.Add(this.UI_FixedLabel_Max);
            this.Controls.Add(this.UI_FixedLabel_Min);
            this.Controls.Add(this.UI_TrackBar_NumberOfIterations);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UI_TrackBar_NumberOfIterations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar UI_TrackBar_NumberOfIterations;
        private System.Windows.Forms.Label UI_FixedLabel_Min;
        private System.Windows.Forms.Label UI_FixedLabel_Max;
        private System.Windows.Forms.Label UI_FixedLabel_NumberOfIterations;
        private System.Windows.Forms.Timer UI_Timer1;
    }
}

