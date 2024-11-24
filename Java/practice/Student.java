class Student{
    int data, roll;
    String user;
    public Student(int no){
        this.data = no;
    }

    public Student(int no, String name){
        this(no);
        this.roll = no;
        this.user = name;
    }

    public void display(){
        System.out.println("Data: " + data);
        System.out.println("Roll: " + roll);
        System.out.println("User: " + user);
    }

    public static void main(String[] args) {
        Student s1 = new Student(10);
        s1.display();
        Student s2 = new Student(10, "Shakti");
        s2.display();
    }
}