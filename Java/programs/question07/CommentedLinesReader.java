import java.io.*;

public class CommentedLinesReader {
    public static void main(String[] args) {
        String filePath = "example.txt";

        try (BufferedReader br = new BufferedReader(new FileReader(filePath))) {
            String line;

            while ((line = br.readLine()) != null) {

                if (line.trim().startsWith("//")) {

                    System.out.println(line);
                }
            }
        } catch (FileNotFoundException e) {
            System.err.println("File not found: " + filePath);
        } catch (IOException e) {
            System.err.println("Error reading file: " + e.getMessage());
        }
    }
}
