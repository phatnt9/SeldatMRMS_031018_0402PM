﻿namespace SeldatMRMS.Model
{
    partial class ReadyModel
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_lineInfo = new System.Windows.Forms.Button();
            this.connectToAgent = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.dGV_properties = new System.Windows.Forms.DataGridView();
            this.txt_properties = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dGV_properties, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(372, 461);
            this.tableLayoutPanel1.TabIndex = 58;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.Controls.Add(this.btn_lineInfo);
            this.panel1.Controls.Add(this.connectToAgent);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Location = new System.Drawing.Point(3, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 39);
            this.panel1.TabIndex = 58;
            // 
            // btn_lineInfo
            // 
            this.btn_lineInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_lineInfo.Location = new System.Drawing.Point(186, 4);
            this.btn_lineInfo.Name = "btn_lineInfo";
            this.btn_lineInfo.Size = new System.Drawing.Size(84, 30);
            this.btn_lineInfo.TabIndex = 44;
            this.btn_lineInfo.Text = "Line";
            this.btn_lineInfo.UseVisualStyleBackColor = true;
            this.btn_lineInfo.Click += new System.EventHandler(this.btn_lineInfo_Click);
            // 
            // connectToAgent
            // 
            this.connectToAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.connectToAgent.Location = new System.Drawing.Point(7, 4);
            this.connectToAgent.Name = "connectToAgent";
            this.connectToAgent.Size = new System.Drawing.Size(84, 30);
            this.connectToAgent.TabIndex = 43;
            this.connectToAgent.Text = "Connect";
            this.connectToAgent.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_update.Location = new System.Drawing.Point(96, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(84, 30);
            this.btn_update.TabIndex = 41;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_cancel.Location = new System.Drawing.Point(275, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(84, 30);
            this.btn_cancel.TabIndex = 42;
            this.btn_cancel.Text = "Close";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // dGV_properties
            // 
            this.dGV_properties.AllowUserToAddRows = false;
            this.dGV_properties.AllowUserToDeleteRows = false;
            this.dGV_properties.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_properties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_properties.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txt_properties,
            this.txt_value});
            this.dGV_properties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_properties.Location = new System.Drawing.Point(3, 3);
            this.dGV_properties.Name = "dGV_properties";
            this.dGV_properties.Size = new System.Drawing.Size(366, 410);
            this.dGV_properties.TabIndex = 45;
            // 
            // txt_properties
            // 
            this.txt_properties.HeaderText = "";
            this.txt_properties.Name = "txt_properties";
            this.txt_properties.ReadOnly = true;
            // 
            // txt_value
            // 
            this.txt_value.HeaderText = "";
            this.txt_value.Name = "txt_value";
            // 
            // ReadyModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ReadyModel";
            this.Text = "Ready";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReadyModel_FormClosed);
            this.Load += new System.EventHandler(this.Ready_Load);
            this.Shown += new System.EventHandler(this.Ready_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btn_lineInfo;
        public System.Windows.Forms.Button connectToAgent;
        public System.Windows.Forms.Button btn_update;
        public System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridView dGV_properties;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_properties;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_value;
    }
}