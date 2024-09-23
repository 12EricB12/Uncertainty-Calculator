namespace UncertaintyCalculator
{
    partial class UncertaintyCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UncertaintyCalculator));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            initial1 = new TextBox();
            initial2 = new TextBox();
            final2 = new TextBox();
            final1 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            finalValueAVG = new TextBox();
            label8 = new Label();
            finalUncertainty = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            zValMD = new TextBox();
            xValMD = new TextBox();
            yValMD = new TextBox();
            deltaXValueMD = new TextBox();
            label14 = new Label();
            deltaYValueMD = new TextBox();
            label15 = new Label();
            label16 = new Label();
            deltaZValMD = new TextBox();
            label17 = new Label();
            label20 = new Label();
            zValPow = new TextBox();
            xValPow = new TextBox();
            label21 = new Label();
            powerVal = new TextBox();
            label22 = new Label();
            deltaZValPow = new TextBox();
            label24 = new Label();
            deltaXPow = new TextBox();
            label25 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Initial Value 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 112);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 1;
            label2.Text = "Initial Value 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 190);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 2;
            label3.Text = "Final Value 1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 254);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 3;
            label4.Text = "Final Value 2";
            // 
            // initial1
            // 
            initial1.Location = new Point(12, 74);
            initial1.Name = "initial1";
            initial1.Size = new Size(125, 27);
            initial1.TabIndex = 4;
            initial1.TextChanged += initial1_TextChanged;
            // 
            // initial2
            // 
            initial2.Location = new Point(12, 135);
            initial2.Name = "initial2";
            initial2.Size = new Size(125, 27);
            initial2.TabIndex = 5;
            initial2.TextChanged += initial2_TextChanged;
            // 
            // final2
            // 
            final2.Location = new Point(11, 277);
            final2.Name = "final2";
            final2.Size = new Size(125, 27);
            final2.TabIndex = 6;
            final2.TextChanged += final2_TextChanged;
            // 
            // final1
            // 
            final1.Location = new Point(11, 213);
            final1.Name = "final1";
            final1.Size = new Size(125, 27);
            final1.TabIndex = 6;
            final1.TextChanged += final1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(137, 28);
            label5.TabIndex = 7;
            label5.Text = "Add/subtract";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(299, 9);
            label6.Name = "label6";
            label6.Size = new Size(162, 28);
            label6.TabIndex = 8;
            label6.Text = "Multiply/Divide";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 328);
            label7.Name = "label7";
            label7.Size = new Size(122, 20);
            label7.TabIndex = 9;
            label7.Text = "Final Value (AVG)";
            // 
            // finalValueAVG
            // 
            finalValueAVG.BackColor = SystemColors.Info;
            finalValueAVG.Location = new Point(12, 351);
            finalValueAVG.Name = "finalValueAVG";
            finalValueAVG.ReadOnly = true;
            finalValueAVG.Size = new Size(125, 27);
            finalValueAVG.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 390);
            label8.Name = "label8";
            label8.Size = new Size(119, 20);
            label8.TabIndex = 11;
            label8.Text = "Final Uncertainty";
            // 
            // finalUncertainty
            // 
            finalUncertainty.BackColor = SystemColors.Info;
            finalUncertainty.Location = new Point(11, 413);
            finalUncertainty.Name = "finalUncertainty";
            finalUncertainty.ReadOnly = true;
            finalUncertainty.Size = new Size(125, 27);
            finalUncertainty.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(305, 50);
            label11.Name = "label11";
            label11.Size = new Size(55, 20);
            label11.TabIndex = 17;
            label11.Text = "z value";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(305, 102);
            label12.Name = "label12";
            label12.Size = new Size(55, 20);
            label12.TabIndex = 18;
            label12.Text = "x value";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(305, 155);
            label13.Name = "label13";
            label13.Size = new Size(55, 20);
            label13.TabIndex = 19;
            label13.Text = "y value";
            // 
            // zValMD
            // 
            zValMD.Location = new Point(305, 73);
            zValMD.Name = "zValMD";
            zValMD.Size = new Size(125, 27);
            zValMD.TabIndex = 20;
            zValMD.TextChanged += zValMD_TextChanged;
            // 
            // xValMD
            // 
            xValMD.Location = new Point(305, 125);
            xValMD.Name = "xValMD";
            xValMD.Size = new Size(125, 27);
            xValMD.TabIndex = 21;
            xValMD.TextChanged += xValMD_TextChanged;
            // 
            // yValMD
            // 
            yValMD.Location = new Point(305, 178);
            yValMD.Name = "yValMD";
            yValMD.Size = new Size(125, 27);
            yValMD.TabIndex = 22;
            yValMD.TextChanged += yValMD_TextChanged;
            // 
            // deltaXValueMD
            // 
            deltaXValueMD.Location = new Point(305, 228);
            deltaXValueMD.Name = "deltaXValueMD";
            deltaXValueMD.Size = new Size(125, 27);
            deltaXValueMD.TabIndex = 24;
            deltaXValueMD.TextChanged += deltaXValueMD_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(305, 205);
            label14.Name = "label14";
            label14.Size = new Size(64, 20);
            label14.TabIndex = 23;
            label14.Text = "δx value";
            // 
            // deltaYValueMD
            // 
            deltaYValueMD.Location = new Point(305, 285);
            deltaYValueMD.Name = "deltaYValueMD";
            deltaYValueMD.Size = new Size(125, 27);
            deltaYValueMD.TabIndex = 26;
            deltaYValueMD.TextChanged += deltaYValueMD_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(305, 262);
            label15.Name = "label15";
            label15.Size = new Size(64, 20);
            label15.TabIndex = 25;
            label15.Text = "δy value";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(305, 328);
            label16.Name = "label16";
            label16.Size = new Size(64, 20);
            label16.TabIndex = 27;
            label16.Text = "δz value";
            // 
            // deltaZValMD
            // 
            deltaZValMD.BackColor = SystemColors.Info;
            deltaZValMD.Location = new Point(305, 351);
            deltaZValMD.Name = "deltaZValMD";
            deltaZValMD.ReadOnly = true;
            deltaZValMD.Size = new Size(125, 27);
            deltaZValMD.TabIndex = 28;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(590, 9);
            label17.Name = "label17";
            label17.Size = new Size(70, 28);
            label17.TabIndex = 29;
            label17.Text = "Power";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(590, 50);
            label20.Name = "label20";
            label20.Size = new Size(55, 20);
            label20.TabIndex = 32;
            label20.Text = "z value";
            // 
            // zValPow
            // 
            zValPow.Location = new Point(590, 74);
            zValPow.Name = "zValPow";
            zValPow.Size = new Size(125, 27);
            zValPow.TabIndex = 33;
            zValPow.TextChanged += zValPow_TextChanged;
            // 
            // xValPow
            // 
            xValPow.Location = new Point(590, 125);
            xValPow.Name = "xValPow";
            xValPow.Size = new Size(125, 27);
            xValPow.TabIndex = 35;
            xValPow.TextChanged += xValPow_TextChanged;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(590, 101);
            label21.Name = "label21";
            label21.Size = new Size(55, 20);
            label21.TabIndex = 34;
            label21.Text = "x value";
            // 
            // powerVal
            // 
            powerVal.Location = new Point(590, 229);
            powerVal.Name = "powerVal";
            powerVal.Size = new Size(125, 27);
            powerVal.TabIndex = 37;
            powerVal.TextChanged += powerVal_TextChanged;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(590, 205);
            label22.Name = "label22";
            label22.Size = new Size(88, 20);
            label22.TabIndex = 36;
            label22.Text = "Power value";
            // 
            // deltaZValPow
            // 
            deltaZValPow.BackColor = SystemColors.Info;
            deltaZValPow.Location = new Point(590, 282);
            deltaZValPow.Name = "deltaZValPow";
            deltaZValPow.ReadOnly = true;
            deltaZValPow.Size = new Size(125, 27);
            deltaZValPow.TabIndex = 40;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(590, 259);
            label24.Name = "label24";
            label24.Size = new Size(64, 20);
            label24.TabIndex = 39;
            label24.Text = "δz value";
            // 
            // deltaXPow
            // 
            deltaXPow.Location = new Point(590, 178);
            deltaXPow.Name = "deltaXPow";
            deltaXPow.Size = new Size(125, 27);
            deltaXPow.TabIndex = 42;
            deltaXPow.TextChanged += deltaXPow_TextChanged;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(590, 155);
            label25.Name = "label25";
            label25.Size = new Size(64, 20);
            label25.TabIndex = 41;
            label25.Text = "δx value";
            // 
            // UncertaintyCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deltaXPow);
            Controls.Add(label25);
            Controls.Add(deltaZValPow);
            Controls.Add(label24);
            Controls.Add(powerVal);
            Controls.Add(label22);
            Controls.Add(xValPow);
            Controls.Add(label21);
            Controls.Add(zValPow);
            Controls.Add(label20);
            Controls.Add(label17);
            Controls.Add(deltaZValMD);
            Controls.Add(label16);
            Controls.Add(deltaYValueMD);
            Controls.Add(label15);
            Controls.Add(deltaXValueMD);
            Controls.Add(label14);
            Controls.Add(yValMD);
            Controls.Add(xValMD);
            Controls.Add(zValMD);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(finalUncertainty);
            Controls.Add(label8);
            Controls.Add(finalValueAVG);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(final1);
            Controls.Add(final2);
            Controls.Add(initial2);
            Controls.Add(initial1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UncertaintyCalculator";
            Text = "Uncertainty Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox initial1;
        private TextBox initial2;
        private TextBox final2;
        private TextBox final1;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox finalValueAVG;
        private Label label8;
        private TextBox finalUncertainty;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox zValMD;
        private TextBox xValMD;
        private TextBox yValMD;
        private TextBox deltaXValueMD;
        private Label label14;
        private TextBox deltaYValueMD;
        private Label label15;
        private Label label16;
        private TextBox deltaZValMD;
        private Label label17;
        private Label label20;
        private TextBox zValPow;
        private TextBox xValPow;
        private Label label21;
        private TextBox powerVal;
        private Label label22;
        private TextBox deltaZValPow;
        private Label label24;
        private TextBox deltaXPow;
        private Label label25;
    }
}
