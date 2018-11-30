using System;
using System.Collections.Generic;
using System.Text;

namespace KBMain
{
    class CodeSnippets
    {
        //ctor+tab+tab - creates a constructor for the current class
        //scope: class
        public CodeSnippets()
        {

        }

        //prop+tab+tab - properties allow access inside a private field
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
    }
}
