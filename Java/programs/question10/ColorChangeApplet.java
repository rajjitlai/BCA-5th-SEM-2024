import java.applet.Applet;
import java.awt.*;
import java.awt.event.*;

public class ColorChangeApplet extends Applet {
    private Button redButton;
    private Button blueButton;

    @Override
    public void init() {
        setSize(400, 200);
        redButton = new Button("Red");
        blueButton = new Button("Blue");

        add(redButton);
        add(blueButton);

        redButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                setBackground(Color.RED);
            }
        });

        blueButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                setBackground(Color.BLUE);
            }
        });
    }

    @Override
    public void paint(Graphics g) {
        g.setColor(Color.BLACK);
        g.drawString("Click on the buttons to change the background color", 100, 100);
    }
}
