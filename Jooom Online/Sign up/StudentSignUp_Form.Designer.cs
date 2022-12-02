
namespace Jooom_Online
{
	partial class StudentSignUp_Form
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
			this.passwordBox2 = new System.Windows.Forms.TextBox();
			this.passwordBox1 = new System.Windows.Forms.TextBox();
			this.nameBox = new System.Windows.Forms.TextBox();
			this.loginBox = new System.Windows.Forms.TextBox();
			this.Proceed_Button = new System.Windows.Forms.Button();
			this.Cancel_Button = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// passwordBox2
			// 
			this.passwordBox2.Location = new System.Drawing.Point(168, 216);
			this.passwordBox2.Name = "passwordBox2";
			this.passwordBox2.Size = new System.Drawing.Size(288, 20);
			this.passwordBox2.TabIndex = 9;
			this.passwordBox2.UseSystemPasswordChar = true;
			this.passwordBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressHandler);
			// 
			// passwordBox1
			// 
			this.passwordBox1.Location = new System.Drawing.Point(168, 176);
			this.passwordBox1.Name = "passwordBox1";
			this.passwordBox1.Size = new System.Drawing.Size(288, 20);
			this.passwordBox1.TabIndex = 10;
			this.passwordBox1.UseSystemPasswordChar = true;
			this.passwordBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressHandler);
			// 
			// nameBox
			// 
			this.nameBox.Location = new System.Drawing.Point(168, 64);
			this.nameBox.Name = "nameBox";
			this.nameBox.Size = new System.Drawing.Size(288, 20);
			this.nameBox.TabIndex = 11;
			this.nameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressHandler);
			// 
			// loginBox
			// 
			this.loginBox.Location = new System.Drawing.Point(168, 120);
			this.loginBox.Name = "loginBox";
			this.loginBox.Size = new System.Drawing.Size(288, 20);
			this.loginBox.TabIndex = 12;
			this.loginBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressHandler);
			// 
			// Proceed_Button
			// 
			this.Proceed_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Proceed_Button.Location = new System.Drawing.Point(344, 272);
			this.Proceed_Button.Name = "Proceed_Button";
			this.Proceed_Button.Size = new System.Drawing.Size(96, 48);
			this.Proceed_Button.TabIndex = 7;
			this.Proceed_Button.Text = "Далее";
			this.Proceed_Button.UseVisualStyleBackColor = true;
			this.Proceed_Button.Click += new System.EventHandler(this.Button_Click);
			// 
			// Cancel_Button
			// 
			this.Cancel_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Cancel_Button.Location = new System.Drawing.Point(32, 272);
			this.Cancel_Button.Name = "Cancel_Button";
			this.Cancel_Button.Size = new System.Drawing.Size(96, 48);
			this.Cancel_Button.TabIndex = 8;
			this.Cancel_Button.Text = "Назад";
			this.Cancel_Button.UseVisualStyleBackColor = true;
			this.Cancel_Button.Click += new System.EventHandler(this.Button_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(8, 216);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(141, 18);
			this.label3.TabIndex = 3;
			this.label3.Text = "Повторите пароль:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.Control;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(96, 64);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 18);
			this.label4.TabIndex = 4;
			this.label4.Text = "ФИО:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.Control;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(80, 176);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 18);
			this.label2.TabIndex = 5;
			this.label2.Text = "Пароль:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(88, 120);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 18);
			this.label1.TabIndex = 6;
			this.label1.Text = "Логин:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.Control;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(136, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(234, 24);
			this.label5.TabIndex = 20;
			this.label5.Text = "Регистрация студента\r\n";
			// 
			// StudentSignUp_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.ClientSize = new System.Drawing.Size(471, 341);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.passwordBox2);
			this.Controls.Add(this.passwordBox1);
			this.Controls.Add(this.nameBox);
			this.Controls.Add(this.loginBox);
			this.Controls.Add(this.Proceed_Button);
			this.Controls.Add(this.Cancel_Button);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "StudentSignUp_Form";
			this.Text = "StudentSignUp_Form";
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressHandler);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox passwordBox2;
		private System.Windows.Forms.TextBox passwordBox1;
		private System.Windows.Forms.TextBox nameBox;
		private System.Windows.Forms.TextBox loginBox;
		private System.Windows.Forms.Button Proceed_Button;
		private System.Windows.Forms.Button Cancel_Button;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
	}
}