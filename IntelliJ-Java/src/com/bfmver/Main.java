package com.bfmver;

import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.List;

/**
 * My Test Application.
 */
public final class Main {

    /**
     * Application Entry point.
     *
     * @param args Program arguments
     */
    public static void main(final String[] args) {
        try {
            List<String> lines = Files.readAllLines(Paths.get("testfile.txt"));
            for (String line : lines) {
                System.out.println("Read Line: " + line);
            }
        } catch (IOException ex) {
            System.err.println("Error reading testfile");
            ex.printStackTrace(System.err);
        }
    }
}
