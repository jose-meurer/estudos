import java.util.Arrays;

public class Main {
    public static void main(String[] args) {

        Rectangle.list.add("Maristela");

        Rectangle rec = new Rectangle(10, 5);
        var x = calculateArea(rec);
        System.out.println(rec + " : Area{ " + x + " }");
    }

    public static double calculateArea(Object shape) {
        System.out.println(Rectangle.list.toString());


        return switch (shape) {
            case Rectangle(int width, int height) -> width * height;
            default -> 0.0;
        };
    }
}