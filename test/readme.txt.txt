 # Interview test case
 ## Author: Fernanda Ochoa

 ## Short Description
This test case opens Google with a browser selected by the parameter. Search "seleniumhq" and click on the first result from the list.

 ## Pattern used
 ### Page Object Pattern
 ### Factory Pattern

 ## How can run the test case?

 ** Step 1: Source code **
Download the source on the desktop folder. From git repository: [Repository](https://github.com/ferchuochoa/intive-test.git)
Download the repository on the User/UserName space.For more information you can see the app.config file inside the project.

 ** Step 2: Software needed **
You need download nunit console, you can do it from here and install it:
[NUnit](https://github.com/nunit/nunit-console/releases)

Add to system environment var _PATH_ this: _C:\Program Files (x86)\NUnit.org\nunit-console_

 ** Step 3: Run test **
Open command line _cmd_, go to the current path where the _dll_ was been generated _(..test\IntiveFDV-test\IntiveFDV-test\bin\Debug)_

And type on a console the next command line.You can run the test case for Browser:IE/FireFox/Chrome browsers:
$ nunit3-console.exe --params:Browser=IE IntiveFDV-test.dll

 ## Notes
The test case run with Chrome Browser like default, if the parameter Browser is missing.
Explorer need change some security permissions
Platform is windows
