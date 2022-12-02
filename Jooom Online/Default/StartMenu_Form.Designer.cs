
namespace Jooom_Online
{
	partial class StartMenu_Form
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.About_Button = new System.Windows.Forms.Button();
			this.Support_Button = new System.Windows.Forms.Button();
			this.Exit_Button = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.LoginTeacher_Button = new System.Windows.Forms.Button();
			this.LoginStudent_Button = new System.Windows.Forms.Button();
			this.RegisterStudent_Button = new System.Windows.Forms.Button();
			this.RegisterTeacher_Button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(120, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(569, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = " Добро пожаловать в Jooom Online!";
			// 
			// About_Button
			// 
			this.About_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.About_Button.ForeColor = System.Drawing.Color.Black;
			this.About_Button.Location = new System.Drawing.Point(112, 168);
			this.About_Button.Name = "About_Button";
			this.About_Button.Size = new System.Drawing.Size(189, 59);
			this.About_Button.TabIndex = 1;
			this.About_Button.Text = "Что такое Jooom?";
			this.About_Button.UseVisualStyleBackColor = true;
			this.About_Button.Click += new System.EventHandler(this.Button_Click);
			// 
			// Support_Button
			// 
			this.Support_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Support_Button.ForeColor = System.Drawing.Color.Black;
			this.Support_Button.Location = new System.Drawing.Point(512, 168);
			this.Support_Button.Name = "Support_Button";
			this.Support_Button.Size = new System.Drawing.Size(189, 59);
			this.Support_Button.TabIndex = 4;
			this.Support_Button.Text = "Тех. Поддержка";
			this.Support_Button.UseVisualStyleBackColor = true;
			this.Support_Button.Click += new System.EventHandler(this.Button_Click);
			// 
			// Exit_Button
			// 
			this.Exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Exit_Button.ForeColor = System.Drawing.Color.Black;
			this.Exit_Button.Location = new System.Drawing.Point(312, 488);
			this.Exit_Button.Name = "Exit_Button";
			this.Exit_Button.Size = new System.Drawing.Size(184, 56);
			this.Exit_Button.TabIndex = 5;
			this.Exit_Button.Text = "Выйти";
			this.Exit_Button.UseVisualStyleBackColor = true;
			this.Exit_Button.Click += new System.EventHandler(this.Button_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(109, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(599, 37);
			this.label3.TabIndex = 7;
			this.label3.Text = "Выберите одну из опций чтобы начать!";
			// 
			// LoginTeacher_Button
			// 
			this.LoginTeacher_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LoginTeacher_Button.ForeColor = System.Drawing.Color.Black;
			this.LoginTeacher_Button.Location = new System.Drawing.Point(512, 272);
			this.LoginTeacher_Button.Name = "LoginTeacher_Button";
			this.LoginTeacher_Button.Size = new System.Drawing.Size(189, 59);
			this.LoginTeacher_Button.TabIndex = 1;
			this.LoginTeacher_Button.Text = "Вход для преподавателей";
			this.LoginTeacher_Button.UseVisualStyleBackColor = true;
			this.LoginTeacher_Button.Click += new System.EventHandler(this.Button_Click);
			// 
			// LoginStudent_Button
			// 
			this.LoginStudent_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LoginStudent_Button.ForeColor = System.Drawing.Color.Black;
			this.LoginStudent_Button.Location = new System.Drawing.Point(112, 272);
			this.LoginStudent_Button.Name = "LoginStudent_Button";
			this.LoginStudent_Button.Size = new System.Drawing.Size(189, 59);
			this.LoginStudent_Button.TabIndex = 1;
			this.LoginStudent_Button.Text = "Вход для учащихся";
			this.LoginStudent_Button.UseVisualStyleBackColor = true;
			this.LoginStudent_Button.Click += new System.EventHandler(this.Button_Click);
			// 
			// RegisterStudent_Button
			// 
			this.RegisterStudent_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.RegisterStudent_Button.ForeColor = System.Drawing.Color.Black;
			this.RegisterStudent_Button.Location = new System.Drawing.Point(112, 376);
			this.RegisterStudent_Button.Name = "RegisterStudent_Button";
			this.RegisterStudent_Button.Size = new System.Drawing.Size(189, 59);
			this.RegisterStudent_Button.TabIndex = 1;
			this.RegisterStudent_Button.Text = "Регистрация учащихся";
			this.RegisterStudent_Button.UseVisualStyleBackColor = true;
			this.RegisterStudent_Button.Click += new System.EventHandler(this.Button_Click);
			// 
			// RegisterTeacher_Button
			// 
			this.RegisterTeacher_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.RegisterTeacher_Button.ForeColor = System.Drawing.Color.Black;
			this.RegisterTeacher_Button.Location = new System.Drawing.Point(512, 376);
			this.RegisterTeacher_Button.Name = "RegisterTeacher_Button";
			this.RegisterTeacher_Button.Size = new System.Drawing.Size(189, 59);
			this.RegisterTeacher_Button.TabIndex = 1;
			this.RegisterTeacher_Button.Text = "Регистрация преподавателей";
			this.RegisterTeacher_Button.UseVisualStyleBackColor = true;
			this.RegisterTeacher_Button.Click += new System.EventHandler(this.Button_Click);
			// 
			// StartMenu_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.ClientSize = new System.Drawing.Size(828, 588);
			this.ControlBox = false;
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Exit_Button);
			this.Controls.Add(this.Support_Button);
			this.Controls.Add(this.RegisterStudent_Button);
			this.Controls.Add(this.LoginStudent_Button);
			this.Controls.Add(this.RegisterTeacher_Button);
			this.Controls.Add(this.LoginTeacher_Button);
			this.Controls.Add(this.About_Button);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.Color.Brown;
			this.Name = "StartMenu_Form";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button About_Button;
		private System.Windows.Forms.Button Support_Button;
		private System.Windows.Forms.Button Exit_Button;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button LoginTeacher_Button;
		private System.Windows.Forms.Button LoginStudent_Button;
		private System.Windows.Forms.Button RegisterStudent_Button;
		private System.Windows.Forms.Button RegisterTeacher_Button;
	}
}

