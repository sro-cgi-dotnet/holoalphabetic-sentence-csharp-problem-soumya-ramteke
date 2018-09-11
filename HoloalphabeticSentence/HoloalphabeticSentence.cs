using System;
using System.Linq;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        // Write the logic to determine whether the input string is a HoloalphabeticSentence or not
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
            if(input=="")
            {
                return false;
            }
            else
            {   bool[] mark= new bool[26];
                int index=0;
                for(int i=0; i<input.Length; i++)
                {
                    if(input[i]>='A' && input[i]<='Z')
                    {
                        index= input[i]-'A'; 
                    }
                    if(input[i]>='a' && input[i]<='z')
                    {
                        index= input[i]-'a';
                    }
                    mark[index]=true;
                }
                for(int j=0;j<25;j++)
                {
                    if(mark[j]==false)
                        return false;
                }
                return true;
        }
    }
}
}
