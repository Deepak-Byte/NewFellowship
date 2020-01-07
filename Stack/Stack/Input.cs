//----------------------------------------------------------------------
// <copyright file="Input.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Stack
{
    /// <summary>
    /// The Input class.
    /// </summary>
    public class Input
    {
        /// <summary>
        /// Inputstacks this instance.
        /// </summary>
        public void Inputstack()
        {
            Utility utility = new Utility();
            string str = "(2+4)+(4-2)";
            char[] ch = str.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                utility.Push(ch[i]);
            }
            //int count = 0;
            //int count1 = 0;
            
            //for (int i = 0; i < ch.Length; i++)
            //{
            //    char ch1 = utility.Pop();
            //    //char[] ch2 = (char[])ch1;
            //    if (ch1 == '(')
            //    {
            //        count++;
            //    }
            //    if (ch1 == ')')
            //    {
            //        count1++;
            //    }
            //}

            //if (count == count1)
            //{
            //    Console.WriteLine("Your equestion is balanced");
            //}
            //else
            //{
            //    Console.WriteLine("Your equestion is not balanced");
            //}
        }

    }
}
