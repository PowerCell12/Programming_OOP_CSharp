namespace CustomRandomList;

public class RandomList :  List<string>{

    public string RandomString(){

        Random random = new Random();
        string word = this[random.Next(0, this.Count)];

        return word;


    }
}
