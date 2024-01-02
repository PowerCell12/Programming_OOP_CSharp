namespace CustomStack;

public class StackOfStrings :  Stack<string>{


    public bool IsEmpty(){

        return  Count == 0;
    }

    public Stack<string> AddRange(IEnumerable<string> first){

        foreach( var thing in first){
            Push(thing);
        }

        return this;

    }



}
