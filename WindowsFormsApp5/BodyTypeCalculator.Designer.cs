namespace WindowsFormsApp5
{
    partial class BodyTypeCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BodyTypeCalculator));
            this.btnStart = new System.Windows.Forms.Button();
            this.lb1EveryShape = new System.Windows.Forms.Label();
            this.pnlCalculator = new System.Windows.Forms.Panel();
            this.lbStyleReminder = new System.Windows.Forms.Label();
            this.lbReminder = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPlayQuiz = new System.Windows.Forms.Button();
            this.txtHipSize = new System.Windows.Forms.TextBox();
            this.txtWaistSize = new System.Windows.Forms.TextBox();
            this.txtBustSize = new System.Windows.Forms.TextBox();
            this.txtShoulderSize = new System.Windows.Forms.TextBox();
            this.hipSize = new System.Windows.Forms.Label();
            this.waistSize = new System.Windows.Forms.Label();
            this.bustSize = new System.Windows.Forms.Label();
            this.shoulderSize = new System.Windows.Forms.Label();
            this.cbUnit4 = new System.Windows.Forms.ComboBox();
            this.cbUnit3 = new System.Windows.Forms.ComboBox();
            this.cbUnit2 = new System.Windows.Forms.ComboBox();
            this.cbUnit1 = new System.Windows.Forms.ComboBox();
            this.lbYourShape = new System.Windows.Forms.Label();
            this.pnlCalculator.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.BurlyWood;
            this.btnStart.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(399, 136);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(247, 43);
            this.btnStart.TabIndex = 22;
            this.btnStart.Text = "Find out your shape here!";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lb1EveryShape
            // 
            this.lb1EveryShape.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb1EveryShape.AutoSize = true;
            this.lb1EveryShape.BackColor = System.Drawing.Color.Transparent;
            this.lb1EveryShape.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1EveryShape.ForeColor = System.Drawing.Color.Black;
            this.lb1EveryShape.Location = new System.Drawing.Point(348, 53);
            this.lb1EveryShape.Name = "lb1EveryShape";
            this.lb1EveryShape.Size = new System.Drawing.Size(521, 42);
            this.lb1EveryShape.TabIndex = 21;
            this.lb1EveryShape.Text = "Welcome To StyleMeetsShapes\r\n";
            this.lb1EveryShape.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCalculator
            // 
            this.pnlCalculator.Controls.Add(this.lbStyleReminder);
            this.pnlCalculator.Controls.Add(this.lbReminder);
            this.pnlCalculator.Controls.Add(this.btnCalculate);
            this.pnlCalculator.Controls.Add(this.btnReset);
            this.pnlCalculator.Controls.Add(this.btnPlayQuiz);
            this.pnlCalculator.Controls.Add(this.txtHipSize);
            this.pnlCalculator.Controls.Add(this.txtWaistSize);
            this.pnlCalculator.Controls.Add(this.txtBustSize);
            this.pnlCalculator.Controls.Add(this.txtShoulderSize);
            this.pnlCalculator.Controls.Add(this.hipSize);
            this.pnlCalculator.Controls.Add(this.waistSize);
            this.pnlCalculator.Controls.Add(this.bustSize);
            this.pnlCalculator.Controls.Add(this.shoulderSize);
            this.pnlCalculator.Controls.Add(this.cbUnit4);
            this.pnlCalculator.Controls.Add(this.cbUnit3);
            this.pnlCalculator.Controls.Add(this.cbUnit2);
            this.pnlCalculator.Controls.Add(this.cbUnit1);
            this.pnlCalculator.Controls.Add(this.lbYourShape);
            this.pnlCalculator.Location = new System.Drawing.Point(32, 220);
            this.pnlCalculator.Name = "pnlCalculator";
            this.pnlCalculator.Size = new System.Drawing.Size(1003, 394);
            this.pnlCalculator.TabIndex = 23;
            this.pnlCalculator.Visible = false;
            // 
            // lbStyleReminder
            // 
            this.lbStyleReminder.AutoSize = true;
            this.lbStyleReminder.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStyleReminder.Location = new System.Drawing.Point(593, 186);
            this.lbStyleReminder.Name = "lbStyleReminder";
            this.lbStyleReminder.Size = new System.Drawing.Size(375, 21);
            this.lbStyleReminder.TabIndex = 54;
            this.lbStyleReminder.Text = "You only need to style according to your shape!";
            this.lbStyleReminder.Visible = false;
            // 
            // lbReminder
            // 
            this.lbReminder.AutoSize = true;
            this.lbReminder.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReminder.Location = new System.Drawing.Point(593, 150);
            this.lbReminder.Name = "lbReminder";
            this.lbReminder.Size = new System.Drawing.Size(397, 21);
            this.lbReminder.TabIndex = 53;
            this.lbReminder.Text = "GENTLE REMINDER : EVERY SHAPE IS BEAUTIFUL!!";
            this.lbReminder.Visible = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnCalculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.Tomato;
            this.btnCalculate.Location = new System.Drawing.Point(323, 284);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(133, 48);
            this.btnCalculate.TabIndex = 38;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnReset.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Teal;
            this.btnReset.Location = new System.Drawing.Point(161, 284);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(133, 48);
            this.btnReset.TabIndex = 39;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPlayQuiz
            // 
            this.btnPlayQuiz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlayQuiz.BackColor = System.Drawing.Color.Bisque;
            this.btnPlayQuiz.CausesValidation = false;
            this.btnPlayQuiz.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayQuiz.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayQuiz.Image")));
            this.btnPlayQuiz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlayQuiz.Location = new System.Drawing.Point(587, 282);
            this.btnPlayQuiz.Name = "btnPlayQuiz";
            this.btnPlayQuiz.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPlayQuiz.Size = new System.Drawing.Size(265, 50);
            this.btnPlayQuiz.TabIndex = 52;
            this.btnPlayQuiz.Text = "       Wanna play style quiz?";
            this.btnPlayQuiz.UseVisualStyleBackColor = false;
            this.btnPlayQuiz.Visible = false;
            this.btnPlayQuiz.Click += new System.EventHandler(this.btnPlayQuiz_Click);
            // 
            // txtHipSize
            // 
            this.txtHipSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHipSize.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtHipSize.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHipSize.Location = new System.Drawing.Point(280, 200);
            this.txtHipSize.Name = "txtHipSize";
            this.txtHipSize.Size = new System.Drawing.Size(118, 30);
            this.txtHipSize.TabIndex = 47;
            this.txtHipSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWaistSize
            // 
            this.txtWaistSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWaistSize.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtWaistSize.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWaistSize.Location = new System.Drawing.Point(280, 154);
            this.txtWaistSize.Name = "txtWaistSize";
            this.txtWaistSize.Size = new System.Drawing.Size(118, 30);
            this.txtWaistSize.TabIndex = 46;
            this.txtWaistSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBustSize
            // 
            this.txtBustSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBustSize.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtBustSize.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBustSize.Location = new System.Drawing.Point(280, 107);
            this.txtBustSize.Name = "txtBustSize";
            this.txtBustSize.Size = new System.Drawing.Size(118, 30);
            this.txtBustSize.TabIndex = 45;
            this.txtBustSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtShoulderSize
            // 
            this.txtShoulderSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtShoulderSize.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtShoulderSize.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShoulderSize.Location = new System.Drawing.Point(280, 57);
            this.txtShoulderSize.Name = "txtShoulderSize";
            this.txtShoulderSize.Size = new System.Drawing.Size(118, 30);
            this.txtShoulderSize.TabIndex = 44;
            this.txtShoulderSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hipSize
            // 
            this.hipSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hipSize.AutoSize = true;
            this.hipSize.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hipSize.Location = new System.Drawing.Point(156, 205);
            this.hipSize.Name = "hipSize";
            this.hipSize.Size = new System.Drawing.Size(99, 25);
            this.hipSize.TabIndex = 43;
            this.hipSize.Text = "Hip Size : ";
            // 
            // waistSize
            // 
            this.waistSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.waistSize.AutoSize = true;
            this.waistSize.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waistSize.Location = new System.Drawing.Point(142, 154);
            this.waistSize.Name = "waistSize";
            this.waistSize.Size = new System.Drawing.Size(117, 25);
            this.waistSize.TabIndex = 42;
            this.waistSize.Text = "Waist Size : ";
            // 
            // bustSize
            // 
            this.bustSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bustSize.AutoSize = true;
            this.bustSize.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bustSize.Location = new System.Drawing.Point(142, 107);
            this.bustSize.Name = "bustSize";
            this.bustSize.Size = new System.Drawing.Size(107, 25);
            this.bustSize.TabIndex = 41;
            this.bustSize.Text = "Bust Size : ";
            // 
            // shoulderSize
            // 
            this.shoulderSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shoulderSize.AutoSize = true;
            this.shoulderSize.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoulderSize.Location = new System.Drawing.Point(120, 60);
            this.shoulderSize.Name = "shoulderSize";
            this.shoulderSize.Size = new System.Drawing.Size(144, 25);
            this.shoulderSize.TabIndex = 40;
            this.shoulderSize.Text = "Shoulder Size :";
            // 
            // cbUnit4
            // 
            this.cbUnit4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbUnit4.BackColor = System.Drawing.Color.NavajoWhite;
            this.cbUnit4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnit4.FormattingEnabled = true;
            this.cbUnit4.Items.AddRange(new object[] {
            "in",
            "cm"});
            this.cbUnit4.Location = new System.Drawing.Point(414, 200);
            this.cbUnit4.Name = "cbUnit4";
            this.cbUnit4.Size = new System.Drawing.Size(70, 33);
            this.cbUnit4.TabIndex = 51;
            // 
            // cbUnit3
            // 
            this.cbUnit3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbUnit3.BackColor = System.Drawing.Color.NavajoWhite;
            this.cbUnit3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnit3.FormattingEnabled = true;
            this.cbUnit3.Items.AddRange(new object[] {
            "in",
            "cm"});
            this.cbUnit3.Location = new System.Drawing.Point(414, 155);
            this.cbUnit3.Name = "cbUnit3";
            this.cbUnit3.Size = new System.Drawing.Size(70, 33);
            this.cbUnit3.TabIndex = 50;
            // 
            // cbUnit2
            // 
            this.cbUnit2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbUnit2.BackColor = System.Drawing.Color.NavajoWhite;
            this.cbUnit2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnit2.FormattingEnabled = true;
            this.cbUnit2.Items.AddRange(new object[] {
            "in",
            "cm"});
            this.cbUnit2.Location = new System.Drawing.Point(414, 108);
            this.cbUnit2.Name = "cbUnit2";
            this.cbUnit2.Size = new System.Drawing.Size(70, 33);
            this.cbUnit2.TabIndex = 49;
            // 
            // cbUnit1
            // 
            this.cbUnit1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbUnit1.BackColor = System.Drawing.Color.NavajoWhite;
            this.cbUnit1.DisplayMember = "in";
            this.cbUnit1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnit1.FormattingEnabled = true;
            this.cbUnit1.Items.AddRange(new object[] {
            "in",
            "cm"});
            this.cbUnit1.Location = new System.Drawing.Point(414, 58);
            this.cbUnit1.Name = "cbUnit1";
            this.cbUnit1.Size = new System.Drawing.Size(70, 33);
            this.cbUnit1.TabIndex = 48;
            this.cbUnit1.ValueMember = "in";
            // 
            // lbYourShape
            // 
            this.lbYourShape.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbYourShape.AutoSize = true;
            this.lbYourShape.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYourShape.Location = new System.Drawing.Point(580, 70);
            this.lbYourShape.Name = "lbYourShape";
            this.lbYourShape.Size = new System.Drawing.Size(364, 37);
            this.lbYourShape.TabIndex = 36;
            this.lbYourShape.Text = "Your Shape is Body Type";
            this.lbYourShape.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbYourShape.Visible = false;
            // 
            // BodyTypeCalculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1069, 636);
            this.Controls.Add(this.pnlCalculator);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lb1EveryShape);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "BodyTypeCalculator";
            this.Text = "BodyTypeCalculator";
            this.pnlCalculator.ResumeLayout(false);
            this.pnlCalculator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lb1EveryShape;
        private System.Windows.Forms.Panel pnlCalculator;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPlayQuiz;
        private System.Windows.Forms.TextBox txtHipSize;
        private System.Windows.Forms.TextBox txtWaistSize;
        private System.Windows.Forms.TextBox txtBustSize;
        private System.Windows.Forms.TextBox txtShoulderSize;
        private System.Windows.Forms.Label hipSize;
        private System.Windows.Forms.Label waistSize;
        private System.Windows.Forms.Label bustSize;
        private System.Windows.Forms.Label shoulderSize;
        private System.Windows.Forms.ComboBox cbUnit4;
        private System.Windows.Forms.ComboBox cbUnit3;
        private System.Windows.Forms.ComboBox cbUnit2;
        private System.Windows.Forms.ComboBox cbUnit1;
        private System.Windows.Forms.Label lbYourShape;
        private System.Windows.Forms.Label lbReminder;
        private System.Windows.Forms.Label lbStyleReminder;
    }
}