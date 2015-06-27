namespace PresentationTier
{
    partial class ScheduleWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleWindow));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ScheduleCalc_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(741, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(468, 165);
            this.dataGridView1.TabIndex = 0;
            // 
            // ScheduleCalc_btn
            // 
            this.ScheduleCalc_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ScheduleCalc_btn.BackgroundImage")));
            this.ScheduleCalc_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ScheduleCalc_btn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleCalc_btn.Location = new System.Drawing.Point(1012, 82);
            this.ScheduleCalc_btn.Name = "ScheduleCalc_btn";
            this.ScheduleCalc_btn.Size = new System.Drawing.Size(197, 84);
            this.ScheduleCalc_btn.TabIndex = 2;
            this.ScheduleCalc_btn.Text = "Calculate Schedule";
            this.ScheduleCalc_btn.UseVisualStyleBackColor = true;
            this.ScheduleCalc_btn.Click += new System.EventHandler(this.ScheduleCalc_btn_Click_1);
            // 
            // Update_btn
            // 
            this.Update_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Update_btn.BackgroundImage")));
            this.Update_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Update_btn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_btn.Location = new System.Drawing.Point(1012, 172);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(197, 84);
            this.Update_btn.TabIndex = 3;
            this.Update_btn.Text = "Update Data";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click_1);
            // 
            // ScheduleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1221, 439);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.ScheduleCalc_btn);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScheduleWindow";
            this.Text = "Scheduling";
            this.Load += new System.EventHandler(this.ScheduleWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ScheduleCalc_btn;
        private System.Windows.Forms.Button Update_btn;
    }
}