csc /target:library /out:BusinessLogic.dll .\BusinessLogic\Interfaces\IDisplayable.cs .\BusinessLogic\*
csc .\hello.cs -r:.\BusinessLogic.dll
csc /target:library /out:GreetingTests.dll /recurse:.\Tests\* -r:"C:\Program Files (x86)\Microsoft Visual Studio\2019\TestAgent\Common7\IDE\Extensions\TestPlatform\Microsoft.VisualStudio.QualityTools.UnitTestFramework.dll",.\BusinessLogic.dll
