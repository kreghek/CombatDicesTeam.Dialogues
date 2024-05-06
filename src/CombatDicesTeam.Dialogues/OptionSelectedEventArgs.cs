namespace CombatDicesTeam.Dialogues;

public sealed class OptionSelectedEventArgs<TParagraphConditionContext, TAftermathContext> : EventArgs
{
    public OptionSelectedEventArgs(DialogueOption<TParagraphConditionContext, TAftermathContext> option)
    {
        Option = option;
    }

    public DialogueOption<TParagraphConditionContext, TAftermathContext> Option { get; }
}