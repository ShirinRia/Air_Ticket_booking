
namespace Airline
{
    partial class userlist
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.dataGridView1.Location = new System.Drawing.Point(69, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1204, 371);
            this.dataGridView1.TabIndex = 3;
            // 
            // dgsl
            // 
            this.dgsl.HeaderText = "SL";
            this.dgsl.Name = "dgsl";
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
            // 
            // gn
            // 
            this.gn.HeaderText = "Gender";
            this.gn.Name = "gn";
            // 
            // dgon
            // 
            this.dgon.HeaderText = "Address";
            this.dgon.Name = "dgon";
            this.dgon.Width = 200;
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
            this.dgdp.Width = 150;
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
            this.dgf.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(572, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(639, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "List";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1035, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1165, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "userlist";
            this.Size = new System.Drawing.Size(1276, 539);
            this.Load += new System.EventHandler(this.userlist_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}
