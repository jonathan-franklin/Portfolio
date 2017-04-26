namespace Project_5
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sameDayRadio = new System.Windows.Forms.RadioButton();
            this.expressRadio = new System.Windows.Forms.RadioButton();
            this.standardRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.itemCountTextBox = new System.Windows.Forms.TextBox();
            this.itemWeightTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.categoryBRadio = new System.Windows.Forms.RadioButton();
            this.categoryARadio = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.noSurchargeRadio = new System.Windows.Forms.RadioButton();
            this.surchargeRadio = new System.Windows.Forms.RadioButton();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.shippingCostTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(446, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sameDayRadio);
            this.groupBox1.Controls.Add(this.expressRadio);
            this.groupBox1.Controls.Add(this.standardRadio);
            this.groupBox1.Location = new System.Drawing.Point(13, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shipping Method";
            // 
            // sameDayRadio
            // 
            this.sameDayRadio.AutoSize = true;
            this.sameDayRadio.Location = new System.Drawing.Point(7, 67);
            this.sameDayRadio.Name = "sameDayRadio";
            this.sameDayRadio.Size = new System.Drawing.Size(118, 17);
            this.sameDayRadio.TabIndex = 2;
            this.sameDayRadio.TabStop = true;
            this.sameDayRadio.Text = "Same Day Shipping";
            this.sameDayRadio.UseVisualStyleBackColor = true;
            // 
            // expressRadio
            // 
            this.expressRadio.AutoSize = true;
            this.expressRadio.Location = new System.Drawing.Point(7, 44);
            this.expressRadio.Name = "expressRadio";
            this.expressRadio.Size = new System.Drawing.Size(106, 17);
            this.expressRadio.TabIndex = 1;
            this.expressRadio.TabStop = true;
            this.expressRadio.Text = "Express Shipping";
            this.expressRadio.UseVisualStyleBackColor = true;
            // 
            // standardRadio
            // 
            this.standardRadio.AutoSize = true;
            this.standardRadio.Location = new System.Drawing.Point(7, 20);
            this.standardRadio.Name = "standardRadio";
            this.standardRadio.Size = new System.Drawing.Size(112, 17);
            this.standardRadio.TabIndex = 0;
            this.standardRadio.TabStop = true;
            this.standardRadio.Text = "Standard Shipping";
            this.standardRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "# of Items (Cat. A):";
            // 
            // itemCountTextBox
            // 
            this.itemCountTextBox.Location = new System.Drawing.Point(113, 158);
            this.itemCountTextBox.Name = "itemCountTextBox";
            this.itemCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemCountTextBox.TabIndex = 3;
            this.itemCountTextBox.Text = "0";
            // 
            // itemWeightTextBox
            // 
            this.itemWeightTextBox.Location = new System.Drawing.Point(113, 185);
            this.itemWeightTextBox.Name = "itemWeightTextBox";
            this.itemWeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemWeightTextBox.TabIndex = 4;
            this.itemWeightTextBox.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Weight (Cat. B):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.categoryBRadio);
            this.groupBox2.Controls.Add(this.categoryARadio);
            this.groupBox2.Location = new System.Drawing.Point(232, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 80);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shipping Category";
            // 
            // categoryBRadio
            // 
            this.categoryBRadio.AutoSize = true;
            this.categoryBRadio.Location = new System.Drawing.Point(7, 44);
            this.categoryBRadio.Name = "categoryBRadio";
            this.categoryBRadio.Size = new System.Drawing.Size(77, 17);
            this.categoryBRadio.TabIndex = 1;
            this.categoryBRadio.TabStop = true;
            this.categoryBRadio.Text = "Category B";
            this.categoryBRadio.UseVisualStyleBackColor = true;
            // 
            // categoryARadio
            // 
            this.categoryARadio.AutoSize = true;
            this.categoryARadio.Location = new System.Drawing.Point(7, 20);
            this.categoryARadio.Name = "categoryARadio";
            this.categoryARadio.Size = new System.Drawing.Size(77, 17);
            this.categoryARadio.TabIndex = 0;
            this.categoryARadio.TabStop = true;
            this.categoryARadio.Text = "Category A";
            this.categoryARadio.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.noSurchargeRadio);
            this.groupBox3.Controls.Add(this.surchargeRadio);
            this.groupBox3.Location = new System.Drawing.Point(234, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 74);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Surcharge (HI or AL)";
            // 
            // noSurchargeRadio
            // 
            this.noSurchargeRadio.AutoSize = true;
            this.noSurchargeRadio.Location = new System.Drawing.Point(7, 44);
            this.noSurchargeRadio.Name = "noSurchargeRadio";
            this.noSurchargeRadio.Size = new System.Drawing.Size(39, 17);
            this.noSurchargeRadio.TabIndex = 1;
            this.noSurchargeRadio.TabStop = true;
            this.noSurchargeRadio.Text = "No";
            this.noSurchargeRadio.UseVisualStyleBackColor = true;
            // 
            // surchargeRadio
            // 
            this.surchargeRadio.AutoSize = true;
            this.surchargeRadio.Location = new System.Drawing.Point(7, 20);
            this.surchargeRadio.Name = "surchargeRadio";
            this.surchargeRadio.Size = new System.Drawing.Size(43, 17);
            this.surchargeRadio.TabIndex = 0;
            this.surchargeRadio.TabStop = true;
            this.surchargeRadio.Text = "Yes";
            this.surchargeRadio.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(13, 219);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(200, 23);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Shipping Cost:";
            // 
            // shippingCostTextBox
            // 
            this.shippingCostTextBox.Location = new System.Drawing.Point(324, 221);
            this.shippingCostTextBox.Name = "shippingCostTextBox";
            this.shippingCostTextBox.Size = new System.Drawing.Size(110, 20);
            this.shippingCostTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 261);
            this.Controls.Add(this.shippingCostTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemWeightTextBox);
            this.Controls.Add(this.itemCountTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Project 5 | CS 1400 | JTF";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton sameDayRadio;
        private System.Windows.Forms.RadioButton expressRadio;
        private System.Windows.Forms.RadioButton standardRadio;
        private System.Windows.Forms.TextBox itemCountTextBox;
        private System.Windows.Forms.TextBox itemWeightTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton categoryBRadio;
        private System.Windows.Forms.RadioButton categoryARadio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton noSurchargeRadio;
        private System.Windows.Forms.RadioButton surchargeRadio;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox shippingCostTextBox;
    }
}

