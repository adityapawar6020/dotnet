using System.IO.Compression;
using Notificationnm;
using Accountnm;
namespace Accountnm;

public class Account{
    private int accNo;
    public float Balance{get;set;}

    public event MessageDeligate underbalance;
    public event SetBalanceD overbalance;

    public void Deposit(float amt){
        this.Balance=this.Balance+amt;
        Console.WriteLine("Deposited...");
        if(this.Balance>30000){
            //fire overbalance
            overbalance(150);
            Console.WriteLine("Balance is >30000,pay tax now,Mf");
        }
    }

    public void Withdraw(float amt){
        this.Balance=this.Balance-amt;
        Console.WriteLine("Withdrawned...");
        if(this.Balance<=500){
            //fire overbalance
            underbalance("Raj","Plz pay fine...");
        }
        
    }

    public void SetAccNo(int ac)
    {
        this.accNo=ac;
        Console.WriteLine("account no assigned");
    } 
    public int GetAccNo()
    {
        return this.accNo;
    } 
}