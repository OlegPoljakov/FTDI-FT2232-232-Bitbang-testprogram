namespace FTXX32
{
    partial class fFT232
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fFT232));
            this.lbFT232parameters = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnHighChannel2 = new System.Windows.Forms.Button();
            this.btnLowChannel2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFT232parameters
            // 
            this.lbFT232parameters.FormattingEnabled = true;
            this.lbFT232parameters.Location = new System.Drawing.Point(13, 39);
            this.lbFT232parameters.Name = "lbFT232parameters";
            this.lbFT232parameters.Size = new System.Drawing.Size(236, 394);
            this.lbFT232parameters.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(268, 364);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(192, 69);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Параметры выбранной микросхемы:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 69);
            this.button1.TabIndex = 8;
            this.button1.Text = "Подача высокого уровня канал 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(268, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 69);
            this.button2.TabIndex = 9;
            this.button2.Text = "Подача низкого уровня канал 1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnHighChannel2
            // 
            this.btnHighChannel2.Location = new System.Drawing.Point(481, 39);
            this.btnHighChannel2.Name = "btnHighChannel2";
            this.btnHighChannel2.Size = new System.Drawing.Size(192, 69);
            this.btnHighChannel2.TabIndex = 10;
            this.btnHighChannel2.Text = "Подача высокого уровня канал 2";
            this.btnHighChannel2.UseVisualStyleBackColor = true;
            this.btnHighChannel2.Click += new System.EventHandler(this.btnHighChannel2_Click);
            // 
            // btnLowChannel2
            // 
            this.btnLowChannel2.Location = new System.Drawing.Point(481, 135);
            this.btnLowChannel2.Name = "btnLowChannel2";
            this.btnLowChannel2.Size = new System.Drawing.Size(192, 69);
            this.btnLowChannel2.TabIndex = 11;
            this.btnLowChannel2.Text = "Подача низкого уровня канал 2";
            this.btnLowChannel2.UseVisualStyleBackColor = true;
            this.btnLowChannel2.Click += new System.EventHandler(this.btnLowChannel2_Click);
            // 
            // fFT232
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.btnLowChannel2);
            this.Controls.Add(this.btnHighChannel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbFT232parameters);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fFT232";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTXX32 TEST PROGRAM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFT232parameters;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnHighChannel2;
        private System.Windows.Forms.Button btnLowChannel2;
    }
}