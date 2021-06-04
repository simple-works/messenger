# ![Icon](./icon.png?raw=true) Messenger

[![Deprecated](https://img.shields.io/badge/Deprecated-red)](https://github.com/topics/windows)
[![Plarform Windows](https://img.shields.io/badge/Windows-blue?logo=windows)](https://github.com/topics/windows)
[![C# 4.0](https://img.shields.io/badge/C%23-4.0-blue?logo=c-sharp)](https://github.com/topics/csharp)
[![.NET Framework 4.0](https://img.shields.io/badge/.NET%20Framework-4.0-blue?logo=dot-net)](https://github.com/topics/dotnet)

This is just a *very basic* wrapper for [Facebook Messenger Web application](https://www.messenger.com) so it acts like a Windows desktop version.

**:floppy_disk: [Download Binary Release](./Messenger/bin/Release/Messenger.exe?raw=true "Download")**

![screenshot](./screenshot.png?raw=true)

## :information_source: What's the point ?
I used to run this in the past on an very old computer where I needed to use messenger without opening any modern browser or other heavy application, so I made this. It's easy and very basic but it did the job for me well at the time.

This probably won't work today as it's using the [**WebBrowser**](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/webbrowser-control-overview) control, which is a managed wrapper for the deprecated [**ActiveX**](https://en.wikipedia.org/wiki/ActiveX) WebBrowser control that duplicates [**Internet Explorer**](https://en.wikipedia.org/wiki/Internet_Explorer) Web browsing functionality or just provides a simple HTML document viewer, which is too old to be able to properly render modern Web pages.<br/>
Therefore, the embeded [**Messenger Website**](https://www.messenger.com) will be incompatible and won't work as expected.<br/>
I should probably replace it with a custom [**Chromium**](https://www.chromium.org) based wrapper control.

## :rocket: Development
The source is written in **[C#](https://github.com/dotnet/csharplang) 4.0** with **[.NET](https://github.com/dotnet) Framework 4.0** and **[WinForms](https://github.com/dotnet/winforms)** using **[Visual Studio](https://visualstudio.microsoft.com) 2010**.

## :page_facing_up: License
- Licensed under [MIT License](./LICENSE?raw=true).
- Using [Icons8](https://icons8.com) licensed under [Icons8 License](https://icons8.com/license).

> Disclaimer: This project is not endorsed by Facebook and doesn't reflect the views or opinions of Facebook or anyone officially involved in producing or managing Messenger. Messenger and Facebook are trademarks or registered trademarks of Facebook, Inc. Messenger © Facebook, Inc.