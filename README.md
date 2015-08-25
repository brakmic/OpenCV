# OpenCV Demos

**Character Recognition**

*Environment Setup*

* Download & Install <a href="http://opencv.org/downloads.html" target="_blank">OpenCV 3.0.0</a><br/>
* Download & Install EmguCV, the OpenCV wrapper libs for .NET, from <a href="http://sourceforge.net/projects/emgucv/files/" target="_blank">here</a>.<br/>
* Set a system-wide variable pointing to the EmguCV install dir, for example <br/><br/>``` EMGU_ROOT=C:\bin\Emgu```<br/><br/>
You can do this via **System Preferences/Advanced Settings**<br/><br/>
* Add this variable to the variable *PATH* in the same settings window. Go to the *PATH*-entry and expand it to <br/><br/>```%EMGU_ROOT%\bin\x64```<br/>
<br/>This entry is needed because the app will automatically search for **cvextern.dll** located in this directory.<br/>
* Open the solution file and start the app (Notice: *this is an x64 app*)<br/>
* Load one of the available images from the **Assets** folder (these are simple invoice documents)<br/>
* Click on Analyze and wait for the OCR-task to complete. <br/>

*Example*

<img src="http://fs2.directupload.net/images/150825/jli4zbww.png" width="400" height="400">

*License*<br/>
MIT



