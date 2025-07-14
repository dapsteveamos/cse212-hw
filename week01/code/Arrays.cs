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



        // Step 1: Create a new array of size 'length' to hold the multiples
        // Step 2: Use a for loop from 0 to length - 1
        // Step 3: For each index i, set array[i] = number * (i + 1)
        //         This ensures the multiples start from number (not 0)
        // Step 4: After filling the array, return it

        double[] result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        return result;
    
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
        // Step 1: Determine how many elements need to be moved from the end to the front.
        //         This is 'amount' elements from the end of the list.
        // Step 2: Use GetRange to extract those last 'amount' elements into a temporary list.
        // Step 3: Use RemoveRange to remove those last 'amount' elements from the end of the original list.
        // Step 4: Use InsertRange to insert the saved elements at the beginning of the list.

        List<int> tail = data.GetRange(data.Count - amount, amount);
        data.RemoveRange(data.Count - amount, amount);
        data.InsertRange(0, tail);
    }

}
