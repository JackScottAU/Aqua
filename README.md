# The Aqua Programming Language

## Introduction

*Aqua* is a general purpose procedural programming language based on elements 
from Lisp, C, and Lua. Aqua is based on a single composite data type, the 
associative array, and both code and data are expressed in this format. It is 
designed to be suitable for both application and server-side web programming 
through an extensive standard library.

## Features

*  Like LISP-variants, code and data are both stored in memory as the same data 
   structures, making meta-programming trivial. Unlike LISP-variants, code is 
   written in the familiar C-derived curly-brackets style.

*  General-purpose enough to be useful for applications programming, with all 
   the libraries one would expect for the job: networking, file access, console 
   I/O, and graphical user interfaces, amongst others.

*  Also useful for web programming with libraries available for generating 
   XML/HTML and JSON directly from Aqua data structures.

*  Multiple return values per function.

*  First class functions.

*  Errors are a first-class data type, meaning that errors can be checked for 
   using standard control structures such as if() statements.

*  The language is dynamically typed. Function definitions can have type 
   specifications to add constraints if desired.

## The Aqua Project

There are two main parts to the wider Aqua ecosystem:

*  The Aqua specification, documenting the programming language and its standard
   libraries. The canonical copy of the repository can be found on 
   [BitBucket](https://bitbucket.org/JackScottAU/aqua).

*  [Fluid](https://bitbucket.org/JackScottAU/fluid), the major implementation of 
   Aqua. This interpreter runs on any POSIX system, is implemented in C, and can
   be used as a CGI handler for web scripting.

Also noteworthy is [Synergy](https://bitbucket.org/JackScottAU/synergy-os), a 
project to create an entire cloud computing infrastructure based on the Aqua 
ecosystem.

## Licensing

The entire specification of the Aqua programming language is released under the 
terms of the ISC license. The full license text follows:

*Copyright (c) 2013, [Jack Scott](mailto:jack@jackscott.id.au)*

*Permission to use, copy, modify, and/or distribute this software for any 
purpose with or without fee is hereby granted, provided that the above copyright 
notice and this permission notice appear in all copies.*

*THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES WITH
REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF MERCHANTABILITY AND
FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY SPECIAL, DIRECT,
INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES WHATSOEVER RESULTING FROM LOSS
OF USE, DATA OR PROFITS, WHETHER IN AN ACTION OF CONTRACT, NEGLIGENCE OR OTHER
TORTIOUS ACTION, ARISING OUT OF OR IN CONNECTION WITH THE USE OR PERFORMANCE OF
THIS SOFTWARE.*

## Example Code

Code to compute and output the 100th fibonacci number:

	//Import the contents of the aqua.console library into this program.
	clone aqua.console.* this;

	//First set of brackets is arguments, second set is returns.
	function fibonacci (integer n) (integer)
	{
		if(n==0)
			return 0;		
  		
		if(n==1 || n==2)
			return 1;
		
		return fibonacci(n-1) + fibonacci(n-2);
	}

	//.. is a concatenation operator.
	print("100th Fibonacci Number:" .. fibonacci(100));

Code to build and a basic HTML page:

	clone aqua.data.xml.* this;
	clone aqua.console.* this;

	myPage = {
		"html": {
			"body": {
				//keys with values are turned into tags with content/tags inside.
				"p": "Hello, world!",
				//keys without values are turned into <img /> style tags.
				"img src='./nyan-cat.png' alt='Nyan Cat'": null,
				//values without keys are turned into content.
				"Don't even need to specify that there isn't a key!"
			}
		}
	};

	renderedPage = convertToHTML(myPage);
	print(renderedPage);
