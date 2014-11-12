Media Viewer example
====================

Media Viewer is a Windows Phone example application implemented with 
Silverlight. The application is ported from the FileList Qt Quick example. 

Media Viewer enables the user to explore a list of pictures and music files 
stored on their device. It's also possible to preview an image, play a music 
file, and check the details of the selected file on a separate page.

![Picture preview](/doc/screenshots/PicturePreview.PNG?raw=true)&nbsp;
![Song details](/doc/screenshots/SongDetails.PNG?raw=true)

This example application is hosted in GitHub:
https://github.com/Microsoft/media-viewer

For more information on porting, visit the wiki page:
https://github.com/Microsoft/media-viewer/wiki

This project is compatible with Windows Phone 7 and Windows Phone 8.


1. Building and deploying with Microsoft Visual Studio
-------------------------------------------------------------------------------

1. Open the Solution file (.sln): File > Open Project, select the file
   `MediaViewer.sln`
2. Select the target, either emulator or device.
3. Press F5 to build the project and run it in the selected target. If the
   selected target is device, the app will deployed on the phone.


2. Implementation
-------------------------------------------------------------------------------

**Folders:**

* The root folder contains the project file, App.xaml file, resource files,
  license information, and this file (README.md).
* `Pages`: Contains pages `.xaml` and `xaml.cs` files.
* `ViewModels`: Contains model classes for views.
* `Converters`: Contains value converter classes.


**Important files/classes:**

| File | Description |
| ---- | ----------- |
| `App.xaml` | Encapsulates a Silverlight application |
| `MainPage.xaml` | Main page implementation containg pivot whose items represent pictures and music categories |
| `PicturePreviewPage.xaml` | Picture preview page implementation | 
| `SongDetailsPage.xaml` | Song details page implementation | 
| `CategoryDetailsModel.cs` | Base class for category models |
| `PicturesCategoryModel.cs` | Model used for pivot pictures category item |
| `MusicCategoryModel.cs` | Model used for pivot music category item |
| `PicturesPreviewModel.sc` | Model for picture preview page |


3. Version history
-------------------------------------------------------------------------------

* Version 1.0: The first release.
