System.IO.Utilities
================

This library provides a wrapper over the System.IO.File class. 
The System.IO.File is a class whose methods are all static, which are no easy to mock. This library provides a interface called IFileHandler that exposes all the same methods that System.IO.File class and an implementation of that interface (FileHandler) that acts as a wrapper of the System.IO.File class.
So the idea is when you need to manipulate files, just use the IFileHandler/FileHandle pair instead of the System.IO.File class, this way your code will be able to mock the file operations.

 
