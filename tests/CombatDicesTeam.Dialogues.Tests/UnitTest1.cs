namespace CombatDicesTeam.Dialogues.Tests;

public class HideConditionsTests
{
    [Test]
    public void Test1()
    {
        // ARRANGE

        var factory = Mock.Of<IDialogueContextFactory<object, object>>();
        var dialogue = new Dialogue<object, object>(new DialogueNode<object, object>(
            new DialogueParagraph<object, object>(ArraySegment<DialogueSpeech<object, object>>.Empty), new[]
            {
                new DialogueOption<object, object>("1", DialogueNode<object, object>.EndNode),
                new DialogueOption<object, object>("2", DialogueNode<object, object>.EndNode)
                {
                    HideConditions = new[]
                    {
                        Mock.Of<IDialogueParagraphCondition<object>>(x => x.Check(It.IsAny<object>()) == false)
                    }
                }
            }));

        // ACT

        var player = new DialoguePlayer<object, object>(dialogue, factory);

        // ASSERT

        player.CurrentOptions.Single().TextSid.Should().Be("1");
    }

    [Test]
    public void Test2()
    {
        // ARRANGE

        var factory = Mock.Of<IDialogueContextFactory<object, object>>();
        var dialogueOption = new DialogueOption<object, object>("1", new DialogueNode<object, object>(
            new DialogueParagraph<object, object>(ArraySegment<DialogueSpeech<object, object>>.Empty), new[]
            {
                new DialogueOption<object, object>("2", DialogueNode<object, object>.EndNode)
                {
                    HideConditions = new[]
                    {
                        Mock.Of<IDialogueParagraphCondition<object>>(x => x.Check(It.IsAny<object>()) == false)
                    }
                },
                new DialogueOption<object, object>("3", DialogueNode<object, object>.EndNode)
            }));
        var dialogue = new Dialogue<object, object>(new DialogueNode<object, object>(
            new DialogueParagraph<object, object>(ArraySegment<DialogueSpeech<object, object>>.Empty), new[]
            {
                dialogueOption
            }));

        var player = new DialoguePlayer<object, object>(dialogue, factory);

        // ACT

        player.SelectOption(dialogueOption);

        // ASSERT

        player.CurrentOptions.Single().TextSid.Should().Be("3");
    }
}