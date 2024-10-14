class UnderAge extends Exception {
    private int age;

    public UnderAge(int age) {
        this.age = age;
    }
    
    @Override
    public String toString() {
        return "Under Age: " + age;
    }
}

public class exceptionDemo {
    public void test(int age) throws UnderAge {
        if (age < 18) {
            throw new UnderAge(age);
        } else {
            System.out.println("Age is valid: " + age);
        }
    }

    public static void main(String[] args) {
        exceptionDemo demo = new exceptionDemo();
        try {
            demo.test(16);
        } catch (UnderAge e) {
            System.out.println(e);
        }

        try {
            demo.test(20);
        } catch (UnderAge e) {
            System.out.println(e);
        }
    }
}