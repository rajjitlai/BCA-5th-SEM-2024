import java.applet.Applet;
import java.awt.*;
import java.awt.event.*;

public class KeyTypedApplet extends Applet {
    @Override
    public void init() {
        setSize(400, 200);
        setBackground(Color.LIGHT_GRAY);
        addKeyListener(new KeyAdapter() {
            @Override
            public void keyTyped(KeyEvent e) {
                char typedChar = e.getKeyChar();
                System.out.println("Key Typed: " + typedChar);
            }
        });

        setFocusable(true);
    }

    @Override
    public void paint(Graphics g) {
        g.setColor(Color.BLACK);
        g.drawString("Press any key to see the key typed event.", 50, 100);
    }
}