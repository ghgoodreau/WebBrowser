# WebBrowser
Web Browser built incrementally with C#, MySQL, and Git.

# Running the program
To run this program, please open in Visual Studio and build a version to run in debug mode. The current release version
does not handle all bookmark events properly and will return errors. The debug mode generally works well.

# Purpose
This program was built with the intention of learning software construction fundamentals. I learned Git, SQL, and C# while writing this program. It was fun. I plan to fix the remaining bugs eventually.

# Screenshots
Here are some screenshots of the program and some of it's functionalities.
## Main Form
![Web Browser](https://i.imgur.com/8fqJGIR.png)<br/>
<br/>
This is the main browser form. As you can see, there are a lot of tool strip icons. Including a back, forward, refresh, home, go, and bookmark button. All of these are fully functional and work as intended. The browser also supports multiple tabs.
<br/>
## Tool Dropdown
![Tool Dropdown](https://i.imgur.com/ql0XhqZ.png)<br/>
<br/>
When clicking on the "Tool" option, this dropdown with some options is shown.
<br/>
## History Manager
![History Manager](https://i.imgur.com/LDnJ4OI.png)<br/>
<br/>
The history manager form shows a MySQL database with history items. You can search, delete selected, or clear the items.
<br/>
## Bookmark Manager
![Boomark Manager](https://i.imgur.com/Otm4wYM.png)<br/>
<br/>
The bookmark manager form shows a MySQL database with bookmark items. You can search, delete selected, or clear the items. This is the only form that is buggy at the moment.

# TODO
- Have tab pages named based off of the website they are currently on
- Fix the Bookmark table adapter error that sometimes occurs on certain websites (Amazon, for example)
