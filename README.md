About tinyIPS
=============

[![Join the chat at https://gitter.im/vector-man/tinyips](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/vector-man/tinyips?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
tinyIPS is a lightweight, cross-platform command-line IPS (International Patching System) patcher and creator. 

The project page is located here: https://github.com/vector-man/tinyips

About LibIPS.NET
================
tinyIPS uses LibIPS.NET, a .NET library for 'International Patching System' (IPS) patches. It is based on the source code of 'flips,' that was originally created by Alcaro. You can read more about his version on this forum: http://www.smwcentral.net/?p=viewthread&t=61289

LibIPS.NET's project page is located here: https://github.com/vector-man/LibIPS.NET (Please contribute changes to the library on this page.)

Requirements
============
Mono is 3.2.3 or .NET Framework 4.0.

How to Use
==========
To apply Patches:

    Usage: apply <patch> <target> [<output>]

Start by typing 'apply' (without quotes), followed by the patch's full path, then the target file's full path (the file you wish to patch). An output file path can be optionally specified if you wish to patch to a copy of the target file instead.

To create patches:

    Usage: create <original> <modified> <output>

Start by typing 'create' (without quotes), followed by the original (unaltered) file's full path, the modified (altered) file's full path, and the output file's (the IPS file you wish to create) full path.

Copyright
=========
tinyIPS is licensed under GNU Lesser General Public License, version 3.0 or higher.  Copyright (c) 2013 CodeIsle.com.

LibIPS.NET is licensed under the GNU Lesser General Public License, version 3.0 or higher. Copyright (c) 2013 CodeIsle.com. Based on 'flips' Copyright (c) 2012 Alcaro. 

Thanks
======
I want to thank Alcaro for creating 'libips,' a library 'LibIPS.NET' is heavily based on. Without him, tinyIPS would not exist.
