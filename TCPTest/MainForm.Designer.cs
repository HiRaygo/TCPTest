/*
 * Created by SharpDevelop.
 * User: XiaoSanya
 * Date: 2015/3/22
 * Time: 19:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TCPTest
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.TextBox textBoxPort;
		private System.Windows.Forms.ComboBox comboBoxIP;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labellink;
		private System.Windows.Forms.Button buttonStop;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxSend;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxSpeed;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxTimes;
		private System.Windows.Forms.Button buttonSend;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxReceive;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel StatusLabelInfo;
		private System.Windows.Forms.CheckBox checkBoxTopMost;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.CheckBox checkBoxLog;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonStart = new System.Windows.Forms.Button();
			this.textBoxPort = new System.Windows.Forms.TextBox();
			this.comboBoxIP = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labellink = new System.Windows.Forms.Label();
			this.buttonStop = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxSend = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxSpeed = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxTimes = new System.Windows.Forms.TextBox();
			this.buttonSend = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxReceive = new System.Windows.Forms.TextBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.StatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.checkBoxTopMost = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.checkBoxLog = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(9, 90);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(69, 23);
			this.buttonStart.TabIndex = 0;
			this.buttonStart.Text = "Start";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.ButtonStartClick);
			// 
			// textBoxPort
			// 
			this.textBoxPort.Location = new System.Drawing.Point(58, 52);
			this.textBoxPort.Name = "textBoxPort";
			this.textBoxPort.Size = new System.Drawing.Size(58, 21);
			this.textBoxPort.TabIndex = 9;
			this.textBoxPort.Text = "54321";
			// 
			// comboBoxIP
			// 
			this.comboBoxIP.FormattingEnabled = true;
			this.comboBoxIP.Location = new System.Drawing.Point(58, 18);
			this.comboBoxIP.Name = "comboBoxIP";
			this.comboBoxIP.Size = new System.Drawing.Size(118, 20);
			this.comboBoxIP.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(9, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "IP:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(9, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 18);
			this.label2.TabIndex = 4;
			this.label2.Text = "Port:";
			// 
			// labellink
			// 
			this.labellink.Location = new System.Drawing.Point(133, 55);
			this.labellink.Name = "labellink";
			this.labellink.Size = new System.Drawing.Size(43, 18);
			this.labellink.TabIndex = 5;
			this.labellink.Text = "unlink";
			// 
			// buttonStop
			// 
			this.buttonStop.Enabled = false;
			this.buttonStop.Location = new System.Drawing.Point(107, 90);
			this.buttonStop.Name = "buttonStop";
			this.buttonStop.Size = new System.Drawing.Size(69, 23);
			this.buttonStop.TabIndex = 6;
			this.buttonStop.Text = "Stop";
			this.buttonStop.UseVisualStyleBackColor = true;
			this.buttonStop.Click += new System.EventHandler(this.ButtonStopClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.buttonStop);
			this.groupBox1.Controls.Add(this.buttonStart);
			this.groupBox1.Controls.Add(this.labellink);
			this.groupBox1.Controls.Add(this.textBoxPort);
			this.groupBox1.Controls.Add(this.comboBoxIP);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(422, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(189, 123);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Server";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(13, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Send";
			// 
			// textBoxSend
			// 
			this.textBoxSend.Location = new System.Drawing.Point(13, 28);
			this.textBoxSend.Multiline = true;
			this.textBoxSend.Name = "textBoxSend";
			this.textBoxSend.Size = new System.Drawing.Size(391, 107);
			this.textBoxSend.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(13, 145);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 15);
			this.label4.TabIndex = 10;
			this.label4.Text = "Speed";
			// 
			// textBoxSpeed
			// 
			this.textBoxSpeed.Location = new System.Drawing.Point(58, 142);
			this.textBoxSpeed.Name = "textBoxSpeed";
			this.textBoxSpeed.Size = new System.Drawing.Size(55, 21);
			this.textBoxSpeed.TabIndex = 11;
			this.textBoxSpeed.Text = "1";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(120, 145);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(66, 15);
			this.label5.TabIndex = 12;
			this.label5.Text = "/s  Times";
			// 
			// textBoxTimes
			// 
			this.textBoxTimes.Location = new System.Drawing.Point(193, 142);
			this.textBoxTimes.Name = "textBoxTimes";
			this.textBoxTimes.Size = new System.Drawing.Size(50, 21);
			this.textBoxTimes.TabIndex = 13;
			this.textBoxTimes.Text = "1";
			// 
			// buttonSend
			// 
			this.buttonSend.Location = new System.Drawing.Point(329, 141);
			this.buttonSend.Name = "buttonSend";
			this.buttonSend.Size = new System.Drawing.Size(75, 23);
			this.buttonSend.TabIndex = 14;
			this.buttonSend.Text = "Send";
			this.buttonSend.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label6.Location = new System.Drawing.Point(13, 173);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 15);
			this.label6.TabIndex = 15;
			this.label6.Text = "Receive";
			// 
			// textBoxReceive
			// 
			this.textBoxReceive.Location = new System.Drawing.Point(13, 192);
			this.textBoxReceive.Multiline = true;
			this.textBoxReceive.Name = "textBoxReceive";
			this.textBoxReceive.ReadOnly = true;
			this.textBoxReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxReceive.Size = new System.Drawing.Size(391, 225);
			this.textBoxReceive.TabIndex = 16;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1,
			this.StatusLabelInfo,
			this.toolStripStatusLabel2});
			this.statusStrip1.Location = new System.Drawing.Point(0, 420);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(624, 22);
			this.statusStrip1.TabIndex = 17;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 17);
			this.toolStripStatusLabel1.Text = " Note:";
			// 
			// StatusLabelInfo
			// 
			this.StatusLabelInfo.AutoSize = false;
			this.StatusLabelInfo.Name = "StatusLabelInfo";
			this.StatusLabelInfo.Size = new System.Drawing.Size(480, 17);
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(131, 17);
			this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
			// 
			// checkBoxTopMost
			// 
			this.checkBoxTopMost.Checked = true;
			this.checkBoxTopMost.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxTopMost.Location = new System.Drawing.Point(329, 3);
			this.checkBoxTopMost.Name = "checkBoxTopMost";
			this.checkBoxTopMost.Size = new System.Drawing.Size(75, 22);
			this.checkBoxTopMost.TabIndex = 18;
			this.checkBoxTopMost.Text = "TopMost";
			this.checkBoxTopMost.UseVisualStyleBackColor = true;
			this.checkBoxTopMost.CheckedChanged += new System.EventHandler(this.CheckBoxTopMostCheckedChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(537, 394);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 19;
			this.button1.Text = "Rules Edit";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// checkBoxLog
			// 
			this.checkBoxLog.Checked = true;
			this.checkBoxLog.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxLog.Location = new System.Drawing.Point(151, 173);
			this.checkBoxLog.Name = "checkBoxLog";
			this.checkBoxLog.Size = new System.Drawing.Size(104, 19);
			this.checkBoxLog.TabIndex = 20;
			this.checkBoxLog.Text = "Log";
			this.checkBoxLog.UseVisualStyleBackColor = true;
			this.checkBoxLog.CheckedChanged += new System.EventHandler(this.CheckBoxLogCheckedChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 442);
			this.Controls.Add(this.checkBoxLog);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.checkBoxTopMost);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.textBoxReceive);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.buttonSend);
			this.Controls.Add(this.textBoxTimes);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxSpeed);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxSend);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TCPTest";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
