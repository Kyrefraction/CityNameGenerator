package cityNameGenerator;

import java.util.Random;
import java.util.Scanner;

public class Controller {
	
	// Fantasy Elven Style City Name Generator 5
	static String[] prefixes5 = {"Riv","Loth","Tir","Aqu","Gond","Fir","For","Mirk","Mith","Galad","Gal","Cel","Sir","Luc","Val","Glor"};
	static String[] suffixes5 = {"endell","ariel","en Haven", "olin","alonde","ion","ian","en Woods","an Riverlands"};
	
	// Fantasy Evil Style City Name Generator 4
	
	static String[] prefixes4 = {"Mor","Izen","Khan","Dagor","Lich","Kro","Wor","Gorgo","Iron","Dagen","Dre","Darken"};
	static String[] suffixes4 = {"dor","gard","karak","land","moth","gen","roth","forge","fort","den"};
	
	// British Fantasy Style City Name Generator 3
	static String[] prefixes3 = {"Norther","Wessen","Talken", "Tolken","Larken","Litten","Litter","Britter","Souther", "Wester","Easter","Farken", "Falken", "Tarr","Marr","Ports","Brad","Lei","Herr"};
	static String[] suffixes3 = {"land", "glade","den","feld","brough","bridge","chester","mouth","water","ford","ham"};
	
	// German Style City Name Generator 2
	static String[] prefixes2 = {"Ber","Ham","Mu","Frank","Dres","Nurem","Dussel","Stutt","Bre","Lu","Dort","Augs","Saar","Ro","Wurtz","Wurtem","Olden","Klagen"};
	static String[] suffixes2 = {"lin","burg","berg","furt","dorf","gart","beck","brucken","dam"};

	
	// Italian Style City Name Generator 1
	static String[] prefixes1 = {"Tor","Ver","Pad","Mess","Gen","Pr","Sal","Ferr","Lat","Camp","Berg","Sirac","Tr","Nov","Anc","Lec","Piac","Liv","Nav"};
	static String[] suffixes1 = {"ini","ati","oli","osa","ata","anto","ona","onte","ano","ecchio","ere","ino","ello","ana","agna","asco","ate","ero","azzo","ezzo","aro","ano","ano"};


	public static void main(String[] args) {
		System.out.println("City Name Generator");
		askForInput();
	}
	public static void askForInput() {
		System.out.println("1. Italian");
		System.out.println("2. German");
		System.out.println("3. Realm of Men");
		System.out.println("4. Evil");
		System.out.println("5. Elven");
		System.out.println();
		
		
		
		int style = scanForInput();
		genNames(style);
		askForInput();	
			
	}
	
	public static int scanForInput() {
		int n;
		@SuppressWarnings("resource")
		Scanner reader = new Scanner(System.in);
		System.out.print("Enter a selection: ");
		n = reader.nextInt();
		
		System.out.println();
		
		return n;
	}
	public static void genNames(int number) {
		System.out.println("------------------------------");
		genName(number);
		genName(number);
		genName(number);
		genName(number);
		genName(number);
		System.out.println("------------------------------");
		System.out.println();
	}
	public static void genName(int number) {
		if(number == 1) {
			String name = getRandom(prefixes1);
			name = name + "" + getRandom(suffixes1);
			System.out.println(name);
		} else if(number == 2) {
			String name = getRandom(prefixes2);
			name = name + "" + getRandom(suffixes2);
			System.out.println(name);
		} else if(number == 3) {
			String name = getRandom(prefixes3);
			name = name + "" + getRandom(suffixes3);
			System.out.println(name);
		} else if(number == 4) {
			String name = getRandom(prefixes4);
			name = name + "" + getRandom(suffixes4);
			System.out.println(name);
		} else if(number == 5) {
			String name = getRandom(prefixes5);
			name = name + "" + getRandom(suffixes5);
			System.out.println(name);
		}
	}

	public static String getRandom(String[] array) {
	    int random = new Random().nextInt(array.length);
	    return array[random];
	}
}
