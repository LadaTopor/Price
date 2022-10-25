namespace Price
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(90, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск магазина";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(84, 90);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(162, 20);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.Text = "Название магазина";
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbSearch_MouseClick);
            // 
            // bSearch
            // 
            this.bSearch.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSearch.Location = new System.Drawing.Point(106, 129);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(120, 34);
            this.bSearch.TabIndex = 2;
            this.bSearch.Text = "Поиск";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.Location = new System.Drawing.Point(106, 184);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(120, 95);
            this.lbItems.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 372);
            this.Controls.Add(this.lbItems);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Price";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.ListBox lbItems;
    }
}

