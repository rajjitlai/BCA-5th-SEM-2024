class MyTest {
    int a;
    int b;

    // constructor
    public MyTest(int a1, int b1) {
        a = a1;
        b = b1;
    }

    void putNumber() {
        System.out.println(a);
        System.out.println(b);
    }

    public static void main(String[] args) {
        MyTest mc = new MyTest(2, 3);
        mc.putNumber();
    }
}
