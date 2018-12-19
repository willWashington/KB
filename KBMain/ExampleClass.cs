using System;
using System.Collections.Generic;
using System.Text;

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
            className = className;
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
         *| Do:
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
         *| Do Not:                                             |
         *| Use Abbreviations in the name                       |
         *| Use Prefixes in the name                            |
         *| Use Underscores in the name                         |
         *| Create large classes                                |
         * */
    }

    public class ExampleClass2
    {


    }
}
