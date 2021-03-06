Imports System
Imports EnvDTE
Imports EnvDTE80
Imports EnvDTE90
Imports EnvDTE90a
Imports EnvDTE100
Imports System.Diagnostics

Public Module DuplicateLine

    Sub DuplicateBelow()
        Dim text As String = GetLine()

        'Add new line
        DTE.ActiveDocument.Selection.EndOfLine()
        DTE.ActiveDocument.Selection.NewLine()
        DTE.ActiveDocument.Selection.StartOfLine(0)

        'Paste text
        DTE.ActiveDocument.Selection.Text = text
    End Sub

    Sub DuplicateAbove()
        Dim text As String = GetLine()

        'Add new line
        DTE.ActiveDocument.Selection.StartOfLine(0)
        DTE.ActiveDocument.Selection.NewLine()
        DTE.ActiveDocument.Selection.LineUp()

        'Paste text
        DTE.ActiveDocument.Selection.Text = text
    End Sub

    Private Function GetLine() As String
        'Select line
        DTE.ActiveDocument.Selection.StartOfLine(0)
        DTE.ActiveDocument.Selection.EndOfLine(True)
        Return DTE.ActiveDocument.Selection.Text()
    End Function

End Module
