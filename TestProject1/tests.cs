using FluentAssertions;
using System.Linq;
using static TestingProject1.Tests;
using NUnit.Framework;
using System.Collections;
using Microsoft.VisualBasic;
using TestProject1;

namespace TestingProject1
{


    public class Tests
    {
        [Test]
        public void When_a_list_is_created_it_should_be_empty()
        {
            // Arrange
            var list = new MyList<int>();

            list.Add(1);
            list.Clear();

            // Assert
            list.Count().Should().Be(0);
        }
        [Test]
        public void if_an_element_is_found_return_index_If_not_return_negative_one()
        {
            // Arrange
            var list = new MyList<int>();

            list.Add(1);
            var IndexOfOne = list.IndexOf(1);
            var IndexOfTwo = list.IndexOf(2);

            // Assert
            IndexOfOne.Should().Be(0);
            IndexOfTwo.Should().Be(-1);
        }

    }



}
