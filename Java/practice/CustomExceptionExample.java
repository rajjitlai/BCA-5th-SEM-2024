class InvalidAgeException extends Exception {
    public InvalidAgeException(String str) {
        super(str);
    }
}

public class CustomExceptionExample {
    static void validate(int age) throws InvalidAgeException {
        if (age < 18) {
            throw new InvalidAgeException("Age is not valid to vote");
        } else {
            System.out.println("You are eligible to vote");
        }
    }

    public static void main(String[] args) {
        try {
            validate(18);
            validate(13);
        } catch (InvalidAgeException ex) {
            System.out.println("Caught the Exception");
            System.out.println("Exception occurred: " + ex);
        }
        System.out.println("Thank you!");
    }
}
