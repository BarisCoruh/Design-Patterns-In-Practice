public interface INotification
{
    void Send(string message);
}

public class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"E-posta gönderildi: {message}");
    }
}

public class SmsNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"SMS gönderildi: {message}");
    }
}

public class PushNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Push bildirimi gönderildi: {message}");
    }
}

public class NotificationFactory
{
    public static INotification Create(NotificationType notificationType)
    {
        switch (notificationType)
        {
            case NotificationType.Email:
                return new EmailNotification();
            case NotificationType.Sms:
                return new SmsNotification();
            case NotificationType.Push:
                return new PushNotification();
            default:
                throw new ArgumentException("Geçersiz bildirim türü");
        }
    }
}