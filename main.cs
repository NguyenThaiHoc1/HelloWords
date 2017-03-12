using System;
public class Student {
	private string MSSV;
	private string Hoten;
	private double Cost;

	public Student (string mssv = null, string hoten = null,double cost = null){
	 	MSSV = mssv;
		Hoten = hoten;
		Cost = cost;
	}

	public void Show_Student() {
		System.Console.Writeline(MSSV + Hoten + Cost.toString());
	}

	public string MSSV {
		get {return MSSV;}
		set {MSSV = value;}
	}

	public string Hoten {
		get {return Hoten;}
		set {Hoten = value;}
	}
	
	public double Cost {
		get {return Cost;}
		set {Cost = value;}
	}
	
}
public class Text {
	public string name = "Beckham Angela";	
	public static void main () {
		System.Console.Writeline("Chao Mung Ban" + name);
	}
}
