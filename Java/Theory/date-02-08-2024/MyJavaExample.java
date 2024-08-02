class MyClass {
    int a;
    int b;

    void getNumber(int a1, int b1) {
        a = a1;
        b = b1;
    }

    void putNumber() {
        System.out.println(a);
        System.out.println(b);
    }
}

public class MyJavaExample {
    public static void main(String[] args) {
        MyClass mc = new MyClass();
        mc.getNumber(2, 3);
        mc.putNumber();
    }
}
