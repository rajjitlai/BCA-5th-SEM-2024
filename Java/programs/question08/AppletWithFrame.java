package Java.programs.question08;

import java.applet.Applet;
import java.awt.*;
import java.awt.event.*;

public class AppletWithFrame extends Applet implements MouseListener {
    private Frame childFrame;

    @Override
    public void init() {
        setSize(400, 200);
        setBackground(Color.LIGHT_GRAY);

        addMouseListener(this);

        childFrame = new Frame("Child Frame");
        childFrame.setSize(200, 100);
        childFrame.setLayout(null);
        childFrame.setVisible(true);
        childFrame.setBackground(Color.CYAN);

        childFrame.addWindowListener(new WindowAdapter() {
            @Override
            public void windowClosing(WindowEvent e) {
                childFrame.setVisible(false);
            }
        });
    }

    @Override
    public void paint(Graphics g) {
        g.setColor(Color.BLACK);
        g.drawString("Click anywhere to open child frame", 50, 100);
    }

    @Override
    public void mouseClicked(MouseEvent e) {
        showStatus("Mouse Clicked at: (" + e.getX() + ", " + e.getY() + ")");
    }

    public void mouseEntered(MouseEvent e) {
        childFrame.setVisible(true);
    }

    @Override
    public void mouseExited(MouseEvent e) {
        childFrame.setVisible(false);
    }

    @Override
    public void mousePressed(MouseEvent e) {
    }

    @Override
    public void mouseReleased(MouseEvent e) {
    }
}