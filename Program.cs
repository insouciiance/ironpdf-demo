using IronPdf.Engines.Chrome;
using IronPdf.Rendering;

License.LicenseKey = "...";

ChromePdfRenderer renderer = new();
         
renderer.RenderingOptions.MarginBottom = 0;
renderer.RenderingOptions.MarginLeft = 0;
renderer.RenderingOptions.MarginRight = 0;
renderer.RenderingOptions.MarginTop = 0;
renderer.RenderingOptions.PaperSize = PdfPaperSize.Letter;
renderer.RenderingOptions.CssMediaType = PdfCssMediaType.Screen;
renderer.RenderingOptions.PaperFit.UseChromeDefaultRendering();
renderer.RenderingOptions.FitToPaperMode = FitToPaperModes.Automatic;
         
var doc = renderer.RenderHtmlAsPdf("<html></html>");
         
doc.SaveAs("output.pdf");
