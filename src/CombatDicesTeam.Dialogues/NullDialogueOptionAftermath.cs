namespace CombatDicesTeam.Dialogues;

public sealed class NullDialogueOptionAftermath<TAftermathContext> : IDialogueOptionAftermath<TAftermathContext>
{
    public bool IsHidden => true;

    public void Apply(TAftermathContext aftermathContext)
    {
        // Do nothing
    }

    public string GetDescription(TAftermathContext aftermathContext)
    {
        return string.Empty;
    }
}
