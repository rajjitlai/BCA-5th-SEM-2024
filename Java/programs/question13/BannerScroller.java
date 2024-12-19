import javax.swing.*;
import java.awt.*;

public class BannerScroller extends JFrame implements Runnable {
    private String message = "This is Scrolling text, let us see how it actually works.";
    private int xPos = 0;
    private final int width = 400;
    private final int height = 100;
    private BannerPanel bannerPanel;

    public BannerScroller() {
        setTitle("Scrolling Text");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setSize(width, height);
        setLocationRelativeTo(null);
        setLayout(new BorderLayout());

        bannerPanel = new BannerPanel();
        add(bannerPanel);

        Thread thread = new Thread(this);
        thread.start();
    }

    private class BannerPanel extends JPanel {
        private int xPosition = 0;

        public void setxPosition(int x) {
            this.xPosition = x;
            repaint();
        }

        @Override
        protected void paintComponent(Graphics g) {
            super.paintComponent(g);
            g.setFont(new Font("Arial", Font.BOLD, 24));
            g.setColor(Color.BLUE);
            g.drawString(message, xPosition, getHeight() / 2);
        }
    }

    @Override
    public void run() {
        while (true) {
            try {
                Thread.sleep(50);
                xPos += 5;
                if (xPos > getWidth()) {
                    xPos = -message.length() * 10;
                }

                bannerPanel.setxPosition(xPos);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            BannerScroller scroller = new BannerScroller();
            scroller.setVisible(true);
        });
    }
}