namespace WinTerpDesktop
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pdfViewAndDataFormSplitContainer = new SplitContainer();
            DragAndDropDescriptionLabel = new Label();
            FileChooserButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pdfViewAndDataFormSplitContainer).BeginInit();
            pdfViewAndDataFormSplitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // pdfViewAndDataFormSplitContainer
            // 
            pdfViewAndDataFormSplitContainer.BackColor = Color.Transparent;
            pdfViewAndDataFormSplitContainer.Dock = DockStyle.Fill;
            pdfViewAndDataFormSplitContainer.IsSplitterFixed = true;
            pdfViewAndDataFormSplitContainer.Location = new Point(0, 0);
            pdfViewAndDataFormSplitContainer.Margin = new Padding(3, 4, 3, 4);
            pdfViewAndDataFormSplitContainer.Name = "pdfViewAndDataFormSplitContainer";
            // 
            // pdfViewAndDataFormSplitContainer.Panel1
            // 
            pdfViewAndDataFormSplitContainer.Panel1.BackColor = SystemColors.AppWorkspace;
            // 
            // pdfViewAndDataFormSplitContainer.Panel2
            // 
            pdfViewAndDataFormSplitContainer.Panel2.BackColor = SystemColors.Control;
            pdfViewAndDataFormSplitContainer.Size = new Size(632, 403);
            pdfViewAndDataFormSplitContainer.SplitterDistance = 209;
            pdfViewAndDataFormSplitContainer.SplitterWidth = 5;
            pdfViewAndDataFormSplitContainer.TabIndex = 1;
            pdfViewAndDataFormSplitContainer.Visible = false;
            // 
            // DragAndDropDescriptionLabel
            // 
            DragAndDropDescriptionLabel.AutoSize = true;
            DragAndDropDescriptionLabel.BackColor = Color.Transparent;
            DragAndDropDescriptionLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DragAndDropDescriptionLabel.Location = new Point(0, 0);
            DragAndDropDescriptionLabel.Name = "DragAndDropDescriptionLabel";
            DragAndDropDescriptionLabel.Size = new Size(529, 32);
            DragAndDropDescriptionLabel.TabIndex = 0;
            DragAndDropDescriptionLabel.Text = "Einsatzbestätigung per Drag && Drop hinzufügen";
            DragAndDropDescriptionLabel.TextAlign = ContentAlignment.MiddleCenter;
            DragAndDropDescriptionLabel.Click += DragAndDropDescriptionLabel_Click;
            // 
            // FileChooserButton
            // 
            FileChooserButton.AutoSize = true;
            FileChooserButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FileChooserButton.Location = new Point(125, 313);
            FileChooserButton.Margin = new Padding(3, 4, 3, 4);
            FileChooserButton.Name = "FileChooserButton";
            FileChooserButton.Size = new Size(336, 53);
            FileChooserButton.TabIndex = 0;
            FileChooserButton.Text = "oder hier Datei auswählen";
            FileChooserButton.UseVisualStyleBackColor = true;
            FileChooserButton.Click += FileChooserButton_Click;
            // 
            // MainWindow
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 403);
            Controls.Add(DragAndDropDescriptionLabel);
            Controls.Add(FileChooserButton);
            Controls.Add(pdfViewAndDataFormSplitContainer);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainWindow";
            Text = "WinTerpreters";
            TopMost = true;
            Load += MainWindow_Load;
            DragDrop += MainWindow_DragDrop;
            DragEnter += MainWindow_DragEnter;
            DragLeave += MainWindow_DragLeave;
            Resize += MainWindow_Resize;
            ((System.ComponentModel.ISupportInitialize)pdfViewAndDataFormSplitContainer).EndInit();
            pdfViewAndDataFormSplitContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private SplitContainer pdfViewAndDataFormSplitContainer;
        private Label DragAndDropDescriptionLabel;
        private Button FileChooserButton;
    }
}
