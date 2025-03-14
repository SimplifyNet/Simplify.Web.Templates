# Parameters

$appName = "MyProject.SchedulerApi"
$appPath = $PSScriptRoot
$exepath = $appPath + "\" + $appName + ".exe"
$description = "MyProject.SchedulerApi service"
$stopTimeout = 150000 # 5 minutes
$logonUser = "LocalService"

# Installation execution

nssm install $appName $exepath
nssm set $appName AppDirectory $appPath
nssm set $appName DisplayName $description
nssm set $appName Description $description
nssm set $appName ObjectName $logonUser
nssm set $appName AppStopMethodConsole $stopTimeout
nssm set $appName AppExit Default Exit
