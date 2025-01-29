import java.util.ArrayList;
import java.util.List;

public record Rectangle(int width, int height) {

    public static List<String> list = new ArrayList<>();

    static {
        list.add("Nicole");
        list.add("Miguel");
    }

}
