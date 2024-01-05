# Gui4GL-2023 <--> GreenLuma 2023 Manager
An application to manage the AppList folder of the Steam unlocker "GreenLuma 2023".

This is a fork of BlueAmulet's GreenLuma Reborn Manager. 
Thanks also to ImaniiTy, the original developer of the GreenLuma Reborn Manager.


## Features by JostenSyon
- Folder Browser Dialog for error-proof path selection (Steam and GreenLuma)
- New Windows 11 style theme
- Manual insert of Game/DLC by ID

## Features
- Easily manage profiles for various games (useful to circumvent the 168 ID limit)
- Add/Remove one or more games at once
- Add/Remove profiles
- Search for any game you want to add directly from the app
- Generate the AppList, close Steam, and run GreenLuma 2023 with one click
- All profile info is in JSON files, so you can easily share with anyone
- It will detect whether Steam is open or not and close it if necessary
- All the profiles info are in JSON files so you can easily share with anyone
  - The profiles are saved on: C:\Users\\%userprofile%\AppData\Local\GLR_Manager\Profiles
- Handles portable GL2023 (not in the Steam folder) (BlueAmulet)
- Improved searching (BlueAmulet)
- Enhanced error handling (BlueAmulet)
- Other bug fixes and improvements (BlueAmulet)



Below text is mostly sourced from ImaniiTy's README
## What is [GreenLuma 2023](https://cs.rin.ru/forum/viewtopic.php?f=29&t=103709)?
GreenLuma 2023 (GL2023) is a Steam unlocker made by Steam006 that is used to obtain games from family shared libraries and DLC for games. There's much more to it, though.

The full list of features provided by Steam006.

![alt text](https://i.imgur.com/D18pz0f.png)

## Can I get banned for using GreenLuma 2023?
There will always be a risk when using GL2023. If you're willing to take that risk, go right on ahead. If not, then don't bother. Especially when that risk means the status of your Steam account.

As expected, there are some games that blacklist GL2023 and using it will result in receiving a game ban.  
Some games will check for GreenLuma's files or the manager's files in the Steam folder.  
Some games have server side game and DLC ownership checks.

Please keep in mind. Like CreamAPI, GreenLuma 2023 **does not** work for every game.  
Also, keep in mind that not **every game** is available to play through Steam family sharing.

#### Credits to [@linkthehylian](https://github.com/linkthehylian) for this brief explanation

I **highly advise** you to use the "Legit stealth mode" checking the box "Stealth mode" on my program:
![alt text](https://i.imgur.com/xpAXU1b.png)



## Future Plans (JostenSyon)
- Menu setting for Light/Dark mode
- Support External theme

## Built With
* [PyQt5](https://www.riverbankcomputing.com/software/pyqt/intro) - The GUI framework
* [PyInstaller](https://pyinstaller.readthedocs.io/en/stable/index.html) - Used to make the standalone executable


## Authors
[**ImaniiTy**](https://github.com/ImaniiTy):

![alt text](https://i.imgur.com/zmS7oBs.gif)

[**BlueAmulet**](https://github.com/BlueAmulet): **[BlueAmulet GreenLuma 2023 Manager](https://github.com/BlueAmulet/GreenLuma-2023-Manager/releases/latest)**

[**JostenSyon**](https://github.com/JostenSyon): this fork
