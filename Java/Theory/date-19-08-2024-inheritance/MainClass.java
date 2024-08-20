// inheritance in JAVA

class Parent{
    public Parent(){
        System.out.println("Parent constructor");
    }
}

class Child extends Parent{
    public Child(){
        System.out.println("Child constructor");
    }
}

public class MainClass{
    public static void main(String[] args){
        // Parent p = new Parent(); // output -> Parent Constructor
        Child c = new Child(); // output -> Parent constructor Child constructor
    }
}