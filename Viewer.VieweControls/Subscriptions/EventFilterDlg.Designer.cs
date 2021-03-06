//<summary>
//  Title   : Event filter
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C)2009, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

namespace CAS.OPC.UA.Viewer.Controls
{
    partial class EventFilterDlg
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
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( EventFilterDlg ) );
          this.ButtonsPN = new System.Windows.Forms.Panel();
          this.BackBTN = new System.Windows.Forms.Button();
          this.OkBTN = new System.Windows.Forms.Button();
          this.CancelBTN = new System.Windows.Forms.Button();
          this.NextBTN = new System.Windows.Forms.Button();
          this.MainPN = new System.Windows.Forms.SplitContainer();
          this.ContentFilterCTRL = new CAS.OPC.UA.Viewer.Controls.ContentFilterElementListCtrl();
          this.BrowseCTRL = new CAS.OPC.UA.Viewer.Controls.BrowseTreeCtrl();
          this.FilterOperandsCTRL = new CAS.OPC.UA.Viewer.Controls.FilterOperandListCtrl();
          this.SelectClauseCTRL = new CAS.OPC.UA.Viewer.Controls.SelectClauseListCtrl();
          this.ButtonsPN.SuspendLayout();
          this.MainPN.Panel1.SuspendLayout();
          this.MainPN.Panel2.SuspendLayout();
          this.MainPN.SuspendLayout();
          this.SuspendLayout();
          // 
          // ButtonsPN
          // 
          this.ButtonsPN.Controls.Add( this.BackBTN );
          this.ButtonsPN.Controls.Add( this.OkBTN );
          this.ButtonsPN.Controls.Add( this.CancelBTN );
          this.ButtonsPN.Controls.Add( this.NextBTN );
          this.ButtonsPN.Dock = System.Windows.Forms.DockStyle.Bottom;
          this.ButtonsPN.Location = new System.Drawing.Point( 0, 395 );
          this.ButtonsPN.Name = "ButtonsPN";
          this.ButtonsPN.Size = new System.Drawing.Size( 692, 31 );
          this.ButtonsPN.TabIndex = 2;
          // 
          // BackBTN
          // 
          this.BackBTN.Anchor = System.Windows.Forms.AnchorStyles.Right;
          this.BackBTN.Location = new System.Drawing.Point( 451, 4 );
          this.BackBTN.Name = "BackBTN";
          this.BackBTN.Size = new System.Drawing.Size( 75, 23 );
          this.BackBTN.TabIndex = 3;
          this.BackBTN.Text = "< Back";
          this.BackBTN.UseVisualStyleBackColor = true;
          this.BackBTN.Click += new System.EventHandler( this.MoveBTN_Click );
          // 
          // OkBTN
          // 
          this.OkBTN.Anchor = System.Windows.Forms.AnchorStyles.Right;
          this.OkBTN.Location = new System.Drawing.Point( 532, 4 );
          this.OkBTN.Name = "OkBTN";
          this.OkBTN.Size = new System.Drawing.Size( 75, 23 );
          this.OkBTN.TabIndex = 0;
          this.OkBTN.Text = "OK";
          this.OkBTN.UseVisualStyleBackColor = true;
          this.OkBTN.Click += new System.EventHandler( this.OkBTN_Click );
          // 
          // CancelBTN
          // 
          this.CancelBTN.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
          this.CancelBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
          this.CancelBTN.Location = new System.Drawing.Point( 613, 4 );
          this.CancelBTN.Name = "CancelBTN";
          this.CancelBTN.Size = new System.Drawing.Size( 75, 23 );
          this.CancelBTN.TabIndex = 1;
          this.CancelBTN.Text = "Cancel";
          this.CancelBTN.UseVisualStyleBackColor = true;
          // 
          // NextBTN
          // 
          this.NextBTN.Anchor = System.Windows.Forms.AnchorStyles.Right;
          this.NextBTN.Location = new System.Drawing.Point( 532, 4 );
          this.NextBTN.Name = "NextBTN";
          this.NextBTN.Size = new System.Drawing.Size( 75, 23 );
          this.NextBTN.TabIndex = 2;
          this.NextBTN.Text = "Next >";
          this.NextBTN.UseVisualStyleBackColor = true;
          this.NextBTN.Click += new System.EventHandler( this.MoveBTN_Click );
          // 
          // MainPN
          // 
          this.MainPN.Dock = System.Windows.Forms.DockStyle.Fill;
          this.MainPN.Location = new System.Drawing.Point( 0, 0 );
          this.MainPN.Name = "MainPN";
          // 
          // MainPN.Panel1
          // 
          this.MainPN.Panel1.Controls.Add( this.ContentFilterCTRL );
          this.MainPN.Panel1.Controls.Add( this.BrowseCTRL );
          // 
          // MainPN.Panel2
          // 
          this.MainPN.Panel2.Controls.Add( this.FilterOperandsCTRL );
          this.MainPN.Panel2.Controls.Add( this.SelectClauseCTRL );
          this.MainPN.Size = new System.Drawing.Size( 692, 395 );
          this.MainPN.SplitterDistance = 340;
          this.MainPN.TabIndex = 3;
          // 
          // ContentFilterCTRL
          // 
          this.ContentFilterCTRL.Dock = System.Windows.Forms.DockStyle.Fill;
          this.ContentFilterCTRL.Instructions = "Right click to add filter elements.";
          this.ContentFilterCTRL.Location = new System.Drawing.Point( 0, 0 );
          this.ContentFilterCTRL.Name = "ContentFilterCTRL";
          this.ContentFilterCTRL.Padding = new System.Windows.Forms.Padding( 3, 3, 0, 3 );
          this.ContentFilterCTRL.Size = new System.Drawing.Size( 340, 395 );
          this.ContentFilterCTRL.TabIndex = 2;
          this.ContentFilterCTRL.ItemsSelected += new CAS.OPC.UA.Viewer.Client.Controls.ListItemActionEventHandler( this.ContentFilterCTRL_ItemsSelected );
          // 
          // BrowseCTRL
          // 
          this.BrowseCTRL.AllowDrop = true;
          this.BrowseCTRL.AttributesCtrl = null;
          this.BrowseCTRL.Dock = System.Windows.Forms.DockStyle.Fill;
          this.BrowseCTRL.EnableDragging = true;
          this.BrowseCTRL.Location = new System.Drawing.Point( 0, 0 );
          this.BrowseCTRL.Name = "BrowseCTRL";
          this.BrowseCTRL.Padding = new System.Windows.Forms.Padding( 3, 3, 0, 3 );
          this.BrowseCTRL.SessionTreeCtrl = null;
          this.BrowseCTRL.Size = new System.Drawing.Size( 340, 395 );
          this.BrowseCTRL.TabIndex = 1;
          this.BrowseCTRL.ItemsSelected += new CAS.OPC.UA.Viewer.Controls.NodesSelectedEventHandler( this.BrowseCTRL_ItemsSelected );
          // 
          // FilterOperandsCTRL
          // 
          this.FilterOperandsCTRL.Dock = System.Windows.Forms.DockStyle.Fill;
          this.FilterOperandsCTRL.Enabled = false;
          this.FilterOperandsCTRL.Instructions = "Right click to add filter operands.";
          this.FilterOperandsCTRL.Location = new System.Drawing.Point( 0, 0 );
          this.FilterOperandsCTRL.Name = "FilterOperandsCTRL";
          this.FilterOperandsCTRL.Padding = new System.Windows.Forms.Padding( 0, 3, 3, 3 );
          this.FilterOperandsCTRL.Size = new System.Drawing.Size( 348, 395 );
          this.FilterOperandsCTRL.TabIndex = 3;
          // 
          // SelectClauseCTRL
          // 
          this.SelectClauseCTRL.AllowDrop = true;
          this.SelectClauseCTRL.Dock = System.Windows.Forms.DockStyle.Fill;
          this.SelectClauseCTRL.EnableDragging = true;
          this.SelectClauseCTRL.Instructions = null;
          this.SelectClauseCTRL.Location = new System.Drawing.Point( 0, 0 );
          this.SelectClauseCTRL.Name = "SelectClauseCTRL";
          this.SelectClauseCTRL.Padding = new System.Windows.Forms.Padding( 0, 3, 3, 3 );
          this.SelectClauseCTRL.Size = new System.Drawing.Size( 348, 395 );
          this.SelectClauseCTRL.TabIndex = 1;
          // 
          // EventFilterDlg
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size( 692, 426 );
          this.Controls.Add( this.MainPN );
          this.Controls.Add( this.ButtonsPN );
          this.Icon = ( (System.Drawing.Icon)( resources.GetObject( "$this.Icon" ) ) );
          this.Name = "EventFilterDlg";
          this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
          this.Text = "Edit Event Filter";
          this.ButtonsPN.ResumeLayout( false );
          this.MainPN.Panel1.ResumeLayout( false );
          this.MainPN.Panel2.ResumeLayout( false );
          this.MainPN.ResumeLayout( false );
          this.ResumeLayout( false );

        }

        #endregion

        private SelectClauseListCtrl SelectClauseCTRL;
        private System.Windows.Forms.Panel ButtonsPN;
        private System.Windows.Forms.Button OkBTN;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.SplitContainer MainPN;
        private BrowseTreeCtrl BrowseCTRL;
        private System.Windows.Forms.Button BackBTN;
        private System.Windows.Forms.Button NextBTN;
        private ContentFilterElementListCtrl ContentFilterCTRL;
        private FilterOperandListCtrl FilterOperandsCTRL;
    }
}
