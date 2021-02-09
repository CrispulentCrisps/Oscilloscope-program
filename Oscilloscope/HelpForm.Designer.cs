namespace Oscilloscope
{
    partial class HelpForm
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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Load");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Export");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("File", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Edit");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("View");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Help");
            this.HelpSelect = new System.Windows.Forms.TreeView();
            this.HelpText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HelpSelect
            // 
            this.HelpSelect.Location = new System.Drawing.Point(13, 13);
            this.HelpSelect.Name = "HelpSelect";
            treeNode7.Name = "Load";
            treeNode7.Tag = "Load";
            treeNode7.Text = "Load";
            treeNode8.Name = "Export";
            treeNode8.Tag = "Export";
            treeNode8.Text = "Export";
            treeNode9.Name = "File";
            treeNode9.Text = "File";
            treeNode10.Name = "Edit";
            treeNode10.Tag = "Edit";
            treeNode10.Text = "Edit";
            treeNode11.Name = "View";
            treeNode11.Tag = "View";
            treeNode11.Text = "View";
            treeNode12.Name = "Help";
            treeNode12.Tag = "Help";
            treeNode12.Text = "Help";
            this.HelpSelect.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            this.HelpSelect.Size = new System.Drawing.Size(147, 425);
            this.HelpSelect.TabIndex = 0;
            this.HelpSelect.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // HelpText
            // 
            this.HelpText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HelpText.Location = new System.Drawing.Point(175, 15);
            this.HelpText.Name = "HelpText";
            this.HelpText.Size = new System.Drawing.Size(613, 426);
            this.HelpText.TabIndex = 1;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HelpText);
            this.Controls.Add(this.HelpSelect);
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView HelpSelect;
        private System.Windows.Forms.Label HelpText;
    }
}