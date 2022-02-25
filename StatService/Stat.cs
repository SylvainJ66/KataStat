namespace StatService;

/*
 * Your task is to process a sequence of integer numbers to determine the following statistics:

minimum value
maximum value
number of elements in the sequence
average value
For example: [6, 9, 15, -2, 92, 11]

minimum value = -2
maximum value = 92
number of elements in the sequence = 6
average value = 21.833333
 * 
 */

public class Stat
{
    public string Process(List<int> liste)
    {
        return "Minimum value = " + liste.Min().ToString() + "\n"
            + "Maximum value = " + liste.Max().ToString() + "\n"
            + "Number of elements in the sequence = " + liste.Count + "\n"
            + "Average value = " + Math.Round(liste.Average(), 6) + " ";
    }
}
