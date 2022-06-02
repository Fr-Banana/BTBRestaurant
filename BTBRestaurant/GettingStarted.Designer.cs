namespace BTBRestaurant
{
    partial class GettingStarted
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GettingStarted));
            this.label_Heading = new System.Windows.Forms.Label();
            this.button_GetStarted = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Heading
            // 
            this.label_Heading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Heading.Font = new System.Drawing.Font("Futura Hv BT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Heading.Image = global::BTBRestaurant.Properties.Resources.BTB_LOGO;
            this.label_Heading.Location = new System.Drawing.Point(12, 9);
            this.label_Heading.Name = "label_Heading";
            this.label_Heading.Size = new System.Drawing.Size(342, 341);
            this.label_Heading.TabIndex = 0;
            this.label_Heading.Text = "BTB Restaurant";
            this.label_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_GetStarted
            // 
            this.button_GetStarted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_GetStarted.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_GetStarted.FlatAppearance.BorderSize = 0;
            this.button_GetStarted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GetStarted.Font = new System.Drawing.Font("Futura Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_GetStarted.ForeColor = System.Drawing.SystemColors.Control;
            this.button_GetStarted.Location = new System.Drawing.Point(12, 353);
            this.button_GetStarted.Name = "button_GetStarted";
            this.button_GetStarted.Size = new System.Drawing.Size(342, 49);
            this.button_GetStarted.TabIndex = 1;
            this.button_GetStarted.Text = "Get Started";
            this.button_GetStarted.UseVisualStyleBackColor = false;
            this.button_GetStarted.Click += new System.EventHandler(this.button_GetStarted_Click);
            // 
            // GettingStarted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 414);
            this.Controls.Add(this.button_GetStarted);
            this.Controls.Add(this.label_Heading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(382, 453);
            this.Name = "GettingStarted";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Getting Started";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GettingStarted_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label_Heading;
        private Button button_GetStarted;
    }
}