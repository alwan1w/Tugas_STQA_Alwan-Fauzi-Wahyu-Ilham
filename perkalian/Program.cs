using System;

/// <summary>
/// main class program perkalikan
/// </summary>
/// <remarks>method main tersebut berisi program perkaliannya </remarks>
class Perkalian
{
    /// <summary>
    /// program ini mengoprasikan perkalian saja
    /// </summary>
    /// <param name="bilangan1"></param>
    /// <param name="bilangan2"></param>
    /// <remarks>di concole.writeline yang paling bawah tersebuh menghitung hasil dari perkalian angka yang dimasukkan</remarks>
    static void Main(string[] args)
    {
        Console.WriteLine("Masukkan bilangan pertama:");
        int bilangan1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Masukkan bilangan kedua:");
        int bilangan2 = Convert.ToInt32(Console.ReadLine());
        int hasil = bilangan1 * bilangan2;
        Console.WriteLine("Hasil perkalian " + bilangan1 + " dengan " + bilangan2 + " adalah " + hasil);
        Console.ReadLine();
    }
}
