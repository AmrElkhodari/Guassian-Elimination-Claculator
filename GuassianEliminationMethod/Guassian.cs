using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuassianEliminationMethod
{
    internal static class Guassian
    {
        static public double[][] matrix;
        static public double[] finalSolution;
        public static int numofEquation;
        public static int numofVariables;
        static public void preSetMatrix(int numofEquation, int numofVariables)
        {
            finalSolution = new double[numofVariables - 1];
            matrix = new double[numofEquation][];
            for (int i = 0; i < numofVariables - 1; i++)
            {
                finalSolution[i] = 0;
            }
            for (int i = 0; i < numofEquation; i++)
            {
                matrix[i] = new double[numofVariables];
                for (int j = 0; j < numofVariables; j++)
                {
                    matrix[i][j] = 0;
                }
            }
            Guassian.numofVariables = numofVariables;
            Guassian.numofEquation = numofEquation;
        }

        public static SolutionState solveMatrix()
        {
            sortMatrix();
            int lastNonZero = numofEquation - 1;
            while (isZeroRow(lastNonZero)) // determining last - non zero row
            {
                lastNonZero--;
            }
            if (isImpossipleRow(lastNonZero)) // checking if there is an impossiple row
                return SolutionState.noSolutions;
            int i, b;
            for (i = 0, b = 0; i <= lastNonZero && b < numofVariables - 1; i++, b++)
            {
                if (matrix[i][b] == 0) // if the leading == 0 >> search for row non zero and swap
                {
                    for (int j = i + 1; j <= lastNonZero; j++)
                    {
                        if (matrix[j][b] != 0)
                        {
                            swapRows(i, j);
                            break;
                        }
                    }
                    if (matrix[i][b] == 0) // if there is no row with non zero leading value >> increase b whit same row
                    {
                        i--;
                        continue;
                    }
                }
                fixLeading(i, matrix[i][b]);
                for (int j = i + 1; j <= lastNonZero; j++)
                {
                    fixAfterLeading(i, j, b);
                    if (isImpossipleRow(j))
                        return SolutionState.noSolutions;
                }
                while (isZeroRow(lastNonZero)) // redetermining last - non zero row
                {
                    lastNonZero--;
                }
                for (int j = i + 1; j <= lastNonZero; j++)
                {
                    if (isZeroRow(j))
                    {
                        swapRows(j, lastNonZero);
                        lastNonZero--;
                    }
                }
            }
            if (i < numofVariables - 1)
                return SolutionState.infiniteSolutions;
            i--;
            for (; i >= 0; i--)
            {
                b = determineLeading(i);
                for (int j = b + 1; j < numofVariables - 1; j++)
                {
                    finalSolution[b] -= matrix[i][j] * finalSolution[j];
                }
                finalSolution[b] += matrix[i][numofVariables - 1];
                finalSolution[b] /= matrix[i][b];
            }
            return SolutionState.oneSolution;
        }

        private static bool isZeroRow(int row)
        {
            for (int i = 0; i < numofVariables; i++)
            {
                if (matrix[row][i] != 0)
                    return false;
            }
            return true;

        }

        private static bool isImpossipleRow(int row)
        {
            if (matrix[row][numofVariables - 1] == 0)
                return false;
            for (int i = 0; i < numofVariables - 1; i++)
            {
                if (matrix[row][i] != 0)
                    return false;
            }
            return true;
        }

        private static void swapRows(int row1, int row2)
        {
            double temp;
            for (int i = 0; i < numofVariables; i++)
            {
                temp = matrix[row1][i];
                matrix[row1][i] = matrix[row2][i];
                matrix[row2][i] = temp;
            }
        }

        public static int leftZeros(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0) return i;
            }
            return arr.Length;
        }

        public static void sortMatrix()
        {
            matrix = matrix.OrderBy(arr => leftZeros(arr)).ToArray();
        }

        private static void fixLeading(int row, double devidor)
        {
            for (int i = 0; i < numofVariables; i++)
            {
                matrix[row][i] /= devidor;
            }
        }

        private static void fixAfterLeading(int leadingRow, int currentRow, int leadingItem) // fix every row under leading
        {
            double constant = -matrix[currentRow][leadingItem] / matrix[leadingRow][leadingItem];
            for (int i = 0; i < numofVariables; i++)
            {
                matrix[currentRow][i] += matrix[leadingRow][i] * constant;
            }
        }

        private static int determineLeading(int i)
        {
            int j = 0;
            while (matrix[i][j] == 0)
            {
                j++;
            }
            return j;
        }
    }
    internal enum SolutionState
    {
        oneSolution,
        infiniteSolutions,
        noSolutions
    }
}
