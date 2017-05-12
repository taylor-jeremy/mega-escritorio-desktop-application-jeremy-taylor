namespace Mega_Escritorio_Desktop_Application
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.width = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.depth = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.numberDrawers = new System.Windows.Forms.ComboBox();
			this.surfaceMaterial = new System.Windows.Forms.ComboBox();
			this.orderDays = new System.Windows.Forms.ComboBox();
			this.submitButton = new System.Windows.Forms.Button();
			this.priceQuote = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.width)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.depth)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Enabled = false;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(99, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(278, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mega Escritorio Desk Orders";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(81, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(157, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Desk Width (Inches):";
			// 
			// width
			// 
			this.width.DecimalPlaces = 2;
			this.width.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.width.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.width.Location = new System.Drawing.Point(314, 72);
			this.width.Name = "width";
			this.width.Size = new System.Drawing.Size(120, 26);
			this.width.TabIndex = 0;
			//this.width.ValueChanged += new System.EventHandler(this.value_Enter);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(81, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(160, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Desk Depth (Inches):";
			// 
			// depth
			// 
			this.depth.DecimalPlaces = 2;
			this.depth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.depth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.depth.Location = new System.Drawing.Point(314, 117);
			this.depth.Name = "depth";
			this.depth.Size = new System.Drawing.Size(120, 26);
			this.depth.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(81, 160);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(150, 20);
			this.label4.TabIndex = 0;
			this.label4.Text = "Number of Drawers:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(81, 203);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(129, 20);
			this.label5.TabIndex = 0;
			this.label5.Text = "Surface Material:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(81, 246);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(145, 20);
			this.label6.TabIndex = 0;
			this.label6.Text = "Rush Order (Days):";
			// 
			// numberDrawers
			// 
			this.numberDrawers.FormatString = "N0";
			this.numberDrawers.FormattingEnabled = true;
			this.numberDrawers.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
			this.numberDrawers.Location = new System.Drawing.Point(313, 160);
			this.numberDrawers.Name = "numberDrawers";
			this.numberDrawers.Size = new System.Drawing.Size(121, 21);
			this.numberDrawers.TabIndex = 2;
			// 
			// surfaceMaterial
			// 
			this.surfaceMaterial.FormatString = "N0";
			this.surfaceMaterial.FormattingEnabled = true;
			this.surfaceMaterial.Items.AddRange(new object[] {
            "laminate",
            "oak",
            "pine"});
			this.surfaceMaterial.Location = new System.Drawing.Point(313, 203);
			this.surfaceMaterial.Name = "surfaceMaterial";
			this.surfaceMaterial.Size = new System.Drawing.Size(121, 21);
			this.surfaceMaterial.TabIndex = 3;
			// 
			// orderDays
			// 
			this.orderDays.FormatString = "N0";
			this.orderDays.FormattingEnabled = true;
			this.orderDays.Items.AddRange(new object[] {
            "3",
            "5",
            "7"});
			this.orderDays.Location = new System.Drawing.Point(313, 246);
			this.orderDays.Name = "orderDays";
			this.orderDays.Size = new System.Drawing.Size(121, 21);
			this.orderDays.TabIndex = 4;
			// 
			// submitButton
			// 
			this.submitButton.AutoSize = true;
			this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.submitButton.Location = new System.Drawing.Point(85, 297);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(154, 34);
			this.submitButton.TabIndex = 5;
			this.submitButton.Text = "Get Price Quote";
			this.submitButton.UseVisualStyleBackColor = true;
			this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
			// 
			// priceQuote
			// 
			this.priceQuote.AutoSize = true;
			this.priceQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.priceQuote.Location = new System.Drawing.Point(272, 302);
			this.priceQuote.Name = "priceQuote";
			this.priceQuote.Size = new System.Drawing.Size(30, 24);
			this.priceQuote.TabIndex = 6;
			this.priceQuote.Text = "$0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 361);
			this.Controls.Add(this.priceQuote);
			this.Controls.Add(this.submitButton);
			this.Controls.Add(this.orderDays);
			this.Controls.Add(this.surfaceMaterial);
			this.Controls.Add(this.numberDrawers);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.depth);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.width);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Mega Escritorio";
			((System.ComponentModel.ISupportInitialize)(this.width)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.depth)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown width;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown depth;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox numberDrawers;
		private System.Windows.Forms.ComboBox surfaceMaterial;
		private System.Windows.Forms.ComboBox orderDays;
		private System.Windows.Forms.Button submitButton;
		private System.Windows.Forms.Label priceQuote;
	}
}

