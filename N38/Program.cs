int size = 5;
double [] array = new double [size];
for (int i =0; i<array.Length; ++i )
{
    array[i]= new Random().NextDouble();
}
Console.WriteLine(string.Join( ",", array)); 

double max = array[0];
if (array[1]> max) max = array[1];
if (array[2]> max) max = array[2];
if (array[3]> max) max = array[3];
if (array[4]> max) max = array[4];
double min = array[0];
if (array[1]< min) min = array[1];
if (array[2]< min) min = array[2];
if (array[3]< min) min = array[3];
if (array[4]< min) min = array[4];
double raz = 0;
raz = max - min;
Console.WriteLine("max = " + max + " min = " + min + " max - min = " + raz);