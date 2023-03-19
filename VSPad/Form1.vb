Public Class Form1
    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        SaveFile()
    End Sub

    Public Sub SaveFile()
     
        'SavesFile
        Dim savefile As New SaveFileDialog
        savefile.Title = "Save document"
        savefile.Filter = "Text Document (*.txt) | *.txt"
        savefile.ShowDialog()
        RichTextBox1.SaveFile(savefile.FileName, RichTextBoxStreamType.PlainText)
    End Sub

    Private Sub FontsNotWorkingSaveingToolStripMenuItem_Click(sender As Object, e As EventArgs)
       'Font Dialog //-Not Working
        FontDialog1.ShowDialog()
        RichTextBox1.Font = FontDialog1.Font

    End Sub

    Private Sub ColorNotSaveingToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ColorCommandUse()
    End Sub
    Public Sub ColorCommandUse()
        Dim colors As DialogResult
        colors = ColorDialog1.ShowDialog()

        If colors = Windows.Forms.DialogResult.OK Then

            RichTextBox1.ForeColor = ColorDialog1.Color

        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem1.Click
      'SaveFile
        SaveFile()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

    'OpensFile Explorer Dialog
        OpenFileDialog1.Title = "Select a text document"
        OpenFileDialog1.Filter = "Text Document (*.txt) | *.txt"
        OpenFileDialog1.AddExtension = False
        OpenFileDialog1.ShowDialog()
        Try
       'LoadsFile
            RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub SelectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub FontsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontsToolStripMenuItem.Click
        Dim selectfont As New FontDialog
        selectfont.ShowDialog()
        Try
            RichTextBox1.Font = selectfont.Font
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
       'Color Menu
        Dim selectcolor As New ColorDialog
      'Show Dialog
        selectcolor.ShowDialog()
        Try
        'Changes Color
            RichTextBox1.ForeColor = selectcolor.Color
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
       'Opens AboutBox
        AboutBox1.Visible = True
    End Sub

    Private Sub CreditsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreditsToolStripMenuItem.Click
       'Opens Cridit Menu
        Form3.Visible = True
    End Sub
End Class
