using Discord.Commands;

namespace RoleBot.App.Commands;

public class PingCommand : CommandBase
{
    [Command("ping")]
    public async Task HandleCommandAsync()
    {
        await ReplyAsync("I am pinging the server.");
    }
}