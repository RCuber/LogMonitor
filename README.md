# LogMonitor
A Simple Log Monitor to tigger notification on known keywords

Note: You may have to run the application with admin privileges to monitor the files in the AppData Folder.

Intro LogMonitor is Currently used to monitor few OBS Studio statuses by monitoring its logs. The application provides a notification popup whenever certain actions are performed like Start Recording or Start Streaming.

Usage First Run:

Configure the OBS log folder by Clicking on the Configure Button. 2.Select or Enter the OBS Log folder in the textbox provided and click on the save button. Usually located at C:\Users<UserName>\AppData\Roaming\obs-studio\logs , If you cannot see that folder in the folder selection dialog box then might have to turn on Enable Hidden Item in Windows Explorer > View settings.
Once the settings are saved the app will start monitoring the latest log file in the folder.
Click on the Start button to start monitoring the status of OBS.
Currently supported notifications. 
Recording Start 
Recording Stop 
Replay Buffer 
Start Replay 
Buffer Stop 
Streaming Start 
Streaming Stop 
Wrote replay buffer

[![Build status](https://ci.appveyor.com/api/projects/status/0x348rk753h0aumu?svg=true)](https://ci.appveyor.com/project/RCuber/logmonitor)
