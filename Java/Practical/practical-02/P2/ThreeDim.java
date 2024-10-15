package P2;

import P1.TwoDim;

public class ThreeDim extends TwoDim {
    private int z;

    // Default constructor
    public ThreeDim() {
        super();
        this.z = 0;
    }

    // Parameterized constructor
    public ThreeDim(int x, int y, int z) {
        super(x, y);
        this.z = z;
    }

    // Override toString() to display three-dimensional coordinates
    @Override
    public String toString() {
        return "ThreeDim Coordinates: (" + super.toString().substring(18) + ", " + z + ")";
    }
}
