namespace bitmapCso
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblR = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panColor = new System.Windows.Forms.Panel();
            this.numR = new System.Windows.Forms.NumericUpDown();
            this.numG = new System.Windows.Forms.NumericUpDown();
            this.numB = new System.Windows.Forms.NumericUpDown();
            this.numA = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panControl = new System.Windows.Forms.Panel();
            this.rdbChColor = new System.Windows.Forms.RadioButton();
            this.rdbCheck = new System.Windows.Forms.RadioButton();
            this.lblCheckR = new System.Windows.Forms.Label();
            this.lblCheckG = new System.Windows.Forms.Label();
            this.lblCheckB = new System.Windows.Forms.Label();
            this.lblCheckA = new System.Windows.Forms.Label();
            this.lblCheckTag = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panOpControl = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOutput = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rdbClean = new System.Windows.Forms.RadioButton();
            this.btnClean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).BeginInit();
            this.panControl.SuspendLayout();
            this.panOpControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblR.Location = new System.Drawing.Point(28, 140);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(38, 21);
            this.lblR.TabIndex = 1;
            this.lblR.Text = "R : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(28, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "G : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(28, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "B : ";
            // 
            // panColor
            // 
            this.panColor.BackColor = System.Drawing.Color.Black;
            this.panColor.Location = new System.Drawing.Point(638, -4);
            this.panColor.Name = "panColor";
            this.panColor.Size = new System.Drawing.Size(45, 466);
            this.panColor.TabIndex = 7;
            // 
            // numR
            // 
            this.numR.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numR.Location = new System.Drawing.Point(70, 136);
            this.numR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numR.Name = "numR";
            this.numR.Size = new System.Drawing.Size(92, 30);
            this.numR.TabIndex = 8;
            this.numR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numR.ValueChanged += new System.EventHandler(this.RGB_ValueChanged);
            // 
            // numG
            // 
            this.numG.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numG.Location = new System.Drawing.Point(70, 172);
            this.numG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numG.Name = "numG";
            this.numG.Size = new System.Drawing.Size(92, 30);
            this.numG.TabIndex = 8;
            this.numG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numG.ValueChanged += new System.EventHandler(this.RGB_ValueChanged);
            // 
            // numB
            // 
            this.numB.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numB.Location = new System.Drawing.Point(70, 208);
            this.numB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(92, 30);
            this.numB.TabIndex = 8;
            this.numB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numB.ValueChanged += new System.EventHandler(this.RGB_ValueChanged);
            // 
            // numA
            // 
            this.numA.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numA.Location = new System.Drawing.Point(70, 244);
            this.numA.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numA.Name = "numA";
            this.numA.Size = new System.Drawing.Size(92, 30);
            this.numA.TabIndex = 10;
            this.numA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numA.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numA.ValueChanged += new System.EventHandler(this.RGB_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(28, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "A : ";
            // 
            // panControl
            // 
            this.panControl.Controls.Add(this.btnClean);
            this.panControl.Controls.Add(this.label4);
            this.panControl.Controls.Add(this.rdbCheck);
            this.panControl.Controls.Add(this.rdbClean);
            this.panControl.Controls.Add(this.rdbChColor);
            this.panControl.Controls.Add(this.numA);
            this.panControl.Controls.Add(this.numR);
            this.panControl.Controls.Add(this.lblCheckTag);
            this.panControl.Controls.Add(this.lblCheckA);
            this.panControl.Controls.Add(this.label3);
            this.panControl.Controls.Add(this.lblCheckR);
            this.panControl.Controls.Add(this.lblR);
            this.panControl.Controls.Add(this.numB);
            this.panControl.Controls.Add(this.lblCheckG);
            this.panControl.Controls.Add(this.label1);
            this.panControl.Controls.Add(this.numG);
            this.panControl.Controls.Add(this.lblCheckB);
            this.panControl.Controls.Add(this.label2);
            this.panControl.Location = new System.Drawing.Point(437, -4);
            this.panControl.Name = "panControl";
            this.panControl.Size = new System.Drawing.Size(203, 494);
            this.panControl.TabIndex = 11;
            // 
            // rdbChColor
            // 
            this.rdbChColor.AutoSize = true;
            this.rdbChColor.Checked = true;
            this.rdbChColor.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdbChColor.Location = new System.Drawing.Point(32, 108);
            this.rdbChColor.Name = "rdbChColor";
            this.rdbChColor.Size = new System.Drawing.Size(141, 23);
            this.rdbChColor.TabIndex = 11;
            this.rdbChColor.Text = "更改畫格顏色";
            this.rdbChColor.UseVisualStyleBackColor = true;
            // 
            // rdbCheck
            // 
            this.rdbCheck.AutoSize = true;
            this.rdbCheck.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdbCheck.Location = new System.Drawing.Point(32, 288);
            this.rdbCheck.Name = "rdbCheck";
            this.rdbCheck.Size = new System.Drawing.Size(141, 23);
            this.rdbCheck.TabIndex = 11;
            this.rdbCheck.Text = "查看畫格顏色";
            this.rdbCheck.UseVisualStyleBackColor = true;
            // 
            // lblCheckR
            // 
            this.lblCheckR.AutoSize = true;
            this.lblCheckR.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCheckR.Location = new System.Drawing.Point(28, 314);
            this.lblCheckR.Name = "lblCheckR";
            this.lblCheckR.Size = new System.Drawing.Size(38, 21);
            this.lblCheckR.TabIndex = 1;
            this.lblCheckR.Text = "R : ";
            // 
            // lblCheckG
            // 
            this.lblCheckG.AutoSize = true;
            this.lblCheckG.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCheckG.Location = new System.Drawing.Point(28, 342);
            this.lblCheckG.Name = "lblCheckG";
            this.lblCheckG.Size = new System.Drawing.Size(39, 21);
            this.lblCheckG.TabIndex = 3;
            this.lblCheckG.Text = "G : ";
            // 
            // lblCheckB
            // 
            this.lblCheckB.AutoSize = true;
            this.lblCheckB.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCheckB.Location = new System.Drawing.Point(28, 370);
            this.lblCheckB.Name = "lblCheckB";
            this.lblCheckB.Size = new System.Drawing.Size(38, 21);
            this.lblCheckB.TabIndex = 5;
            this.lblCheckB.Text = "B : ";
            // 
            // lblCheckA
            // 
            this.lblCheckA.AutoSize = true;
            this.lblCheckA.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCheckA.Location = new System.Drawing.Point(28, 397);
            this.lblCheckA.Name = "lblCheckA";
            this.lblCheckA.Size = new System.Drawing.Size(39, 21);
            this.lblCheckA.TabIndex = 9;
            this.lblCheckA.Text = "A : ";
            // 
            // lblCheckTag
            // 
            this.lblCheckTag.AutoSize = true;
            this.lblCheckTag.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCheckTag.Location = new System.Drawing.Point(10, 422);
            this.lblCheckTag.Name = "lblCheckTag";
            this.lblCheckTag.Size = new System.Drawing.Size(56, 21);
            this.lblCheckTag.TabIndex = 9;
            this.lblCheckTag.Text = "Tag : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(28, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "畫板 : ";
            // 
            // panOpControl
            // 
            this.panOpControl.Controls.Add(this.txtName);
            this.panOpControl.Controls.Add(this.label6);
            this.panOpControl.Controls.Add(this.label5);
            this.panOpControl.Controls.Add(this.btnOutput);
            this.panOpControl.Location = new System.Drawing.Point(673, -4);
            this.panOpControl.Name = "panOpControl";
            this.panOpControl.Size = new System.Drawing.Size(222, 474);
            this.panOpControl.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(16, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "輸出設定 : ";
            // 
            // btnOutput
            // 
            this.btnOutput.AutoSize = true;
            this.btnOutput.BackColor = System.Drawing.Color.White;
            this.btnOutput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOutput.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOutput.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOutput.Location = new System.Drawing.Point(61, 399);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(141, 42);
            this.btnOutput.TabIndex = 14;
            this.btnOutput.Text = "輸出";
            this.btnOutput.UseVisualStyleBackColor = false;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(16, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "名字(英文或數字) : ";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(20, 102);
            this.txtName.MaxLength = 10;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 30);
            this.txtName.TabIndex = 17;
            this.txtName.Text = "img1";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdbClean
            // 
            this.rdbClean.AutoSize = true;
            this.rdbClean.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdbClean.Location = new System.Drawing.Point(32, 74);
            this.rdbClean.Name = "rdbClean";
            this.rdbClean.Size = new System.Drawing.Size(84, 23);
            this.rdbClean.TabIndex = 11;
            this.rdbClean.Text = "橡皮擦";
            this.rdbClean.UseVisualStyleBackColor = true;
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClean.Location = new System.Drawing.Point(32, 38);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(130, 30);
            this.btnClean.TabIndex = 13;
            this.btnClean.Text = "重新繪畫";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bitmapCso.Properties.Resources.t;
            this.ClientSize = new System.Drawing.Size(895, 447);
            this.Controls.Add(this.panOpControl);
            this.Controls.Add(this.panControl);
            this.Controls.Add(this.panColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).EndInit();
            this.panControl.ResumeLayout(false);
            this.panControl.PerformLayout();
            this.panOpControl.ResumeLayout(false);
            this.panOpControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panColor;
        private System.Windows.Forms.NumericUpDown numR;
        private System.Windows.Forms.NumericUpDown numG;
        private System.Windows.Forms.NumericUpDown numB;
        private System.Windows.Forms.NumericUpDown numA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panControl;
        private System.Windows.Forms.RadioButton rdbChColor;
        private System.Windows.Forms.RadioButton rdbCheck;
        private System.Windows.Forms.Label lblCheckA;
        private System.Windows.Forms.Label lblCheckR;
        private System.Windows.Forms.Label lblCheckG;
        private System.Windows.Forms.Label lblCheckB;
        private System.Windows.Forms.Label lblCheckTag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panOpControl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbClean;
        private System.Windows.Forms.Button btnClean;
    }
}

