// See https://aka.ms/new-console-template for more information
using DesignPatternsApp.Creational.SimpleFactoryMethod;
using Method = DesignPatternsApp.Creational.FactoryMethod_GOF;

Console.WriteLine("--- Running Simple Factory Method Pattern ---");
EmailNotification emailNotification = (EmailNotification)NotificationFactory.CreateNotification("email");
emailNotification.Notify("Hello");
SMSNotification smsNotification = (SMSNotification)NotificationFactory.CreateNotification("sms");
smsNotification.Notify("Hi");
Console.WriteLine("--- Simple Factory Method Pattern Complete ---");
Console.WriteLine();
Console.WriteLine("--- Running Factory Method Pattern ---");

var emailFactory = new Method.EmailNotificationFactory();
var emailNotification2 = emailFactory.CreateNotification();
emailNotification2.Notify("Hello from Factory Method!");
var smsFactory = new Method.SMSNotificationFactory();
var smsNotification2 = smsFactory.CreateNotification();
smsNotification2.Notify("Hi from Factory Method!");
Console.WriteLine("--- Factory Method Pattern Complete ---");