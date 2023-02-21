using AdippNet;
using AdippNet.Models;

var tesseract4AnalyzeUid = "625cf8a6-a648-44f9-aa3a-42624a77154c";
var watchlist = new Watchlist("C:\\ProgramData\\Griffeye Technologies\\Griffeye Analyze\\Data\\Plugins\\Tesseract4AnalyzeWatchlist\\watchlist.json");


var plugin = new Adipp();

void SearchOcrText(MediaFile file)
{
    var customPropertyValue = file.CustomPropertyValues.FirstOrDefault(c => c.Key == tesseract4AnalyzeUid);
    if (customPropertyValue is null) return;
    var result = watchlist.Search(customPropertyValue.Value[0].Value, "OCR-Watchlist");
    file.AddBookmarks(result);
}

plugin.AddAction(SearchOcrText);
plugin.Run();