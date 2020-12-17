# System Refresher
English | [简体中文](README.zh-Hans.md)

A quick smart cross-platform tool that helps you quickly recovery from a system reinstall.

## When Will the First Release Be Avilable

I'd like to know it, too.

## Key Features

- Scan and save software list before you reinstall your system. 

  On windows, the software will scan your  installed package manager (such as Chocolatey and Scoop), and export their installation list. Software that you manually installed will also be recorded and you can either chose to use a similar package in package manager or just download it or even write your own script to install them. We also intend to provide a script market where you can share your installation list.

  On Linux and macOS, the progress is similar, but the detection of manually installed software may be limited.

- Backup your installed software configuration if you like。

  For each software on each platform, we will have a list that contains its configuration path. Of course, we can't know all the configuration path. You can write your own rules and share it by making pull requests (it is intend to be in the other repo). 

- Light-weighted

  We intend to use as less third-party libraries as possible, and compiles with [NativeAOT](https://github.com/dotnet/runtimelab/tree/feature/NativeAOT). This will greatly reduces the executable size. You need download nothing before the program begin to work on your new installed system.

## System and Package Manager Support

We intend to support following Operating Systems when the first stable version released.

- [ ] Windows 10 : Chocolatey, Scoop
- [ ] macOS : Homebrew
- [ ] Arch Linux : pacman, AUR
- [ ] Fedora : dnf
- [ ] Ubuntu : apt-get
- [ ] All of above: vcpkg
- [ ] All Linux above: Snap

The supported system will have first class support. However, distribution with the same package manager **may** also work, but we won't accept issues on non-supported systems before we officially support them. (Pull request that support new system are welcomed and issues that **suggest** new systems are allowed.)

## User Guide

TBD