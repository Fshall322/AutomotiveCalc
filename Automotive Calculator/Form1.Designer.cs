namespace Automotive_Calculator
{
    partial class Form1
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
            this.MaintLabel = new System.Windows.Forms.Label();
            this.OilChngBox = new System.Windows.Forms.CheckBox();
            this.RadFlushBox = new System.Windows.Forms.CheckBox();
            this.TransFlushBox = new System.Windows.Forms.CheckBox();
            this.inspectionBox = new System.Windows.Forms.CheckBox();
            this.TireRotaBox = new System.Windows.Forms.CheckBox();
            this.muffReplaceBox = new System.Windows.Forms.CheckBox();
            this.partLaborLabel = new System.Windows.Forms.Label();
            this.patrCostLabel = new System.Windows.Forms.Label();
            this.partsCostText = new System.Windows.Forms.TextBox();
            this.TotalLaborLabel = new System.Windows.Forms.Label();
            this.totalLaborText = new System.Windows.Forms.TextBox();
            this.CalcButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalCostText = new System.Windows.Forms.TextBox();
            this.taxText = new System.Windows.Forms.TextBox();
            this.partsBox = new System.Windows.Forms.TextBox();
            this.servLaborText = new System.Windows.Forms.TextBox();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.taxesLabel = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.servLaborLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MaintLabel
            // 
            this.MaintLabel.AutoSize = true;
            this.MaintLabel.Location = new System.Drawing.Point(70, 32);
            this.MaintLabel.Name = "MaintLabel";
            this.MaintLabel.Size = new System.Drawing.Size(113, 13);
            this.MaintLabel.TabIndex = 0;
            this.MaintLabel.Text = "Maintenance Services";
            // 
            // OilChngBox
            // 
            this.OilChngBox.AutoSize = true;
            this.OilChngBox.Location = new System.Drawing.Point(73, 81);
            this.OilChngBox.Name = "OilChngBox";
            this.OilChngBox.Size = new System.Drawing.Size(120, 17);
            this.OilChngBox.TabIndex = 1;
            this.OilChngBox.Tag = "25.00";
            this.OilChngBox.Text = "Oil Change ($25.00)";
            this.OilChngBox.UseVisualStyleBackColor = true;
            // 
            // RadFlushBox
            // 
            this.RadFlushBox.AutoSize = true;
            this.RadFlushBox.Location = new System.Drawing.Point(73, 116);
            this.RadFlushBox.Name = "RadFlushBox";
            this.RadFlushBox.Size = new System.Drawing.Size(133, 17);
            this.RadFlushBox.TabIndex = 2;
            this.RadFlushBox.Tag = "45.00";
            this.RadFlushBox.Text = "Radiator Flush($45.00)";
            this.RadFlushBox.UseVisualStyleBackColor = true;
            // 
            // TransFlushBox
            // 
            this.TransFlushBox.AutoSize = true;
            this.TransFlushBox.Location = new System.Drawing.Point(73, 149);
            this.TransFlushBox.Name = "TransFlushBox";
            this.TransFlushBox.Size = new System.Drawing.Size(154, 17);
            this.TransFlushBox.TabIndex = 3;
            this.TransFlushBox.Tag = "80.00";
            this.TransFlushBox.Text = "Transmission Flush($80.00)";
            this.TransFlushBox.UseVisualStyleBackColor = true;
            // 
            // inspectionBox
            // 
            this.inspectionBox.AutoSize = true;
            this.inspectionBox.Location = new System.Drawing.Point(73, 189);
            this.inspectionBox.Name = "inspectionBox";
            this.inspectionBox.Size = new System.Drawing.Size(114, 17);
            this.inspectionBox.TabIndex = 4;
            this.inspectionBox.Tag = "30.00";
            this.inspectionBox.Text = "Inspection($30.00)";
            this.inspectionBox.UseVisualStyleBackColor = true;
            // 
            // TireRotaBox
            // 
            this.TireRotaBox.AutoSize = true;
            this.TireRotaBox.Location = new System.Drawing.Point(73, 230);
            this.TireRotaBox.Name = "TireRotaBox";
            this.TireRotaBox.Size = new System.Drawing.Size(126, 17);
            this.TireRotaBox.TabIndex = 5;
            this.TireRotaBox.Tag = "25.00";
            this.TireRotaBox.Text = "Tire Rotation($25.00)";
            this.TireRotaBox.UseVisualStyleBackColor = true;
            // 
            // muffReplaceBox
            // 
            this.muffReplaceBox.AutoSize = true;
            this.muffReplaceBox.Location = new System.Drawing.Point(73, 272);
            this.muffReplaceBox.Name = "muffReplaceBox";
            this.muffReplaceBox.Size = new System.Drawing.Size(169, 17);
            this.muffReplaceBox.TabIndex = 6;
            this.muffReplaceBox.Tag = "125.00";
            this.muffReplaceBox.Text = "Muffler Replacement($125.00)";
            this.muffReplaceBox.UseVisualStyleBackColor = true;
            // 
            // partLaborLabel
            // 
            this.partLaborLabel.AutoSize = true;
            this.partLaborLabel.Location = new System.Drawing.Point(444, 32);
            this.partLaborLabel.Name = "partLaborLabel";
            this.partLaborLabel.Size = new System.Drawing.Size(82, 13);
            this.partLaborLabel.TabIndex = 7;
            this.partLaborLabel.Text = "Parts and Labor";
            // 
            // patrCostLabel
            // 
            this.patrCostLabel.AutoSize = true;
            this.patrCostLabel.Location = new System.Drawing.Point(397, 81);
            this.patrCostLabel.Name = "patrCostLabel";
            this.patrCostLabel.Size = new System.Drawing.Size(97, 13);
            this.patrCostLabel.TabIndex = 8;
            this.patrCostLabel.Text = "Total Parts Cost ($)";
            // 
            // partsCostText
            // 
            this.partsCostText.Location = new System.Drawing.Point(521, 78);
            this.partsCostText.Name = "partsCostText";
            this.partsCostText.Size = new System.Drawing.Size(100, 20);
            this.partsCostText.TabIndex = 10;
            // 
            // TotalLaborLabel
            // 
            this.TotalLaborLabel.AutoSize = true;
            this.TotalLaborLabel.Location = new System.Drawing.Point(343, 130);
            this.TotalLaborLabel.Name = "TotalLaborLabel";
            this.TotalLaborLabel.Size = new System.Drawing.Size(151, 13);
            this.TotalLaborLabel.TabIndex = 11;
            this.TotalLaborLabel.Text = "Toatl Labor at $20.00 per hour";
            // 
            // totalLaborText
            // 
            this.totalLaborText.Location = new System.Drawing.Point(521, 130);
            this.totalLaborText.Name = "totalLaborText";
            this.totalLaborText.Size = new System.Drawing.Size(100, 20);
            this.totalLaborText.TabIndex = 12;
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(447, 207);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(127, 23);
            this.CalcButton.TabIndex = 13;
            this.CalcButton.Text = "Calculate Total";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalCostText);
            this.groupBox1.Controls.Add(this.taxText);
            this.groupBox1.Controls.Add(this.partsBox);
            this.groupBox1.Controls.Add(this.servLaborText);
            this.groupBox1.Controls.Add(this.totalCostLabel);
            this.groupBox1.Controls.Add(this.taxesLabel);
            this.groupBox1.Controls.Add(this.partsLabel);
            this.groupBox1.Controls.Add(this.servLaborLabel);
            this.groupBox1.Location = new System.Drawing.Point(313, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 181);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary";
            // 
            // totalCostText
            // 
            this.totalCostText.Location = new System.Drawing.Point(154, 145);
            this.totalCostText.Name = "totalCostText";
            this.totalCostText.ReadOnly = true;
            this.totalCostText.Size = new System.Drawing.Size(100, 20);
            this.totalCostText.TabIndex = 7;
            // 
            // taxText
            // 
            this.taxText.Location = new System.Drawing.Point(154, 108);
            this.taxText.Name = "taxText";
            this.taxText.ReadOnly = true;
            this.taxText.Size = new System.Drawing.Size(100, 20);
            this.taxText.TabIndex = 6;
            // 
            // partsBox
            // 
            this.partsBox.Location = new System.Drawing.Point(154, 58);
            this.partsBox.Name = "partsBox";
            this.partsBox.ReadOnly = true;
            this.partsBox.Size = new System.Drawing.Size(100, 20);
            this.partsBox.TabIndex = 5;
            // 
            // servLaborText
            // 
            this.servLaborText.Location = new System.Drawing.Point(154, 20);
            this.servLaborText.Name = "servLaborText";
            this.servLaborText.ReadOnly = true;
            this.servLaborText.Size = new System.Drawing.Size(100, 20);
            this.servLaborText.TabIndex = 4;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(16, 148);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(55, 13);
            this.totalCostLabel.TabIndex = 3;
            this.totalCostLabel.Text = "Total Cost";
            // 
            // taxesLabel
            // 
            this.taxesLabel.AutoSize = true;
            this.taxesLabel.Location = new System.Drawing.Point(13, 108);
            this.taxesLabel.Name = "taxesLabel";
            this.taxesLabel.Size = new System.Drawing.Size(36, 13);
            this.taxesLabel.TabIndex = 2;
            this.taxesLabel.Text = "Taxes";
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Location = new System.Drawing.Point(13, 58);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(31, 13);
            this.partsLabel.TabIndex = 1;
            this.partsLabel.Text = "Parts";
            // 
            // servLaborLabel
            // 
            this.servLaborLabel.AutoSize = true;
            this.servLaborLabel.Location = new System.Drawing.Point(10, 20);
            this.servLaborLabel.Name = "servLaborLabel";
            this.servLaborLabel.Size = new System.Drawing.Size(94, 13);
            this.servLaborLabel.TabIndex = 0;
            this.servLaborLabel.Text = "Service and Labor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 453);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.totalLaborText);
            this.Controls.Add(this.TotalLaborLabel);
            this.Controls.Add(this.partsCostText);
            this.Controls.Add(this.patrCostLabel);
            this.Controls.Add(this.partLaborLabel);
            this.Controls.Add(this.muffReplaceBox);
            this.Controls.Add(this.TireRotaBox);
            this.Controls.Add(this.inspectionBox);
            this.Controls.Add(this.TransFlushBox);
            this.Controls.Add(this.RadFlushBox);
            this.Controls.Add(this.OilChngBox);
            this.Controls.Add(this.MaintLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MaintLabel;
        private System.Windows.Forms.CheckBox OilChngBox;
        private System.Windows.Forms.CheckBox RadFlushBox;
        private System.Windows.Forms.CheckBox TransFlushBox;
        private System.Windows.Forms.CheckBox inspectionBox;
        private System.Windows.Forms.CheckBox TireRotaBox;
        private System.Windows.Forms.CheckBox muffReplaceBox;
        private System.Windows.Forms.Label partLaborLabel;
        private System.Windows.Forms.Label patrCostLabel;
        private System.Windows.Forms.TextBox partsCostText;
        private System.Windows.Forms.Label TotalLaborLabel;
        private System.Windows.Forms.TextBox totalLaborText;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox totalCostText;
        private System.Windows.Forms.TextBox taxText;
        private System.Windows.Forms.TextBox partsBox;
        private System.Windows.Forms.TextBox servLaborText;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label taxesLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label servLaborLabel;
    }
}

