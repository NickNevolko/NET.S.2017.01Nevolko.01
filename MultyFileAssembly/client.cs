using System;
using OperSystems;

 class Client
{
	static void Main()
	{
		Win windows = new Win();
		windows.Greeting();
		
		Linux lin = new Linux();
		lin.Greeting();
		
		MacOS mac = new MacOS();
		mac.Greeting();
	}
}