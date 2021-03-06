namespace PicColorSetter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SavePicBtn = new System.Windows.Forms.Button();
            this.SelectedColor = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BrightnessSelection = new System.Windows.Forms.HScrollBar();
            this.label4 = new System.Windows.Forms.Label();
            this.BlueSelection = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.GreenSelection = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.RedSelection = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picToned = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picOriginal = new System.Windows.Forms.PictureBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedColor)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picToned)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SavePicBtn);
            this.groupBox4.Controls.Add(this.SelectedColor);
            this.groupBox4.Location = new System.Drawing.Point(436, 443);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(320, 122);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Save";
            // 
            // SavePicBtn
            // 
            this.SavePicBtn.Location = new System.Drawing.Point(128, 20);
            this.SavePicBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SavePicBtn.Name = "SavePicBtn";
            this.SavePicBtn.Size = new System.Drawing.Size(184, 89);
            this.SavePicBtn.TabIndex = 8;
            this.SavePicBtn.Text = "Download Picture";
            this.SavePicBtn.UseVisualStyleBackColor = true;
            this.SavePicBtn.Click += new System.EventHandler(this.SavePicBtn_Click);
            // 
            // SelectedColor
            // 
            this.SelectedColor.BackColor = System.Drawing.Color.LightBlue;
            this.SelectedColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SelectedColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectedColor.Location = new System.Drawing.Point(11, 22);
            this.SelectedColor.Margin = new System.Windows.Forms.Padding(4);
            this.SelectedColor.Name = "SelectedColor";
            this.SelectedColor.Size = new System.Drawing.Size(100, 88);
            this.SelectedColor.TabIndex = 7;
            this.SelectedColor.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BrightnessSelection);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.BlueSelection);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.GreenSelection);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.RedSelection);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(8, 443);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(420, 122);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Set Colors";
            // 
            // BrightnessSelection
            // 
            this.BrightnessSelection.Location = new System.Drawing.Point(76, 102);
            this.BrightnessSelection.Maximum = 264;
            this.BrightnessSelection.Name = "BrightnessSelection";
            this.BrightnessSelection.Size = new System.Drawing.Size(338, 14);
            this.BrightnessSelection.TabIndex = 21;
            this.BrightnessSelection.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrColorComponent_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Bright:";
            // 
            // BlueSelection
            // 
            this.BlueSelection.Location = new System.Drawing.Point(76, 77);
            this.BlueSelection.Maximum = 264;
            this.BlueSelection.Name = "BlueSelection";
            this.BlueSelection.Size = new System.Drawing.Size(338, 14);
            this.BlueSelection.TabIndex = 19;
            this.BlueSelection.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrColorComponent_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Blue:";
            // 
            // GreenSelection
            // 
            this.GreenSelection.Location = new System.Drawing.Point(76, 54);
            this.GreenSelection.Maximum = 264;
            this.GreenSelection.Name = "GreenSelection";
            this.GreenSelection.Size = new System.Drawing.Size(338, 14);
            this.GreenSelection.TabIndex = 17;
            this.GreenSelection.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrColorComponent_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Green:";
            // 
            // RedSelection
            // 
            this.RedSelection.Location = new System.Drawing.Point(76, 31);
            this.RedSelection.Maximum = 264;
            this.RedSelection.Name = "RedSelection";
            this.RedSelection.Size = new System.Drawing.Size(338, 14);
            this.RedSelection.TabIndex = 15;
            this.RedSelection.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrColorComponent_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Red:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picToned);
            this.groupBox2.Location = new System.Drawing.Point(344, 1);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(324, 435);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "After";
            // 
            // picToned
            // 
            this.picToned.Location = new System.Drawing.Point(12, 22);
            this.picToned.Margin = new System.Windows.Forms.Padding(4);
            this.picToned.Name = "picToned";
            this.picToned.Size = new System.Drawing.Size(300, 400);
            this.picToned.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picToned.TabIndex = 5;
            this.picToned.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picOriginal);
            this.groupBox1.Location = new System.Drawing.Point(8, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(327, 435);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Before";
            // 
            // picOriginal
            // 
            this.picOriginal.Image = ((System.Drawing.Image)(resources.GetObject("picOriginal.Image")));
            this.picOriginal.Location = new System.Drawing.Point(14, 30);
            this.picOriginal.Margin = new System.Windows.Forms.Padding(4);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(300, 391);
            this.picOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOriginal.TabIndex = 4;
            this.picOriginal.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(807, 627);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture Color Changer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SelectedColor)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picToned)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button SavePicBtn;
        private System.Windows.Forms.PictureBox SelectedColor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.HScrollBar BrightnessSelection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.HScrollBar BlueSelection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HScrollBar GreenSelection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar RedSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picToned;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picOriginal;

    }
}

