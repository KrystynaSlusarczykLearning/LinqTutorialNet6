using Exercises;
using NUnit.Framework;
using System.Linq;

namespace ExercisesTests
{
    [TestFixture]
    public class Count_RefactoringChallenge_Tests
    {
        [Test]
        public void SomeSequencesAreTooLong()
        {
            var numberSequences = new[]
            {
                new [] {1,2,3},
                new [] {1,2,3,4}
            };
            var numberSequencesAsString = string.Join(
                ", ", numberSequences.Select(seq => seq.Count()));
            var result = Count.IsAnySequenceTooLong(numberSequences, 3);
            Assert.True(result, $"The test failed because some of the sequences of " +
                $"lengths {numberSequencesAsString} is longer than max count 3");
        }

        [Test]
        public void SomeSequencesAreTooLong_Refactored()
        {
            var numberSequences = new[]
            {
                new [] {1,2,3},
                new [] {1,2,3,4}
            };
            var numberSequencesAsString = string.Join(
                ", ", numberSequences.Select(seq => seq.Count()));
            var result = Count.IsAnySequenceTooLong_Refactored(numberSequences, 3);
            Assert.True(result, $"The test failed because some of the sequences of" +
                $" lengths {numberSequencesAsString} is longer than max count 3");
        }

        [Test]
        public void NoneSequencesAreTooLong()
        {
            var numberSequences = new[]
            {
                new [] {1,2,3},
                new [] {1,2,3,4}
            };
            var numberSequencesAsString = string.Join(
                ", ", numberSequences.Select(seq => seq.Count()));
            var result = Count.IsAnySequenceTooLong(numberSequences, 4);
            Assert.False(result, $"The test failed because none of the sequences of " +
                $"lengths {numberSequencesAsString} is longer than max count 4");
        }

        [Test]
        public void NoneSequencesAreTooLong_Refactored()
        {
            var numberSequences = new[]
            {
                new [] {1,2,3},
                new [] {1,2,3,4}
            };
            var numberSequencesAsString = string.Join(
                ", ", numberSequences.Select(seq => seq.Count()));
            var result = Count.IsAnySequenceTooLong_Refactored(numberSequences, 4);
            Assert.False(result, $"The test failed because none of the sequences of " +
                $"lengths {numberSequencesAsString} is longer than max count 3");
        }
    }
}
