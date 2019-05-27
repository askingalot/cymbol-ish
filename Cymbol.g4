grammar Cymbol;

program : (stmt ';')* EOF ;

stmt : declaration
     | function
     | expr
     ;

declaration : type ID '=' expr ;

type : 'int' | 'bool' | 'string' ;

function : 'fun' ID '(' (ID (',' ID)*)? ')' '{' (stmt ';')* '}' ;

expr : expr op=('*'|'/') expr           # muldiv
     | expr op=('+'|'-') expr           # addsub
     | 'print' '(' expr ')'             # print
     | 'print' '(' STRING? ')'          # printString
     | ID '(' (expr (',' expr)*)? ')'   # call
     | INT                              # int
     | BOOL                             # bool
     | STRING                           # string
     | ID                               # variable
     ;

MUL : '*' ;
DIV : '/' ;
ADD : '+' ;
SUB : '-' ;

INT : [0-9]+ ;

BOOL : 'true' | 'false' ;

STRING : '"' .*? '"' ;

ID : [_a-zA-Z] [_a-zA-Z0-9]* ;

COMMENT : '//' .*? '\r'? '\n' -> skip ;

ML_COMMENT : '/*' .*? '*/' -> skip ;

WS : [ \t\r\n]+ -> skip ;
