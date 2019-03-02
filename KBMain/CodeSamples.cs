using System;
using System.Collections.Generic;
using System.Text;

namespace KBMain
{
    class CodeSamples
    {
        void Ternary()
        {
            int fin = 0;
            int num1 = 0;
            fin = num1 < 0 ? 1 : num1;
            // --^^-- ternary - set fin to 1 if lastSum < 0 or set fin to lastSum if fin is >= 0
        }

        #region TickCounter
        public static bool CheckFooTestA(String SearchMe, String[] FindMe)
        {
            //split the string like the human eye does and check the count of Foos 
            //and the position of the Foo or Foos to determine our logic:
            string[] v = SearchMe.Split(FindMe, StringSplitOptions.None);

            //Foo not found, OR foo found once and was at the beginning of the string
            return (v.Length == 0 || v.Length == 1 && v[0] == String.Empty);
        }
        public static bool CheckFooTestB(String SearchMe, String[] FindMe)
        {
            //scan the way computers or non-speed readers do, and look for the first instance of Foo
            int i = SearchMe.IndexOf(FindMe[0]);

            //Foo not found OR 
            //    foo found at the start of the string 
            //    AND the last Foo found is also at the start of the string
            return (i == -1 || i == 0 && SearchMe.LastIndexOf(FindMe[0]) == 0);
        }
        public static bool CheckFooTestC(String SearchMe, String[] FindMe)
        {
            //Use the logic we distilled from the word problem to make this single check:
            return (SearchMe.LastIndexOf(FindMe[0]) <= 0);
        }
        public static void Main()
        {
            String[] x = new String[]{
        "Foo foo Foo bar",
        "Foo foo foo bar",
        "foo foo Foo bar",
        "foo foo foo bar",
        "asfda asdfa asf" };

            var s = new[] { "Foo" };
            var i = 0;
            bool f = false;
            long End = DateTime.Now.Ticks;
            long Start = DateTime.Now.Ticks;
            for (; i < 1000; i++)
            {
                f = CheckFooTestA(x[i % 5], s);
            }
            End = DateTime.Now.Ticks;
            Console.WriteLine((End - Start).ToString() + " ticks (Test A)");

            i = 0;
            f = false;
            End = DateTime.Now.Ticks;
            Start = DateTime.Now.Ticks;
            for (; i < 1000; i++)
            {
                f = CheckFooTestB(x[i % 5], s);
            }
            End = DateTime.Now.Ticks;
            Console.WriteLine((End - Start).ToString() + " ticks (Test B)");

            i = 0;
            f = false;
            End = DateTime.Now.Ticks;
            Start = DateTime.Now.Ticks;
            for (; i < 1000; i++)
            {
                f = CheckFooTestC(x[i % 5], s);
            }
            End = DateTime.Now.Ticks;
            Console.WriteLine((End - Start).ToString() + " ticks (Test C)");
        }

        /* OUTPUT: 
            260510 ticks (Test A)
            117150 ticks (Test B)
            76160 ticks (Test C)
        */

    }
    //Test.Main();

    #region TickCounterComments
    //    Read on for a lessons in coding logic(humor this old man)
    //This question may be old, but for the sake of those finding this question later who are curious about how to logically distill word problems (so please don't downvote this lurker who finally decided to post), here's my massively overdone analysis for this extremely simple homework assignment:

    //I ran a set of tests to see what options were the fastest - this often helps me see flaws in my logic. I am also going to explain my thought process, since, IMHO, understanding how to distill a problem to it's core logic is a good thing to know for real world use.

    //After all, that's what Business Requirements Docs are... word problems that need to be distilled into functional specs (e.g. architectural design).

    //Step 1
    //Eliminate Extraneous Information
    //Based on the requirements given, lower case foo may or may not matter: There is no explicit statement that a string not containing foo and not containing Foo should return false; There is also no explicit statement that says a string not containing Foo and not containing foo should return true.

    //In a perfect world, you would go back for clarification on the requirements, but in some cases, there isn't time. Assuming there is a deadline, I would move forward with the assumption that all we care about is Foo being uppercase only when in the first position in the sentence, lower case at all other times, so we will ignore foo altogether, and if the "client" complains, point out the missing clarity and explain why you made a judgement call (to keep the project on time, and on budget, if applicable).

    //Step 2
    //Break down the logic into OR/AND pieces:
    //Breaking Foo into components lets us look at individual pieces, which can be easier than looking at the whole.So, if we break the string into "stuff before Foo" (even if that is "nothing") and "stuff after Foo" OR if Foo isn't there to break up the string, we only have one piece to look at. (Our brains do this all the time - it's called pattern recognition).

    //IF The string cannot be split because Foo is not found
    //    OR
    //      splitting on Foo gives us no more than two pieces: nothing before, and everything after
    //       AND (implied by the previous check only finding an empty "before" and only one "section" in the "after")       Foo is not found anywhere else in the string

    //Sound good? Well, it's 100% accurate, but we can cut some cruft and distill it further - keep in mind computers don't think like humans, so our mental processing is inefficient for them.

    //Because Foo not being found at all is considered valid, and Foo at the beginning is valid, but Foo anywhere else later in the string is invalid, we can say:

    //IF Foo is not found
    //    OR
    //      Foo is not found anywhere in the string past the first position

    //Seems tight, right? Don't stop now. We can do better.

    //If Foo is found at the beginning, we're fine with it, right? So "Foo is not Found" OR "Foo is found at the beginning AND Foo is not found anywhere else" can be looked at from a more pure logic (boolean, true/false, black and white) perspective:

    //LET FNA = "Foo is not found anywhere"
    //LET FN1 = "Foo is not found in position 1"
    //LET FN2 = "Foo is not found after position 1"
    //LET FF1 = "Foo is found in position 1"
    //LET FF2 = "Foo is found after position 1"
    //So now define as invalid only those cases which are guaranteed invalid, and mark the rest as valid. We'll use boolean math to determine all use cases.

    //LET FNA = valid
    //LET FN1 = valid
    //LET FN2 = valid
    //LET FF1 = valid
    //LET FF2 = invalid
    //Now that we've labeled only the cases that absolutely force a return of false, we can do the math to see the only cases where we get an invalid/false value.

    //FNA = FN1 and FN2 (so if FNA & X = true, then F1 & X must be true, and F2 & X must also be true);

    //    FNA and/or FF1 = true, so we know that all combinations of and/or of these 4 variables = true; This leaves only one variable left to combine, and we can see really quickly that FF2 and anything will always be false.

    //So translated back into human logic... see how much simpler this task is?

    //ONLY FALSE IF Foo is found after position 1

    //Or, to flip the boolean (since the requirements say to return true for valid cases):

    //IF Foo is NOT found after position 1, string is valid.

    //Or, to put it more like a computer's thinking:

    //IF scanning from the end of the string until the 2nd to the last character does not find Foo, string is valid

    //There, now we can't distill it any further down. So let's code these different bits of logic and see how they perform in real code:

    //    Results and Conclusions
    //Test A(human logic of visually splitting on/counting the words found), compared to test B(scanning using indexes with the distilled logic), Test A runs over 220% longer!

    //Test C is the best performer - only one scan of the string needed.Coming in at less than 30% the processing time required (Test A takes over 340%! of the amount of time Test C requires to complete the same work).

    //So hopefully some student somewhere has read this and the lightbulb goes on.You can always come up with ways to make stuff that "works", but understanding boolean logic and how to distill a concept down to it's core can make a significant impact on the quality of your work.

    //Happy coding, everyone!
    //https://stackoverflow.com/a/19869776
    #endregion

    #endregion


}

