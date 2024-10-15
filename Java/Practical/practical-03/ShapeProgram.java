import java.util.Scanner;

import P1.Shape;
import P2.Rectangle;
import P3.Circle;

public class ShapeProgram {
    public static void main(String[] args) {
        try (Scanner sc = new Scanner(System.in)) {
            Shape shape;

            System.out.println("Choose a shape to calculate area:");
            System.out.println("1. Rectangle");
            System.out.println("2. Circle");
            int choice = sc.nextInt();

            switch (choice) {
                case 1:
                    shape = new Rectangle();
                    break;
                case 2:
                    shape = new Circle();
                    break;
                default:
                    System.out.println("Invalid choice!");
                    return;
            }

            shape.readData();
            System.out.println("The area of the shape is: " + shape.area());
        }
    }
}
