namespace CombatDicesTeam.Dialogues;

public sealed class DialogueOption<TParagraphConditionContext, TAftermathContext>
{
    public DialogueOption(string textSid, DialogueNode<TParagraphConditionContext, TAftermathContext> nextNode)
    {
        TextSid = textSid;
        Next = nextNode;
        Aftermath = new NullDialogueOptionAftermath<TAftermathContext>();
    }

    public IDialogueOptionAftermath<TAftermathContext> Aftermath { get; init; }
    public DialogueNode<TParagraphConditionContext, TAftermathContext> Next { get; }
    public string TextSid { get; }
    public string? DescriptionSid { get; init; }
}