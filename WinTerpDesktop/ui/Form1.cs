using PdfiumViewer;

namespace WinTerpDesktop
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            this.BackColor = SystemColors.AppWorkspace;
        }

        private void MainWindow_DragLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }

        private void MainWindow_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (string filePath in files)
                {
                    DisplayPDF(filePath);
                }
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.Manual;
            Rectangle workingArea = Screen.GetWorkingArea(this);
            int margin = 60;
            int x = workingArea.Right - (this.Width + margin);
            int y = workingArea.Bottom - (this.Height + margin);

            this.Location = new Point(x, y);
            Adjust_Components();
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            Adjust_Components();
        }

        private void Adjust_Components()
        {
            AdjustSizeOf(pdfViewAndDataFormSplitContainer);
            AdjustLocationOf(DragAndDropDescriptionLabel, y_ratio: 4);
            AdjustLocationOf(FileChooserButton);
        }


        private void AdjustSizeOf(Control control)
        {
            (control as SplitContainer).SplitterDistance = ClientSize.Width / 2;
        }

        private void AdjustLocationOf(Control control, int x_ratio = 2, int y_ratio = 2)
        {
            int x = (Width - control.Width) / x_ratio;
            int y = (Height - control.Height) / y_ratio;
            control.Location = new Point(x, y);
        }

        private void PDFViewerPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void DisplayPDF(string filePath)
        {
            var viewer = new PdfViewer();
            viewer.Dock = DockStyle.Fill;
            viewer.Document = PdfDocument.Load(filePath);
            pdfViewAndDataFormSplitContainer.Panel1.Controls.Clear();
            pdfViewAndDataFormSplitContainer.Panel1.Controls.Add(viewer);
            Hide_UploadComponents();
            pdfViewAndDataFormSplitContainer.Visible = true;
            WindowState = FormWindowState.Maximized;
        }

        private void Hide_UploadComponents()
        {
            DragAndDropDescriptionLabel.Visible = false;
            FileChooserButton.Visible = false;
        }

        private void DragAndDropDescriptionLabel_Click(object sender, EventArgs e)
        {
            ChooseFile();
        }

        private void FileChooserButton_Click(object sender, EventArgs e)
        {
            ChooseFile();
        }

        private void ChooseFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                string downloadDirectoryPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                    "Downloads"
                    );
                openFileDialog.Title = "Wählen eine Einsatzbestätigung aus Ihren Dateien aus";
                openFileDialog.Filter = "PDF  (*.txt)|*.pdf";
                openFileDialog.Multiselect = false;
                openFileDialog.InitialDirectory = downloadDirectoryPath;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    DisplayPDF(selectedFilePath);
                }
            }
        }
    }
}

