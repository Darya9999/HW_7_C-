int m = 3;
int n = 4;
double[,] arr = new double[m,n];
Random rand = new Random(DateTime.Now.Millisecond);
for (int i = 0; i < m; i++)
{
for (int j = 0; j < n; j++)
{
arr[i, j] = Math.Round(rand.NextDouble() * 20 , 2 );
}
}
string otv = "";

for (int i = 0; i < m; i++) {
otv = "";
for (int j = 0; j < n; j++){
otv += arr[i, j];
if (j<n-1) {
otv += " ";
}
}
Console.WriteLine(otv);
}

string istr = Console.ReadLine();
int it = Convert.ToInt32(istr);
string jstr = Console.ReadLine();
int jt = Convert.ToInt32(jstr);

if (it<m && jt<n){
Console.WriteLine(arr[it, jt]);
} else {
Console.WriteLine("такого числа в массиве нет");
}
