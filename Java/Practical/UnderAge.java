// File: UnderAge.java
class UnderAge extends Exception {
    private int age;

    // Constructor to initialize age
    public UnderAge(int age) {
        this.age = age;
    }

    // Override toString() to display custom message with age value
    @Override
    public String toString() {
        return "Under Age: " + age;
    }
}