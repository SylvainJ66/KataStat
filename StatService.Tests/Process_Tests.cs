using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace StatService.Tests;

public class Process_Tests
{
    private Stat _stat;

    public Process_Tests()
    {
        _stat = new Stat();
    }

    [Fact]
    public void DoNoting()
    {
        Assert.False(false);
    }

    [Fact]
    public void Process_ShouldReturnMinValueFromList01()
    {
        List<int> list = new List<int> { 1, 2, -1 };
        Assert.Contains("Minimum value = -1", _stat.Process(list));
    }

    [Fact]
    public void Process_ShouldReturnMinValueFromList02()
    {
        List<int> list = new List<int> { 10, 20, -5 };
        Assert.Contains("Minimum value = -5", _stat.Process(list));
    }

    [Fact]
    public void Process_ShouldReturnMaxValueFromList01()
    {
        List<int> list = new List<int> { 1, 2, -1 };
        Assert.Contains("Maximum value = 2", _stat.Process(list));
    }

    [Fact]
    public void Process_ShouldReturnMaxValueFromList02()
    {
        List<int> list = new List<int> { 100, 2, -100 };
        Assert.Contains("Maximum value = 100", _stat.Process(list));
    }

    [Fact]
    public void Process_ShouldReturnNumberOfElementsFromList01()
    {
        List<int> list = new List<int> { 100, 2, -100 };
        Assert.Contains("Number of elements in the sequence = 3", _stat.Process(list));
    }

    [Fact]
    public void Process_ShouldReturnNumberOfElementsFromList02()
    {
        List<int> list = new List<int> { 100, 2, -100, 45, 8 };
        Assert.Contains("Number of elements in the sequence = 5", _stat.Process(list));
    }

    [Fact]
    public void Process_ShouldReturnAverageFromList01()
    {
        List<int> list = new List<int> { 6, 9, 15, -2, 92, 11 };
        Assert.Contains("Average value = 21,833333 ", _stat.Process(list));
    }

    [Fact]
    public void Process_ShouldReturnAverageFromList02()
    {
        List<int> list = new List<int> { 6, 9, 15, -2, 92, 3, 7 ,-45 };
        Assert.Contains("Average value = 10,625 ", _stat.Process(list));
    }
}