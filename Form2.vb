Public Class Form2
    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        Dim notify As Object = MessageBox.Show("¿Esta seguro de crear un nuevo archivo?, el actual se eliminará.", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If notify = DialogResult.Yes Then
            txtpad.Clear()

        End If

    End Sub

    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenToolStripButton.Click
        OpenFileDialog1.ShowDialog()

    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        If SaveFileDialog1.FileName = Nothing Then
            SaveFileDialog1.ShowDialog()
        Else

            txtpad.SaveFile(SaveFileDialog1.FileName, MessageBoxButtons.YesNo)

        End If
    End Sub

    Private Sub GuardarComoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarComoToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()

    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        PrintDialog1.ShowDialog()

    End Sub

    Private Sub VistaPreviaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VistaPreviaToolStripMenuItem.Click
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub ConfiguraciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraciónToolStripMenuItem.Click
        PageSetupDialog1.ShowDialog()

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        txtpad.Undo()

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        txtpad.Redo()

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        txtpad.SelectAll()

    End Sub

    Private Sub CopyToolStripButton_Click(sender As Object, e As EventArgs) Handles CopyToolStripButton.Click
        txtpad.Copy()

    End Sub

    Private Sub CutToolStripButton_Click(sender As Object, e As EventArgs) Handles CutToolStripButton.Click
        txtpad.Cut()

    End Sub

    Private Sub PasteToolStripButton_Click(sender As Object, e As EventArgs) Handles PasteToolStripButton.Click
        txtpad.Paste()

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        FontDialog1.ShowDialog()
        txtpad.Font = FontDialog1.Font

    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        ColorDialog1.ShowDialog()
        txtpad.ForeColor = ColorDialog1.Color

    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        txtpad.Font = New Font(txtpad.Font, FontStyle.Bold)

    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        txtpad.Font = New Font(txtpad.Font, FontStyle.Italic)

    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        txtpad.Font = New Font(txtpad.Font, FontStyle.Strikeout)

    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        txtpad.Font = New Font(txtpad.Font, FontStyle.Regular)

    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles ToolStripButton10.Click
        txtpad.Font = New Font(txtpad.Font.Size, txtpad.Font.Size + 2)

    End Sub

    Private Sub ToolStripButton11_Click(sender As Object, e As EventArgs) Handles ToolStripButton11.Click
        txtpad.Font = New Font(txtpad.Font.Size, txtpad.Font.Size - 2)

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Dim CONTP As Integer
        Dim PAL As String

        For i = 1 To txtpad.Text.Length

            PAL = (Mid(txtpad.Text, i, 1))

            If PAL = " " Then
                CONTP = CONTP + 1


            End If


        Next
        ToolStripLabel1.Text = CONTP + 1
    End Sub

    Private Sub ToolStripButton12_Click(sender As Object, e As EventArgs) Handles ToolStripButton12.Click
        txtpad.SelectAll()
        txtpad.Text = ""
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(txtpad.Text, New Font("Arial ", 20), Brushes.Black, 12, 20)
    End Sub
End Class