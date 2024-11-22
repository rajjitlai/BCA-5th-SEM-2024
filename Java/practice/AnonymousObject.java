class Person { 
	String name; 
	int age; 

	Person(String name, int age) 
	{ 
		this.name = name; 
		this.age = age; 
	} 

	void display() 
	{ 
		System.out.println("Name: " + name 
						+ ", Age: " + age); 
	} 
} 

public class AnonymousObject { 
	public static void main(String[] args) 
	{ 
		new Person("John", 30).display(); 
	} 
}
