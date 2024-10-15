class Complex {
    double real;
    double imaginary;

    public Complex(double real, double imaginary) {
        this.real = real;
        this.imaginary = imaginary;
    }

    public Complex add(Complex other) {
        return new Complex(real + other.real, imaginary + other.imaginary);
    }

    public Complex multiply(Complex other) {
        double realPart = (real * other.real) - (imaginary * other.imaginary);
        double imaginaryPart = (real * other.imaginary) + (imaginary * other.real);
        return new Complex(realPart, imaginaryPart);
    }

    @Override
    public String toString() {
        if (imaginary < 0) {
            return real + " - " + Math.abs(imaginary) + "i";
        }
        return real + " + " + imaginary + "i";
    }

    public static String displaySum(Complex c1, Complex c2, Complex result) {
        return "The Sum of the numbers " + c1.toString() + " and " + c2.toString() + " is " + result.toString();
    }

    public static String displayProduct(Complex c1, Complex c2, Complex result) {
        return "The Product of the numbers " + c1.toString() + " and " + c2.toString() + " is " + result.toString();
    }

    public static void main(String[] args) {
        Complex c1 = new Complex(4, 2);
        Complex c2 = new Complex(2, 3);

        Complex sum = c1.add(c2);
        System.out.println(displaySum(c1, c2, sum));

        Complex product = c1.multiply(c2);
        System.out.println(displayProduct(c1, c2, product));
    }
}
