namespace week12
{
    partial class Form2
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
            this.label_chooseteam = new System.Windows.Forms.Label();
            this.combobox_chooseteam = new System.Windows.Forms.ComboBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.button_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // label_chooseteam
            // 
            this.label_chooseteam.AutoSize = true;
            this.label_chooseteam.Location = new System.Drawing.Point(46, 43);
            this.label_chooseteam.Name = "label_chooseteam";
            this.label_chooseteam.Size = new System.Drawing.Size(85, 13);
            this.label_chooseteam.TabIndex = 0;
            this.label_chooseteam.Text = "CHOOSE TEAM";
            // 
            // combobox_chooseteam
            // 
            this.combobox_chooseteam.FormattingEnabled = true;
            this.combobox_chooseteam.Location = new System.Drawing.Point(148, 40);
            this.combobox_chooseteam.Name = "combobox_chooseteam";
            this.combobox_chooseteam.Size = new System.Drawing.Size(169, 21);
            this.combobox_chooseteam.TabIndex = 1;
            this.combobox_chooseteam.SelectionChangeCommitted += new System.EventHandler(this.combobox_chooseteam_SelectionChangeCommitted);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(425, 40);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(326, 108);
            this.dataGridView3.TabIndex = 2;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(49, 164);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(588, 190);
            this.dataGridView4.TabIndex = 3;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(194, 96);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 4;
            this.button_update.Text = "update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 379);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.combobox_chooseteam);
            this.Controls.Add(this.label_chooseteam);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_chooseteam;
        private System.Windows.Forms.ComboBox combobox_chooseteam;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button button_update;
    }
}