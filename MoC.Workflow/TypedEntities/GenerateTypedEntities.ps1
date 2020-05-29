[CmdletBinding()]
param(
	[Parameter(Mandatory=$true)]
	[String]$username,

	[Parameter(Mandatory=$true)]
	[String]$password
)

$ErrorActionPreference = "Stop"
$crmSvcUtil = "$PSScriptRoot\..\..\..\Utilities\Utilities.CodeGeneration\bin\Debug\crmSvcUtil.exe"
$splitFiles = "$PSScriptRoot\..\..\..\Utilities\Utilities.SplitCodeFile\bin\Debug\SplitCodeFile.exe"

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

 LogMessage "Generating: Xrm.Typed.OptionSets.cs"
 . $crmSvcUtil /url:https://unittestexample.crm4.dynamics.com `
	 /u:$username `
	 /p:$password `
	 /out:Xrm.Typed.OptionSets.cs `
	 /namespace:MoC.Workflow.Entities `
	 /codecustomization:"Utilities.CodeGeneration.OptionSetCustomisationService, Utilities.CodeGeneration" `
	 /codewriterfilter:"Utilities.CodeGeneration.OptionsetFilteringService, Utilities.CodeGeneration"


 LogMessage "Generating: Xrm.Typed.Entities.cs"
 . $crmSvcUtil /url:https://unittestexample.crm4.dynamics.com `
	 /u:$username `
	 /p:$password `
	 /out:Xrm.Typed.Entities.cs  `
	 /namespace:MoC.Workflow.Entities `
	 /codewriterfilter:"Utilities.CodeGeneration.CodeWriterFilter, Utilities.CodeGeneration"
	
 LogMessage "Generating: Xrm.Typed.Attributes.cs"
 . $crmSvcUtil /url:https://unittestexample.crm4.dynamics.com `
	 /u:$username `
	 /p:$password `
	 /out:Xrm.Typed.Attributes.cs  `
	 /namespace:MoC.Workflow.Entities `
	 /codecustomization:"Utilities.CodeGeneration.LogicalNameCustomizationService, Utilities.CodeGeneration" `
	 /codewriterfilter:"Utilities.CodeGeneration.CodeWriterFilter, Utilities.CodeGeneration"

LogMessage "Script took $($stopwatch.Elapsed.ToString()) to execute."
