namespace DesignPatternsApp.Creational.FactoryMethod_GOF;

// The Product Interface
public interface INotification
{
    void Notify(string message);
}

// The Concrete Products
public class EmailNotification : INotification
{
    public void Notify(string message)
    {
        Console.WriteLine($"Email Notification: {message}");
    }
}

public class SMSNotification : INotification
{
    public void Notify(string message)
    {
        Console.WriteLine($"SMS Notification: {message}");
    }  
}

// The Factory
public abstract class NotificationFactory
{
    public abstract INotification CreateNotification();
    public void SendNotification(string message)
    {
        INotification notification = CreateNotification();
        notification.Notify(message);
    }
}

// Concrete Factories

public class EmailNotificationFactory : NotificationFactory
{
   public override INotification CreateNotification() => new EmailNotification();
}

public class SMSNotificationFactory : NotificationFactory
{
   public override INotification CreateNotification() => new SMSNotification();
}

