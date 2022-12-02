
namespace Jooom_Online
{
    partial class Watch_Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Watch_Form));
			this.WebinarCode_Box = new System.Windows.Forms.TextBox();
			this.Name_Box = new System.Windows.Forms.TextBox();
			this.WebinarName_Box = new System.Windows.Forms.TextBox();
			this.Cancel_Button = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.Exit_Button = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Watch_Button = new System.Windows.Forms.Button();
			this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
			((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
			this.SuspendLayout();
			// 
			// WebinarCode_Box
			// 
			this.WebinarCode_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.WebinarCode_Box.Location = new System.Drawing.Point(176, 96);
			this.WebinarCode_Box.Name = "WebinarCode_Box";
			this.WebinarCode_Box.Size = new System.Drawing.Size(432, 26);
			this.WebinarCode_Box.TabIndex = 33;
			// 
			// Name_Box
			// 
			this.Name_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Name_Box.Location = new System.Drawing.Point(176, 8);
			this.Name_Box.Name = "Name_Box";
			this.Name_Box.ReadOnly = true;
			this.Name_Box.Size = new System.Drawing.Size(432, 26);
			this.Name_Box.TabIndex = 31;
			// 
			// WebinarName_Box
			// 
			this.WebinarName_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.WebinarName_Box.Location = new System.Drawing.Point(176, 64);
			this.WebinarName_Box.Name = "WebinarName_Box";
			this.WebinarName_Box.ReadOnly = true;
			this.WebinarName_Box.Size = new System.Drawing.Size(432, 26);
			this.WebinarName_Box.TabIndex = 32;
			// 
			// Cancel_Button
			// 
			this.Cancel_Button.BackColor = System.Drawing.SystemColors.HighlightText;
			this.Cancel_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Cancel_Button.ForeColor = System.Drawing.Color.Black;
			this.Cancel_Button.Location = new System.Drawing.Point(8, 588);
			this.Cancel_Button.Name = "Cancel_Button";
			this.Cancel_Button.Size = new System.Drawing.Size(177, 64);
			this.Cancel_Button.TabIndex = 34;
			this.Cancel_Button.Text = "Назад";
			this.Cancel_Button.UseVisualStyleBackColor = false;
			this.Cancel_Button.Click += new System.EventHandler(this.Button_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(64, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 20);
			this.label3.TabIndex = 30;
			this.label3.Text = "Код доступа";
			// 
			// Exit_Button
			// 
			this.Exit_Button.BackColor = System.Drawing.SystemColors.HighlightText;
			this.Exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Exit_Button.ForeColor = System.Drawing.Color.Black;
			this.Exit_Button.Location = new System.Drawing.Point(832, 588);
			this.Exit_Button.Name = "Exit_Button";
			this.Exit_Button.Size = new System.Drawing.Size(177, 62);
			this.Exit_Button.TabIndex = 35;
			this.Exit_Button.Text = "Выйти";
			this.Exit_Button.UseVisualStyleBackColor = false;
			this.Exit_Button.Click += new System.EventHandler(this.Button_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(48, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 20);
			this.label1.TabIndex = 28;
			this.label1.Text = "Вы вошли, как";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(8, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(159, 20);
			this.label2.TabIndex = 29;
			this.label2.Text = "Название вебинара";
			// 
			// Watch_Button
			// 
			this.Watch_Button.BackColor = System.Drawing.Color.White;
			this.Watch_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Watch_Button.Location = new System.Drawing.Point(624, 64);
			this.Watch_Button.Name = "Watch_Button";
			this.Watch_Button.Size = new System.Drawing.Size(384, 56);
			this.Watch_Button.TabIndex = 27;
			this.Watch_Button.Text = "Посмотреть вебинар";
			this.Watch_Button.UseVisualStyleBackColor = false;
			this.Watch_Button.Click += new System.EventHandler(this.Button_Click);
			// 
			// WMP
			// 
			this.WMP.Enabled = true;
			this.WMP.Location = new System.Drawing.Point(8, 132);
			this.WMP.Name = "WMP";
			this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
			this.WMP.Size = new System.Drawing.Size(1004, 445);
			this.WMP.TabIndex = 25;
			// 
			// Watch_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.ClientSize = new System.Drawing.Size(1020, 672);
			this.Controls.Add(this.WebinarCode_Box);
			this.Controls.Add(this.Name_Box);
			this.Controls.Add(this.WebinarName_Box);
			this.Controls.Add(this.Cancel_Button);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Exit_Button);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Watch_Button);
			this.Controls.Add(this.WMP);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Watch_Form";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.TextBox WebinarCode_Box;
		private System.Windows.Forms.TextBox Name_Box;
		private System.Windows.Forms.TextBox WebinarName_Box;
		private System.Windows.Forms.Button Cancel_Button;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button Exit_Button;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button Watch_Button;
		private AxWMPLib.AxWindowsMediaPlayer WMP;
	}
}