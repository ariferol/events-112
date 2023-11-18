package tr.net.softwareteam.designpatterns.observer;

public interface IObservable {
    public void subscribe(Agent agent);
    public void unsubscribe(Agent agent);

    public void mesajiYayinla(String message);

}
