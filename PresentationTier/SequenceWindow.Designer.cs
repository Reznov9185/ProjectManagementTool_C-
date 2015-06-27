namespace PresentationTier
{
    partial class SequenceWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SequenceWindow));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Update_btn = new System.Windows.Forms.Button();
            this.SequenceCalc_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(537, 175);
            this.dataGridView2.TabIndex = 0;
            // 
            // Update_btn
            // 
            this.Update_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Update_btn.BackgroundImage")));
            this.Update_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Update_btn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_btn.Location = new System.Drawing.Point(823, 3);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(163, 67);
            this.Update_btn.TabIndex = 4;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // SequenceCalc_btn
            // 
            this.SequenceCalc_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SequenceCalc_btn.BackgroundImage")));
            this.SequenceCalc_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SequenceCalc_btn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SequenceCalc_btn.Location = new System.Drawing.Point(806, 76);
            this.SequenceCalc_btn.Name = "SequenceCalc_btn";
            this.SequenceCalc_btn.Size = new System.Drawing.Size(180, 71);
            this.SequenceCalc_btn.TabIndex = 5;
            this.SequenceCalc_btn.TabStop = false;
            this.SequenceCalc_btn.Text = "Calculate Sequence";
            this.SequenceCalc_btn.UseVisualStyleBackColor = true;
            this.SequenceCalc_btn.Click += new System.EventHandler(this.SequenceCalc_btn_Click);
            // 
            // SequenceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 484);
            this.Controls.Add(this.SequenceCalc_btn);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.dataGridView2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SequenceWindow";
            this.Text = "Sequencing";
            this.Load += new System.EventHandler(this.SequenceWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button SequenceCalc_btn;
    }
}