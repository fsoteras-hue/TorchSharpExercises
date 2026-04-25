// See https://aka.ms/new-console-template for more information
using TorchSharp;
using static TorchSharp.torch;

// Create a tensor with 3 elements

var t = tensor(new double[] { 1, 2, 3 });
// Create a 2x3 matrix of zeros
var zeros = torch.zeros(new long[] { 2, 3 });
Console.WriteLine("Tensor t:");
Console.WriteLine(t);
Console.WriteLine("Zeros matrix:");
Console.WriteLine(zeros);