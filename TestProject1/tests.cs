using FluentAssertions;
using System.Linq;
using static TestingProject1.Tests;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
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
            list.InsertAt(2, 4);
            list.InsertAt(0, 4);
            list.Clear();

            // Assert
            list.Count().Should().Be(0);
        }

        [Test]
        public void if_an_element_is_added_it_should_be_added_to_end_of_the_list()
        {
            // Arrange
            var list = new MyList<int>();

            //Act

            list.Add(1);
            var IndexOfTwo = list.IndexOf(1);
            // Assert

            list.Count().Should().Be(1);
            IndexOfTwo.Should().Be(0);
        }

        [Test]
        public void if_list_contains_element_return_true_if_not_return_false()
        {
            // Arrange
            var list = new MyList<int>();

            list.InsertAt(0, 1);
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
        public void If_element_is_set_it_should_be_set_at_the_rightIndex()
        {
            // Arrange
            var list = new MyList<int>();

            // Act
            list.InsertAt(0, 1);
            list.InsertAt(1, 2);
            list.InsertAt(2, 3);
            list.InsertAt(10, 10);
            var IndexOfOne = list.IndexOf(1);
            var IndexOfTen = list.IndexOf(10);

            // Assert
            IndexOfTen.Should().Be(3);
            IndexOfOne.Should().Be(0);
            list.Count().Should().Be(4);
        }

        [Test]
        public void List_can_also_be_string()
        {
            // Arrange
            var list = new MyList<string>();
            list.InsertAt(1, "a");
            list.InsertAt(0, "b");
            list.InsertAt(2, "c");
            list[2] = "d";
            var IndexOfD = list.IndexOf("d");


            IndexOfD.Should().Be(2);
            list.Count().Should().Be(3);
        }


        [Test]
        public void Enumerator_Should_returnFalse_if_ListIs_Empty()
        {
            // Arrange
            var list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Clear();

            // Act
            var enumerator = list.GetEnumerator();

            // Assert

            enumerator.MoveNext().Should().BeFalse();
        }

        [Test]
        public void Enumerator_Should_returnTrue_if_ListIs_NotEmpty()
        {
            // Arrange
            var list = new MyList<int>();
            list.Add(3);
            list.Add(2);

            // Act
            var enumerator = list.GetEnumerator();

            // Assert
            enumerator.MoveNext().Should().BeTrue();
            enumerator.Current.Should().Be(3);

            enumerator.MoveNext().Should().BeTrue();
            enumerator.Current.Should().Be(2);


        }

        [Test]
        public void Where_ShouldFilterElementsBasedOnPredicate()
        {
            // Arrange
            var list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            // Act
            var result = list.Where(x => x % 2 == 0);

            // Assert
            result.Should().ContainInOrder(2, 4);
        }

        [Test]
        public void When_a_list_is_cleared_it_should_be_emp()
        {
            // Arrange
            var list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);


            //act
            IEnumerable<int> Numbers = Enumerable.Where(list, n => n > 2);

            var enumerator = Numbers.GetEnumerator();

            //assert
            IEnumerable<int> QuerySyntax = from obj in list
                                           where obj > 2
                                           select obj;
            var query = QuerySyntax.GetEnumerator();
            // Assert
            query.MoveNext().Should().BeTrue();
            query.Current.Should().Be(3);
        }

        [Test]
        public void Select_ShouldTransformElementsCorrectly()
        {
            // Arrange
            var list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            // Act
            var result = list.Select(x => x * 2);

            // Assert
            result.Should().BeEquivalentTo(2, 4, 6);
        }

        [Test]
        public void Any_ShouldReturnTrueIfAnyElementSatisfiesPredicate()
        {
            // Arrange
            var linkedList = new LinkedList<int>();
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);

            // Act & Assert
            linkedList.Any(x => x > 2).Should().BeTrue();
            linkedList.Any(x => x > 5).Should().BeFalse();
        }

        [Test]
        public void Where_ShouldFilterElementsBasedOnPredic()
        {
            // Arrange
            var linkedList = new LinkedList<int>();
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);

            // Act & Assert
            linkedList.FirstOrDefault(x => x > 2).Should().Be(3);
            linkedList.FirstOrDefault(x => x > 5).Should().Be(0); // Default value for int
        }

        [Test]
        public void Where_ShouldFilterElementsBasedOnPredicate()
        {
            // Arrange
            var linkedList = new LinkedList<int>();
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);

            // Act
            var result = linkedList.Where(x => x > 1);

            // Assert
            result.Should().BeEquivalentTo(2, 3);
        }



    }



}
