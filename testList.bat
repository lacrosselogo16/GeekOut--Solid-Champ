::testing failed scenario

::testing second parameter not being a valid language then default to english
hello Gregory Jones english

:: testing when we put in an extra parameter beyond language 
Hello "Gregory Jones" french blah 
Hello "Gregory Jones" blahblah



:: Help menu test (Success)
hello help

:: One Off
	::FirstName Only
Hello Gregory
	::Fullname only
Hello "Gregory Jones"
	::No parameter 
Hello

:: English test (Success)
:: Language Only
hello English  
Hello ENGLISH
hello english
hello EnGlIsH
::FirstName
	::Regular
hello Gregory English
Hello Gregory ENGLISH
hello Gregory english 
hello Gregory EnGlIsH
	::Swap
hello English Gregory
hello ENGLISH Gregory
hello english Gregory
hello EnGlIsH Gregory
	::Regular with third parameter
hello Gregory English blah blah blah
hello Gregory ENGLISH blah blah blah
hello Gregory english blah blah blah
hello Gregory EnGlIsH blah blah blah
	::Swap with third parameter
hello English Gregory blah blah blah
hello ENGLISH Gregory blah blah blah
hello english Gregory blah blah blah
hello EnGlIsH Gregory blah blah blah

:: Fullname
hello "Gregory Jones" English 
Hello "Gregory Jones" ENGLISH
hello "Gregory Jones" english 
hello "Gregory Jones" EnGlIsH
	::Swap
hello English "Gregory Jones"
hello ENGLISH "Gregory Jones"
hello english "Gregory Jones"
hello EnGlIsH "Gregory Jones"
	::Regular with third parameter
hello "Gregory Jones" English blah blah blah
hello "Gregory Jones" ENGLISH blah blah blah
hello "Gregory Jones" english blah blah blah
hello "Gregory Jones" EnGlIsH blah blah blah
	::Swap with third parameter
hello English "Gregory Jones" blah blah blah
hello ENGLISH "Gregory Jones" blah blah blah
hello english "Gregory Jones" blah blah blah
hello EnGlIsH "Gregory Jones" blah blah blah
 

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

:: Chinese test (Success)
hello Chinese 
Hello CHINESE
hello chinese
hello ChInEsE
hello Gregory Chinese 
Hello Gregory CHINESE
hello Gregory chinese 
hello Gregory ChInEsE
hello "Gregory Jones" Chinese 
Hello "Gregory Jones" CHINESE
hello "Gregory Jones" chinese 
hello "Gregory Jones" ChInEsE
hello Chinese Gregory
hello Gregory Chinese blah blah blah 
hello Chinese Gregory blah blah blah

:: MultiLanguage Test (Success)
hello English English
hello English French
hello English Italian
hello English Spanish
hello English Japanese
hello English Chinese

hello French English
hello French French
hello French Italian
hello French Spanish
hello French Japanese
hello French Chinese

hello Italian English
hello Italian French
hello Italian Italian
hello Italian Spanish
hello Italian Japanese
hello Italian Chinese

hello Spanish English
hello Spanish French
hello Spanish Italian
hello Spanish Spanish
hello Spanish Japanese
hello Spanish Chinese

hello Japanese English
hello Japanese French
hello Japanese Italian
hello Japanese Spanish
hello Japanese Japanese
hello Japanese Chinese

hello Chinese English
hello Chinese French
hello Chinese Italian
hello Chinese Spanish
hello Chinese Japanese
hello Chinese Chinese

