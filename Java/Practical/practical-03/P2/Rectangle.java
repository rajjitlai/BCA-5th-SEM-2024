package P2;

import java.util.Scanner;

import P1.Shape;

public class Rectangle extends Shape {
    private double length;
    private double breadth;

    @Override
    public void readData() {
        try (Scanner sc = new Scanner(System.in)) {
            System.out.print("Enter length of the rectangle: ");
            length = sc.nextDouble();
            System.out.print("Enter breadth of the rectangle: ");
            breadth = sc.nextDouble();
        }
    }

    @Override
    public double area() {
        return length * breadth;
    }
}