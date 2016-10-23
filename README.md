# Epic-Intentions-Forms
Automating Excel with C# and MySQL

## Setting Up ##
1. First download and install visual studio community edition: [found here](https://www.visualstudio.com/downloads/)
2. Next clone the project from github from within visual studio. You have two options for this, but we can just do the one that doesn't require any extra downloads first.
 1. You should see the team explorer on the right of your screen in visual studio. If you don't, you can go to the team tab and click "manage connections"
 2. Now that you are at the team explorer, you can click clone in the git option and enter the url of this repository.
 3. You may have to enter your login details, but you should now have the project!
3. Now you should download the mysql installer. Don't install everything right away!: [found here](https://dev.mysql.com/downloads/installer/)
 1. If you alreday have it, I recommend uninstalling and then doing this step
4. When you run the installer, install everything except for Connector/Net
5. Now go download Connector/Net 6.8.8: [found here](https://dev.mysql.com/downloads/connector/net/6.8.html)
6. Run it and now open up mysql installer again once it is done.
7. It will be trying to upgrade your Connector to 6.9.9. Dont do that! Choose 6.9.8.
8. Once that is done, reopen visual studio
9. Look for Add Reference... in the project tab and open it
10. In the COM > type libraries tab of the new window, look for the Microsoft Excel object library and make sure you have selected it, then click ok. (If you have, it will have a check next to it)
11. Now you should open up mysql workbench, which was installed by the mysql installer
12. Make a new connection and change the connection name to Epic Intentions if you want
13. Once you have set up, make sure not to forget your password!
14. Click on you new instance if it isn't already open
15. Click on File > new query tab
16. Copy paste the db from the google doc, but remove the past project bit at the end
17. Click the little lightning bolt above the script and the db should be good to go!
18. You can now connect the db from visual studio, but it might be hard to explain and cover the weirdness that can occur at this step, so we can do that when we meet. Ask me if you have any questions!
