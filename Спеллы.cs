using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Linq;

class Script
{
    [STAThread]
    static public void Main(string[] args)
    {
		string path=@"C:\Games\spells (1).2da";
		
		
		string[] s = File.ReadAllLines(path);
		
		string  words = s.Split(new char [] {' '});
		string y ="****"; 
		string pdn=words [15];
		for(int i=0; i<=843; i++)
		{
			if (pdn==y)
			{
				Console.WriteLine(pdn);
				
			}
		
		
		}
		Console.ReadLine();
    }
}