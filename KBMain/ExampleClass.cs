using System;
using System.Collections.Generic;
using System.Text;
//you can use the "using static" syntax to reference a specific method inside of a class
//references must be one way - if class X is using class Y, class Y cannot be using class X

#region FAQ
//what is the difference between a property and a method:
    //properties are the gate-keepers, providing access to data
    //methods are the operations
//what is a constructor?
    //a method executed when an instance is created of a class
//what is a namespace?
    //namespaces are used to organize classes into a logical heirarchy
    //prevent class name collisions
//what is a static class?
    //a class that cannot be instantiated
    //used for common code libraries
//what is a singleton?
    //a class that provides a single instance of itself
//what is the difference between static and singleton?
    //a static class cannot be instantiated
    //a singleton can instantiate itself and provide that instance to other code
//what is the difference between a class and an object?
    //a class represents things of the same type - an object represents one specific thing
    //a class defines the template of that type
    //an object defines one thing created from that template
    //class is created at development time by creating code
    //object is created at runtime with new keyword

//Object Initialization Best Practices
    //it's best to properties when populating an object from database values - using properties makes it easier to convert data from database types
    //setting properties is also best when modifying property values

    //paramaterized constructors are best used when setting the basic set of properties

    //object initializers are best used when readability is important and when initializing a subset or superset of properties
#endregion

/*
 * | Namespace Do:                              |
 * | Follow <company>.<technology>.<feature>    |
 * | Use PascalCasing                           |
 * | -----------------                          |
 * | Namespace Do Not:                          |
 * | Do not use System in your namespace        |
 * | Do not use a class name in your namespace  |
 * */
namespace KBMain
{
    /// <summary>
    /// XML Document comments are identified with three slashes.
    /// These are used with Visual Studio to assist with intellisense.
    /// </summary>

    #region Class Signature
    public class ExampleClass
    #endregion
    {
        #region Class Fields
        private int productId;
        private string productName;
        //class fields are simply the variables on the class scope
        //the field holds the data that the class is responsible for
        //define a property for each field in the class
        //also called backing fields because they provide the in memory storage for the
        //-> data exposed by the properties
        #endregion

        #region Class Properties
        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        public string ProductName
        {
            get { return productName }
            set { productName = value; }
        }
        //properties are getter and setter functions that guard access to fields
        //fields should almost always be private
        //developers should use properties to get and set the value of a field
        //the property is exposed publicly, the field is protected with private
        //define a property for each class field
        #endregion

        #region Class Constructors
        public ExampleClass()
        {
        }
        //Constructors are special methods inside the class that is automatically executed
        //-> everytime you create an instance of the class.
        //Constructors must be named with the same name as the class
        //Default constructor has no parameters
        //Not Required

        public ExampleClass(string className) : this()
        {
            ClassName = className;
        }
        //Paramaterized constructors allow you to initialize each instance with data
        //Defines parameters to initialize the object instance 
        //The :this() syntax invokes the default constructor
        //This constructor calls the default ( :this() ) constructor first to do any default constructing
        //This is called constructor chaining
        #endregion



        #region Class Methods
        public decimal CalculateQuantityOnHand()
        {
            var quantity = 0;

            return quantity;
        }
        //methods are functions containing the logic for the class
        //methods define the behavior of the class        
        #endregion

        /*
         *| Class Do's:
         *| Define a meaningful name                            |
         *| Use a noun when naming classes                      |
         *| Use PascalCasing when naming                        |
         *| Add XML Document Comments                           |
         *| Use properties to encap fields                      |
         *| Each class must have a purpose                      |
         *| Create one class per file                           |
         *| Add properties at top of class                      |
         *| Each class should have its own unit test file       |
         *| ------------------------------                      |
         *| Class Do Not's:                                             |
         *| Use Abbreviations in the name                       |
         *| Use Prefixes in the name                            |
         *| Use Underscores in the name                         |
         *| Create large classes                                |
         * */


        /*
         *| Constructor Do's:                                           |  
         *| Consider providing a default constructor                    |
         *| Consider providing a parameterized constructor              | 
         *| Name the parameters the same name as the related properties |
         * */

    }

    #region Static Classes
    //uses the static keyword in the signature
    //class can only include static members
    //cannot instantiate static class
    //acts like a container for properties and methods
    //-> that provide utility features like logging or email generation

    /*
     * | Static Classes Do:
     * Use sparingly
     * Should only be supporting classes
     * Use for code library components when needed
     * --------------
     * | Static Classes Do Not:
     * Do not use as miscellaneous bucket - should have purpose
     * 
     * 
     * */

    public static class ExampleClass2
    {
        public static string SendMessage(string subject, string message,
                            string recipient)
        {
            var confirmation = "Message sent: " + subject;
            return confirmation;
        }
    }
    #endregion

    #region Singleton Classes
    //a singleton is a class that allows only one instance
    //change constructor to private from public
    //add static property that provides one instance

    public class User
    { //example singleton class
        private static User instance; //backing field for instance
        //allows code in this class to create an instance
        private User() { }
        public static User Instance
        //static property that creates the one instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new User();
                }
                //if no instance, create an instance, else don't
                return instance;
            }
        }
    }
    #endregion
}
