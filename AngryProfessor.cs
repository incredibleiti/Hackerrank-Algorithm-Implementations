/*
 * Created by SharpDevelop.
 * User: ityagi
 * Date: 6/27/2016
 * Time: 11:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program {

	static void Main(String[] args) {
		int t = Convert.ToInt32(Console.ReadLine());
		if(t>=0 && t<=10)
		{
			for(int a0 = 0; a0 < t; a0++){
				string[] tokens_n = Console.ReadLine().Split(' ');
				int n = Convert.ToInt32(tokens_n[0]);
				int k = Convert.ToInt32(tokens_n[1]);
				int noOfStuds =0;
				if(n>=1 && n<=1000)
				{
					if(k>=1 && k<=n)
					{
						string[] a_temp = Console.ReadLine().Split(' ');
						int[] a = Array.ConvertAll(a_temp,Int32.Parse);
						
						for(int i=0;i<n;i++)
						{
							if(a[i]>=-100 && a[i]<=100)
							{
								if(a[i]<=0)
									noOfStuds++;
							}
						}
					}
				}
				if(noOfStuds>=k)
				{
					Console.WriteLine("NO");
					
				}
				if(noOfStuds<k)
				{
					Console.WriteLine("YES");
				}
			}
		}
	}
}
