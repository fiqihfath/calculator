class calculator
{
	static void main (string[] args)
	{
		int a = 10 ;
		int b = 6 ;
		
		Console.WriteLine("hasil penambahan : {0} + {1} = {2}",a,b,penambahan(a,b));
		Console.WriteLine("hasil penambahan : {0} - {1} = {2}",a,b,pengurangan(a,b));
		
		Console.WriteLine("\n tekan sembarangkey untuk keluar");
		Console.ReadKey();
		
	}
	static int penambahan (int a, int b){
		return a+b;
	}
	statis int pengurangan (int a , int b )
	{
		return a- b;
	}
}

