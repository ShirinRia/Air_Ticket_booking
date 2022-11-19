
namespace Airline
{
    partial class TR
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
            this.bi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgfn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgsl,
            this.bi,
            this.dgfn,
            this.dgon,
            this.fr,
            this.dgt,
            this.dgds,
            this.dgdp,
            this.dgat,
            this.dgf,
            this.dgap,
            this.airp,
            this.airl,
            this.frt,
            this.ps});
            this.dataGridView1.Location = new System.Drawing.Point(1, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1321, 350);
            this.dataGridView1.TabIndex = 3;
            // 
            // dgsl
            // 
            this.dgsl.HeaderText = "SL";
            this.dgsl.Name = "dgsl";
            // 
            // bi
            // 
            this.bi.HeaderText = "Booking Id";
            this.bi.Name = "bi";
            // 
            // dgfn
            // 
            this.dgfn.HeaderText = "Flight No.";
            this.dgfn.Name = "dgfn";
            // 
            // dgon
            // 
            this.dgon.HeaderText = "Name";
            this.dgon.Name = "dgon";
            // 
            // fr
            // 
            this.fr.HeaderText = "From";
            this.fr.Name = "fr";
            // 
            // dgt
            // 
            this.dgt.HeaderText = "To";
            this.dgt.Name = "dgt";
            // 
            // dgds
            // 
            this.dgds.HeaderText = "Departure Date";
            this.dgds.Name = "dgds";
            this.dgds.Width = 110;
            // 
            // dgdp
            // 
            this.dgdp.HeaderText = "Departure Time";
            this.dgdp.Name = "dgdp";
            this.dgdp.Width = 110;
            // 
            // dgat
            // 
            this.dgat.HeaderText = "Phone";
            this.dgat.Name = "dgat";
            this.dgat.Width = 120;
            // 
            // dgf
            // 
            this.dgf.HeaderText = "Email";
            this.dgf.Name = "dgf";
            this.dgf.Width = 160;
            // 
            // dgap
            // 
            this.dgap.HeaderText = "No.Of person";
            this.dgap.Name = "dgap";
            // 
            // airp
            // 
            this.airp.HeaderText = "Airport";
            this.airp.Name = "airp";
            // 
            // airl
            // 
            this.airl.HeaderText = "Airline";
            this.airl.Name = "airl";
            // 
            // frt
            // 
            this.frt.HeaderText = "Fare";
            this.frt.Name = "frt";
            // 
            // ps
            // 
            this.ps.HeaderText = "Payment Status";
            this.ps.Name = "ps";
            this.ps.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(584, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Reservation List";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(993, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1151, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1151, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(877, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Name",
            "Booking ID"});
            this.comboBox1.Location = new System.Drawing.Point(993, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "Search by";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TR";
            this.Size = new System.Drawing.Size(1280, 505);
            this.Load += new System.EventHandler(this.TR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgsl;
        private System.Windows.Forms.DataGridViewTextBoxColumn bi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgfn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgon;
        private System.Windows.Forms.DataGridViewTextBoxColumn fr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgds;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgf;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgap;
        private System.Windows.Forms.DataGridViewTextBoxColumn airp;
        private System.Windows.Forms.DataGridViewTextBoxColumn airl;
        private System.Windows.Forms.DataGridViewTextBoxColumn frt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ps;
    }
}
