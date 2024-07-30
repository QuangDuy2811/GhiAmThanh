namespace GD_GhiAm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRecord = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stopBox = new System.Windows.Forms.PictureBox();
            this.recorderBox = new System.Windows.Forms.PictureBox();
            this.labelTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stopBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recorderBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.lblRecord);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 48);
            this.panel1.TabIndex = 0;
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Location = new System.Drawing.Point(26, 17);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(0, 13);
            this.lblRecord.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Record Computer Audio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(410, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // stopBox
            // 
            this.stopBox.Image = ((System.Drawing.Image)(resources.GetObject("stopBox.Image")));
            this.stopBox.Location = new System.Drawing.Point(134, 158);
            this.stopBox.Name = "stopBox";
            this.stopBox.Size = new System.Drawing.Size(45, 36);
            this.stopBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stopBox.TabIndex = 1;
            this.stopBox.TabStop = false;
            this.stopBox.Click += new System.EventHandler(this.stopBox_Click);
            // 
            // recorderBox
            // 
            this.recorderBox.BackColor = System.Drawing.Color.Transparent;
            this.recorderBox.Image = ((System.Drawing.Image)(resources.GetObject("recorderBox.Image")));
            this.recorderBox.Location = new System.Drawing.Point(29, 158);
            this.recorderBox.Name = "recorderBox";
            this.recorderBox.Size = new System.Drawing.Size(40, 36);
            this.recorderBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.recorderBox.TabIndex = 2;
            this.recorderBox.TabStop = false;
            this.recorderBox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.labelTimer.Location = new System.Drawing.Point(63, 92);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(86, 23);
            this.labelTimer.TabIndex = 4;
            this.labelTimer.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(245, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(171, 147);
            this.listBox1.TabIndex = 5;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 227);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.recorderBox);
            this.Controls.Add(this.stopBox);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Name = "Form1";
            this.Text = "GhiAm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stopBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recorderBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox stopBox;
        private System.Windows.Forms.PictureBox recorderBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.ListBox listBox1;
    }
}

