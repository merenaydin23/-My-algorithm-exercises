import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double base;
        int power;

        // First, we ask the user to input the base (x) and power (n).
        do {
            // Prompt the user to enter the base.
            // The base must be between -100.0 and 100.0.
            do {
                System.out.println("Please enter the base -100.00 < base < 100.00 ");
                base = sc.nextDouble();
            } while (base >= 100 || base <= -100);  // The loop ensures that base is within the valid range.

            // Now, we ask for the power (n).
            // The power must be between -231 and 230.
            do {
                System.out.println("Please enter the power -231 < power < 230 ");
                power = sc.nextInt();
            } while (power <= -231 || power >= 231);  // Ensures that the power is within the valid range.

            // If the base is 0, power must be greater than 0, otherwise, we show an error message.
            if (base == 0 && power <= 0) {
                System.out.println("Error: If base is 0, power must be greater than 0. Please re-enter values.");
            }
        } while (base == 0 && power <= 0); // The loop keeps asking the user until the correct values are entered.

        // Once we have valid inputs, we call the Pow function to calculate the result.
        double result = Pow(base, power);
        System.out.println("Result is: " + result);
    }

    // Pow function: This function calculates x raised to the power n (x^n).
    public static double Pow(double base, int power) {
        double result = 1;  // Initialize the result to 1, as this is the identity element for multiplication.

        // If power is positive, we multiply the base by itself power times.
        if (power > 0) {
            for (int i = 0; i < power; i++) {
                result *= base;  // Multiply the result by the base.
            }
        }
        // If power is zero, we return 1 (x^0 is always 1 for any non-zero x).
        else if (power == 0) {
            result = 1;  // By definition, any non-zero number raised to the power of 0 is 1.
        }
        // If power is negative, we compute the positive power first, and then invert the result.
        else {
            for (int i = 0; i < -power; i++) {
                result *= base;  // Multiply the result by the base.
            }
            result = 1 / result;  // Since the power is negative, we return the reciprocal of the result (1 / x^n).
        }

        return result;  // Return the final result.
    }
}
