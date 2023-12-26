using Accountnm;
using Notificationnm;
using Taxnm;


Account acc=new Account();

acc.Balance=20000;

acc.Deposit(4000);
acc.Withdraw(7000);

Notification notify=new Notification();
//synchronous 
notify.SendMsg("Om","Hii, Omkar...");
notify.SendMail("Aditya","Hii, Aditya ...");
notify.SendWAppMsg("Bobby","ok boyy...");

Tax tax =new Tax();
tax.GSTTax(200);
tax.ServiceTax(350);

//Asynchronous
SetAccNoD proxyaccno=new SetAccNoD(acc.SetAccNo);
proxyaccno(69);
Console.WriteLine("account no="+ acc.GetAccNo());
Console.WriteLine("\n");
MessageDeligate proxymail=new MessageDeligate(notify.SendMail);
//proxymail("mail to adi","Hi adi");

MessageDeligate proxymsg=new MessageDeligate(notify.SendMsg);
MessageDeligate proxywapp=new MessageDeligate(notify.SendWAppMsg);

MessageDeligate proxy=null;
proxy += proxymail;
proxy += proxymsg;
proxy += proxywapp;
proxy("Adi ","we are studing (Chaining)");
Console.WriteLine("\n");

proxy -= proxywapp;
proxy("Adi ","we are studing (Chaining removal )");
Console.WriteLine("\n");

//Synchronous
proxy.Invoke("omkar","proxy invoke"); 
Console.WriteLine("\n");

//Asynchronous
// IAsyncResult rsid=proxy.BeginInvoke("Booba","proxy begin invoke",null,null);
// proxy.EndInvoke(rsid);

Console.WriteLine("\nEvent Handling...");
Account acc7=new Account();
acc.Balance=5000;

SetBalanceD proxyb1= new SetBalanceD(tax.GSTTax);
SetBalanceD proxyb2= new SetBalanceD(tax.ServiceTax);


acc7.overbalance += proxyb1;
acc7.overbalance += proxyb2;

acc7.underbalance += proxymail;
acc7.underbalance += proxymsg;
acc7.underbalance += proxywapp;

acc7.Deposit(40000);
Console.WriteLine("\n");
acc7.Withdraw(45000);
