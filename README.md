# intive-test
 # Interview test case
 ## Author: Fernanda Ochoa

 ## Short Description
This test case opens Google with a browser selected by the parameter. Search "seleniumhq" and click on the first result from the list.

 ## How can you run the test case?

 **Step 1: Source code**
Download or clone the source from git repository: [Repository](https://github.com/ferchuochoa/intive-test.git)
Download the repository on the _User/UserName_ space (your %USERPROFILE%). For more information, you can see the _app.config_ the file inside the project. 

 **Step 2: Software needed**
You need download nunit console, you can do it from here and install it:
[NUnit](https://github.com/nunit/nunit-console/releases)

Add to system environment var _PATH_ this: _C:\Program Files (x86)\NUnit.org\nunit-console_

 **Step 3: Run test**
Open command line _cmd_, go to the current path where the _dll_ was been generated _(..\IntiveFDV-test\bin\Debug)_

And type on a console the next command line.
$ nunit3-console.exe --params:Browser=IE IntiveFDV-test.dll

You can run the test case for Browser:IE/Chrome/FireFox if you change the params as Browser=FireFox. Also if you run command line without params the test case run for Chrome as default.

 ## Notes
Selenium WebDriver
Language C#
Platform on Windows 10

 ## Pattern used
 I am using those patterns to abstract behaviour.
 
 ### Page Object Pattern
 This pattern is commonly used on test automation to split the functionality of the page with the test case steps. I used when I did the class _Google_ where there put all functionality regarding thing to do on this page site.
 
 ### Factory Pattern 
 Also, I use this pattern, to create a different instance depending on the browser. I used the class _BrowserFactory_ where I´ll generate the different instance according to the browser sent by the parameter.