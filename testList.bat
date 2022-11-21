::testing failed scenario

::testing second parameter not being a valid language then default to english
hello Gregory Jones english

:: testing when we put in an extra parameter beyond language 
Hello "Gregory Jones" french blah 
Hello "Gregory Jones" blahblah

::testing no parameters (Success)
Hello Gregory
Hello "Gregory Jones" 
Hello

:: English test (Success)
hello English  
Hello ENGLISH
hello english
hello EnGlIsH
hello Gregory English
Hello Gregory ENGLISH
hello Gregory english 
hello Gregory EnGlIsH
hello "Gregory Jones" English 
Hello "Gregory Jones" ENGLISH
hello "Gregory Jones" english 
hello "Gregory Jones" EnGlIsH
hello English Gregory
hello Gregory English blah blah blah 
hello English Gregory blah blah blah 

:: French test (Success)
hello French 
Hello FRENCH
hello french
hello FrEnCh
hello Gregory French 
Hello Gregory FRENCH
hello Gregory french 
hello Gregory fReNcH
hello "Gregory Jones" French 
Hello "Gregory Jones" FRENCH
hello "Gregory Jones" french 
hello "Gregory Jones" fReNcH
hello French Gregory
hello Gregory French blah blah blah 
hello French Gregory blah blah blah 

:: italian test (Success)
hello Italian 
Hello ITALIAN
hello italian
hello ItAlIaN
hello Gregory Italian 
Hello Gregory ITALIAN
hello Gregory italian 
hello Gregory ItAlIaN
hello "Gregory Jones" Italian 
Hello "Gregory Jones" ITALIAN
hello "Gregory Jones" italian 
hello "Gregory Jones" ItAlIaN
hello Italian Gregory
hello Gregory Italian blah blah blah 
hello Italian Gregory blah blah blah 


:: Spanish test (Success)
hello Spanish 
Hello SPANISH
hello spanish
hello SpAnIsH
hello Gregory Spanish 
Hello Gregory SPANISH
hello Gregory spanish 
hello Gregory SpAnIsH
hello "Gregory Jones" Spanish 
Hello "Gregory Jones" SPANISH
hello "Gregory Jones" spanish 
hello "Gregory Jones" SpAnIsH
hello Spanish Gregory
hello Gregory Spanish blah blah blah 
hello Spanish Gregory blah blah blah 

:: Japanese test (Success)
hello Japanese 
Hello JAPANESE
hello japanese
hello JaPaNeSe
hello Gregory Japanese 
Hello Gregory JAPANESE
hello Gregory japanese 
hello Gregory JaPaNeSe
hello "Gregory Jones" Japanese 
Hello "Gregory Jones" JAPANESE
hello "Gregory Jones" japanese 
hello "Gregory Jones" JaPaNeSe
hello Japanese Gregory
hello Gregory Japanese blah blah blah 
hello Japanese Gregory blah blah blah

:: MultiLanguage Test (Success)
hello English English
hello English French
hello English Italian
hello English Spanish
hello English Japanese

hello French English
hello French French
hello French Italian
hello French Spanish
hello French Japanese

hello Italian English
hello Italian French
hello Italian Italian
hello Italian Spanish
hello Italian Japanese

hello Spanish English
hello Spanish French
hello Spanish Italian
hello Spanish Spanish
hello Spanish Japanese

hello Japanese English
hello Japanese French
hello Japanese Italian
hello Japanese Spanish
hello Japanese Japanese