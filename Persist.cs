using System;

public class Persist 
{

	public Persist()
	{
		Persistence(39);
	}

	public static int Persistence(long n) 
	{
		List<string> numeros = new List<string>();
		int count = 0;
		int total = 1;
		// your code
		var number = n.ToString();
		do{
			numeros.Clear();
			foreach(var caractere in number){
				numeros.Add(caractere.ToString());
			}
			if(numeros.Count == 1)
				break;
			foreach(var num in numeros ){
				total = total * int.Parse(num);
			}
			number = total.ToString();
			count++;
			total = 1;
		}while(numeros.Count > 1);
		return count;
	}
}