
namespace Jooom_Online
{
   partial class StudentLogin_Form
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
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.loginBox = new System.Windows.Forms.TextBox();
			this.Proceed_Button = new System.Windows.Forms.Button();
			this.Cancel_Button = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.Control;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(31, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 18);
			this.label2.TabIndex = 13;
			this.label2.Text = "Логин:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(28, 139);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 18);
			this.label1.TabIndex = 14;
			this.label1.Text = "Пароль:";
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(102, 138);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(291, 20);
			this.passwordBox.TabIndex = 11;
			this.passwordBox.UseSystemPasswordChar = true;
			this.passwordBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressHandler);
			// 
			// loginBox
			// 
			this.loginBox.Location = new System.Drawing.Point(101, 80);
			this.loginBox.Name = "loginBox";
			this.loginBox.Size = new System.Drawing.Size(291, 20);
			this.loginBox.TabIndex = 12;
			this.loginBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressHandler);
			// 
			// Proceed_Button
			// 
			this.Proceed_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Proceed_Button.Location = new System.Drawing.Point(303, 186);
			this.Proceed_Button.Name = "Proceed_Button";
			this.Proceed_Button.Size = new System.Drawing.Size(89, 42);
			this.Proceed_Button.TabIndex = 9;
			this.Proceed_Button.Text = "Далее";
			this.Proceed_Button.UseVisualStyleBackColor = true;
			this.Proceed_Button.Click += new System.EventHandler(this.Button_Click);
			// 
			// Cancel_Button
			// 
			this.Cancel_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Cancel_Button.Location = new System.Drawing.Point(21, 189);
			this.Cancel_Button.Name = "Cancel_Button";
			this.Cancel_Button.Size = new System.Drawing.Size(89, 42);
			this.Cancel_Button.TabIndex = 10;
			this.Cancel_Button.Text = "Назад";
			this.Cancel_Button.UseVisualStyleBackColor = true;
			this.Cancel_Button.Click += new System.EventHandler(this.Button_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(98, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(237, 24);
			this.label3.TabIndex = 20;
			this.label3.Text = "Авторизация студента";
			// 
			// StudentLogin_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.ClientSize = new System.Drawing.Size(426, 256);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.loginBox);
			this.Controls.Add(this.Proceed_Button);
			this.Controls.Add(this.Cancel_Button);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "StudentLogin_Form";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "StudentLogin_Form";
			this.Enter += new System.EventHandler(this.Button_Click);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressHandler);
			this.ResumeLayout(false);
			this.PerformLayout();

      }

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.TextBox loginBox;
		private System.Windows.Forms.Button Proceed_Button;
		private System.Windows.Forms.Button Cancel_Button;
		private System.Windows.Forms.Label label3;
	}
}