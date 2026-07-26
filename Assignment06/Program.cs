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
            #region Question03
            /*
             A) No,Because the appliance is abstract class can't creat an object with because the class is not fully implemented
             B)-PowerConsumtion: is abstract(Not implemented body) because each derived classes must implement it and override with own power
               -Status: is a implemented method with body and a derived class can override it with own status but if didn't override with own body ,still with default body in parent class
               -Label: is concrete because all classes with the same implementation ,so any derived classes not should to ovveride and repeat the code with same behaviour
             C) Will return the default implemetation in parent class , because derived class didn't override it  
             */
            #endregion
            #region Question04
            /*
             A) A partial class is a class whose definition is split across multiple files 
                and During compilation the  compiler merges all parts into one complete class.
                A developer splits Calculator to organize the code, share with team .
             B) A partial method is a method whose declaration is in one part of a partial class and the implementation can be in another part
                Yes,the code will still compile because the compiler ignores it and does not throw an error
             C)-Extension method is a method that allows you to add new functionality to an existing class 
                without modifying its source code.
               -Solid Concept open for extension, closed for modification
               -Three rules : must be inside static class ,static method,using (this parameter)
             d) Log: result = 20
                 $20.00
             */
            #endregion
            #endregion
        }
    }
}
