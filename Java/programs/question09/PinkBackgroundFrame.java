import java.awt.*;
import java.awt.event.*;

public class PinkBackgroundFrame extends Frame {
    public PinkBackgroundFrame() {
        super("Pink Background Frame");
        setBackground(Color.PINK);
        setSize(300, 300);

        addWindowListener(new WindowAdapter() {
            @Override
            public void windowClosing(WindowEvent e) {
                System.exit(0);
            }
        });
    }

    @Override
    public void paint(Graphics g) {
        g.setColor(Color.BLACK);
        g.drawString("Pink Background Frame", 100, 100);
    }

    public static void main(String[] args) {
        PinkBackgroundFrame frame = new PinkBackgroundFrame();

        frame.setVisible(true);
    }
}
