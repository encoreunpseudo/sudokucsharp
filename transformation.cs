using System;

static class Transformation
{
    static Random rnd = new Random();

    public static void remplir_grille(int[,] grille_vide)
    {
        int idx = 0;
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                grille_vide[i, j] = (j + idx) % 9 + 1;
            }
            idx++;
        }
    }

    public static int[,] SwapColonnes(int[,] grille)
    {
        int pile = rnd.Next(3);               // pile de colonnes : 0, 1 ou 2
        int k1 = rnd.Next(3);
        int k2 = (k1 + 1 + rnd.Next(2)) % 3;  // toujours différent de k1

        int col1 = 3 * pile + k1;
        int col2 = 3 * pile + k2;

        var res = (int[,])grille.Clone();
        for (int i = 0; i < 9; i++)
            (res[i, col1], res[i, col2]) = (res[i, col2], res[i, col1]);

        return res;
    }

    public static int[,] SwapLignes(int[,] grille)
    {
        int pile = rnd.Next(3);               // pile de lignes : 0, 1 ou 2
        int k1 = rnd.Next(3);
        int k2 = (k1 + 1 + rnd.Next(2)) % 3;  // toujours différent de k1

        int ligne1 = 3 * pile + k1;
        int ligne2 = 3 * pile + k2;

        var res = (int[,])grille.Clone();
        for (int j = 0; j < 9; j++)
            (res[ligne1, j], res[ligne2, j]) = (res[ligne2, j], res[ligne1, j]);

        return res;
    }

    public static int[,] transposer_grille(int[,] grille)
    // Transpose la grille
    {
        int[,] grille_transpose = new int[9, 9];
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                grille_transpose[i, j] = grille[j, i];
            }
        }

        return grille_transpose;
    }
}
