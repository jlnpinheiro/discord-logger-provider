namespace JNogueira.Discord.Logger;

public class UserClaimValueToDiscordField(string claimType, string discordFieldName)
{
    public string ClaimType { get; } = claimType?.Trim();

    public string DiscordFieldName { get; } = discordFieldName?.Trim();
}
