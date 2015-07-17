# Short GUID Generator

This is a small utility tool complementing the _Create GUID_ tool found in Visual Studio.

Instead of displaying the GUID as hexadecimal values, the GUID is ASCII encoded into a smaller string since the data density of ASCII characters are higher than of hexadecimal values.

The equivalent of the hexadecimal value of

���c9a646d3-9c61-4cb7-bfcd-ee2522c8f633���

would in ASCII be

���00amyWGct0y_ze4lIsj2Mw���


The encoding code is based on Mads Kristensen's [blog post](http://madskristensen.net/post/a-shorter-and-url-friendly-guid).

![Application snapshot](design/ApplicationSnapshot.png)