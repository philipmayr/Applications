using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Writer
{
    public partial class Main : Form
    {
        private string FullFileName = "Document", FileName = "Document";
        private RichTextBoxStreamType FileType = RichTextBoxStreamType.RichText; 
        private bool OpenedDocument, SavedDocument, DocumentTextChanged;

        public Main()
        {
            InitializeComponent();
        }

        private void NewDocument(object sender, EventArgs e)
        {
            if (DocumentTextChanged)
            {
                switch (MessageBox.Show("Do you wish to save changes to " + FullFileName + "?", "Writer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        if (OpenedDocument || SavedDocument)
                        {
                            RichTextBox.SaveFile(FullFileName, FileType);
                        }
                        else
                        {
                            SaveFileDialog.FileName = "Document";
                            SaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                            if (SaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                if (SaveFileDialog.FileName != null)
                                {
                                    FullFileName = SaveFileDialog.FileName;
                                    FileName = Path.GetFileNameWithoutExtension(SaveFileDialog.FileName);
                                }
                                if (SaveFileDialog.FilterIndex == 1)
                                {
                                    FileType = RichTextBoxStreamType.RichText;
                                    RichTextBox.SaveFile(FullFileName, FileType);
                                }
                                else
                                {
                                    FileType = RichTextBoxStreamType.PlainText;
                                    RichTextBox.SaveFile(FullFileName, FileType);
                                }
                            }
                            else return;
                        }
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }
            RichTextBox.Clear();
            Text = "Document - Writer";
            FullFileName = "Document";
            OpenedDocument = false;
            SavedDocument = false;
            DocumentTextChanged = false;
        }

        private void OpenDocument(object sender, EventArgs e)
        {
            OpenFileDialog.FileName = null;
            OpenFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            OpenFileDialog.ShowDialog();
        }

        private void OpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            if (DocumentTextChanged)
            {
                switch (MessageBox.Show("Do you wish to save changes to " + FullFileName + "?", "Writer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        SaveDocument(null, null);
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }
            if (OpenFileDialog.FileName != null)
            {
                FullFileName = OpenFileDialog.FileName;
                FileName = Path.GetFileNameWithoutExtension(FullFileName);
            }
            if (Path.GetExtension(FullFileName) == ".rtf")
            {
                FileType = RichTextBoxStreamType.RichText;
                RichTextBox.LoadFile(FullFileName, FileType);
            }
            else
            {
                FileType = RichTextBoxStreamType.PlainText;
                RichTextBox.Font = new Font("Segoe UI", 10);
                RichTextBox.ForeColor = Color.Black;
                RichTextBox.LoadFile(FullFileName, FileType);
            }
            Text = FileName + " - Writer";
            OpenedDocument = true;
            DocumentTextChanged = false;
        }

        private void SaveDocument(object sender, EventArgs e)
        {
            if (OpenedDocument || SavedDocument) { RichTextBox.SaveFile(FullFileName, FileType); DocumentTextChanged = false; } else SaveAs();
        }

        private void SaveAs()
        {
            SaveFileDialog.FileName = "Document";
            SaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            SaveFileDialog.ShowDialog();
        }

        private void SaveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            if (SaveFileDialog.FileName != null)
            {
                FullFileName = SaveFileDialog.FileName;
                FileName = Path.GetFileNameWithoutExtension(SaveFileDialog.FileName);
            }
            if (SaveFileDialog.FilterIndex == 1)
            {
                FileType = RichTextBoxStreamType.RichText;
                RichTextBox.SaveFile(FullFileName, FileType);
            }
            else
            {
                FileType = RichTextBoxStreamType.PlainText;
                RichTextBox.SaveFile(FullFileName, FileType);
            }
            Text = FileName + " - Writer";
            SavedDocument = true;
            DocumentTextChanged = false;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DocumentTextChanged)
            {
                switch(MessageBox.Show("Do you want to save changes to " + FullFileName + "?", "Writer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        SaveDocument(null, null);
                        break;
                    case DialogResult.No:
                        Application.ExitThread();
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void RichTextBoxUndo(object sender, EventArgs e)
        {
            RichTextBox.Undo();
        }

        private void RichTextBoxRedo(object sender, EventArgs e)
        {
            RichTextBox.Redo();
        }

        private void RichTextBoxCut(object sender, EventArgs e)
        {
            RichTextBox.Cut();
        }

        private void RichTextBoxCopy(object sender, EventArgs e)
        {
            RichTextBox.Copy();
        }

        private void RichTextBoxPaste(object sender, EventArgs e)
        {
            RichTextBox.Paste();
        }

        private void RichTextBoxClear(object sender, EventArgs e)
        {
            RichTextBox.SelectedText = string.Empty;
        }

        private void RichTextBoxSelectAll(object sender, EventArgs e)
        {
            RichTextBox.SelectAll();
        }

        private void RichTextBoxWordWrap(object sender, EventArgs e)
        {
            RichTextBox.WordWrap = WordWrapToolStripMenuItem.Checked;
        }

        private void RichTextBoxFont(object sender, EventArgs e)
        {
            FontDialog.Font = RichTextBox.SelectionFont;
            FontDialog.Color = RichTextBox.SelectionColor;
            if (FontDialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBox.SelectionFont = FontDialog.Font;
                RichTextBox.SelectionColor = FontDialog.Color;
            }
        }

        private void RichTextBoxBulletStyle(object sender, EventArgs e)
        {
            RichTextBox.BulletIndent = 50;
            RichTextBox.SelectionBullet = BulletStyleToolStripMenuItem.Checked;
        }

        private void RichTextBoxLeftAlignment(object sender, EventArgs e)
        {
            RichTextBox.SelectionAlignment = HorizontalAlignment.Left;
            LeftToolStripMenuItem.Checked = true;
            RightToolStripMenuItem.Checked = false;
            CenterToolStripMenuItem.Checked = false;
        }

        private void RichTextBoxRightAlignment(object sender, EventArgs e)
        {
            RichTextBox.SelectionAlignment = HorizontalAlignment.Right;
            RightToolStripMenuItem.Checked = true;
            LeftToolStripMenuItem.Checked = false;
            CenterToolStripMenuItem.Checked = false;
        }

        private void RichTextBoxCenterAlignment(object sender, EventArgs e)
        {
            RichTextBox.SelectionAlignment = HorizontalAlignment.Center;
            CenterToolStripMenuItem.Checked = true;
            LeftToolStripMenuItem.Checked = false;
            RightToolStripMenuItem.Checked = false;
        }

        private void RichTextBox_SelectionChanged(object sender, EventArgs e)
        {
            if (RichTextBox.SelectionLength > 0)
            {
                CutToolStripButton.Enabled = true;
                CopyToolStripButton.Enabled = true;
                ClearToolStripMenuItem.Enabled = true;
            }
            else
            {
                CutToolStripButton.Enabled = false;
                CopyToolStripButton.Enabled = false;
                ClearToolStripMenuItem.Enabled = false;
            }
            BulletStyleToolStripMenuItem.Checked = RichTextBox.SelectionBullet;
            switch (RichTextBox.SelectionAlignment)
            {
                case HorizontalAlignment.Left:
                    LeftToolStripMenuItem.Checked = true;
                    RightToolStripMenuItem.Checked = false;
                    CenterToolStripMenuItem.Checked = false;
                    break;
                case HorizontalAlignment.Right:
                    RightToolStripMenuItem.Checked = true;
                    LeftToolStripMenuItem.Checked = false;
                    CenterToolStripMenuItem.Checked = false;
                    break;
                case HorizontalAlignment.Center:
                    CenterToolStripMenuItem.Checked = true;
                    LeftToolStripMenuItem.Checked = false;
                    RightToolStripMenuItem.Checked = false;
                    break;
            }
        }

        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            DocumentTextChanged = true;
            if (RichTextBox.TextLength > 0)
            {
                SelectAllToolStripMenuItem.Enabled = true;
                ToolStripMenuItem7.Enabled = true;
            }
            else
            {
                SelectAllToolStripMenuItem.Enabled = false;
                ToolStripMenuItem7.Enabled = false;
            }
        }

        private void RichTextBoxContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (RichTextBox.SelectionLength > 0)
            {
                ToolStripMenuItem3.Enabled = true;
                ToolStripMenuItem4.Enabled = true;
                ToolStripMenuItem6.Enabled = true;
            }
            else
            {
                ToolStripMenuItem3.Enabled = false;
                ToolStripMenuItem4.Enabled = false;
                ToolStripMenuItem6.Enabled = false;
            }
            ToolStripMenuItem1.Enabled = RichTextBox.CanUndo;
            ToolStripMenuItem2.Enabled = RichTextBox.CanRedo;
            ToolStripMenuItem5.Enabled = Clipboard.ContainsText() || Clipboard.ContainsImage();
            ToolStripMenuItem7.Enabled = RichTextBox.TextLength > 0;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UndoToolStripMenuItem.Enabled = RichTextBox.CanUndo;
            RedoToolStripMenuItem.Enabled = RichTextBox.CanRedo;
            if (Clipboard.ContainsText() || Clipboard.ContainsImage())
            {
                PasteToolStripButton.Enabled = true;
                PasteToolStripMenuItem.Enabled = true;
            }
            else
            {
                PasteToolStripButton.Enabled = false;
                PasteToolStripMenuItem.Enabled = false;
            }
        }
    }
}
