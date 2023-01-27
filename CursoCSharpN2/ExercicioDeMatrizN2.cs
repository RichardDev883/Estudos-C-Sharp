// Esta "Class" é apenas um registro do Exercicio de Matriz Realizado na Sessão 6 do Curso do Nélio.


/*

Console.Write("Digite a quantidade de Linhas da Matriz: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Digite a quantidade de Colunas da Matriz: ");
int n = int.Parse(Console.ReadLine());

int[,] mat = new int[m, n];

for (int i = 0; i < m; i++)
{

    Console.Write("Digite os valores da Linha #" + i + " : ");
    string[] values = Console.ReadLine().Split(' ');

    for (int j = 0; j < n; j++)
    {
        mat[i, j] = int.Parse(values[j]);
    }
}

Console.Write("Digite um numero da Matriz: ");
int x = int.Parse(Console.ReadLine());
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (mat[i, j] == x)
        {
            Console.WriteLine("Position " + i + "," + j + ":");
            if (j > 0)
            {
                Console.WriteLine("Left: " + mat[i, j - 1]);
            }
            if (i > 0)
            {
                Console.WriteLine("Up: " + mat[i - 1, j]);
            }
            if (j < n - 1)
            {
                Console.WriteLine("Right: " + mat[i, j + 1]);
            }
            if (i < m - 1)
            {
                Console.WriteLine("Down: " + mat[i + 1, j]);
            }

*/
