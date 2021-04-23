\ symbols.fs  to build a dictionary file
warnings off

: ""  [char] " emit ;
: ^^  [char] ^ emit ;
: ::  [char] : emit ;
\ : ,   [char] , emit cr ;

: {{  ." {#" ;
: }}  ." }{^}" ; 
: left  ." STPH" ;

create _steno  0 c, 20 allot
create _English 0 c, 20 allot
: steno   _steno count type ;
: English  _English count type ;

: -/
    BL word count _steno place
    BL word count _English place
    "" left steno "" :: space "" {{ English }} ""
    ;
: --  -/ [char] , emit cr ;

.( {) cr
-- -R left
-- -G right
-- -P up
-- -B down
-- -RB control(left)
-- -BG control(right)
-- -FBL Page_Down
-- -RPG Page_Up
-- -FPL Home
-/ -RBG End
.( }) cr
bye
