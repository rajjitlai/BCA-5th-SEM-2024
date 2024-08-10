// autoboxing

public class WrapperExample1 {
    public static void main(String[] args) {
        int a = 20;
        Integer i = Integer.valueOf(a); // old way (explicitly)
        Integer j = a; // autoboxing

        System.out.println(a + " " + i + " " +j);
    }
}

// Output - 20 20 20