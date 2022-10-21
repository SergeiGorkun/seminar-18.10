// Написать программу масштабирования фигуры


void ScaleMatrix(int n = 1) {
    int [,] matrix = new int [n,n];
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
        Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Thread.Sleep(1000);
    ScaleMatrix(n * 2);
}

ScaleMatrix(2);