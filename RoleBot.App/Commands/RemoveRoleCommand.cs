using Discord.Commands;

namespace RoleBot.App.Commands;

public class RemoveRoleCommand : CommandBase
{
    [Command("remove")]
    public async Task HandleCommandAsync([Remainder] string roleName)
    {
        var role = Context.Guild.Roles.FirstOrDefault(r => r.Name == roleName);
        if (role is null)
        {
            await ReplyAsync($"{Mention} The {roleName} role does not exist");
        }
        else
        {
            var hasRole = role.Members.FirstOrDefault(m => m.Id == GuildUser.Id) is not null;
            Console.WriteLine(hasRole);
            if (!hasRole)
            {
                await ReplyAsync($"{Mention} You do not have the role {roleName}.");
            }
            else
            {
                await GuildUser.RemoveRoleAsync(role);
                await ReplyAsync($"{Mention} The {roleName} role has been removed!");
            }
        }
    }
}