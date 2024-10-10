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

    public static void main(String[] args) {
        Complex c1 = new Complex(3, 2);
        Complex c2 = new Complex(1, 7);

        Complex sum = c1.add(c2);
        System.out.println("Sum: " + sum);

        Complex product = c1.multiply(c2);
        System.out.println("Product: " + product);
    }
}