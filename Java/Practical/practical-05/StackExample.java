class StackOverflowException extends Exception {
    @Override
    public String toString() {
        return "Stack Overflow: Cannot push, stack is full!";
    }
}

class StackUnderflowException extends Exception {
    @Override
    public String toString() {
        return "Stack Underflow: Cannot pop, stack is empty!";
    }
}

public class StackExample {
    private int[] stackArray;
    private int top;
    private int maxSize;

    public StackExample(int size) {
        this.maxSize = size;
        this.stackArray = new int[maxSize];
        this.top = -1;
    }

    public void push(int value) throws StackOverflowException {
        if (top == maxSize - 1) {
            throw new StackOverflowException();
        } else {
            stackArray[++top] = value;
            System.out.println("Pushed " + value + " into the stack.");
        }
    }

    public int pop() throws StackUnderflowException {
        if (top == -1) {
            throw new StackUnderflowException();
        } else {
            System.out.println("Popped " + stackArray[top] + " from the stack.");
            return stackArray[top--];
        }
    }

    public void display() {
        if (top == -1) {
            System.out.println("Stack is empty.");
        } else {
            System.out.print("Stack elements: ");
            for (int i = 0; i <= top; i++) {
                System.out.print(stackArray[i] + " ");
            }
            System.out.println();
        }
    }

    public static void main(String[] args) {
        StackExample stack = new StackExample(3);

        try {
            stack.push(10);
            stack.push(20);
            stack.push(30);

            stack.display();
            stack.push(40);

        } catch (StackOverflowException e) {
            System.out.println(e);
        }

        try {
            stack.pop();
            stack.pop();
            stack.pop();
            stack.display();

            stack.pop();

        } catch (StackUnderflowException e) {
            System.out.println(e);
        }
    }
}
