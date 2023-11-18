package tr.net.softwareteam.designpatterns.observer;

public class Agent {
    private int id;
    private String name;
    private String role;
    private String  color;

    public Agent(int id, String name, String role, String color) {
        this.id = id;
        this.name = name;
        this.role = role;
        this.color = color;
    }

    public void update(String message) {
        System.out.println(this.name + ": "+message);
    }
}
