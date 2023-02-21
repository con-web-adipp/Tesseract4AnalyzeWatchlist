# Tesseract4AnalyzeWatchlist

![build](https://img.shields.io/github/actions/workflow/status/con-web-adipp/Tesseract4AnalyzeWatchlist/build.yml)
![release](https://img.shields.io/github/v/release/con-web-adipp/Tesseract4AnalyzeWatchlist)
![license](https://img.shields.io/github/license/con-web-adipp/Tesseract4AnalyzeWatchlist)

Tesseract4AnalyzeWatchlist is a Griffeye Analyze DI Pro plugin that performs an automated watch list search in the text read from images by the [Tesseract4Analyze OCR-plugin](https://github.com/con-web-adipp/Tesseract4Analyze). 
If a search term has a match, a bookmark is attached to the respective file in Analyze DI Pro.

## First steps
### System requirements

- Win64
- [Griffeye Analyze DI Pro](https://www.griffeye.com/analyze-di/)
- [Tesseract4Analyze](https://github.com/con-web-adipp/Tesseract4Analyze)


### Download and installation

The latest release is available for download on the [release page of this repository](https://github.com/con-web-adipp/Tesseract4AnalyzeWatchlist/releases).


Install the plugin by selecting ``Tesseract4AnalyzeWatchlist_[Version].appkg`` from ``File -> Settings -> Plugins -> Install`` within Griffeye Analyze DI Pro.

The plugin is ready to use immediately (e.g. via ``Case Data -> Rescan against Plugins -> Tesseract4AnalyzeWatchlist``).

## Basic usage

### Watchlist setup

The watch lists are stored in a .JSON file at the following file path:

```
C:\ProgramData\Griffeye Technologies\Griffeye Analyze\Data\Plugins\Tesseract4AnalyzeWatchlist\watchlist.json
```


The content of the file looks like this:
```json
[
  {
    "Name": "Test",
    "SearchTerms": [
      "access",
      "alert",
      "photo",
      "common"
    ]
  }
]
```
The value for the key ```"Name"``` defines a name for a keyword list. This name will then appear in Analyze DI Pro as the parent category of all bookmarks assigned to the keywords in this list.
The list of values for the key ```"SearchTerms"``` defines the respective search terms.

The use of regular expressions is possible, see for example a primitive regular expression for an IBAN:

```json
[
  {
    "Name": "IBAN",
    "SearchTerms": [
      "[A-Z]{2}[0-9]{20}"
    ]
  }
]
```

Any number of watch lists can be stored in the ``watchlist.json`` file:

```json
[
  {
    "Name": "IBAN",
    "SearchTerms": [
      "[A-Z]{2}[0-9]{20}"
    ]
  },
  {
    "Name": "Test",
    "SearchTerms": [
      "access",
      "alert",
      "photo",
      "common"
    ]
  },
  {
    "Name": "AnotherList",
    "SearchTerms": [
      "x",
      "y",
      "z"
    ]
  }
]
```

## See also

- [https://regex101.com/](https://regex101.com/) (build and test regular expressions)
- [Tesseract4Analyze](https://github.com/con-web-adipp/Tesseract4Analyze)
- [https://www.griffeye.com/analyze-di/](https://www.griffeye.com/analyze-di/)
