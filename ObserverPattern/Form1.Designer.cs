namespace ObserverPattern
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
            this.inputText = new System.Windows.Forms.TextBox();
            this.inputBtn = new System.Windows.Forms.Button();
            this.webText = new System.Windows.Forms.TextBox();
            this.wiText = new System.Windows.Forms.TextBox();
            this.webLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.attachBtn = new System.Windows.Forms.Button();
            this.observerList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // inputText
            // 
            this.inputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputText.Location = new System.Drawing.Point(241, 38);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(112, 38);
            this.inputText.TabIndex = 0;
            this.inputText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputBtn
            // 
            this.inputBtn.Location = new System.Drawing.Point(384, 38);
            this.inputBtn.Name = "inputBtn";
            this.inputBtn.Size = new System.Drawing.Size(69, 38);
            this.inputBtn.TabIndex = 1;
            this.inputBtn.Text = "Input";
            this.inputBtn.UseVisualStyleBackColor = true;
            this.inputBtn.Click += new System.EventHandler(this.inputBtn_Click);
            // 
            // webText
            // 
            this.webText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webText.Location = new System.Drawing.Point(131, 209);
            this.webText.Name = "webText";
            this.webText.Size = new System.Drawing.Size(112, 38);
            this.webText.TabIndex = 2;
            this.webText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wiText
            // 
            this.wiText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wiText.Location = new System.Drawing.Point(354, 209);
            this.wiText.Name = "wiText";
            this.wiText.Size = new System.Drawing.Size(112, 38);
            this.wiText.TabIndex = 3;
            this.wiText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // webLabel
            // 
            this.webLabel.AutoSize = true;
            this.webLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webLabel.Location = new System.Drawing.Point(125, 158);
            this.webLabel.Name = "webLabel";
            this.webLabel.Size = new System.Drawing.Size(125, 32);
            this.webLabel.TabIndex = 4;
            this.webLabel.Text = "Website";
            this.webLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wireless";
            // 
            // attachBtn
            // 
            this.attachBtn.Location = new System.Drawing.Point(484, 88);
            this.attachBtn.Name = "attachBtn";
            this.attachBtn.Size = new System.Drawing.Size(117, 58);
            this.attachBtn.TabIndex = 6;
            this.attachBtn.Text = "Attach";
            this.attachBtn.UseVisualStyleBackColor = true;
            this.attachBtn.Click += new System.EventHandler(this.attachBtn_Click);
            // 
            // observerList
            // 
            this.observerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.observerList.FormattingEnabled = true;
            this.observerList.Items.AddRange(new object[] {
            "Wireless",
            "Website"});
            this.observerList.Location = new System.Drawing.Point(300, 106);
            this.observerList.Name = "observerList";
            this.observerList.Size = new System.Drawing.Size(153, 24);
            this.observerList.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 322);
            this.Controls.Add(this.observerList);
            this.Controls.Add(this.attachBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webLabel);
            this.Controls.Add(this.wiText);
            this.Controls.Add(this.webText);
            this.Controls.Add(this.inputBtn);
            this.Controls.Add(this.inputText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Button inputBtn;
        private System.Windows.Forms.TextBox webText;
        private System.Windows.Forms.TextBox wiText;
        private System.Windows.Forms.Label webLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button attachBtn;
        private System.Windows.Forms.ComboBox observerList;
    }
}

