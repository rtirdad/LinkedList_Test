using FluentAssertions;
//using System.Linq;
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
        public void Select_Should_return_selected_elements()
        {
            // Arrange
            var list = new MyList<int>();
            list.InsertAt(0, 1);
            list.InsertAt(1, 2);
            list.InsertAt(2, 3);
            list.InsertAt(3, 4);

            // Act
            var result = list.Select(x => x * 2);

            // Assert
            result.Should().ContainInOrder(2, 4, 6);
        }

        [Test]
        public void Any_ShouldReturn_true_if_element_is_inList()
        {
            // Arrange
            var list = new MyList<int>();
            list.InsertAt(0, 1);
            list.InsertAt(1, 2);
            list.InsertAt(2, 3);

            // Act & Assert
            list.Any(x => x > 2).Should().BeTrue();
            list.Any(x => x > 5).Should().BeFalse();
        }
        /**/

        [Test]
        public void FirstOrDefault_should_return_First_or_default()
        {
            // Arrange
            var list = new MyList<int>();
            list.InsertAt(0,1);
            list.InsertAt(1,2);
            list.InsertAt(2, 3);

            // Act & Assert
            list.FirstOrDefault(x => x > 2).Should().Be(3);
            list.FirstOrDefault(x => x > 5).Should().Be(0); 
        }

        [Test]
        public void Where_Should_Return_FilteredElements()
        {
            // Arrange
            var list = new MyList<int>();
            list.InsertAt(0, 1);
            list.InsertAt(1, 2);
            list.InsertAt(2, 3);

            // Act
            var result = list.Where(x => x > 1);

            // Assert
            result.Should().ContainInOrder(2, 3);
        }

        [Test]
        public void return_evenNumber_using_where()
        {
            // Arrange
            var list = new MyList<int>();
            list.InsertAt(0, 1);
            list.InsertAt(1, 2);
            list.InsertAt(2, 3);
            list.InsertAt(3, 4);


            // Act
            IEnumerable<int> EvenNumbers = Enumerable.Where(list,n => n % 2 ==0);
            var enumerator = EvenNumbers.GetEnumerator();

            // Assert
            enumerator.MoveNext().Should().BeTrue();
            enumerator.Current.Should().Be(2);
        }


        [Test]
        public void where_should_return_all_strings_That_starts_with_T()
        {
            //Arrange
            var list = new MyList<string>();
            list.InsertAt(0, "Time");
            list.InsertAt(1, "Will");
            list.InsertAt(2, "Tell");

            //Act
            var TWords = list.Where(i => i.StartsWith("T")) ;
            var enumerator = TWords.GetEnumerator();

            //Assert
            enumerator.MoveNext().Should().BeTrue();
            enumerator.Current.Should().Be("Time");

            enumerator.MoveNext().Should().BeTrue();
            enumerator.Current.Should().Be("Tell");


            enumerator.MoveNext().Should().BeFalse();
        }


        [Test]
        public void Skip_should_skip_elements()
        {
            //Arrange
            var list = new MyList<string>();
            list.InsertAt(0, "Time");
            list.InsertAt(1, "Will");
            list.InsertAt(2, "Tell");

            //Act
            var TWords = list.Skip(1);
            var enumerator = TWords.GetEnumerator();

            //Assert
            enumerator.MoveNext().Should().BeTrue();
            enumerator.Current.Should().Be("Will");

            enumerator.MoveNext().Should().BeTrue();
            enumerator.Current.Should().Be("Tell");


            enumerator.MoveNext().Should().BeFalse();
        }


        [Test]
        public void List_OrderByDecending()
        {
            //Arrange
            var list = new MyList<string>();
            list.InsertAt(0, "Pears");
            list.InsertAt(1, "Oranges");
            list.InsertAt(2, "Apple");
            list.InsertAt(2, "Watermelon");

            //Act
            var TWords = list.OrderBy(x => x).ToList();
            var enumerator = TWords.GetEnumerator();

            //Assert
            enumerator.MoveNext().Should().BeTrue();
            enumerator.Current.Should().Be("Apple");

            enumerator.MoveNext().Should().BeTrue();
            enumerator.Current.Should().Be("Oranges");

            enumerator.MoveNext().Should().BeTrue();
            enumerator.Current.Should().Be("Pears");

            enumerator.MoveNext().Should().BeTrue();
            enumerator.Current.Should().Be("Watermelon");

            enumerator.MoveNext().Should().BeFalse();
        }

    }



}
