// File: exceptionDemo.java
public class exceptionDemo {

    // Method that throws UnderAge exception if age is less than 18
    public void test(int age) throws UnderAge {
        if (age < 18) {
            throw new UnderAge(age);  // Throwing custom exception with age
        } else {
            System.out.println("Age is valid: " + age);
        }
    }

    public static void main(String[] args) {
        // Creating an instance of exceptionDemo
        exceptionDemo demo = new exceptionDemo();

        // Test with different age values
        try {
            demo.test(16);  // This should throw an UnderAge exception
        } catch (UnderAge e) {
            System.out.println(e);  // Catch and print custom exception
        }

        try {
            demo.test(20);  // This should not throw an exception
        } catch (UnderAge e) {
            System.out.println(e);
        }
    }
}