namespace week12
{
    partial class Form3
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
            this.combobox_chooseteam1 = new System.Windows.Forms.ComboBox();
            this.label_chooseteam1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // combobox_chooseteam1
            // 
            this.combobox_chooseteam1.FormattingEnabled = true;
            this.combobox_chooseteam1.Location = new System.Drawing.Point(63, 52);
            this.combobox_chooseteam1.Name = "combobox_chooseteam1";
            this.combobox_chooseteam1.Size = new System.Drawing.Size(166, 21);
            this.combobox_chooseteam1.TabIndex = 0;
            this.combobox_chooseteam1.SelectionChangeCommitted += new System.EventHandler(this.combobox_chooseteam1_SelectionChangeCommitted);
            // 
            // label_chooseteam1
            // 
            this.label_chooseteam1.AutoSize = true;
            this.label_chooseteam1.Location = new System.Drawing.Point(105, 22);
            this.label_chooseteam1.Name = "label_chooseteam1";
            this.label_chooseteam1.Size = new System.Drawing.Size(68, 13);
            this.label_chooseteam1.TabIndex = 1;
            this.label_chooseteam1.Text = "choose team";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(263, 31);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(403, 211);
            this.dataGridView2.TabIndex = 2;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(98, 122);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 269);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label_chooseteam1);
            this.Controls.Add(this.combobox_chooseteam1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox_chooseteam1;
        private System.Windows.Forms.Label label_chooseteam1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button_delete;
    }
}