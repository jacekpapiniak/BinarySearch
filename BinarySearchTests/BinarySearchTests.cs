using System.Collections.Generic;
using BinarySearchAlgorithm;
using NUnit.Framework;
using FluentAssertions;

namespace BinarySearchTests;

[TestFixture]
public class BinarySearchTests
{
    private const int NotFoundIndex = -1;
    private static readonly List<string> TestSureNames = BinarySearch.SortedSureNames;

    [TestCase("Balaam", 0)]
    [TestCase("Roose", 33)]
    [TestCase("Homes", 16)]
    [TestCase("Wright", 49)]
    public void Search_ReturnIndex_WhenFoundItem(string search, int expectedIndex)
        => BinarySearch.Search(TestSureNames, 0, TestSureNames.Count - 1, search).Should().Be(expectedIndex);
    
    [TestCase("Ros")]
    [TestCase("Papiniak")]
    public void Search_Return_Negative_One_WhenItem_NotFound(string search)
        => BinarySearch.Search(TestSureNames, 0, TestSureNames.Count - 1, search).Should().Be(NotFoundIndex);
}