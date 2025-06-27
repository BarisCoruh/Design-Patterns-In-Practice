
var notification = NotificationFactory.Create(NotificationType.Sms);
notification.Send("Bu bir SMS'tir.");

var notificationEmail = NotificationFactory.Create(NotificationType.Email);
notificationEmail.Send("Bu bir Email'dir.");

var notificationPush = NotificationFactory.Create(NotificationType.Push);
notificationPush.Send("Bu bir Push Notification'dır.");
