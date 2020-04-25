\ symbols.fs  to build a dictionary file
warnings off

: ""  [char] " emit ;
: ^^  [char] ^ emit ;
: {{  [char] { emit ;
: }}  [char] } emit ;
: ::  [char] : emit ;
: ,   [char] , emit cr ;

: [1]  ." FPLT" ;
: [2]  ." RBGS" ;
: [3]  ." FRPB" ;
: [4]  ." FRPBLG" ;

create _steno  0 c, 20 allot
create _English 0 c, 20 allot
: steno   _steno count type ;
: English  _English count type ;

: --
    BL word count _steno place
    BL word count _English place
    "" steno [1] "" :: space "" {{ English ^^ }} "" ,
    "" steno [2] "" :: space "" {{ ^^ English }} "" ,
    "" steno [3] "" :: space "" {{ ^^ English ^^ }} "" ,
    "" steno [4] "" :: space "" English ""
    ;

.( {) cr
-- KPA < ,
-- KW- \" ,
-- KWHR- = ,
-- KWR- ! ,
-- P- % ,
-- PHR- + ,
-- PR- ( ,
-- PR* ) ,
-- PRA > ,
-- PW- | ,
-- PWHR- . ,
-- PWR- [ ,
-- PWR* ] ,
-- SHR- : ,
-- SKP- & ,
-- SKPH- / ,
-- SKW- ? ,
-- SKWR- _ ,
-- SR- ; ,
-- STR- * ,
-- STWR- \\ ,
-- T- ' ,
-- TW- ` ,
-- THR- ~ ,
-- TK- $ ,
-- TKHR- , ,
-- TKPW- @ ,
-- TPH- # ,
-- TPR- \\{ ,
-- TPR* \\} ,
-- WR- - cr
.( }) cr
bye
