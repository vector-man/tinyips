About tinyIPS
=============

tinyIPS is a lightweight, cross platform IPS (International Patching System) patcher and creator. It runs in the command-line.


About LibIPS.NET
================
tinyIPS uses LibIPS.NET. LibIPS.NET is a C# implementation of 'libips', a library for 'International Patching System' (IPS) patches. It is based on the source code of 'flips,' that was originally created by Alcaro. You can read more about his version on this forum: http://www.smwcentral.net/?p=viewthread&t=61289

LibIPS.NET's project page is located here: https://github.com/vector-man/LibIPS.NET (Please contribute changes to the library on this page.)

How to Use
==========
To apply Patches:

Usage: apply <patch> <target> [<output>]

Start by typing 'apply' (without quotes), followed by the patche's full path, then the target file's full path (the file you wish to patch). An output file path can be optionally specified if you wish to patch to a copy of the target file instead.

To create patches:

Usage: create <original> <modified> <output>

Start by typing 'create' (without quotes), followed by the original (unaltered) file's full path, the modified (altered) file's full path, and the output file's (the IPS file you wish to create) full path.

Copyright
=========
tinyIPS is licensed under GNU Lesser General Public License, version 3.0 or higher.  Copyright (c) 2013 CodeIsle.com.

LibIPS.NET is licensed under the GNU Lesser General Public License, version 3.0 or higher. Copyright (c) 2013 CodeIsle.com. Based on 'flips' Copyright (c) 2012 Alcaro. 

Thanks
======
I want to thank Alcaro for creating 'libips,' a library 'LibIPS.NET' is heavily based on. Whitout him, tinyIPS would not exist.
