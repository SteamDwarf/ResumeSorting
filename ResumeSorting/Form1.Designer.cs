
namespace ResumeSorting
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxWorkExperience = new System.Windows.Forms.TextBox();
            this.textBoxEducation = new System.Windows.Forms.TextBox();
            this.textBoxBirth = new System.Windows.Forms.TextBox();
            this.textBoxThirdName = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelWorkExperience = new System.Windows.Forms.Label();
            this.labelEducation = new System.Windows.Forms.Label();
            this.labelBirth = new System.Windows.Forms.Label();
            this.labelThirdName = new System.Windows.Forms.Label();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(113, 35);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 2;
            // 
            // textBoxWorkExperience
            // 
            this.textBoxWorkExperience.Location = new System.Drawing.Point(113, 224);
            this.textBoxWorkExperience.Name = "textBoxWorkExperience";
            this.textBoxWorkExperience.Size = new System.Drawing.Size(100, 20);
            this.textBoxWorkExperience.TabIndex = 3;
            // 
            // textBoxEducation
            // 
            this.textBoxEducation.Location = new System.Drawing.Point(113, 188);
            this.textBoxEducation.Name = "textBoxEducation";
            this.textBoxEducation.Size = new System.Drawing.Size(100, 20);
            this.textBoxEducation.TabIndex = 4;
            // 
            // textBoxBirth
            // 
            this.textBoxBirth.Location = new System.Drawing.Point(113, 150);
            this.textBoxBirth.Name = "textBoxBirth";
            this.textBoxBirth.Size = new System.Drawing.Size(100, 20);
            this.textBoxBirth.TabIndex = 5;
            // 
            // textBoxThirdName
            // 
            this.textBoxThirdName.Location = new System.Drawing.Point(113, 111);
            this.textBoxThirdName.Name = "textBoxThirdName";
            this.textBoxThirdName.Size = new System.Drawing.Size(100, 20);
            this.textBoxThirdName.TabIndex = 6;
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(113, 70);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(100, 20);
            this.textBoxSecondName.TabIndex = 7;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(12, 35);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(29, 13);
            this.labelFirstName.TabIndex = 8;
            this.labelFirstName.Text = "Имя";
            // 
            // labelWorkExperience
            // 
            this.labelWorkExperience.AutoSize = true;
            this.labelWorkExperience.Location = new System.Drawing.Point(12, 224);
            this.labelWorkExperience.Name = "labelWorkExperience";
            this.labelWorkExperience.Size = new System.Drawing.Size(74, 13);
            this.labelWorkExperience.TabIndex = 9;
            this.labelWorkExperience.Text = "Опыт работы";
            // 
            // labelEducation
            // 
            this.labelEducation.AutoSize = true;
            this.labelEducation.Location = new System.Drawing.Point(10, 188);
            this.labelEducation.Name = "labelEducation";
            this.labelEducation.Size = new System.Drawing.Size(75, 13);
            this.labelEducation.TabIndex = 10;
            this.labelEducation.Text = "Образование";
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.Location = new System.Drawing.Point(10, 150);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Size = new System.Drawing.Size(86, 13);
            this.labelBirth.TabIndex = 11;
            this.labelBirth.Text = "Дата рождения";
            // 
            // labelThirdName
            // 
            this.labelThirdName.AutoSize = true;
            this.labelThirdName.Location = new System.Drawing.Point(12, 111);
            this.labelThirdName.Name = "labelThirdName";
            this.labelThirdName.Size = new System.Drawing.Size(54, 13);
            this.labelThirdName.TabIndex = 12;
            this.labelThirdName.Text = "Отчество";
            // 
            // labelSecondName
            // 
            this.labelSecondName.AutoSize = true;
            this.labelSecondName.Location = new System.Drawing.Point(10, 70);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(56, 13);
            this.labelSecondName.TabIndex = 13;
            this.labelSecondName.Text = "Фамилия";
            this.labelSecondName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 40);
            this.button2.TabIndex = 16;
            this.button2.Text = "Открыть папку";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.richTextBox1.Location = new System.Drawing.Point(665, 35);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(310, 445);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.richTextBox2.Location = new System.Drawing.Point(274, 35);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox2.Size = new System.Drawing.Size(340, 445);
            this.richTextBox2.TabIndex = 20;
            this.richTextBox2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1004, 510);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelSecondName);
            this.Controls.Add(this.labelThirdName);
            this.Controls.Add(this.labelBirth);
            this.Controls.Add(this.labelEducation);
            this.Controls.Add(this.labelWorkExperience);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxSecondName);
            this.Controls.Add(this.textBoxThirdName);
            this.Controls.Add(this.textBoxBirth);
            this.Controls.Add(this.textBoxEducation);
            this.Controls.Add(this.textBoxWorkExperience);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxWorkExperience;
        private System.Windows.Forms.TextBox textBoxEducation;
        private System.Windows.Forms.TextBox textBoxBirth;
        private System.Windows.Forms.TextBox textBoxThirdName;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelWorkExperience;
        private System.Windows.Forms.Label labelEducation;
        private System.Windows.Forms.Label labelBirth;
        private System.Windows.Forms.Label labelThirdName;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

