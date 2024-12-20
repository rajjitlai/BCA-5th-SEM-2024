import java.io.*;

public class FileCopy {
    public static void main(String[] args) {
        if (args.length != 2) {
            System.out.println("Usage: java FileCopy <source file> <destination file>");
            return;
        }

        String sourceFile = args[0];
        String destinationFile = args[1];

        try (
                FileInputStream fis = new FileInputStream(sourceFile);
                FileOutputStream fos = new FileOutputStream(destinationFile)) {
            byte[] buffer = new byte[1024];
            int bytesRead;


            while ((bytesRead = fis.read(buffer)) != -1) {
                fos.write(buffer, 0, bytesRead);
            }

            System.out.println("File copied successfully from " + sourceFile + " to " + destinationFile);
        } catch (FileNotFoundException e) {
            System.err.println("File not found: " + e.getMessage());
        } catch (IOException e) {
            System.err.println("Error occurred during file operation: " + e.getMessage());
        }
    }
}
