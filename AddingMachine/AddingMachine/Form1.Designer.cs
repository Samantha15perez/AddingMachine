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
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAddNumber
            // 
            this.textBoxAddNumber.Location = new System.Drawing.Point(12, 392);
            this.textBoxAddNumber.Name = "textBoxAddNumber";
            this.textBoxAddNumber.Size = new System.Drawing.Size(224, 20);
            this.textBoxAddNumber.TabIndex = 0;
            this.textBoxAddNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAddedNumbers
            // 
            this.labelAddedNumbers.BackColor = System.Drawing.Color.White;
            this.labelAddedNumbers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAddedNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAddedNumbers.Location = new System.Drawing.Point(15, 12);
            this.labelAddedNumbers.Name = "labelAddedNumbers";
            this.labelAddedNumbers.Size = new System.Drawing.Size(221, 335);
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
            this.labelRunningTotal.Size = new System.Drawing.Size(221, 24);
            this.labelRunningTotal.TabIndex = 2;
            this.labelRunningTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackgroundImage = global::AddingMachine.Properties.Resources.divisionSymbol;
            this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonDivide.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDivide.Location = new System.Drawing.Point(104, 421);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(40, 40);
            this.buttonDivide.TabIndex = 5;
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackgroundImage = global::AddingMachine.Properties.Resources.MultiplicationSymbol;
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonMultiply.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMultiply.Location = new System.Drawing.Point(58, 421);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(40, 40);
            this.buttonMultiply.TabIndex = 4;
            this.buttonMultiply.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackgroundImage = global::AddingMachine.Properties.Resources.CLRSymbol;
            this.buttonClear.Location = new System.Drawing.Point(196, 421);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(40, 40);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::AddingMachine.Properties.Resources.AdditionSymbol;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(12, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.BackgroundImage = global::AddingMachine.Properties.Resources.SubtractionSymbol;
            this.buttonSubtract.Location = new System.Drawing.Point(150, 421);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(40, 40);
            this.buttonSubtract.TabIndex = 6;
            this.buttonSubtract.UseVisualStyleBackColor = true;
            this.buttonSubtract.Click += new System.EventHandler(this.buttonSubtract_Click);
            // 
            // AddingMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 474);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMultiply);
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
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonSubtract;
    }
}

