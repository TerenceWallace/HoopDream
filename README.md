# HoopDream
A brief article on how to utilize NBA Stats API in a WinForm application

# Introduction
Got involved with this project because I play ESPN/Yahoo Fantasy Sports. This tiny little application allows me to use math to calculate better Fantasy Pre-Draft order, roster lineup, and player scouting.

# Technology Used
Microsoft SQL Server CE
Newtonsoft.Json
 
# Background
The first thing you should know about this project is that there are multiple documents available for the Python client of NBA statistics located at stats.nba.com. If you want to know more about work you check those out. Second, this work is solely dedicated to retrieve, store, view NBA data. There is no attempt here to provide for updating or editing this data to build your team.

If you're anything like me you have several teams active per year in any number of available leagues. With so many teams active, pretty much every Fantasy team will have completely full starting lineups for each day of the season. The problem is deciding which player to start and which player to bench for the best particular matchups.

Choosing which player to start and which player to bench is never going to be an exact science. However, using skills of building great technology we can utilize tools to better help us to decide.

Particular for this project I am using a formula to try and come up with the best players. The formula used here attempts to Calculate Standard Deviation for each player. This helps me to determine which player will probably give me the best matchup results.
