using System;

namespace KBMain
{
    class CodeSnippets
    {
        //ctor+tab+tab - creates a constructor for the current class
        //scope: class
        public CodeSnippets()
        {

        }       

        //prop+tab+tab - properties allow access inside a private field - creates a single line property
        //propfull+tab+tab - creates a full property section
        //scope: class
        public int MyProperty { get; set; }

        

        private void CodeSnippetList()
        {
            //cw+tab+tab - writes a line
            //scope: method
            Console.WriteLine();

            //if+tab+tab
            //scope: method
            if (true)
            {

            }

            //reg+tab+tab
            //scope: comment
            #region MyRegion

            #endregion
        }
        
        //testm+tab+tab - creates a test method -> requires Microsoft.VisualStudio.TestTools.UnitTesting namespace
        //scope: class
        [TestMethod]
        public void MyTestMethod()
        {

        }      
    }
}
