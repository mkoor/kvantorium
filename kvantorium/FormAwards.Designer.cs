namespace kvantorium
{
    partial class FormAwards
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
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listViewAwards = new System.Windows.Forms.ListView();
            this.Fi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Direction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subdivision = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LevelEv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameEv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Result = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxParticipant = new System.Windows.Forms.ComboBox();
            this.comboBoxDirection = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMentor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSubdivision = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxLevelEv = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.kvantorium_dostizheniyaDataSet = new kvantorium.kvantorium_dostizheniyaDataSet();
            this.award_tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.award_tableTableAdapter = new kvantorium.kvantorium_dostizheniyaDataSetTableAdapters.award_tableTableAdapter();
            this.tableAdapterManager = new kvantorium.kvantorium_dostizheniyaDataSetTableAdapters.TableAdapterManager();
            this.pictureBoxEsoft = new System.Windows.Forms.PictureBox();
            this.buttonFiltr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kvantorium_dostizheniyaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.award_tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsoft)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(343, 140);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(158, 20);
            this.textBoxYear.TabIndex = 57;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastName.Location = new System.Drawing.Point(339, 122);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(118, 15);
            this.labelLastName.TabIndex = 56;
            this.labelLastName.Text = "Год мероприятия *";
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(276, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 23);
            this.label1.TabIndex = 63;
            this.label1.Text = "Данные о достижениях учащихся Кванториума";
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(160)))));
            this.buttonDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.buttonDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDel.Location = new System.Drawing.Point(342, 179);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(159, 35);
            this.buttonDel.TabIndex = 61;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(160)))));
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEdit.Location = new System.Drawing.Point(177, 179);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(159, 35);
            this.buttonEdit.TabIndex = 60;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(160)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(12, 179);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(159, 35);
            this.buttonAdd.TabIndex = 59;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listViewAwards
            // 
            this.listViewAwards.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Fi,
            this.Direction,
            this.Fio,
            this.Subdivision,
            this.LevelEv,
            this.NameEv,
            this.Year,
            this.Result});
            this.listViewAwards.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewAwards.FullRowSelect = true;
            this.listViewAwards.GridLines = true;
            this.listViewAwards.HideSelection = false;
            this.listViewAwards.Location = new System.Drawing.Point(12, 234);
            this.listViewAwards.MultiSelect = false;
            this.listViewAwards.Name = "listViewAwards";
            this.listViewAwards.Size = new System.Drawing.Size(1334, 475);
            this.listViewAwards.TabIndex = 58;
            this.listViewAwards.UseCompatibleStateImageBehavior = false;
            this.listViewAwards.View = System.Windows.Forms.View.Details;
            this.listViewAwards.SelectedIndexChanged += new System.EventHandler(this.listViewAwards_SelectedIndexChanged_1);
            // 
            // Fi
            // 
            this.Fi.Text = "ФИ участника";
            this.Fi.Width = 122;
            // 
            // Direction
            // 
            this.Direction.Text = "Направление";
            this.Direction.Width = 108;
            // 
            // Fio
            // 
            this.Fio.Text = "ФИО наставника";
            this.Fio.Width = 119;
            // 
            // Subdivision
            // 
            this.Subdivision.Text = "Структурное подразделение";
            this.Subdivision.Width = 125;
            // 
            // LevelEv
            // 
            this.LevelEv.Text = "Уровень мероприятия";
            this.LevelEv.Width = 122;
            // 
            // NameEv
            // 
            this.NameEv.Text = "Название мероприятия";
            this.NameEv.Width = 120;
            // 
            // Year
            // 
            this.Year.Text = "Год мероприятия";
            this.Year.Width = 68;
            // 
            // Result
            // 
            this.Result.Text = "Результат";
            this.Result.Width = 106;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstName.Location = new System.Drawing.Point(9, 67);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(72, 15);
            this.labelFirstName.TabIndex = 54;
            this.labelFirstName.Text = "Участник *";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(507, 140);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(158, 20);
            this.textBoxResult.TabIndex = 65;
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMiddleName.Location = new System.Drawing.Point(503, 122);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(71, 15);
            this.labelMiddleName.TabIndex = 64;
            this.labelMiddleName.Text = "Результат ";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(177, 140);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(159, 20);
            this.textBoxName.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(174, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 15);
            this.label2.TabIndex = 66;
            this.label2.Text = "Название мероприятия*";
            // 
            // comboBoxParticipant
            // 
            this.comboBoxParticipant.FormattingEnabled = true;
            this.comboBoxParticipant.Location = new System.Drawing.Point(12, 87);
            this.comboBoxParticipant.Name = "comboBoxParticipant";
            this.comboBoxParticipant.Size = new System.Drawing.Size(159, 21);
            this.comboBoxParticipant.TabIndex = 68;
            // 
            // comboBoxDirection
            // 
            this.comboBoxDirection.FormattingEnabled = true;
            this.comboBoxDirection.Location = new System.Drawing.Point(177, 89);
            this.comboBoxDirection.Name = "comboBoxDirection";
            this.comboBoxDirection.Size = new System.Drawing.Size(159, 21);
            this.comboBoxDirection.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(174, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 69;
            this.label3.Text = "Направление *";
            // 
            // comboBoxMentor
            // 
            this.comboBoxMentor.FormattingEnabled = true;
            this.comboBoxMentor.Location = new System.Drawing.Point(343, 87);
            this.comboBoxMentor.Name = "comboBoxMentor";
            this.comboBoxMentor.Size = new System.Drawing.Size(159, 21);
            this.comboBoxMentor.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(340, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 71;
            this.label4.Text = "Наставник *";
            // 
            // comboBoxSubdivision
            // 
            this.comboBoxSubdivision.FormattingEnabled = true;
            this.comboBoxSubdivision.Location = new System.Drawing.Point(506, 87);
            this.comboBoxSubdivision.Name = "comboBoxSubdivision";
            this.comboBoxSubdivision.Size = new System.Drawing.Size(159, 21);
            this.comboBoxSubdivision.TabIndex = 74;
            this.comboBoxSubdivision.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubdivision_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(503, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 15);
            this.label5.TabIndex = 73;
            this.label5.Text = "Стр. подразделение *";
            // 
            // comboBoxLevelEv
            // 
            this.comboBoxLevelEv.FormattingEnabled = true;
            this.comboBoxLevelEv.Location = new System.Drawing.Point(12, 140);
            this.comboBoxLevelEv.Name = "comboBoxLevelEv";
            this.comboBoxLevelEv.Size = new System.Drawing.Size(159, 21);
            this.comboBoxLevelEv.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(9, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 15);
            this.label6.TabIndex = 75;
            this.label6.Text = "Уровень мероприятия *";
            // 
            // kvantorium_dostizheniyaDataSet
            // 
            this.kvantorium_dostizheniyaDataSet.DataSetName = "kvantorium_dostizheniyaDataSet";
            this.kvantorium_dostizheniyaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // award_tableBindingSource
            // 
            this.award_tableBindingSource.DataMember = "award_table";
            this.award_tableBindingSource.DataSource = this.kvantorium_dostizheniyaDataSet;
            // 
            // award_tableTableAdapter
            // 
            this.award_tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.award_tableTableAdapter = this.award_tableTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.direction_tableTableAdapter = null;
            this.tableAdapterManager.level_tableTableAdapter = null;
            this.tableAdapterManager.mentor_tableTableAdapter = null;
            this.tableAdapterManager.participant_tableTableAdapter = null;
            this.tableAdapterManager.subdivision_tableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = kvantorium.kvantorium_dostizheniyaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pictureBoxEsoft
            // 
            this.pictureBoxEsoft.Image = global::kvantorium.Properties.Resources.logo_kvant_min;
            this.pictureBoxEsoft.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxEsoft.Name = "pictureBoxEsoft";
            this.pictureBoxEsoft.Size = new System.Drawing.Size(258, 44);
            this.pictureBoxEsoft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEsoft.TabIndex = 62;
            this.pictureBoxEsoft.TabStop = false;
            // 
            // buttonFiltr
            // 
            this.buttonFiltr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(160)))));
            this.buttonFiltr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFiltr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFiltr.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.buttonFiltr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFiltr.Location = new System.Drawing.Point(1187, 22);
            this.buttonFiltr.Name = "buttonFiltr";
            this.buttonFiltr.Size = new System.Drawing.Size(159, 62);
            this.buttonFiltr.TabIndex = 77;
            this.buttonFiltr.Text = "Фильтрация данных";
            this.buttonFiltr.UseVisualStyleBackColor = false;
            this.buttonFiltr.Click += new System.EventHandler(this.buttonFiltr_Click);
            // 
            // FormAwards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.buttonFiltr);
            this.Controls.Add(this.comboBoxLevelEv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxSubdivision);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxMentor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxDirection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxParticipant);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewAwards);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.pictureBoxEsoft);
            this.Name = "FormAwards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Достижения участников";
            this.Load += new System.EventHandler(this.FormAwards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kvantorium_dostizheniyaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.award_tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsoft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listViewAwards;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.PictureBox pictureBoxEsoft;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxParticipant;
        private System.Windows.Forms.ComboBox comboBoxDirection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxMentor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSubdivision;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxLevelEv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader Fi;
        private System.Windows.Forms.ColumnHeader Direction;
        private System.Windows.Forms.ColumnHeader Fio;
        private System.Windows.Forms.ColumnHeader Subdivision;
        private System.Windows.Forms.ColumnHeader LevelEv;
        private System.Windows.Forms.ColumnHeader NameEv;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.ColumnHeader Result;
        private kvantorium_dostizheniyaDataSet kvantorium_dostizheniyaDataSet;
        private System.Windows.Forms.BindingSource award_tableBindingSource;
        private kvantorium_dostizheniyaDataSetTableAdapters.award_tableTableAdapter award_tableTableAdapter;
        private kvantorium_dostizheniyaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button buttonFiltr;
    }
}