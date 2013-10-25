Media Viewer example
====================

Media Viewer is a Windows Phone example application implemented with 
Silverlight. The application is ported from the FileList Qt Quick example. 

Media Viewer enables the user to explore a list of pictures and music files 
stored on their device. It's also possible to preview an image, play a music 
file, and check the details of the selected file on a separate page.

This example application is hosted in GitHub:
https://github.com/nokia-developer/media-viewer

For more information on porting, visit the wiki page:
https://github.com/nokia-developer/media-viewer/wiki


1. Prerequisites
--------------------------------------------------------------------------------

- C# basics
- Development environment 'Microsoft Visual Studio 2010 Express for Windows
  Phone'


2. Project Structure
--------------------------------------------------------------------------------

2.1 Folders
-----------

 |                  The root folder contains the project file, App.xaml file,
 |                  resource files, license information, and this file
 |                  (release notes).
 |
 |- Pages           Contains pages .xaml and xaml.cs files 
 |
 |- ViewModels      Contains model classes for views
 |
 |- Converters      Contains value converter classes


2.2 Important files/classes
---------------------------

| File                      | Description                                      |
|---------------------------|--------------------------------------------------|
| App.xaml                  | Encapsulates a Silverlight application           |
|---------------------------|--------------------------------------------------|
| MainPage.xaml             | Main page implementation containg pivot whose    |
|                           | items represent pictures and music categories    |
|---------------------------|--------------------------------------------------|
| PicturePreviewPage.xaml   | Picture preview page implementation              | 
|---------------------------|--------------------------------------------------| 
| SongDetailsPage.xaml      | Song details page implementation                 | 
|---------------------------|--------------------------------------------------|
| CategoryDetailsModel.cs   | Base class for category models                   |
|---------------------------|--------------------------------------------------|
| PicturesCategoryModel.cs  | Model used for pivot pictures category item      |
|---------------------------|--------------------------------------------------|
| MusicCategoryModel.cs     | Model used for pivot music category item         |
|---------------------------|--------------------------------------------------|
| PicturesPreviewModel.sc   | Model for picture preview page                   |
|---------------------------|--------------------------------------------------|


3. Known Issues
--------------------------------------------------------------------------------

None.


4. Build and Installation Instructions
--------------------------------------------------------------------------------

4.1 Preparations
----------------

Make sure you have the following installed:
 * Windows 7, may also work on Windows XP
 * Microsoft Visual Studio 2010 Express for Windows Phone
 * The Windows Phone Developer Tools January 2011 Update:
   http://download.microsoft.com/download/6/D/6/6D66958D-891B-4C0E-BC32-2DFC41917B11/WindowsPhoneDeveloperResources_en-US_Patch1.msp
 * Windows Phone Developer Tools Fix:
   http://download.microsoft.com/download/6/D/6/6D66958D-891B-4C0E-BC32-2DFC41917B11/VS10-KB2486994-x86.exe


4.2 Build on Microsoft Visual Studio
------------------------------------

1. Open the Solution file (.sln):
   File > Open Project, select the file MediaViewer.sln
2. Select the target 'Windows Phone 7 Emulator'.
3. Press F5 to build the project and run it on the Windows Phone Emulator.


4.3 Deploy to Windows Phone 7
-----------------------------

Preparations:
1. Register in the App Hub to get a Windows Live ID:
   http://create.msdn.com/en-us/home/membership
2. Install Zune for Windows Phone 7:
   http://www.zune.net/en-us/products/windowsphone7/default.htm
3. Register your phone in your Windows Live account.
   Select from Windows: Start > Windows Phone Developer Tools > Windows Phone
   Developer Registration

Deploy:
1. Open the SLN file:
   File > Open Project, select the file MediaViewer.sln
2. Connect the device to Windows via USB.
3. Select the target 'Windows Phone 7 Device'.
4. Press F5 to build the project and run it on your Windows phone.


5. Compatibility
--------------------------------------------------------------------------------

- Windows Phone 7.0 and 7.1

Tested on:
- HTC 7 Mozart
- Samsung Omnia 7

Developed with:
- Microsoft Visual Studio 2010 Express for Windows Phone


6. Additional Information
--------------------------------------------------------------------------------

Getting Started Guide:
http://create.msdn.com/en-us/home/getting_started

Learn About Windows Phone 7 Development:
http://msdn.microsoft.com/fi-fi/ff380145

App Hub, develop for Windows Phone:
http://create.msdn.com
