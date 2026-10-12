using System;

class Program
{
    static int[,] grille = new int[9, 9];

    static void afficher_grille(int[,] grille)
    {
        for (int i = 0; i < grille.GetLength(0); i++)
        {
            for (int j = 0; j < grille.GetLength(1); j++)
            {
                Console.Write(grille[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Transformation.remplir_grille(grille);
        Console.WriteLine("Grille initiale :");
        afficher_grille(grille);

        Console.WriteLine("\nApres swap_colonnes :");
        afficher_grille(Transformation.SwapColonnes(grille));

        Console.WriteLine("\nApres swap_lignes :");
        afficher_grille(Transformation.SwapLignes(grille));

        Console.WriteLine("\nApres transposer_grille :");
        afficher_grille(Transformation.transposer_grille(grille));
    }
}
