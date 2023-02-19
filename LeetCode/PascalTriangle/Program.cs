// See https://aka.ms/new-console-template for more information
/// <summary>
/// initialise list of list of integers (say _triangle outside of the method)
/// for numRows of 1, add a new list of int with just value of 1 to _triangle
/// if numRows > 1, do a for loop with condition i = 1, i < numRows
/// initialise currentRowLength with previous row count + 1 (i.e GetPreviousRowLength(i-1) + 1)
/// In GetPreviousRowLength method, return triangle[row].Count
/// initialise first and last index such as currentRow[0] = 1 and currentRow[currentRowLength - 1] = 1
/// now for the middle element, do another for loop such as j = 1; j < currentRowLength - 1
/// do a formula inside the for loop
/// currentRow[j] = _triangle[i-1][j-1] + _triangle[i-1][j] (two dimensional)
/// after coming out of second for loop, add currentRow to _triangle (i.e _triangle.Add(currentRow.ToList()))
/// when done with all the elements, return _triangle
/// </summary>
//IList<IList<int>> triangle = new List<IList<int>>();
//Generate(5);
//IList<IList<int>> Generate(int numRows)
//{
//    triangle.Add(new List<int>() { 1 });

//    for(int i = 1; i < numRows; i++)
//    {
//        int currentRowLength = GetPreviousRowLength(i - 1) + 1;
//        int[] currentRow = new int[currentRowLength];
//        currentRow[0] = 1;
//        currentRow[currentRowLength - 1] = 1;

//        for(int j = 1; j < currentRowLength - 1; j++)
//        {
//            currentRow[j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
//        }

//        triangle.Add(currentRow.ToList());
//    }

//    return triangle;
//}

//int GetPreviousRowLength(int row)
//{
//    return triangle[row].Count;
//}

IList<IList<int>> triangle = new List<IList<int>>();
Generate(5);
IList<IList<int>> Generate(int numRows)
{
    triangle.Add(new List<int>() { 1 });
    for(int i = 1; i < numRows; i++)
    {
        int currentRowLength = GetPreviousRowLength(i - 1) + 1;
        int[] currentRow = new int[currentRowLength];
        currentRow[0] = 1;
        currentRow[currentRowLength - 1] = 1;

        for(int j = 1; j < currentRowLength - 1; j++)
        {
            currentRow[j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
        }

        triangle.Add(currentRow);
    }

    return triangle;
}

int GetPreviousRowLength(int row)
{
    return triangle[row].Count;
}