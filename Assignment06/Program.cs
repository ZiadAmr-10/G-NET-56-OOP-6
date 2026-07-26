namespace Assignment06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            #region Question01
            /*
            Abstraction:means hiding the implementation details and exposing only the essential features
                        and  focuses on what object does not how does.
            Encapsulation:means hiding the internal data and controlling access to it 
                          and it focuses on protecting the object's data.
            Example :  BankAccount
            Abstract : The user can call method like deposit,withdraw,checkbalance without knowing how it does implementation or knowing the transaction
            Encapsulation: Balance should be private can't access directly,should use properties/methods to access it to protect the data 
             */
            #endregion
            #region Question02
            /*
             Abstract class : Has properties, fields, constructors, and methods and the methods can be full implemented or abstract
                               and a class can inherit from only one abstract class.
             interface :  Can contain only the signatures of methods, properties, events, and indexers
                          Can't have fields or constructors and a class can implement multiple interfaces.
             Choose an abstract class when you want to share common properties and methods with/without implementation among derived classes.
             Choose an interface when you want to define a common contract (member signatures) that different classes must implement.
             */
            #endregion
            #endregion
        }
    }
}
