using DevExpress.Pdf;
using System;

namespace RemoveInteractiveForm {
    class Program {
        static void Main(string[] args) {
            using (PdfDocumentProcessor processor = new PdfDocumentProcessor()) {

                // Load a document with an interactive form.
                processor.LoadDocument("..\\..\\InteractiveForm.pdf");

                // Remove a form field by its name.
                if (processor.RemoveFormField("FirstName"))

                    // Save the modified document.
                    processor.SaveDocument("..\\..\\Result1.pdf");

                else

                    // Show a message if the form field was not found in a document.
                    Console.WriteLine("The form field was not removed from a document. Make sure, the form field exists in the document.");

                // Remove the whole interactive form.
                if (processor.RemoveForm())

                    // Save the modified document.
                    processor.SaveDocument("..\\..\\Result2.pdf");

                else

                    // Show a message if the interactive form was not found in a document.
                    Console.WriteLine("The interactive form was not removed from a document. Make sure the interactive form exists in the document.");
            }
        }
    }
}
