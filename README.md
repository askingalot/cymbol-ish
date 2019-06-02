# Cymbol(ish) Interpreter

This is my loose take on Terence Parr's Cymbol language as discussed in [The Definitive ANTLR 4 Reference](https://pragprog.com/book/tpantlr2/the-definitive-antlr-4-reference)

Really this is just a concrete way for me to play with the concepts in the book.

> TBH, over time this language has become more _ish_ than _Cymbol_. I just went my own way with it.

**Here are some random facts about _Cymbol(ish)_**
* Most things are expressions (e.g. `if`s)
* Variables are immutable
* Available types are `int`, `string`, `bool` and `list`
    > **NOTE** Elements in a `list` must be of the same time, but since one of the built-in types is a list you can (currently) do this:
    ```swift
    list mixed = [
        [ 1, 2, 3 ],
        [ "a", "b", "c]
    ];
    ```