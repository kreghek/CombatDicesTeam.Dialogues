namespace CombatDicesTeam.Dialogues;

public sealed class DialogueOption<TParagraphConditionContext, TAftermathContext>
{
    public DialogueOption(string textSid, DialogueNode<TParagraphConditionContext, TAftermathContext> nextNode)
    {
        TextSid = textSid;
        Next = nextNode;
        HideConditions = ArraySegment<IDialogueParagraphCondition<TParagraphConditionContext>>.Empty;
        SelectConditions = ArraySegment<IDialogueParagraphCondition<TParagraphConditionContext>>.Empty;
        
        Aftermath = new NullDialogueOptionAftermath<TAftermathContext>();
    }

    public IDialogueOptionAftermath<TAftermathContext> Aftermath { get; init; }
    public DialogueNode<TParagraphConditionContext, TAftermathContext> Next { get; }
    public string TextSid { get; }
    
    public IReadOnlyCollection<IDialogueParagraphCondition<TParagraphConditionContext>> HideConditions { get; init; }
    public IReadOnlyCollection<IDialogueParagraphCondition<TParagraphConditionContext>> SelectConditions { get; init; }
    public string? DescriptionSid { get; init; }
}