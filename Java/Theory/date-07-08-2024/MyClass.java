public class MyClass {
    int a;
    int b;

    // constructor 1
    public MyClass() {
        System.out.println("Default constructor");
    }

    // constructor 2
    public MyClass(int a1) {
        a = a1;
        b = 10;
    }

    // constructor 3
    public MyClass(int a1, int b1) {
        a = a1;
        b = b1;
    }

    void putNumber() {
        System.out.println(a);
        System.out.println(b);
    }

    public static void main(String[] args) {
        MyClass mc1 = new MyClass();
        mc1.putNumber();

        MyClass mc2 = new MyClass(20);
        mc2.putNumber();

        MyClass mc3 = new MyClass(30, 40);
        mc3.putNumber();
    }
}
