# Cymbol(ish) Interpreter

This is my loose take on Terence Parr's Cymbol language as discussed in [The Definitive ANTLR 4 Reference](https://pragprog.com/book/tpantlr2/the-definitive-antlr-4-reference)

Really this is just a concrete way for me to play with the concepts in the book.

> TBH, over time this language has become more _ish_ than _Cymbol_. I just went my own way with it.

**Here are some random facts about _Cymbol(ish)_**
* Most things are expressions (e.g. `if`s)
* No `return` keyword
* Functions return the result of the last evaluated expression
* Variables are immutable
* Variables and values have types
* Available types are `int`, `string`, `bool` and `list`
    * **NOTE** Elements in a `list` must be of the same type, but since `list` is a type, you can (currently) do this:
        ```swift
        list mixed = [
            [ 1, 2, 3 ],
            [ "a", "b", "c" ]
        ];
        ```
* There are no loops, but there is (tail) recursion
* `len()` and `range()` are built-in functions, `print()` is technically a keyword
* Code is allowed outside of a function
* No closures. Each scope is independent
* If you want syntax highlighting for `*.cy` files, `go` and `swift` highlighting seem to work pretty well.