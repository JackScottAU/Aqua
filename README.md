# The Aqua Programming Language

## Introduction

TO BE COMPLETED

## The Aqua Project

There are two main parts to the wider Aqua ecosystem:

* This specification, documenting the programming language and its standard 
libraries. The canonical copy of the repository can be found on 
[BitBucket](https://bitbucket.org/JackScottAU/aqua).

* [Fluid](https://bitbucket.org/JackScottAU/fluid), the major implementation of 
Aqua. This interpreter runs on any POSIX system, is implemented in C, and can be
used as a CGI handler for web scripting.

Also noteworthy is [Synergy](https://bitbucket.org/JackScottAU/synergy-os), a 
project to create an entire cloud computing infrastructure based on the Aqua 
ecosystem.

## Licensing

The entire specification of the Aqua programming language is released under the 
terms of the ISC license. The full license text follows:

*Copyright (c) 2012, [Jack Scott](mailto:jack@jackscott.id.au)*

*Permission to use, copy, modify, and/or distribute this software for any purpose
with or without fee is hereby granted, provided that the above copyright notice
and this permission notice appear in all copies.*

*THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES WITH
REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF MERCHANTABILITY AND
FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY SPECIAL, DIRECT,
INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES WHATSOEVER RESULTING FROM LOSS
OF USE, DATA OR PROFITS, WHETHER IN AN ACTION OF CONTRACT, NEGLIGENCE OR OTHER
TORTIOUS ACTION, ARISING OUT OF OR IN CONNECTION WITH THE USE OR PERFORMANCE OF
THIS SOFTWARE.*

## Random Notes
Based on Lua, C, PHP and Lisp.
Associative arrays are the single composite data type.

pointer-safe?

interpreted vs. compiled? or both?
namespaces - functions in there give access to lots of features

"objects" are sets that can be copy()ied.

lightweight threading?

errors are normal objects, like in go

resultSet = eval(inputSet) 		creates a new (lightweight in some implementations?) thread and executes the thread in there.

resultSet = combine(firstSet, secondSet)	combines two sets into one set, recursively. if a leaf object exists in the other, firstSet is preferred.

resultSet = clone(firstSet)	makes a complete clone of one set into another

can be interpreted or jit-compiled

things the standard library provides: tcp/ip/ipv6/udp networking, console i/o, file i/o, etc - these would need to be provided by the synergy kernel.

The official "aqua" implementation is an interpreter for POSIX.

All source files are UTF-8. Any character or number (started by a character) under UTF rules is valid identifier for aqua.

Sets of data.


SET

	BOOLEAN

	INTEGER

	FLOAT

	STRING

	SET

	ERROR

	STATEMENT TREE ATOM

		STATEMENT TREE ATOM

		SET



A set is either empty, or contains one or more atoms that may or may not have an atom.
An atom is either a statement tree, an integer, a boolean, a float, a string, a set, or an error.
A function is simply a set that contains at least one statement tree atom. Statement trees are executed in order.
A statement tree atom is a single operation, and can be nested. if() {} would be a statement tree that contains one more statement tree atom (for the test) and a set (to hold sta's within the block).

Set
	name->value pairs
	or <anon>->value pairs
	
	
$this is the containing current containing set.
$parent is the set above that set.
$root is the set containing the entire program?

"Looks like C/PHP. Acts like LISP. USES FUCKING CURLY-BRACKETS!"

If there is a choice between using more CPU and using more RAM, use more CPU. CPU is under-used, RAM is always expensive.

clone statement takes one part of the tree/list and copies it in somewhere else.
basically for substantiating classes.
also maybe good for lightweight threading, if i choose to implement that?

 auto
break
case
char
const
continue
default
do
double
else
enum
extern
float
for
goto
if
int
long
register
return
short
signed
sizeof
static
struct
switch
typedef
union
unsigned
void
volatile
while 
