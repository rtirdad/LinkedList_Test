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
        public void When_a_list_is_cleared_it_should_be_empty()
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

            list.InsertAt(0, 1);
            var IndexOfOne = list.IndexOf(1);
            var IndexOfTwo = list.IndexOf(2);

            // Assert
            IndexOfOne.Should().Be(0);
            IndexOfTwo.Should().Be(-1);
        }

        [Test]
        public void if_an_element_is_added_at_index_it_should_be_at_the_right_index()
        {
            // Arrange
            var list = new MyList<int>();
            list.InsertAt(2,4);
            list.InsertAt(0, 4);
             
            // Assert
            list.Count().Should().Be(2);
        }

        [Test]
        public void if_an_element_is_added_it_should_be_added_to_end_of_the_list()
        {
            // Arrange
            var list = new MyList<int>();

            //Act
            //list.AddAt(0, 4);
            list.Add(2);
            list.Add(3);
            var IndexOfTwo = list.IndexOf(3);  
            // Assert

            list.Count().Should().Be(2);
            IndexOfTwo.Should().Be(1);
        }

        [Test]
        public void if_list_contains_element_return_true_if_not_return_false()
        {
            // Arrange
            var list = new MyList<int>();

            list.InsertAt(0,1);
            var ContainOne = list.Contains(1);
            var ContainTwo = list.Contains(2);

            // Assert
            ContainOne.Should().BeTrue();
            ContainTwo.Should().BeFalse();
        }

        [Test]
        public void if_an_element_is_removed_it_should_be_removed_from_list()
        {
            // Arrange
            var list = new MyList<int>();
            list.InsertAt(1, 1);
            list.InsertAt(0, 2);
            list.InsertAt(2, 3);
            list.Remove(3);

            // Assert
            list.Count().Should().Be(2);
        }

        [Test]
        public void if_an_element_is_removedAt_Index_its_element_according_to_the_index_should_be_removed()
        {
            // Arrange
            var list = new MyList<int>();
            list.InsertAt(1, 1);
            list.InsertAt(0, 2);
            list.InsertAt(2, 3);
            list.RemoveAt(1);

            // Assert
            list.Count().Should().Be(2);
        }

        [Test]
        public void If_element_is_set_it_should_be_set_at_the_right_index()
        {
            // Arrange
            var list = new MyList<string>();
            list.InsertAt(1, "a");
            list.InsertAt(0, "b");
            list.InsertAt(2, "c");
            list[2] = "d";
            var IndexOfD = list.IndexOf("d");

            // Assert
            IndexOfD.Should().Be(2);
            list.Count().Should().Be(3);
        }

    }
}
