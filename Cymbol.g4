grammar Cymbol;

program : stmts EOF ;

stmts : (stmt ';')* ;

stmt : declaration
     | function
     | expr
     ;

declaration : type ID '=' expr ;

type : 'int' | 'bool' | 'string'  | 'list' ;

function : 'fun' ID '(' (ID (',' ID)*)? ')' '{' (stmt ';')* '}' ;

expr : expr op=('*'|'/') expr                      # muldiv
     | expr op=('+'|'-') expr                      # addsub
     | expr op=('<'|'>'|'<='|'>='|'=='|'!=') expr  # comp
     | expr op=('&&'|'||') expr                    # rel
     | op=('-'|'!') expr                           # negate
     | 'print' '(' expr? ')'                       # print
     | 'if' '(' expr ')' '{' stmts '}'  
       ('else' 'if' '(' expr ')' '{' stmts '}')*
       ('else' '{' stmts '}')?                     # if
     | ID '(' (expr (',' expr)*)? ')'              # call
     | ID '[' expr ']'                             # element
     | ID                                          # variable
     | INT                                         # int
     | BOOL                                        # bool
     | STRING                                      # string
     | '[' expr (',' expr)* ']'                    # list
     | '[' ']'                                     # emptyList
     | '(' expr ')'                                # paren
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
NOT : '!'  ;
AND : '&&' ;
OR  : '||' ;

INT : [0-9][0-9_]* ;

BOOL : 'true' | 'false' ;

STRING : '"' .*? '"' ;

ID : [_a-zA-Z] [_a-zA-Z0-9]* ;

COMMENT : '//' .*? '\r'? '\n' -> skip ;

ML_COMMENT : '/*' .*? '*/' -> skip ;

WS : [ \t\r\n]+ -> skip ;
