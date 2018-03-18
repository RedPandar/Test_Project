namespace WindowsFormsApp2
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
            this.load_file_btn = new System.Windows.Forms.Button();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.Save_to_file_btn = new System.Windows.Forms.Button();
            this.wrd_count_label = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.wrd_count_label_text = new System.Windows.Forms.Label();
            this.line_count_label_text = new System.Windows.Forms.Label();
            this.line_count_label = new System.Windows.Forms.Label();
            this.Sort_check = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // load_file_btn
            // 
            this.load_file_btn.Location = new System.Drawing.Point(12, 12);
            this.load_file_btn.Name = "load_file_btn";
            this.load_file_btn.Size = new System.Drawing.Size(144, 31);
            this.load_file_btn.TabIndex = 0;
            this.load_file_btn.Text = "Load";
            this.load_file_btn.UseVisualStyleBackColor = true;
            this.load_file_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dGV
            // 
            this.dGV.AllowUserToAddRows = false;
            this.dGV.AllowUserToDeleteRows = false;
            this.dGV.AllowUserToResizeColumns = false;
            this.dGV.AllowUserToResizeRows = false;
            this.dGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dGV.Location = new System.Drawing.Point(174, 12);
            this.dGV.MultiSelect = false;
            this.dGV.Name = "dGV";
            this.dGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGV.Size = new System.Drawing.Size(267, 449);
            this.dGV.TabIndex = 1;
            // 
            // Save_to_file_btn
            // 
            this.Save_to_file_btn.Location = new System.Drawing.Point(12, 49);
            this.Save_to_file_btn.Name = "Save_to_file_btn";
            this.Save_to_file_btn.Size = new System.Drawing.Size(144, 31);
            this.Save_to_file_btn.TabIndex = 2;
            this.Save_to_file_btn.Text = "To file";
            this.Save_to_file_btn.UseVisualStyleBackColor = true;
            this.Save_to_file_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // wrd_count_label
            // 
            this.wrd_count_label.AutoSize = true;
            this.wrd_count_label.Location = new System.Drawing.Point(117, 362);
            this.wrd_count_label.Name = "wrd_count_label";
            this.wrd_count_label.Size = new System.Drawing.Size(40, 13);
            this.wrd_count_label.TabIndex = 3;
            this.wrd_count_label.Text = "№№№";
            // 
            // wrd_count_label_text
            // 
            this.wrd_count_label_text.AutoSize = true;
            this.wrd_count_label_text.Location = new System.Drawing.Point(9, 361);
            this.wrd_count_label_text.Name = "wrd_count_label_text";
            this.wrd_count_label_text.Size = new System.Drawing.Size(96, 13);
            this.wrd_count_label_text.TabIndex = 4;
            this.wrd_count_label_text.Text = "Количество слов:";
            // 
            // line_count_label_text
            // 
            this.line_count_label_text.AutoSize = true;
            this.line_count_label_text.Location = new System.Drawing.Point(9, 386);
            this.line_count_label_text.Name = "line_count_label_text";
            this.line_count_label_text.Size = new System.Drawing.Size(101, 13);
            this.line_count_label_text.TabIndex = 6;
            this.line_count_label_text.Text = "Количество строк:";
            // 
            // line_count_label
            // 
            this.line_count_label.AutoSize = true;
            this.line_count_label.Location = new System.Drawing.Point(117, 387);
            this.line_count_label.Name = "line_count_label";
            this.line_count_label.Size = new System.Drawing.Size(40, 13);
            this.line_count_label.TabIndex = 5;
            this.line_count_label.Text = "№№№";
            // 
            // Sort_check
            // 
            this.Sort_check.AutoSize = true;
            this.Sort_check.Checked = true;
            this.Sort_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Sort_check.Location = new System.Drawing.Point(35, 86);
            this.Sort_check.Name = "Sort_check";
            this.Sort_check.Size = new System.Drawing.Size(91, 17);
            this.Sort_check.TabIndex = 7;
            this.Sort_check.Text = "Сортировать";
            this.Sort_check.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AccessibleName = "wrd_count_file";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 473);
            this.Controls.Add(this.Sort_check);
            this.Controls.Add(this.line_count_label_text);
            this.Controls.Add(this.line_count_label);
            this.Controls.Add(this.wrd_count_label_text);
            this.Controls.Add(this.wrd_count_label);
            this.Controls.Add(this.Save_to_file_btn);
            this.Controls.Add(this.dGV);
            this.Controls.Add(this.load_file_btn);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button load_file_btn;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.Button Save_to_file_btn;
        private System.Windows.Forms.Label wrd_count_label;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label wrd_count_label_text;
        private System.Windows.Forms.Label line_count_label_text;
        private System.Windows.Forms.Label line_count_label;
        private System.Windows.Forms.CheckBox Sort_check;
    }
}

