// accepting input from the command line

public class MyClass {
    public static void main(String args[]) {
        if (args.length > 0) {
            int num = Integer.parseInt(args[0]);

            if (num % 2 == 0) {
                System.out.println("The number is even");
            } else {
                System.out.println("The number is odd");
            }
        }
    }
}

// In order to execute the command, use - java MyClass.java value