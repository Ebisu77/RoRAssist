using Moq;
using NUnit.Framework;
using RoRAssist.Core.BL;

namespace RoRAssist.Testing.UT.CoreBL
{
	[TestFixture]
	public class PersuasionBL_UnitTests
	{
		public class CaltulateBaseNumber
		{
			[Test]
			public void CalculateBaseNumber_SentarorInFaction_CorrectResult()
			{
				// Arrange
				var mock = CreatePersuasionMock(8, 6, 12, 4, 7, 3, true, false);

				// Act
				var result = PersuasionBL.CalculateBaseNumber(mock.Object);

				// Assert
				Assert.IsTrue(result == 5);
			}

			[Test]
			public void CalculateBaseNumber_SentarorNotInFaction_CorrectResult()
			{
				// Arrange
				var mock = CreatePersuasionMock(8, 6, 12, 4, 7, 3, false, false);

				// Act
				var result = PersuasionBL.CalculateBaseNumber(mock.Object);

				// Assert
				Assert.IsTrue(result == 12);
			}
		}

		[TestFixture]
		public class CaltulateDiceRoll
		{
			[Test]
			public void CalculateDiceRoll_EraEndRegularResult_CorrectResult()
			{
				// Arrange
				var mock = new Mock<Core.Model.Persuasion>();
				mock.Object.EraEnd = true;
				mock.Object.ResultBaseNumber = 7;

				// Act
				var result = PersuasionBL.CalculateDiceRoll(mock.Object);

				// Assert
				Assert.IsTrue(result == 7);
			}

			[Test]
			public void CalculateDiceRoll_EraEndHighResult_CorrectResult()
			{
				// Arrange
				var mock = new Mock<Core.Model.Persuasion>();
				mock.Object.EraEnd = true;
				mock.Object.ResultBaseNumber = 15;

				// Act
				var result = PersuasionBL.CalculateDiceRoll(mock.Object);

				// Assert
				Assert.IsTrue(result == 9);
			}

			[Test]
			public void CalculateDiceRoll_NoEraEndRegularResult_CorrectResult()
			{
				// Arrange
				var mock = new Mock<Core.Model.Persuasion>();
				mock.Object.EraEnd = false;
				mock.Object.ResultBaseNumber = 6;

				// Act
				var result = PersuasionBL.CalculateDiceRoll(mock.Object);

				// Assert
				Assert.IsTrue(result == 6);
			}

			[Test]
			public void CalculateDiceRoll_NoEraEndHighResult_CorrectResult()
			{
				// Arrange
				var mock = new Mock<Core.Model.Persuasion>();
				mock.Object.EraEnd = false;
				mock.Object.ResultBaseNumber = 15;

				// Act
				var result = PersuasionBL.CalculateDiceRoll(mock.Object);

				// Assert
				Assert.IsTrue(result == 8);
			}
		}

		private static Mock<Core.Model.Persuasion> CreatePersuasionMock(int oratory, int influence, int bribe, int loyalty, int personalTreasury, int coutnerBribe, bool senatorInFaction, bool eraEnd)
		{
			var mock = new Mock<Core.Model.Persuasion>();
			mock.SetupAllProperties();
			mock.Object.Oratory = oratory;
			mock.Object.Influence = influence;
			mock.Object.Bribe = bribe;
			mock.Object.Loyalty = loyalty;
			mock.Object.PersonalTreasury = personalTreasury;
			mock.Object.CounterBribe = coutnerBribe;
			mock.Object.SenatorInFaction = senatorInFaction;
			mock.Object.EraEnd = eraEnd;
			return mock;
		}
	}
}
