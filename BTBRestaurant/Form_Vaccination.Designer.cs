namespace BTBRestaurant
{
    partial class Form_Vaccination
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Vaccination));
            this.label_Heading = new System.Windows.Forms.Label();
            this.textBox_VaxxID = new System.Windows.Forms.TextBox();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.button_Skip = new System.Windows.Forms.Button();
            this.label_SubText = new System.Windows.Forms.Label();
            this.label_discount = new System.Windows.Forms.Label();
            this.label_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Heading
            // 
            this.label_Heading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Heading.Font = new System.Drawing.Font("Futura Hv BT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Heading.Location = new System.Drawing.Point(12, 9);
            this.label_Heading.Name = "label_Heading";
            this.label_Heading.Size = new System.Drawing.Size(342, 182);
            this.label_Heading.TabIndex = 1;
            this.label_Heading.Text = "Are you vaccinated?";
            this.label_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Heading.Click += new System.EventHandler(this.label_Heading_Click);
            // 
            // textBox_VaxxID
            // 
            this.textBox_VaxxID.Font = new System.Drawing.Font("Futura Lt BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_VaxxID.Location = new System.Drawing.Point(12, 240);
            this.textBox_VaxxID.Name = "textBox_VaxxID";
            this.textBox_VaxxID.Size = new System.Drawing.Size(342, 36);
            this.textBox_VaxxID.TabIndex = 2;
            this.textBox_VaxxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_Confirm
            // 
            this.button_Confirm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Confirm.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Confirm.FlatAppearance.BorderSize = 0;
            this.button_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Confirm.Font = new System.Drawing.Font("Futura Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Confirm.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Confirm.Location = new System.Drawing.Point(12, 315);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(342, 46);
            this.button_Confirm.TabIndex = 3;
            this.button_Confirm.Text = "Confirm ID";
            this.button_Confirm.UseVisualStyleBackColor = false;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // button_Skip
            // 
            this.button_Skip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Skip.BackColor = System.Drawing.Color.IndianRed;
            this.button_Skip.FlatAppearance.BorderSize = 0;
            this.button_Skip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Skip.Font = new System.Drawing.Font("Futura Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Skip.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Skip.Location = new System.Drawing.Point(12, 367);
            this.button_Skip.Name = "button_Skip";
            this.button_Skip.Size = new System.Drawing.Size(342, 35);
            this.button_Skip.TabIndex = 4;
            this.button_Skip.Text = "Skip";
            this.button_Skip.UseVisualStyleBackColor = false;
            this.button_Skip.Click += new System.EventHandler(this.button_Skip_Click);
            // 
            // label_SubText
            // 
            this.label_SubText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_SubText.Font = new System.Drawing.Font("Futura Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_SubText.Location = new System.Drawing.Point(12, 215);
            this.label_SubText.Name = "label_SubText";
            this.label_SubText.Size = new System.Drawing.Size(342, 33);
            this.label_SubText.TabIndex = 5;
            this.label_SubText.Text = "Enter ID: (10% Discount)";
            this.label_SubText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_discount
            // 
            this.label_discount.AutoSize = true;
            this.label_discount.Location = new System.Drawing.Point(183, 200);
            this.label_discount.Name = "label_discount";
            this.label_discount.Size = new System.Drawing.Size(0, 15);
            this.label_discount.TabIndex = 17;
            // 
            // label_error
            // 
            this.label_error.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_error.Font = new System.Drawing.Font("Futura Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_error.ForeColor = System.Drawing.Color.IndianRed;
            this.label_error.Location = new System.Drawing.Point(12, 279);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(342, 33);
            this.label_error.TabIndex = 18;
            this.label_error.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_Vaccination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 414);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.label_discount);
            this.Controls.Add(this.label_SubText);
            this.Controls.Add(this.button_Skip);
            this.Controls.Add(this.button_Confirm);
            this.Controls.Add(this.textBox_VaxxID);
            this.Controls.Add(this.label_Heading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(382, 453);
            this.Name = "Form_Vaccination";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vaccination";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Vaccination_FormClosed);
            this.Load += new System.EventHandler(this.Form_Vaccination_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_Heading;
        private Label label_SubText;
        public Button button_Confirm;
        public Button button_Skip;
        public TextBox textBox_VaxxID;
        private Label label_discount;
        private Label label_error;
    }
}