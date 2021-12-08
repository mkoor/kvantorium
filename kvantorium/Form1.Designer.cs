namespace kvantorium
{
    partial class menu
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
            this.buttonParticipant = new System.Windows.Forms.Button();
            this.buttonMentor = new System.Windows.Forms.Button();
            this.buttonAwards = new System.Windows.Forms.Button();
            this.buttonSubdivision = new System.Windows.Forms.Button();
            this.buttonDirection = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonParticipant
            // 
            this.buttonParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(160)))));
            this.buttonParticipant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonParticipant.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.buttonParticipant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonParticipant.Location = new System.Drawing.Point(30, 116);
            this.buttonParticipant.Name = "buttonParticipant";
            this.buttonParticipant.Size = new System.Drawing.Size(298, 46);
            this.buttonParticipant.TabIndex = 1;
            this.buttonParticipant.Text = "Участники мероприятий";
            this.buttonParticipant.UseVisualStyleBackColor = false;
            this.buttonParticipant.Click += new System.EventHandler(this.buttonParticipant_Click);
            // 
            // buttonMentor
            // 
            this.buttonMentor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(160)))));
            this.buttonMentor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMentor.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMentor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMentor.Location = new System.Drawing.Point(30, 168);
            this.buttonMentor.Name = "buttonMentor";
            this.buttonMentor.Size = new System.Drawing.Size(298, 46);
            this.buttonMentor.TabIndex = 2;
            this.buttonMentor.Text = "Наставники";
            this.buttonMentor.UseVisualStyleBackColor = false;
            this.buttonMentor.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonAwards
            // 
            this.buttonAwards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(160)))));
            this.buttonAwards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAwards.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAwards.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAwards.Location = new System.Drawing.Point(30, 324);
            this.buttonAwards.Name = "buttonAwards";
            this.buttonAwards.Size = new System.Drawing.Size(298, 46);
            this.buttonAwards.TabIndex = 3;
            this.buttonAwards.Text = "Достижения участников";
            this.buttonAwards.UseVisualStyleBackColor = false;
            this.buttonAwards.Click += new System.EventHandler(this.buttonAwards_Click);
            // 
            // buttonSubdivision
            // 
            this.buttonSubdivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(160)))));
            this.buttonSubdivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubdivision.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSubdivision.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSubdivision.Location = new System.Drawing.Point(30, 220);
            this.buttonSubdivision.Name = "buttonSubdivision";
            this.buttonSubdivision.Size = new System.Drawing.Size(298, 46);
            this.buttonSubdivision.TabIndex = 4;
            this.buttonSubdivision.Text = "Структурное подразделение";
            this.buttonSubdivision.UseVisualStyleBackColor = false;
            this.buttonSubdivision.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDirection
            // 
            this.buttonDirection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(160)))));
            this.buttonDirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDirection.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDirection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDirection.Location = new System.Drawing.Point(30, 272);
            this.buttonDirection.Name = "buttonDirection";
            this.buttonDirection.Size = new System.Drawing.Size(298, 46);
            this.buttonDirection.TabIndex = 5;
            this.buttonDirection.Text = "Направление";
            this.buttonDirection.UseVisualStyleBackColor = false;
            this.buttonDirection.Click += new System.EventHandler(this.buttonDirection_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(160)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(30, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Выборка данных о достижениях";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kvantorium.Properties.Resources.logo_kvant_min;
            this.pictureBox1.Location = new System.Drawing.Point(30, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(361, 470);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDirection);
            this.Controls.Add(this.buttonSubdivision);
            this.Controls.Add(this.buttonAwards);
            this.Controls.Add(this.buttonMentor);
            this.Controls.Add(this.buttonParticipant);
            this.Controls.Add(this.pictureBox1);
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Достижения учеников Кванториума";
            this.Load += new System.EventHandler(this.menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonParticipant;
        private System.Windows.Forms.Button buttonMentor;
        private System.Windows.Forms.Button buttonAwards;
        private System.Windows.Forms.Button buttonSubdivision;
        private System.Windows.Forms.Button buttonDirection;
        private System.Windows.Forms.Button button1;
    }
}

