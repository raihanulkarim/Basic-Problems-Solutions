using System;


namespace CSharpPractice
{
    class Problem11{
        public bool IsSort(){
                var a = new int[]{1,3,5,6,4,2};
                int[] b = new int[6];
                int r = a.Length-1;
                int  l = 0;
                for(int i = 0; i < a.Length/2; i++){
                    b[l++] = a[i];
                    b[l++] = a[r--];
                }
                foreach(var i in b){
                    Console.WriteLine(i);
                }
                return true;
            }
    }
}