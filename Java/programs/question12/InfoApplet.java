import java.applet.Applet;
import java.awt.*;
import java.awt.event.*;

@SuppressWarnings("removal")
public class InfoApplet extends Applet implements ActionListener{
    Button buttonA, buttonB;
    String message = "";

    @Override
    public void init() {
        setLayout(new FlowLayout());
        setBackground(Color.LIGHT_GRAY);

        buttonA = new Button("A");
        buttonB = new Button("B");

        add(buttonA);
        add(buttonB);

        buttonA.addActionListener(this);
        buttonB.addActionListener(this);
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        if(e.getSource() == buttonA){
            message = "You clicked button A";
        } else if(e.getSource() == buttonB){
            message = "You clicked button B";
        }
        repaint();
    }

    @Override
    public void paint(Graphics g) {
        g.setFont(new Font("Arial", Font.BOLD, 14));
        g.setColor(Color.BLACK);
        g.drawString(message, 20, 100);
    }
}