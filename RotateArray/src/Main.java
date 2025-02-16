import java.util.Random;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        int length;
        Scanner input = new Scanner(System.in);
        Random chance = new Random();

        // Getting the matrix size from the user
        do {
            System.out.println("Please enter the length of the square matrix (1 <= matrix length <= 20)");
            length = input.nextInt();
        } while (length > 20 || length < 1);

        // Creating the square matrix
        int[][] matrix = squareMatrixCreater(length, chance);

        // Printing the original matrix
        printMatrix(matrix);
        System.out.println("---------------------");

        // Rotating the matrix by 90 degrees
        int[][] rotatedMatrix = rotateMatrix(matrix);

        // Printing the rotated matrix
        printMatrix(rotatedMatrix);
    }

    // 🔹 Method to create a square matrix with random values
    public static int[][] squareMatrixCreater(int length, Random chance) {
        int[][] matrix = new int[length][length];

        System.out.println("Square matrix is being created...");

        for (int i = 0; i < matrix.length; i++) {
            for (int j = 0; j < matrix.length; j++) {
                matrix[i][j] = chance.nextInt(2001) - 1000; // Random values between -1000 and 1000
            }
        }
        return matrix;
    }

    // 🔹 Method to rotate the matrix 90 degrees clockwise
    public static int[][] rotateMatrix(int[][] matrix) {
        int length = matrix.length;
        int[][] rotatedMatrix = new int[length][length];

        for (int i = 0; i < length; i++) {
            for (int j = 0; j < length; j++) {
                rotatedMatrix[j][length - 1 - i] = matrix[i][j];
            }
        }
        return rotatedMatrix;
    }

    // 🔹 Method to print the matrix
    public static void printMatrix(int[][] matrix) {
        for (int i = 0; i < matrix.length; i++) {
            for (int j = 0; j < matrix.length; j++) {
                System.out.print(matrix[i][j] + " ");
            }
            System.out.println();
        }
    }
}
