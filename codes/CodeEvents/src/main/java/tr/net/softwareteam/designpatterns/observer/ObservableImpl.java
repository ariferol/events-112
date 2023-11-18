package tr.net.softwareteam.designpatterns.observer;

import java.util.ArrayList;
import java.util.List;

public class ObservableImpl implements IObservable  {
    private List<Agent> observers = new ArrayList<>();
    @Override
    public void subscribe(Agent agent) {
        observers.add(agent);
    }

    @Override
    public void unsubscribe(Agent agent) {
        observers.remove(agent);
    }

    @Override
    public void mesajiYayinla(String message) {
        for (Agent observer : observers) {
            observer.update(message);
        }

    }
}
