using Discord.Commands;

namespace RoleBot.App.Commands;

public class DeleteRoleCommand : CommandBase
{
    [Command("deleterole")]
    public async Task HandleCommandAsync([Remainder] string roleName)
    {
        var role = Context.Guild.Roles.FirstOrDefault(r => r.Name == roleName);
        if (!GuildUser.GuildPermissions.Administrator)
        {
            await ReplyAsync($"{Mention} Insufficient permissions.");
        }
        else if (role is null)
        {
            await ReplyAsync($"{Mention} The {roleName} role does not exist");
        }
        else
        {
            await role.DeleteAsync();
            await ReplyAsync($"{Mention} The {roleName} role has been deleted!");
        }
    }
}