namespace TestTabPageAutoScroll
{
	partial class Form2
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1144, 733);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.AutoScroll = true;
			this.tabPage1.Controls.Add(this.panel1);
			this.tabPage1.Controls.Add(this.panel2);
			this.tabPage1.Location = new System.Drawing.Point(10, 48);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1124, 675);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.AutoScrollMinSize = new System.Drawing.Size(53, 30);
			this.panel1.Controls.Add(this.richTextBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(697, 669);
			this.panel1.TabIndex = 0;
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.SystemColors.Highlight;
			this.richTextBox1.Location = new System.Drawing.Point(0, 0);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(697, 669);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.richTextBox2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(702, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(419, 669);
			this.panel2.TabIndex = 1;
			// 
			// richTextBox2
			// 
			this.richTextBox2.BackColor = System.Drawing.Color.IndianRed;
			this.richTextBox2.Location = new System.Drawing.Point(0, 0);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(419, 669);
			this.richTextBox2.TabIndex = 0;
			this.richTextBox2.Text = "";
			// 
			// tabPage2
			// 
			this.tabPage2.AutoScroll = true;
			this.tabPage2.Location = new System.Drawing.Point(10, 48);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1124, 675);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1144, 733);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}

