
namespace Airline
{
    partial class UserControl1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgsl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgfn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgsl,
            this.name,
            this.dgfn,
            this.gn,
            this.dgon,
            this.dgds,
            this.dgdp,
            this.dgat,
            this.dgf});
            this.dataGridView1.Location = new System.Drawing.Point(39, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1204, 371);
            this.dataGridView1.TabIndex = 4;
            // 
            // dgsl
            // 
            this.dgsl.HeaderText = "SL";
            this.dgsl.Name = "dgsl";
            this.dgsl.Width = 50;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.Width = 200;
            // 
            // dgfn
            // 
            this.dgfn.HeaderText = "Username";
            this.dgfn.Name = "dgfn";
            this.dgfn.Width = 90;
            // 
            // gn
            // 
            this.gn.HeaderText = "Gender";
            this.gn.Name = "gn";
            this.gn.Width = 85;
            // 
            // dgon
            // 
            this.dgon.HeaderText = "Address";
            this.dgon.Name = "dgon";
            this.dgon.Width = 230;
            // 
            // dgds
            // 
            this.dgds.HeaderText = "Phone";
            this.dgds.Name = "dgds";
            // 
            // dgdp
            // 
            this.dgdp.HeaderText = "Email";
            this.dgdp.Name = "dgdp";
            this.dgdp.Width = 210;
            // 
            // dgat
            // 
            this.dgat.HeaderText = "DOB";
            this.dgat.Name = "dgat";
            // 
            // dgf
            // 
            this.dgf.HeaderText = "Joining Date";
            this.dgf.Name = "dgf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(615, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(531, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Admin";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1244, 507);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgsl;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgfn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgds;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
