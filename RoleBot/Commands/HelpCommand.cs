using Discord.Commands;

namespace RoleBot.Commands;

public class HelpCommand : CommandBase
{
    [Command("help")]
    public async Task HandleCommandAsync()
    {
        await ReplyAsync($"**The following commands can be used:**{Environment.NewLine}" +
                         $"  • **ping** - Pings the Discord channel{Environment.NewLine}" +
                         $"  • **addrole \"name of role\" \"name of user\" (repeat for multiple users)** - Adds new role with option to add users immediately");
    }
}