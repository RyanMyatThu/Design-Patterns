namespace DesignPatternsApp.Creational.SimpleFactoryMethod;

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
public class NotificationFactory
{
    public static INotification CreateNotification(string type)
    {
        return type.ToLower() switch
        {
            "email" => new EmailNotification(),
            "sms" => new SMSNotification(),
            _ => throw new ArgumentException("Invalid notification type")
        };
    }
}
