// java program to find the sum of given integers

import java.util.Scanner;

public class MyClass {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter the integers (enter a non-integer to start calculation): ");
        int sum = 0;

        while (sc.hasNextInt()) {
            int i = sc.nextInt();
            sum += i;
        }

        System.out.println("The sum of given integers is: " + sum);
        sc.close();
    }
}