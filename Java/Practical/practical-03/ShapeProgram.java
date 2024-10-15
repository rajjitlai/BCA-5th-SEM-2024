import java.util.Scanner;

abstract class Shape {

    public abstract void readData();

    public abstract double area();
}

class Rectangle extends Shape {
    private double length;
    private double breadth;

    @Override
    public void readData() {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter length of the rectangle: ");
        length = sc.nextDouble();
        System.out.print("Enter breadth of the rectangle: ");
        breadth = sc.nextDouble();
    }

    @Override
    public double area() {
        return length * breadth;
    }
}

class Circle extends Shape {
    private double radius;

    @Override
    public void readData() {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter radius of the circle: ");
        radius = sc.nextDouble();
    }

    @Override
    public double area() {
        return Math.PI * radius * radius;
    }
}

public class ShapeProgram {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Shape shape = null;

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
