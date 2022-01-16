using Discord;
using Discord.Commands;

namespace RoleBot.Commands;

public class RemoveRoleCommand : CommandBase
{
    [Command("removerole")]
    public async Task HandleCommandAsync([Remainder] string roleName)
    {
        var role = Context.Guild.Roles.FirstOrDefault(r => r.Name == roleName);
        if (role is null)
        {
            await ReplyAsync($"{Mention} The {roleName} role does not exist");
        }
        else
        {
            var hasRole = role.Members.Select(m => m.Id).FirstOrDefault() == GuildUser.Id;
            Console.WriteLine(hasRole);
            if (!hasRole)
            {
                await ReplyAsync($"{Mention} You do not have the role {roleName}.");
                return;
            }
            await GuildUser.RemoveRoleAsync(role);
            await ReplyAsync($"{Mention} The {roleName} role has been removed!");
        }
    }
}