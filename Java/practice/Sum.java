import java.util.Scanner;

public class Sum {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter the numbers: ");
        int sum = 0;
        while (sc.hasNextInt()) {
            int i = sc.nextInt();
            sum += i;
        }
        System.out.println("Sum of the numbers: " + sum);
    }
}
