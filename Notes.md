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




Program = Set of data/code + list of symbols, so any new code can be put in the acyclic graph in the right place can be translated into an object.

{
	"Bob": 3,
	"Carol": 4,
	"main()": 
	{
		"Bob2": ???
		if() {}
		return bob;
	}
}

each set has several things:
	- a collection of data items, which may be either code blocks or data items. Each item may have a name or it may not.
	- an ordered collection of code statements that operate on the 