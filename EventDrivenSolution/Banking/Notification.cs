namespace Notificationnm;

public class Notification{

    public void SendMail(string to, string msg){
        Console.WriteLine("mail sent to "+ to);
        Console.WriteLine("msg-"+ msg);
    }

    public void SendMsg(string to, string msg){
        Console.WriteLine("text messege sent to "+ to);
        Console.WriteLine("msg-"+ msg);
    }

    public void SendWAppMsg(string to,string msg){
        Console.WriteLine("whatsapp msg sent to "+ to);
        Console.WriteLine("msg-"+ msg);
    }


}