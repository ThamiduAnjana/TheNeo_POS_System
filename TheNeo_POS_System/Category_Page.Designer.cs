
namespace TheNeo_POS_System
{
    partial class Category_Page
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.txt_CategoryDescription = new System.Windows.Forms.TextBox();
            this.txt_CategoryName = new System.Windows.Forms.TextBox();
            this.txt_CategoryID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_Category = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_CategoryIDSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Category)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Category";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(23, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1467, 3);
            this.panel1.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel5.Location = new System.Drawing.Point(828, 52);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 820);
            this.panel5.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.btn_Insert);
            this.panel4.Controls.Add(this.btn_Delete);
            this.panel4.Controls.Add(this.btn_Update);
            this.panel4.Controls.Add(this.txt_CategoryDescription);
            this.panel4.Controls.Add(this.txt_CategoryName);
            this.panel4.Controls.Add(this.txt_CategoryID);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(832, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(646, 818);
            this.panel4.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label8.Location = new System.Drawing.Point(19, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(290, 19);
            this.label8.TabIndex = 31;
            this.label8.Text = "Add New, Update, Delete Item Category";
            // 
            // btn_Insert
            // 
            this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(254)))));
            this.btn_Insert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.btn_Insert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(79)))), ((int)(((byte)(254)))));
            this.btn_Insert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.btn_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Insert.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_Insert.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Insert.Image = global::TheNeo_POS_System.Properties.Resources.Add_W25px;
            this.btn_Insert.Location = new System.Drawing.Point(433, 591);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(166, 93);
            this.btn_Insert.TabIndex = 30;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Insert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Insert.UseVisualStyleBackColor = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(98)))), ((int)(((byte)(146)))));
            this.btn_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(24)))), ((int)(((byte)(91)))));
            this.btn_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Delete.Image = global::TheNeo_POS_System.Properties.Resources.Broom_25px;
            this.btn_Delete.Location = new System.Drawing.Point(51, 591);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(166, 93);
            this.btn_Delete.TabIndex = 29;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(254)))));
            this.btn_Update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.btn_Update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(79)))), ((int)(((byte)(254)))));
            this.btn_Update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_Update.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Update.Image = global::TheNeo_POS_System.Properties.Resources.Update_25px;
            this.btn_Update.Location = new System.Drawing.Point(241, 591);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(166, 93);
            this.btn_Update.TabIndex = 28;
            this.btn_Update.Text = "Update";
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Update.UseVisualStyleBackColor = false;
            // 
            // txt_CategoryDescription
            // 
            this.txt_CategoryDescription.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_CategoryDescription.Location = new System.Drawing.Point(23, 230);
            this.txt_CategoryDescription.Multiline = true;
            this.txt_CategoryDescription.Name = "txt_CategoryDescription";
            this.txt_CategoryDescription.Size = new System.Drawing.Size(593, 241);
            this.txt_CategoryDescription.TabIndex = 15;
            // 
            // txt_CategoryName
            // 
            this.txt_CategoryName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_CategoryName.Location = new System.Drawing.Point(23, 162);
            this.txt_CategoryName.Name = "txt_CategoryName";
            this.txt_CategoryName.Size = new System.Drawing.Size(593, 27);
            this.txt_CategoryName.TabIndex = 14;
            // 
            // txt_CategoryID
            // 
            this.txt_CategoryID.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_CategoryID.Location = new System.Drawing.Point(23, 98);
            this.txt_CategoryID.Name = "txt_CategoryID";
            this.txt_CategoryID.Size = new System.Drawing.Size(227, 27);
            this.txt_CategoryID.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(19, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Item Category Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.Location = new System.Drawing.Point(19, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Item Category Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.Location = new System.Drawing.Point(19, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Item Category ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Location = new System.Drawing.Point(25, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 820);
            this.panel2.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.dgv_Category);
            this.panel3.Controls.Add(this.btn_Search);
            this.panel3.Controls.Add(this.txt_CategoryIDSearch);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(29, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(757, 818);
            this.panel3.TabIndex = 31;
            // 
            // dgv_Category
            // 
            this.dgv_Category.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_Category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Category.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgv_Category.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("LissenItal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Category.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Category.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Category.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Category.EnableHeadersVisualStyles = false;
            this.dgv_Category.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgv_Category.Location = new System.Drawing.Point(7, 99);
            this.dgv_Category.Name = "dgv_Category";
            this.dgv_Category.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Category.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Category.RowHeadersVisible = false;
            this.dgv_Category.Size = new System.Drawing.Size(731, 703);
            this.dgv_Category.TabIndex = 32;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Category ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Category Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Description";
            this.Column3.Name = "Column3";
            this.Column3.Width = 450;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(254)))));
            this.btn_Search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.btn_Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(79)))), ((int)(((byte)(254)))));
            this.btn_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_Search.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Search.Image = global::TheNeo_POS_System.Properties.Resources.Search_25px;
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(601, 41);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(137, 36);
            this.btn_Search.TabIndex = 30;
            this.btn_Search.Text = "     Search";
            this.btn_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // txt_CategoryIDSearch
            // 
            this.txt_CategoryIDSearch.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_CategoryIDSearch.Location = new System.Drawing.Point(23, 46);
            this.txt_CategoryIDSearch.Name = "txt_CategoryIDSearch";
            this.txt_CategoryIDSearch.Size = new System.Drawing.Size(562, 27);
            this.txt_CategoryIDSearch.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(19, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Item Category ID";
            // 
            // Category_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Category_Page";
            this.Size = new System.Drawing.Size(1512, 904);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_CategoryDescription;
        private System.Windows.Forms.TextBox txt_CategoryName;
        private System.Windows.Forms.TextBox txt_CategoryID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_CategoryIDSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
