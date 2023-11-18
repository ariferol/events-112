package tr.net.softwareteam.designpatterns.observer;

public class CagriKabulMsgTest {
    public static void main(String[] args) {
        IObservable observable = new ObservableImpl();

        observable.subscribe(new Agent(1,"Arif EROL","Çağrı Yönlendirici","Mor"));
        observable.subscribe(new Agent(2,"Muhammed İsmail BAKIR","Çağrı Yönlendirici","Mor"));
        observable.subscribe(new Agent(3,"Necmettin SOLMAZ","Çağrı Yönlendirici","Mor"));

        observable.mesajiYayinla("Serav Yüksel(Çağrı karşılayıcı), Çağrıyı kabul etti.");
    }
}
