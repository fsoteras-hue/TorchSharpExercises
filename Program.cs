// See https://aka.ms/new-console-template for more information
using TorchSharp;
using static TorchSharp.torch;

// Create a tensor with 3 elements
Console.WriteLine("=== Basic Tensors ===");
var t = tensor(new double[] { 1, 2, 3 });
Console.WriteLine("Tensor t:");
Console.WriteLine(t);

// Create a 2x3 matrix of zeros
var zeros = torch.zeros(new long[] { 2, 3 });
Console.WriteLine("\nZeros matrix:");
Console.WriteLine(zeros);

// Matrix operations
Console.WriteLine("\n=== Matrix Operations ===");
var matrix1 = tensor(new float[,] { { 1, 2 }, { 3, 4 } });
var matrix2 = tensor(new float[,] { { 5, 6 }, { 7, 8 } });
Console.WriteLine("Matrix 1:");
Console.WriteLine(matrix1);
Console.WriteLine("\nMatrix 2:");
Console.WriteLine(matrix2);

// Matrix addition
var sum = matrix1 + matrix2;
Console.WriteLine("\nMatrix addition (matrix1 + matrix2):");
Console.WriteLine(sum.ToString());

// Matrix multiplication
var product = matrix1.matmul(matrix2);
Console.WriteLine("\nMatrix multiplication (matrix1 @ matrix2):");
Console.WriteLine(product);

// Element-wise multiplication
var elementwise = matrix1 * matrix2;
Console.WriteLine("\nElement-wise multiplication:");
Console.WriteLine(elementwise);