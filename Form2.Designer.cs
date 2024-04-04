
namespace OSK1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private Form1 parent;
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
            this.table = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeovalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timexvalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timelimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.result,
            this.timeovalue,
            this.timexvalue,
            this.timelimit});
            this.table.Location = new System.Drawing.Point(12, 12);
            this.table.Name = "table";
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(776, 150);
            this.table.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // result
            // 
            this.result.HeaderText = "Wynik";
            this.result.Name = "result";
            // 
            // timeovalue
            // 
            this.timeovalue.HeaderText = "Czas gracza o";
            this.timeovalue.Name = "timeovalue";
            // 
            // timexvalue
            // 
            this.timexvalue.HeaderText = "Czas gracza x";
            this.timexvalue.Name = "timexvalue";
            // 
            // timelimit
            // 
            this.timelimit.HeaderText = "Limit czasu";
            this.timelimit.Name = "timelimit";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.table);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeovalue;
        private System.Windows.Forms.DataGridViewTextBoxColumn timexvalue;
        private System.Windows.Forms.DataGridViewTextBoxColumn timelimit;
    }
}