package P1;

public class TwoDim {
    private int x;
    private int y;

    public TwoDim() {
        this.x = 0;
        this.y = 0;
    }

    public TwoDim(int x, int y) {
        this.x = x;
        this.y = y;
    }

    @Override
    public String toString() {
        return "The Coordinates in TwoDim are: (" + x + ", " + y + ")";
    }
}