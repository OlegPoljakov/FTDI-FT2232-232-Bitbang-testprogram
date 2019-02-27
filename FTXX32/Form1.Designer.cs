namespace FTXX32
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.lbConnectedDevices = new System.Windows.Forms.ListBox();
            this.btnSearchICs = new System.Windows.Forms.Button();
            this.btnChooseIc = new System.Windows.Forms.Button();
            this.btnClearListIcs = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbConnectedDevices
            // 
            this.lbConnectedDevices.FormattingEnabled = true;
            this.lbConnectedDevices.Location = new System.Drawing.Point(13, 13);
            this.lbConnectedDevices.Name = "lbConnectedDevices";
            this.lbConnectedDevices.Size = new System.Drawing.Size(232, 420);
            this.lbConnectedDevices.TabIndex = 0;
            this.lbConnectedDevices.SelectedIndexChanged += new System.EventHandler(this.lbConnectedDevices_SelectedIndexChanged);
            // 
            // btnSearchICs
            // 
            this.btnSearchICs.Location = new System.Drawing.Point(252, 13);
            this.btnSearchICs.Name = "btnSearchICs";
            this.btnSearchICs.Size = new System.Drawing.Size(192, 69);
            this.btnSearchICs.TabIndex = 1;
            this.btnSearchICs.Text = "Поиск микросхем";
            this.btnSearchICs.UseVisualStyleBackColor = true;
            this.btnSearchICs.Click += new System.EventHandler(this.btnSearchICs_Click);
            // 
            // btnChooseIc
            // 
            this.btnChooseIc.Location = new System.Drawing.Point(251, 105);
            this.btnChooseIc.Name = "btnChooseIc";
            this.btnChooseIc.Size = new System.Drawing.Size(192, 69);
            this.btnChooseIc.TabIndex = 2;
            this.btnChooseIc.Text = "Выбор микросхемы";
            this.btnChooseIc.UseVisualStyleBackColor = true;
            this.btnChooseIc.Click += new System.EventHandler(this.btnChooseIc_Click);
            // 
            // btnClearListIcs
            // 
            this.btnClearListIcs.Location = new System.Drawing.Point(252, 193);
            this.btnClearListIcs.Name = "btnClearListIcs";
            this.btnClearListIcs.Size = new System.Drawing.Size(192, 69);
            this.btnClearListIcs.TabIndex = 3;
            this.btnClearListIcs.Text = "Очистить список";
            this.btnClearListIcs.UseVisualStyleBackColor = true;
            this.btnClearListIcs.Click += new System.EventHandler(this.btnClearListIcs_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(252, 364);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(192, 69);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearListIcs);
            this.Controls.Add(this.btnChooseIc);
            this.Controls.Add(this.btnSearchICs);
            this.Controls.Add(this.lbConnectedDevices);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTXX32 TEST PROGRAM";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbConnectedDevices;
        private System.Windows.Forms.Button btnSearchICs;
        private System.Windows.Forms.Button btnChooseIc;
        private System.Windows.Forms.Button btnClearListIcs;
        private System.Windows.Forms.Button btnExit;
    }
}

