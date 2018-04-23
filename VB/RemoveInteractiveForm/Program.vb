Imports DevExpress.Pdf
Imports System

Namespace RemoveInteractiveForm
    Friend Class Program
        Shared Sub Main(ByVal args() As String)
            Using processor As New PdfDocumentProcessor()

                ' Load a document with an interactive form.
                processor.LoadDocument("..\..\InteractiveForm.pdf")

                ' Remove a form field by its name.
                If processor.RemoveFormField("FirstName") Then

                    ' Save the modified document.
                    processor.SaveDocument("..\..\Result1.pdf")

                Else

                    ' Show a message if the form field was not found in a document.
                    Console.WriteLine("The form field was not removed from a document. Make sure, the form field exists in the document.")
                End If

                ' Remove the whole interactive form.
                If processor.RemoveForm() Then

                    ' Save the modified document.
                    processor.SaveDocument("..\..\Result2.pdf")

                Else

                    ' Show a message if the interactive form was not found in a document.
                    Console.WriteLine("The interactive form was not removed from a document. Make sure the interactive form exists in the document.")
                End If
            End Using
        End Sub
    End Class
End Namespace
