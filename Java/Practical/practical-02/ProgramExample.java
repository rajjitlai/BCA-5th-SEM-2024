class TwoDim {
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
        return "TwoDim Coordinates: (" + x + ", " + y + ")";
    }
}

class ThreeDim extends TwoDim {
    private int z;

    public ThreeDim() {
        super();
        this.z = 0;
    }

    public ThreeDim(int x, int y, int z) {
        super(x, y);
        this.z = z;
    }

    @Override
    public String toString() {
        return "ThreeDim Coordinates: (" + super.toString().substring(18) + ", " + z + ")";
    }
}

public class ProgramExample {
    public static void main(String[] args) {
        try (java.util.Scanner sc = new java.util.Scanner(System.in)) {
            TwoDim obj;

            System.out.println("Choose type of coordinates:");
            System.out.println("1. TwoDim (2D)");
            System.out.println("2. ThreeDim (3D)");
            int choice = sc.nextInt();

            switch (choice) {
                case 1:
                    obj = new TwoDim(3, 4); 
                    break;
                case 2:
                    obj = new ThreeDim(5, 6, 7);  
                    break;
                default:
                    System.out.println("Invalid choice!");
                    return;
            }

            System.out.println(obj.toString());
        }
    }
}
