using System;
using System.Windows.Forms;
using Types = TagLibrary.Types;

namespace TagEditor.Controls
{
	public class RealVector2D : Field
	{
		private System.Windows.Forms.Label lblName;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private DevExpress.XtraEditors.TextEdit txtI;
		private DevExpress.XtraEditors.TextEdit txtK;

		private Types.RealVector2D value;

		public Types.RealVector2D Value
		{
			get { return this.value;}
			set { this.value = value; }
		}

		public RealVector2D()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
		}

		public override void Configure(System.Xml.XmlNode valueNode)
		{
			base.Configure(valueNode);
			this.lblName.Text = Caption;
		}

		public override void DataBind(Types.IField value)
		{
			if (!(value is Types.RealVector2D))
				throw new Exception("Cannot bind " + value.ToString() + " to RealVector2D control.");

			this.value = (value as Types.RealVector2D);
			this.txtI.DataBindings.Clear();
			this.txtI.DataBindings.Add(new Binding("Text", this.value, "I"));
			this.txtK.DataBindings.Clear();
			this.txtK.DataBindings.Add(new Binding("Text", this.value, "K"));
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtI = new DevExpress.XtraEditors.TextEdit();
			this.lblName = new System.Windows.Forms.Label();
			this.txtK = new DevExpress.XtraEditors.TextEdit();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.txtI.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtK.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// txtI
			// 
			this.txtI.EditValue = "";
			this.txtI.Location = new System.Drawing.Point(160, 4);
			this.txtI.Name = "txtI";
			this.txtI.Size = new System.Drawing.Size(44, 20);
			this.txtI.TabIndex = 3;
			// 
			// lblName
			// 
			this.lblName.Location = new System.Drawing.Point(4, 5);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(128, 16);
			this.lblName.TabIndex = 2;
			this.lblName.Text = "RealVector2D";
			this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtK
			// 
			this.txtK.EditValue = "";
			this.txtK.Location = new System.Drawing.Point(224, 4);
			this.txtK.Name = "txtK";
			this.txtK.Size = new System.Drawing.Size(44, 20);
			this.txtK.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(148, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(8, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "i";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(212, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(8, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "k";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// RealVector2D
			// 
			this.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.Appearance.Options.UseBackColor = true;
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtK);
			this.Controls.Add(this.txtI);
			this.Controls.Add(this.lblName);
			this.Name = "RealVector2D";
			this.Size = new System.Drawing.Size(272, 28);
			((System.ComponentModel.ISupportInitialize)(this.txtI.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtK.Properties)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion


	}
}

