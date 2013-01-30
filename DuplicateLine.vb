Imports System
Imports EnvDTE
Imports EnvDTE80
Imports EnvDTE90
Imports EnvDTE90a
Imports EnvDTE100
Imports System.Diagnostics

Public Module DuplicateLine

    Sub Duplicate()
        'Select line
        DTE.ActiveDocument.Selection.StartOfLine(0)
        DTE.ActiveDocument.Selection.EndOfLine(True)
        Dim text As String = DTE.ActiveDocument.Selection.Text

        'Add new line
        DTE.ActiveDocument.Selection.EndOfLine()
        DTE.ActiveDocument.Selection.NewLine()
        DTE.ActiveDocument.Selection.StartOfLine(0)

        'Paste text
        DTE.ActiveDocument.Selection.Text = text
    End Sub

End Module
