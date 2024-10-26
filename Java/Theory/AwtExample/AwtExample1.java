package AwtExample;

import java.awt.*;

public class AwtExample1 extends Frame {
    public AwtExample1() {
        Button b = new Button("Click Me!!");
        b.setBounds(30, 100, 80, 30);
        add(b);
        setTitle("AWT Example");
        setLayout(null);

        setSize(300, 200);
        setVisible(true);
    }

    public static void main(String[] args) {
        new AwtExample1();
    }
}
