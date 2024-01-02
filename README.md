# GreenLuma 2023 Manager
An app to manage the Steam unlocker "GreenLuma 2023" AppList folder 



This is a fork of BlueAmulet GreenLuma Reborn Manager to better support GL2023 
Thanks also to ImaniiTy, the original dev of the GreenLuma Reborn Manager


JostenSyon feauture:
Folder Browser Dialog for error proof path (steam and GreenLuma)
...
more feauture soon


BlueAmulet feauture:
Handles portable GL2023 (not in Steam folder)  
Better searching  
Improved error handling  
Other bugfixes and improvements




## BlueAmulet release: **[BlueAmulet GreenLuma 2023 Manager](https://github.com/BlueAmulet/GreenLuma-2023-Manager/releases/latest)**
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

## Features
  * Easily manage profiles for various games (good to circumvent the 168 id limit)
    * Add/Remove 1 or more games at once
    * Add/Remove profiles
  * Search for any game you want to add direct from the app
    * Search results are directly from Steam
    * Sort the results by Type (DLC, Game, etc..) or Name
  * Generate the AppList, close Steam and run GreenLuma 2023 in one click
    * You can choose any GL2023 parameters before launch
    * It will detect whether Steam is open or not and close it if necessary
  * All the profiles info are in JSON files so you can easily share with anyone
    * The profiles are saved on: C:\Users\YOUR_USER\AppData\Local\GLR_Manager\Profiles

![alt text](https://i.imgur.com/B8nDYm3.png)

## Future Plans (JostenSyon)
* Work on the UI
* Manual add for game and dlc by id (already work but i'm looking for a good placement of the gui element)

## Future Plans (BlueAmulet)
* Work on the UI
* Add a way to load previous games on your AppList folder
* Load all DLC for a game instead of the first 64
* Better error handling
* Warnings if GL2023 or the manager are in the Steam folder
* Handling elevated permissions as necessary

## Built With
* [PyQt5](https://www.riverbankcomputing.com/software/pyqt/intro) - The GUI framework
* [PyInstaller](https://pyinstaller.readthedocs.io/en/stable/index.html) - Used to make the standalone executable

## Authors
[**ImaniiTy**](https://github.com/ImaniiTy):

![alt text](https://i.imgur.com/zmS7oBs.gif)

[**BlueAmulet**](https://github.com/BlueAmulet):

[**JostenSyon**](https://github.com/JostenSyon): this fork