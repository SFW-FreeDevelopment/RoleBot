﻿using Discord.Commands;

namespace RoleBot.App.Commands;

public class HelpCommand : CommandBase
{
    [Command("help")]
    public async Task HandleCommandAsync()
    {
        await ReplyAsync($"**The following commands can be used:**{Environment.NewLine}" +
                         $"  • **ping** - Pings the Discord channel{Environment.NewLine}" +
                         $"  • **add \"name of role\"** - Adds user to role, and creates role if it doesn't exist{Environment.NewLine}" +
                         $"  • **remove \"name of role\"** - Removes the user from the role, if it exists{Environment.NewLine}" +
                         "  • **delete \"name of role\"** - Deletes the role from the server, if it exists (admin only)");
    }
}