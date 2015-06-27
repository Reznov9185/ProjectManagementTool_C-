namespace PresentationTier
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Schedule_btn = new System.Windows.Forms.Button();
            this.Sequence_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Schedule_btn
            // 
            this.Schedule_btn.BackColor = System.Drawing.Color.Transparent;
            this.Schedule_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Schedule_btn.BackgroundImage")));
            this.Schedule_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Schedule_btn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Schedule_btn.Location = new System.Drawing.Point(38, 167);
            this.Schedule_btn.Name = "Schedule_btn";
            this.Schedule_btn.Size = new System.Drawing.Size(174, 70);
            this.Schedule_btn.TabIndex = 0;
            this.Schedule_btn.Text = "Schedule";
            this.Schedule_btn.UseVisualStyleBackColor = false;
            this.Schedule_btn.Click += new System.EventHandler(this.Schedule_btn_Click);
            // 
            // Sequence_btn
            // 
            this.Sequence_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sequence_btn.BackgroundImage")));
            this.Sequence_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sequence_btn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sequence_btn.Location = new System.Drawing.Point(256, 167);
            this.Sequence_btn.Name = "Sequence_btn";
            this.Sequence_btn.Size = new System.Drawing.Size(174, 68);
            this.Sequence_btn.TabIndex = 1;
            this.Sequence_btn.Text = "Sequence";
            this.Sequence_btn.UseVisualStyleBackColor = true;
            this.Sequence_btn.Click += new System.EventHandler(this.Sequence_btn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1021, 688);
            this.Controls.Add(this.Sequence_btn);
            this.Controls.Add(this.Schedule_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Scheduling & Sequencing Tool";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Schedule_btn;
        private System.Windows.Forms.Button Sequence_btn;

    }
}

