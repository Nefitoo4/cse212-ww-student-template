public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.


        // Create an array of doubles with the specified length.
        double[] multiples = new double[length];

        // Using a loop to populate the array.
        // Each element at index i should be number * (i + 1)
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        // Return the filled array.
        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        
        //Get the count of the list.
        int n = data.Count;

        //Create a temporary list to store the last amount element.
        List<int> temp = data.GetRange(n - amount, amount);

        //Remove the last amount element from the original list.
        data.RemoveRange(n - amount, amount);

        //Insert the saved elements at the begining of the list.
        data.InsertRange(0, temp);

        //The list is now rotated to the right by the amount positions.
    }
}
