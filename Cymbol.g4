grammar Cymbol;

program : stmts EOF ;

stmts : (stmt ';')* ;

stmt : declaration
     | function
     | expr
     ;

declaration : type ID '=' expr ;

type : 'int' | 'bool' | 'string' ;

function : 'fun' ID '(' (ID (',' ID)*)? ')' '{' (stmt ';')* '}' ;

expr : expr op=('*'|'/') expr                     # muldiv
     | expr op=('+'|'-') expr                     # addsub
     | expr op=('<'|'>'|'<='|'>='|'=='|'!=') expr # rel
     | 'print' '(' expr? ')'                      # print
     | 'if' '(' expr ')' '{' stmts '}'  
       ('else' '{' stmts '}')?                    # if
     | ID '(' (expr (',' expr)*)? ')'             # call
     | INT                                        # int
     | BOOL                                       # bool
     | STRING                                     # string
     | ID                                         # variable
     ;

MUL : '*'  ;
DIV : '/'  ;
ADD : '+'  ;
SUB : '-'  ;
GT  : '>'  ;
GE  : '>=' ;
LT  : '<'  ;
LE  : '<=' ;
EQ  : '==' ;
NE  : '!=' ;

INT : [0-9]+ ;

BOOL : 'true' | 'false' ;

STRING : '"' .*? '"' ;

ID : [_a-zA-Z] [_a-zA-Z0-9]* ;

COMMENT : '//' .*? '\r'? '\n' -> skip ;

ML_COMMENT : '/*' .*? '*/' -> skip ;

WS : [ \t\r\n]+ -> skip ;
