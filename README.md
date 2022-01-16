# ColorBot
A Discord bot to update user colors using dynamically created roles.

Built with .NET Core 3.1 and Docker.

---

Want to invite ColorBot to your own Discord?

[https://discord.com/api/oauth2/authorize?client_id=932322983916224534&permissions=268437504&scope=bot](https://discord.com/api/oauth2/authorize?client_id=932322983916224534&permissions=268437504&scope=bot)

---

Want to pull the latest Docker image to host your own instance of ColorBot?

[https://hub.docker.com/repository/docker/chrisplummer/rolebot](https://hub.docker.com/repository/docker/chrisplummer/rolebot)

## Commands
| Command | Description |
| ------------- | ------------- |
| `rolebot help` | Assists the user by displaying all commands |
| `rolebot ping` | Pings the Discord channel |
| `rolebot addrole "name of role"` | Adds user to role, and creates role if it doesn't exist |
| `rolebot removerole "name of role"` | Removes the user from the role, if it exists |
| `rolebot deleterole "name of role"` |  Deletes the role from the server, if it exists (admin only) |

---

## Screenshots

![image](/Documentation/Images/user.png)

![image](/Documentation/Images/addrole.png)

![image](/Documentation/Images/removerole.png)

![image](/Documentation/Images/deleterole.png)
