using Discord;
using Discord.Commands;

namespace RoleBot.App.Commands;

public class AddRoleCommand : CommandBase
{
    [Command("add")]
    public async Task HandleCommandAsync([Remainder] string roleName)
    {
        var role = Context.Guild.Roles.FirstOrDefault(r => string.Equals(r.Name, roleName, StringComparison.OrdinalIgnoreCase));
        if (role is null)
        {
            var newRole = await Context.Guild.CreateRoleAsync(roleName, GuildPermissions.None, null, false, true);
            await GuildUser.AddRoleAsync(newRole);
            await ReplyAsync($"{Mention} The {roleName} role has been added!");
        }
        else if (role.Permissions.Administrator || role.Permissions.ModerateMembers)
        {
            await ReplyAsync($"{Mention} The {roleName} role is for a privileged few.");
        }
        else
        {
            if (role.Members.Select(m => m.Id).Contains(Context.Message.Author.Id))
            {
                await ReplyAsync($"{Mention} You already have the role {roleName}.");
                return;
            }
            await GuildUser.AddRoleAsync(role);
            await ReplyAsync($"{Mention} The {roleName} role has been added!");
        }
    }
}