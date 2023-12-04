using NUnit.Framework;
using Moq;
using Command_Pattern;

namespace Command_Pattern.Tests
{
    [TestFixture]
    public class CommandTests
    {
        [Test]
        public void AttackCommand_Execute_ShouldCallCharacterAttackMethod()
        {
            // Arrange
            var characterMock = new Mock<Character>();
            var attackCommand = new AttackCommand(characterMock.Object);

            // Act
            attackCommand.Execute();

            // Assert
            characterMock.Verify(c => c.Attack(), Times.Once);
            Assert.AreEqual("Attacked", characterMock.Object.ActionLog);
        }

        [Test]
        public void AttackCommand_Undo_ShouldCallCharacterUndoMethod()
        {
            // Arrange
            var characterMock = new Mock<Character>();
            var attackCommand = new AttackCommand(characterMock.Object);

            // Act
            attackCommand.Undo();

            // Assert
            characterMock.Verify(c => c.Undo(), Times.Once);
            Assert.AreEqual("Undone Last Action", characterMock.Object.ActionLog);
        }

        [Test]
        public void MoveForwards_Execute_ShouldCallCharacterMoveMethod()
        {
            // Arrange
            var characterMock = new Mock<Character>();
            var moveForwardsCommand = new MoveForwards(characterMock.Object);

            // Act
            moveForwardsCommand.Execute();

            // Assert
            characterMock.Verify(c => c.Move(), Times.Once);
            Assert.AreEqual("Moved Forward", characterMock.Object.ActionLog);
        }

        [Test]
        public void MoveForwards_Undo_ShouldCallCharacterUndoMethod()
        {
            // Arrange
            var characterMock = new Mock<Character>();
            var moveForwardsCommand = new MoveForwards(characterMock.Object);

            // Act
            moveForwardsCommand.Undo();

            // Assert
            characterMock.Verify(c => c.Undo(), Times.Once);
            Assert.AreEqual("Undone Last Action", characterMock.Object.ActionLog);
        }

        [Test]
        public void StoppedMoving_Execute_ShouldCallCharacterStopMethod()
        {
            // Arrange
            var characterMock = new Mock<Character>();
            var stoppedMovingCommand = new StoppedMoving(characterMock.Object);

            // Act
            stoppedMovingCommand.Execute();

            // Assert
            characterMock.Verify(c => c.Stop(), Times.Once);
            Assert.AreEqual("Stopped Moving", characterMock.Object.ActionLog);
        }

        [Test]
        public void StoppedMoving_Undo_ShouldCallCharacterUndoMethod()
        {
            // Arrange
            var characterMock = new Mock<Character>();
            var stoppedMovingCommand = new StoppedMoving(characterMock.Object);

            // Act
            stoppedMovingCommand.Undo();

            // Assert
            characterMock.Verify(c => c.Undo(), Times.Once);
            Assert.AreEqual("Undone Last Action", characterMock.Object.ActionLog);
        }
    }
}
