namespace TrafficLight
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
            this.Traffic_light_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Traffic_light_lbl
            // 
            this.Traffic_light_lbl.BackColor = System.Drawing.Color.Red;
            this.Traffic_light_lbl.Location = new System.Drawing.Point(120, 226);
            this.Traffic_light_lbl.Name = "Traffic_light_lbl";
            this.Traffic_light_lbl.Size = new System.Drawing.Size(174, 161);
            this.Traffic_light_lbl.TabIndex = 0;
            this.Traffic_light_lbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Traffic_light_lbl_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 648);
            this.Controls.Add(this.Traffic_light_lbl);
            this.Name = "Form1";
            this.Text = "TrafficLight";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Traffic_light_lbl;
    }
}

