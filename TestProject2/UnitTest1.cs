using Command_Pattern;
using Moq;

namespace TestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AttackCommand_Execute_ShouldCallCharacterAttackMethod()
        {
            // Arrange
            var characterMock = new Mock<Character>();
            characterMock.Setup(c => c.Attack()).CallBase();
            var attackCommand = new AttackCommand(characterMock.Object);

            // Act
            attackCommand.Execute();

            // Assert
            characterMock.Verify(c => c.Attack(), Times.Once);
            Assert.That(characterMock.Object.CurrentAction, Is.EqualTo("Attacked"));
        }

        [Test]
        public void MoveForwards_Execute_ShouldCallCharacterMoveForwards()
        {
            // Arrange
            var characterMock = new Mock<Character>();
            characterMock.Setup(c => c.Move()).CallBase();
            var moveCommand = new MoveForwards(characterMock.Object);

            // Act
            moveCommand.Execute();

            // Assert
            characterMock.Verify(c => c.Move(), Times.Once);
            Assert.That(characterMock.Object.CurrentAction, Is.EqualTo("Moved Forward"));
        }

        [Test]
        public void StoppedMoving_Execute_ShouldCallCharacterStoppedMoving()
        {
            // Arrange
            var characterMock = new Mock<Character>();
            characterMock.Setup(c => c.Stop()).CallBase();
            var stopCommand = new StoppedMoving(characterMock.Object);

            // Act
            stopCommand.Execute();

            // Assert
            characterMock.Verify(c => c.Stop(), Times.Once);
            Assert.That(characterMock.Object.CurrentAction, Is.EqualTo("Stopped Moving"));
        }

        [Test]
        public void Character_Undo_ShouldRestorePreviousAction()
        {
            // Arrange
            var character = new Character();
            character.Move(); // Set the current action to "Moved Forward"

            // Act
            character.Undo();

            // Assert
            Assert.That(character.CurrentAction, Is.EqualTo(character.LastAction));
        }
        [Test]
        public void RemoteControl_DoAction_ShouldExecuteCommand()
        {
            // Arrange
            var commandMock = new Mock<ICommand>();
            var remoteControl = new RemoteControl();

            // Act
            remoteControl.SetCommand(commandMock.Object);
            remoteControl.DoAction();

            // Assert
            commandMock.Verify(c => c.Execute(), Times.Once);
        }

        [Test]
        public void RemoteControl_UndoAction_ShouldUndoCommand()
        {
            // Arrange
            var commandMock = new Mock<ICommand>();
            var remoteControl = new RemoteControl();

            // Act
            remoteControl.SetCommand(commandMock.Object);
            remoteControl.UndoAction();

            // Assert
            commandMock.Verify(c => c.Undo(), Times.Once);
        }

    }
}