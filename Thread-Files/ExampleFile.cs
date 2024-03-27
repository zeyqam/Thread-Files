using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread_Files
{
    internal class ExampleFile
    {
        public void WriteToFile( string path,string text)
        {
            FileStream fs=new FileStream(path,FileMode.Create,FileAccess.Write);
            StreamWriter wr =new StreamWriter(fs);
            wr.WriteLine(text);
       // C:\\Users\\HP\\Desktop\\C#\\file1.txt
            wr.Close();
            fs.Close();
        }

        public void ReadFromFile()
        {
            FileStream fs=new FileStream("C:\\Users\\HP\\Desktop\\C#\\file2.txt",FileMode.Open,FileAccess.Read);
            StreamReader st=new StreamReader(fs);
            string result=st.ReadToEnd();
            Console.WriteLine(result);
            st.Close();
            fs.Close();
        }
    }
}
