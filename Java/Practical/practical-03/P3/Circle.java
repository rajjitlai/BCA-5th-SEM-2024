package P3;

import java.util.Scanner;

import P1.Shape;

public class Circle extends Shape {
    private double radius;

    @Override
    public void readData() {
        try (Scanner sc = new Scanner(System.in)) {
            System.out.print("Enter radius of the circle: ");
            radius = sc.nextDouble();
        }
    }

    @Override
    public double area() {
        return Math.PI * radius * radius;
    }
}