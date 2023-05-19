using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter '+' or '-' : ");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if (operation == '+' || operation == '-')
            {
                int row = int.Parse(Console.ReadLine());
                int col = int.Parse(Console.ReadLine());

                double[, ] matrix1 = new double[row, col];
            
            Console.WriteLine("Enter the matrix elements : ");
            
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                while (!double.TryParse(Console.ReadLine(), out matrix1[i, j]))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
                    
        }

        double[, ] matrix2 = new double[row, col];

        Console.WriteLine("Enter the matrix elements : ");
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                while (!double.TryParse(Console.ReadLine(), out matrix2[i, j]))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
  
        }

        for (int i = 0; i < row; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < col; j++)
            {
                if (operation == '+'){
                    Console.Write(matrix1[i, j] + matrix2[i, j] + " ");
                } else {
                    Console.Write(matrix1[i, j] - matrix2[i, j] + " ");
                }
            }
        }
        Console.WriteLine();

    } 
        
}

}
    

