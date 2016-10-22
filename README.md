System.IO.Utilities
===================

This library provides a wrapper over the _System.IO.File_ class. 

The _System.IO.File_ is a class whose methods are all static and because of that they are difficult to mock. This library provides a interface called _IFileHandler_ that exposes all the same methods that _System.IO.File_ class and an implementation of that interface (_FileHandler_) that acts as a wrapper over the _System.IO.File_ class.

So the idea is when you need to manipulate files, just use the IFileHandler/FileHandler pair instead of the _System.IO.File_  class, this way your code will be able to mock file operations.


Contact & Support
-----------------

In case of bugs, recommendations and/or feature requests you can contact me on Twitter: @incopaez



 
