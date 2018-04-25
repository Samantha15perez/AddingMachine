namespace AddingMachine
{
    partial class AddingMachine
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
            this.textBoxAddNumber = new System.Windows.Forms.TextBox();
            this.labelAddedNumbers = new System.Windows.Forms.Label();
            this.labelRunningTotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAddNumber
            // 
            this.textBoxAddNumber.Location = new System.Drawing.Point(12, 397);
            this.textBoxAddNumber.Name = "textBoxAddNumber";
            this.textBoxAddNumber.Size = new System.Drawing.Size(197, 20);
            this.textBoxAddNumber.TabIndex = 0;
            this.textBoxAddNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAddedNumbers
            // 
            this.labelAddedNumbers.BackColor = System.Drawing.Color.White;
            this.labelAddedNumbers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAddedNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAddedNumbers.Location = new System.Drawing.Point(15, 9);
            this.labelAddedNumbers.Name = "labelAddedNumbers";
            this.labelAddedNumbers.Size = new System.Drawing.Size(194, 335);
            this.labelAddedNumbers.TabIndex = 2;
            this.labelAddedNumbers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;

            // 
            // labelRunningTotal
            // 
            this.labelRunningTotal.BackColor = System.Drawing.Color.GreenYellow;
            this.labelRunningTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRunningTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRunningTotal.Location = new System.Drawing.Point(15, 357);
            this.labelRunningTotal.Name = "labelRunningTotal";
            this.labelRunningTotal.Size = new System.Drawing.Size(194, 24);
            this.labelRunningTotal.TabIndex = 2;
            this.labelRunningTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(112, 423);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 35);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Reset";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // AddingMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 464);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelRunningTotal);
            this.Controls.Add(this.labelAddedNumbers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxAddNumber);
            this.Name = "AddingMachine";
            this.Text = "AddingMachine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddNumber;
        private System.Windows.Forms.Label labelAddedNumbers;
        private System.Windows.Forms.Label labelRunningTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonClear;
    }
}

