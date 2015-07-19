namespace GuidGenerator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonNewGuid = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.groupBoxGuidFormat = new System.Windows.Forms.GroupBox();
            this.radioButtonShortFormat = new System.Windows.Forms.RadioButton();
            this.radioButtonTagFormat = new System.Windows.Forms.RadioButton();
            this.radioButtonAttributeFormat = new System.Windows.Forms.RadioButton();
            this.radioButtonRegistryFormat = new System.Windows.Forms.RadioButton();
            this.radioButtonConstFormat = new System.Windows.Forms.RadioButton();
            this.radioButtonDefineFormat = new System.Windows.Forms.RadioButton();
            this.radioButtonOleCreateFormat = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxResult.SuspendLayout();
            this.groupBoxGuidFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCopy
            // 
            this.buttonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopy.Location = new System.Drawing.Point(282, 12);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy.TabIndex = 0;
            this.buttonCopy.Text = "&Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonNewGuid
            // 
            this.buttonNewGuid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewGuid.Location = new System.Drawing.Point(282, 41);
            this.buttonNewGuid.Name = "buttonNewGuid";
            this.buttonNewGuid.Size = new System.Drawing.Size(75, 23);
            this.buttonNewGuid.TabIndex = 1;
            this.buttonNewGuid.Text = "&New GUID";
            this.buttonNewGuid.UseVisualStyleBackColor = true;
            this.buttonNewGuid.Click += new System.EventHandler(this.buttonNewGuid_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(282, 70);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxResult.Controls.Add(this.labelResult);
            this.groupBoxResult.Location = new System.Drawing.Point(12, 282);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(345, 88);
            this.groupBoxResult.TabIndex = 1;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Result";
            // 
            // labelResult
            // 
            this.labelResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResult.Location = new System.Drawing.Point(6, 19);
            this.labelResult.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(333, 66);
            this.labelResult.TabIndex = 0;
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescription.Location = new System.Drawing.Point(12, 9);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(264, 84);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Choose the desired format below, then select \"Copy\" to copy the result to the cli" +
    "pboard (the result can then be pasted into your source code). Choose \"Exit\" when" +
    " done.";
            // 
            // groupBoxGuidFormat
            // 
            this.groupBoxGuidFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGuidFormat.Controls.Add(this.radioButtonShortFormat);
            this.groupBoxGuidFormat.Controls.Add(this.radioButtonTagFormat);
            this.groupBoxGuidFormat.Controls.Add(this.radioButtonAttributeFormat);
            this.groupBoxGuidFormat.Controls.Add(this.radioButtonRegistryFormat);
            this.groupBoxGuidFormat.Controls.Add(this.radioButtonConstFormat);
            this.groupBoxGuidFormat.Controls.Add(this.radioButtonDefineFormat);
            this.groupBoxGuidFormat.Controls.Add(this.radioButtonOleCreateFormat);
            this.groupBoxGuidFormat.Controls.Add(this.label1);
            this.groupBoxGuidFormat.Location = new System.Drawing.Point(12, 96);
            this.groupBoxGuidFormat.Name = "groupBoxGuidFormat";
            this.groupBoxGuidFormat.Size = new System.Drawing.Size(264, 180);
            this.groupBoxGuidFormat.TabIndex = 3;
            this.groupBoxGuidFormat.TabStop = false;
            this.groupBoxGuidFormat.Text = "GUID Format";
            // 
            // radioButtonShortFormat
            // 
            this.radioButtonShortFormat.AutoSize = true;
            this.radioButtonShortFormat.Location = new System.Drawing.Point(6, 157);
            this.radioButtonShortFormat.Name = "radioButtonShortFormat";
            this.radioButtonShortFormat.Size = new System.Drawing.Size(92, 17);
            this.radioButtonShortFormat.TabIndex = 7;
            this.radioButtonShortFormat.Text = "&7. Short GUID";
            this.radioButtonShortFormat.UseVisualStyleBackColor = true;
            this.radioButtonShortFormat.CheckedChanged += new System.EventHandler(this.radioButtonGuidFormat_CheckedChanged);
            // 
            // radioButtonTagFormat
            // 
            this.radioButtonTagFormat.AutoSize = true;
            this.radioButtonTagFormat.Location = new System.Drawing.Point(6, 134);
            this.radioButtonTagFormat.Name = "radioButtonTagFormat";
            this.radioButtonTagFormat.Size = new System.Drawing.Size(185, 17);
            this.radioButtonTagFormat.TabIndex = 6;
            this.radioButtonTagFormat.Text = "&6. <Guid(\"xxxxxxxx-xxxx ... xxxx\")>";
            this.radioButtonTagFormat.UseVisualStyleBackColor = true;
            this.radioButtonTagFormat.CheckedChanged += new System.EventHandler(this.radioButtonGuidFormat_CheckedChanged);
            // 
            // radioButtonAttributeFormat
            // 
            this.radioButtonAttributeFormat.AutoSize = true;
            this.radioButtonAttributeFormat.Location = new System.Drawing.Point(6, 111);
            this.radioButtonAttributeFormat.Name = "radioButtonAttributeFormat";
            this.radioButtonAttributeFormat.Size = new System.Drawing.Size(179, 17);
            this.radioButtonAttributeFormat.TabIndex = 5;
            this.radioButtonAttributeFormat.Text = "&5. [Guid(\"xxxxxxxx-xxxx ... xxxx\")]";
            this.radioButtonAttributeFormat.UseVisualStyleBackColor = true;
            this.radioButtonAttributeFormat.CheckedChanged += new System.EventHandler(this.radioButtonGuidFormat_CheckedChanged);
            // 
            // radioButtonRegistryFormat
            // 
            this.radioButtonRegistryFormat.AutoSize = true;
            this.radioButtonRegistryFormat.Location = new System.Drawing.Point(6, 88);
            this.radioButtonRegistryFormat.Name = "radioButtonRegistryFormat";
            this.radioButtonRegistryFormat.Size = new System.Drawing.Size(245, 17);
            this.radioButtonRegistryFormat.TabIndex = 4;
            this.radioButtonRegistryFormat.Text = "&4. Registry Format (i.e. {xxxxxxxx-xxxx ... xxxx })";
            this.radioButtonRegistryFormat.UseVisualStyleBackColor = true;
            this.radioButtonRegistryFormat.CheckedChanged += new System.EventHandler(this.radioButtonGuidFormat_CheckedChanged);
            // 
            // radioButtonConstFormat
            // 
            this.radioButtonConstFormat.AutoSize = true;
            this.radioButtonConstFormat.Location = new System.Drawing.Point(6, 65);
            this.radioButtonConstFormat.Name = "radioButtonConstFormat";
            this.radioButtonConstFormat.Size = new System.Drawing.Size(185, 17);
            this.radioButtonConstFormat.TabIndex = 3;
            this.radioButtonConstFormat.Text = "&3. static const struct GUID = { ... }";
            this.radioButtonConstFormat.UseVisualStyleBackColor = true;
            this.radioButtonConstFormat.CheckedChanged += new System.EventHandler(this.radioButtonGuidFormat_CheckedChanged);
            // 
            // radioButtonDefineFormat
            // 
            this.radioButtonDefineFormat.AutoSize = true;
            this.radioButtonDefineFormat.Location = new System.Drawing.Point(6, 42);
            this.radioButtonDefineFormat.Name = "radioButtonDefineFormat";
            this.radioButtonDefineFormat.Size = new System.Drawing.Size(124, 17);
            this.radioButtonDefineFormat.TabIndex = 2;
            this.radioButtonDefineFormat.Text = "&2. DEFINE_GUID(...)";
            this.radioButtonDefineFormat.UseVisualStyleBackColor = true;
            this.radioButtonDefineFormat.CheckedChanged += new System.EventHandler(this.radioButtonGuidFormat_CheckedChanged);
            // 
            // radioButtonOleCreateFormat
            // 
            this.radioButtonOleCreateFormat.AutoSize = true;
            this.radioButtonOleCreateFormat.Checked = true;
            this.radioButtonOleCreateFormat.Location = new System.Drawing.Point(6, 19);
            this.radioButtonOleCreateFormat.Name = "radioButtonOleCreateFormat";
            this.radioButtonOleCreateFormat.Size = new System.Drawing.Size(188, 17);
            this.radioButtonOleCreateFormat.TabIndex = 1;
            this.radioButtonOleCreateFormat.TabStop = true;
            this.radioButtonOleCreateFormat.Text = "&1. IMPLEMENT _OLECREATE(...)";
            this.radioButtonOleCreateFormat.UseVisualStyleBackColor = true;
            this.radioButtonOleCreateFormat.CheckedChanged += new System.EventHandler(this.radioButtonGuidFormat_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 13);
            this.label1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(369, 382);
            this.Controls.Add(this.groupBoxGuidFormat);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonNewGuid);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.labelDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create GUID";
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxGuidFormat.ResumeLayout(false);
            this.groupBoxGuidFormat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonNewGuid;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.GroupBox groupBoxGuidFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonOleCreateFormat;
        private System.Windows.Forms.RadioButton radioButtonConstFormat;
        private System.Windows.Forms.RadioButton radioButtonDefineFormat;
        private System.Windows.Forms.RadioButton radioButtonRegistryFormat;
        private System.Windows.Forms.RadioButton radioButtonAttributeFormat;
        private System.Windows.Forms.RadioButton radioButtonTagFormat;
        private System.Windows.Forms.RadioButton radioButtonShortFormat;
    }
}