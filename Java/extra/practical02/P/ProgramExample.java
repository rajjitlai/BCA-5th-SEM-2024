package P;

import P1.TwoDim;
import P2.ThreeDim;
import java.util.Scanner;

public class ProgramExample {
    public static void main(String[] args) {
        try (Scanner sc = new Scanner(System.in)) {
            TwoDim obj;

            System.out.println("Choose the type of coordinates you want to view: ");
            System.out.println("1. TwoDim (2D)");
            System.out.println("2. ThreeDim (3D)");
            int choice = sc.nextInt();

            switch (choice) {
                case 1:
                    obj = new TwoDim(2, 6);
                    break;
                case 2:
                    obj = new ThreeDim(3, 8, 10);
                    break;
                default:
                    System.out.println("Invalid choice!");
                    return;
            }

            System.out.println(obj);
        }
    }
}
