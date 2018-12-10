namespace Charity_Database_Management
{
    partial class introduction
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(introduction));
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SlidingPanel = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SlidingPanel_ToggelButton = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.maximize = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SlidingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.maximize);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 29);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BackgroundImage = global::Charity_Database_Management.Properties.Resources.d91d0f940dc271752cc72e07b1290909;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(243, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 414);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 342);
            this.label3.MaximumSize = new System.Drawing.Size(750, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(744, 51);
            this.label3.TabIndex = 3;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Charity_Database_Management.Properties.Resources.treeaf;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(13, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(79, 73);
            this.panel4.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Charity_Database_Management.Properties.Resources.hope_background1;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(95, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 73);
            this.panel3.TabIndex = 9;
            // 
            // SlidingPanel
            // 
            this.SlidingPanel.BackgroundImage = global::Charity_Database_Management.Properties.Resources._9ab05ad8b3be22d1276svsvs779b6ca933a9d;
            this.SlidingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SlidingPanel.Controls.Add(this.button6);
            this.SlidingPanel.Controls.Add(this.button1);
            this.SlidingPanel.Controls.Add(this.button4);
            this.SlidingPanel.Controls.Add(this.button5);
            this.SlidingPanel.Controls.Add(this.button2);
            this.SlidingPanel.Controls.Add(this.button3);
            this.SlidingPanel.Controls.Add(this.SlidingPanel_ToggelButton);
            this.SlidingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlidingPanel.Location = new System.Drawing.Point(0, 29);
            this.SlidingPanel.Name = "SlidingPanel";
            this.SlidingPanel.Size = new System.Drawing.Size(246, 414);
            this.SlidingPanel.TabIndex = 1;
            this.SlidingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SlidingPanel_Paint);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Salmon;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(82, 326);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(76, 35);
            this.button6.TabIndex = 13;
            this.button6.Text = "Users";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(51, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Make a Donation";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(1, 138);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(242, 46);
            this.button4.TabIndex = 4;
            this.button4.Text = "About Us";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(1, 181);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(242, 46);
            this.button5.TabIndex = 3;
            this.button5.Text = "Contact Us";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(1, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(242, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Causes We Support";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(1, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(242, 46);
            this.button3.TabIndex = 1;
            this.button3.Text = "Donors";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SlidingPanel_ToggelButton
            // 
            this.SlidingPanel_ToggelButton.BackColor = System.Drawing.Color.Transparent;
            this.SlidingPanel_ToggelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlidingPanel_ToggelButton.Location = new System.Drawing.Point(1, 0);
            this.SlidingPanel_ToggelButton.Name = "SlidingPanel_ToggelButton";
            this.SlidingPanel_ToggelButton.Size = new System.Drawing.Size(242, 46);
            this.SlidingPanel_ToggelButton.TabIndex = 0;
            this.SlidingPanel_ToggelButton.UseVisualStyleBackColor = false;
            this.SlidingPanel_ToggelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // minimize
            // 
            this.minimize.BackgroundImage = global::Charity_Database_Management.Properties.Resources.images;
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimize.Location = new System.Drawing.Point(960, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(34, 29);
            this.minimize.TabIndex = 2;
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // maximize
            // 
            this.maximize.BackgroundImage = global::Charity_Database_Management.Properties.Resources.images1;
            this.maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maximize.Location = new System.Drawing.Point(926, 0);
            this.maximize.Name = "maximize";
            this.maximize.Size = new System.Drawing.Size(35, 29);
            this.maximize.TabIndex = 3;
            this.maximize.UseVisualStyleBackColor = true;
            this.maximize.Click += new System.EventHandler(this.maximize_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImage = global::Charity_Database_Management.Properties.Resources.Close_icon1;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close.Location = new System.Drawing.Point(993, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(33, 29);
            this.close.TabIndex = 1;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // introduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 443);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SlidingPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "introduction";
            this.Text = "introduction";
            this.Load += new System.EventHandler(this.introduction_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.SlidingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button maximize;
        private System.Windows.Forms.Panel SlidingPanel;
        private System.Windows.Forms.Button SlidingPanel_ToggelButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
    }
}