[CmdletBinding()]
param(
	[Parameter(Mandatory=$true)]
	[String]$username,

	[Parameter(Mandatory=$true)]
	[String]$password
)

$ErrorActionPreference = "Stop"
$crmSvcUtil = "$PSScriptRoot\..\..\Utilities.CodeGeneration\bin\Release\crmSvcUtil.exe"
$splitFiles = "$PSScriptRoot\..\..\Utilities.SplitCodeFile\bin\Release\SplitCodeFile.exe"

$prefix = "MoC.TypedEntities";

function LogMessage([String]$message, [String]$color)
{
	if([string]::IsNullOrEmpty($color))
	{
		Write-Host "$('[{0:yyyy-MM-dd} {0:HH:mm:ss}]' -f (Get-Date)): $message"
	}
	else
	{
		Write-Host "$('[{0:yyyy-MM-dd} {0:HH:mm:ss}]' -f (Get-Date)): $message" -ForegroundColor $color
	}
}
$stopwatch =  [system.diagnostics.stopwatch]::StartNew()

 LogMessage "Generating: $prefix.OptionSets.cs"
 . $crmSvcUtil /url:https://unittestexample.crm4.dynamics.com/ `
	 /u:$username `
	 /p:$password `
	 /out:$prefix.OptionSets.cs `
	 /namespace:MoC.TypedEntities `
	 /codecustomization:"Utilities.CodeGeneration.OptionSetCustomisationService, Utilities.CodeGeneration" `
	 /codewriterfilter:"Utilities.CodeGeneration.OptionsetFilteringService, Utilities.CodeGeneration"


 LogMessage "Generating: $prefix.Entities.cs"
 . $crmSvcUtil /url:https://unittestexample.crm4.dynamics.com/ `
	 /u:$username `
	 /p:$password `
	 /out:$prefix.Entities.cs  `
	 /namespace:MoC.TypedEntities `
	 /codewriterfilter:"Utilities.CodeGeneration.CodeWriterFilter, Utilities.CodeGeneration"
	
 LogMessage "Generating: $prefix.Attributes.cs"
 . $crmSvcUtil /url:https://unittestexample.crm4.dynamics.com/ `
	 /u:$username `
	 /p:$password `
	 /out:$prefix.Attributes.cs  `
	 /namespace:MoC.TypedEntities `
	 /codecustomization:"Utilities.CodeGeneration.LogicalNameCustomizationService, Utilities.CodeGeneration" `
	 /codewriterfilter:"Utilities.CodeGeneration.CodeWriterFilter, Utilities.CodeGeneration"

LogMessage "Splitting Files"
. $splitFiles $prefix "$PSScriptRoot\.." "$PSScriptRoot"

LogMessage "Script took $($stopwatch.Elapsed.ToString()) to execute."