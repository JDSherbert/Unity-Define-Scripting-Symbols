![image](https://github.com/JDSherbert/Unity-Define-Scripting-Symbols/assets/43964243/3c7f083e-8465-4f19-b7e5-f558c5309d2f)

# Unity - Define Scripting Symbols

<!-- Header Start -->
<a href = "https://docs.unity.com/"> <img align="left" img height="40" img width="40" src="https://cdn.simpleicons.org/unity/white"> </a> 
<a href = "https://learn.microsoft.com/en-us/dotnet/csharp"> <img height="40" img width="40" src="https://cdn.simpleicons.org/csharp"> </a>
<img align="right" alt="Stars Badge" src="https://img.shields.io/github/stars/jdsherbert/Unity-Define-Scripting-Symbols?label=%E2%AD%90"/>
<img align="right" alt="Forks Badge" src="https://img.shields.io/github/forks/jdsherbert/Unity-Define-Scripting-Symbols?label=%F0%9F%8D%B4"/>
<img align="right" alt="Watchers Badge" src="https://img.shields.io/github/watchers/jdsherbert/Unity-Define-Scripting-Symbols?label=%F0%9F%91%81%EF%B8%8F"/>
<img align="right" alt="Issues Badge" src="https://img.shields.io/github/issues/jdsherbert/Unity-Define-Scripting-Symbols?label=%E2%9A%A0%EF%B8%8F"/>
<img align="right" src="https://hits.seeyoufarm.com/api/count/incr/badge.svg?url=https%3A%2F%2Fgithub.com%2FJDSherbert%2FUnity-Define-Scripting-Symbols%2Fhit-counter%2FREADME&count_bg=%2379C83D&title_bg=%23555555&labelColor=0E1128&title=🔍&style=for-the-badge">
<!-- Header End --> 

-----------------------------------------------------------------------

<a href="https://docs.unity.com/"> 
  <img align="left" alt="Extension Tool For Unity" src="https://img.shields.io/badge/Extension%20Tool%20For%20Unity-FFFFFF?style=for-the-badge&logo=unity&logoColor=black&color=black&labelColor=FFFFFF"> </a>
  
<a href="https://choosealicense.com/licenses/mit"> 
  <img align="right" alt="License" src="https://img.shields.io/badge/License%20:%20MIT-black?style=for-the-badge&logo=mit&logoColor=white&color=black&labelColor=black"> </a>
  
<br></br>

 -----------------------------------------------------------------------
## Overview

Small script to automatically add scripting defines to your Unity build. The defines you specify in the readonly string class will be added when the script is compiled. They will be added in the order as defined in the readonly string.

Be aware that this script must be put into an "Editor" folder in order to work correctly.

You can add the additional scripting defines like this:
```cs
	/// <summary>
	/// Symbols to add build settings.
	/// </summary>
	public static readonly string[] Symbols = new string[]
	{
		"SOME_SYMBOL",
    		"ANOTHER_SYMBOL",
    		"A_THIRD_SYMBOL"
	};
```
