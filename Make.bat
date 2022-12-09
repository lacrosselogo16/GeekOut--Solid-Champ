csc /target:library /out:BusinessLogic.dll .\BusinessLogic\Interfaces\IDisplayable.cs .\BusinessLogic\*
csc .\hello.cs -r:.\BusinessLogic.dll
csc /target:library /out:GreetingTests.dll .\Tests\GreetingTests.cs -r:"C:\Program Files (x86)\Microsoft Visual Studio\2019\TestAgent\Common7\IDE\Extensions\TestPlatform\Microsoft.VisualStudio.QualityTools.UnitTestFramework.dll",.\BusinessLogic.dll
C:\PROGRA~2\MICROS~2\2019\TESTAG~1\Common7\IDE\MSTest.exe /testcontainer:.\GreetingTests.dll /test:*